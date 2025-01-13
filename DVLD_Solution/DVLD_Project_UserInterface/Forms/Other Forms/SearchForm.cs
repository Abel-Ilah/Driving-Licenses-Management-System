using System;
using BusinessLayer;
using System.Windows.Forms;
using System.IO;

namespace UserInterface
{
    public partial class SearchForm : Form
    {
        public enum enSearchFor { SearchForPerson=1, SearchForUser=2 }
        public enum enSearchReason { ToShowInfo=1,ToUpdateInfo=2,ToDelete=3 }

        enSearchFor _SearchFor;

        enSearchReason _SearchReason;

        bool _IsCurrentUserPasswordCorrect=false;

        public SearchForm(enSearchFor searchFor, enSearchReason searchReason)
        {
            InitializeComponent();
            _SearchFor = searchFor;
            _SearchReason = searchReason;   
        }

        public void CheckIfUserPasswordCorrect(bool IsUserPasswordCorrect)
        {
            _IsCurrentUserPasswordCorrect = IsUserPasswordCorrect;
        }
        bool DoesPersonSearchedForExist(ref int ID)
        {
            if (cmbSearchBy.SelectedItem.ToString() == "PersonID")
            {
                if (!clsPeople.IsPersonExist(Convert.ToInt32(txtbSearchBy.Text)))
                {
                    return false;
                }
                ID = Convert.ToInt32(txtbSearchBy.Text);
            }
            if (cmbSearchBy.SelectedItem.ToString() == "NationalNo")
            {
                ID = clsPeople.GetPersonID(txtbSearchBy.Text);
                if (ID== -1)
                {
                    return false;
                }
            }
            return true;
        }

        bool DoesUserSearchedForExist(ref int ID)
        {
            if (cmbSearchBy.SelectedItem.ToString() == "UserID")
            {
                if (!clsUsers.IsUserExist(Convert.ToInt32(txtbSearchBy.Text)))
                {
                    return false;
                }
                ID = Convert.ToInt32(txtbSearchBy.Text);
            }
            if (cmbSearchBy.SelectedItem.ToString() == "UserName")
            {
                ID = clsUsers.GetUserIdByUserName(txtbSearchBy.Text);
                if (ID == -1)
                {
                    return false;
                }
            }
            if (cmbSearchBy.SelectedItem.ToString() == "PersonID")
            {
                ID = clsUsers.GetUserIdByPersonID(Convert.ToInt32(txtbSearchBy.Text));
                if (ID == -1)
                {
                    return false;
                }
            }
            if (cmbSearchBy.SelectedItem.ToString() == "NationalNo")
            {
                ID = clsUsers.GetUserIdByNationalNo(txtbSearchBy.Text);
                if (ID == -1)
                {
                    return false;
                }
            }
            return true;

        }
        void ShowInfoForm(int ID)
        {
            switch (_SearchFor)
            {
                case enSearchFor.SearchForPerson:
                    PersonInfoForm PersonInfo = new PersonInfoForm(ID);
                    PersonInfo.ShowDialog();
                    break;
                case enSearchFor.SearchForUser:
                    UserInfoForm UserInfo = new UserInfoForm(ID);
                    UserInfo.ShowDialog();
                    break;
            }
        }
        void ShowUpdateForm(int ID)
        {
            switch (_SearchFor)
            {
                case enSearchFor.SearchForPerson:
                    Add_EditePeopleForm UpdatePersonForm = new Add_EditePeopleForm(ID);
                    UpdatePersonForm.ShowDialog();
                    break;
                case enSearchFor.SearchForUser:
                    if (ID==GlobalSettings.CurrentUser.UserID)
                    {
                        ConfirmUserPassWordForm ConfirmPasswordFrm = new ConfirmUserPassWordForm();
                        ConfirmPasswordFrm.DataBack += CheckIfUserPasswordCorrect;
                        ConfirmPasswordFrm.ShowDialog();
                        if (!_IsCurrentUserPasswordCorrect) return;
                    }
                    AddEditUsersForm UpdateUserForm = new AddEditUsersForm(ID);
                    UpdateUserForm.ShowDialog();
                    break;

            }

        }

        void DeletePerson(int ID)
        {
            if (MessageBox.Show("Are you sure you want to delete this person from the system ? ", "Confirm the operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string PersonImagePath = "";

                if (!string.IsNullOrEmpty(clsPeople.Find(ID).ImagePath))
                    PersonImagePath = clsPeople.Find(ID).ImagePath;

                if (clsPeople.Delete(ID))
                {
                    MessageBox.Show("Person has been deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (File.Exists(PersonImagePath)) { File.Delete(PersonImagePath); }
                }
                else
                    MessageBox.Show("This person can't be deleted because it is linked to other data on the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        void DeleteUser(int ID)
        {
            if (MessageBox.Show("Are you sure you want to delete this User from the system ? ", "Confirm the operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (clsUsers.Delete(ID))
                {
                    MessageBox.Show("User has been deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("This User can't be deleted because it is linked to other data on the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        void Delete(int ID)
        {
          ConfirmUserPassWordForm ConfirmPasswordFrm = new ConfirmUserPassWordForm();
          ConfirmPasswordFrm.DataBack += CheckIfUserPasswordCorrect;
          ConfirmPasswordFrm.ShowDialog();
          if (!_IsCurrentUserPasswordCorrect) return;

            switch (_SearchFor)
            {
                case enSearchFor.SearchForPerson:
                    DeletePerson(ID);
                    break;
                case enSearchFor.SearchForUser:
                    if (GlobalSettings.CurrentUser.UserID == ID)
                    {
                        if (MessageBox.Show("You are trying to delete your account.Are you sure you want to continue? You will not be able to log in again after this process! ", "Confirm the Process", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        {
                            MessageBox.Show("operation has been cancelled", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (clsUsers.Delete(ID))
                            {
                                GlobalSettings.CloseAllFormsAndReturnToLoginForm();
                            }
                            else MessageBox.Show("Your account can't be deleted because it is linked to other data on the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return;
                    }
                    DeleteUser(ID);
                    break;
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            switch (_SearchFor)
            {
                case enSearchFor.SearchForPerson:
                    lbSearchFor.Text = "Search For a Person";
                    cmbSearchBy.Items.Clear();
                    cmbSearchBy.Items.Add("PersonID");
                    cmbSearchBy.Items.Add("NationalNo");
                    break;
                case enSearchFor.SearchForUser:
                    lbSearchFor.Text = "Search For a User";
                    cmbSearchBy.Items.Clear();
                    cmbSearchBy.Items.Add("UserID");
                    cmbSearchBy.Items.Add("UserName");
                    cmbSearchBy.Items.Add("PersonID");
                    cmbSearchBy.Items.Add("NationalNo");
                    break;
            }
            cmbSearchBy.SelectedIndex = 0;
        }

        private void lbSearchFor_Click(object sender, EventArgs e)
        {

        }
        private void txtbUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbSearchBy.SelectedItem.ToString() == "PersonID" || cmbSearchBy.SelectedItem.ToString() == "UserID")
            {
               
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                { e.Handled = true; return; }
            }

            if (cmbSearchBy.SelectedItem.ToString() == "NationalNo")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-')
                { e.Handled = true; return; }
            }
            if (cmbSearchBy.SelectedItem.ToString() == "UserName")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '@')
                {
                    e.Handled = true; return;
                }
            }
         
        }

        private void cmbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbSearchBy.Clear();
            txtbSearchBy.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbSearchBy.Text)) return;

            int ID = -1;

            switch (_SearchFor)
            {
                case enSearchFor.SearchForPerson:
                    if (!DoesPersonSearchedForExist(ref ID))
                    { MessageBox.Show("Person Doesn't Exist!","",MessageBoxButtons.OK,MessageBoxIcon.Error); return; }
                    break;
                case enSearchFor.SearchForUser:
                    if (!DoesUserSearchedForExist(ref ID))
                    { MessageBox.Show("User Doesn't Exist!", "", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    break;
             
            }

            switch (_SearchReason)
            {
                case enSearchReason.ToShowInfo:
                    ShowInfoForm(ID);
                    break;
                case enSearchReason.ToUpdateInfo:
                    ShowUpdateForm(ID);
                    break;
                case enSearchReason.ToDelete:
                    Delete(ID);
                    break;
               
            }
        }

        private void txtbSearchBy_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbSearchBy.Text))
                btnSearch.Visible = false;
            else btnSearch.Visible = true;
            
        }

        private void txtbSearchBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }



    }
}
