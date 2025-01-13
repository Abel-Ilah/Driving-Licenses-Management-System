using BusinessLayer;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class AddEditUsersForm : Form
    {
        private enum enMode { eAddNew = 1, eUpdate = 2 }
        enMode _Mode;
        private int _UserID;
        clsUsers _User;
      
        public AddEditUsersForm(int ID)
        {
            InitializeComponent();

            if (ID == -1) 
                 _Mode = enMode.eAddNew; 
            else _Mode = enMode.eUpdate;

            _UserID = ID;
        }

        private void ShowFormInUpdateMode()
        {
            lbFormMode.Text = "Update User";
            _User = clsUsers.FindByUserID(_UserID);
            if (_User == null)
            {
                MessageBox.Show("The User was not found in the system", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            uC_PersonInfoWithFilter1.DisableFilter();
            uC_PersonInfoWithFilter1.ShowPersonInfoInCard(_User.PersonID);
            lbUserID.Text = _User.UserID.ToString();
            txtbUserName.Text = _User.UserName.ToString();
           
            if (_User.IsActive) rbActive.Select();
            else                rbInactive.Select();

        }

        private bool IsUserInfoChanged()
        {
            return txtbUserName.Text!=_User.UserName || (txtbNewPassword.Text!=string.Empty && clsEncryption.ComputeHash(txtbNewPassword.Text) !=_User.Password) || (_User.IsActive!=rbActive.Checked);
        }
        private void AddEditUsersForm_Load(object sender, EventArgs e)
        {

            btnPrev.Enabled = false;
            rbActive.Checked= true;
            lbFormMode.Text = "Add New User";
            if (_Mode == enMode.eAddNew)
            {
                _User = new clsUsers();
                return;
            }
            ShowFormInUpdateMode();

        }

        private void ShowSaveButton()
        {
            btnNext.Visible = false;
            btnSave.Visible = true;
        }

        private void HideSaveButton()
        {
            btnNext.Visible = true;
            btnSave.Visible = false;
        }

        private bool IsUserNameAlreadyExist(string UserName)
        {
           switch (_Mode)
            {
                 case enMode.eAddNew:
                    return clsUsers.IsUserExist(UserName);
 
                case enMode.eUpdate:
                    int ID = clsUsers.GetUserIdByUserName(UserName);
                    if (ID!=-1 && ID != _User.UserID)
                        return true;
                    break;
            }
            return false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
         if (_Mode==enMode.eAddNew)
         {
             if (_User.PersonID == -1)
             {
                 MessageBox.Show("Please link a person to this user account before proceeding.", "Link Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }
             if (clsUsers.IsPersonRelatedToAnyUser(_User.PersonID))
             {
                 MessageBox.Show("This person is already linked with another user account.", "Duplicate Link", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
         }

         btnPrev.Enabled = true;

         ShowSaveButton();
         tabcontrolUser.SelectedTab = tabcontrolUser.TabPages["UserLoginInfoPage"];
         txtbUserName.Focus();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            btnPrev.Enabled = false;
            HideSaveButton();
            tabcontrolUser.SelectedTab = tabcontrolUser.TabPages["PersonalInfoPage"];
        }

        private void txtbUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '@')
           {
               e.Handled = true; return;
           }
        }

        private void txtbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true; return;
            }
        }

        private void txtbConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true; return;
            }
        }

        private void PreventPasteTextOnTextBoxes (object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }

        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.eUpdate && !IsUserInfoChanged())
                return;

            if (string.IsNullOrEmpty(txtbUserName.Text))
            {
                ErrorProvider1.SetError(txtbUserName, "Please Enter a UserName here!");
                return;
            }
            if (IsUserNameAlreadyExist(txtbUserName.Text))
            {
                ErrorProvider1.SetError(txtbUserName, "This username is already in use. Please choose a different username");
                return;
            }

            if ((_Mode == enMode.eAddNew &&  string.IsNullOrEmpty(txtbNewPassword.Text)) || (_Mode == enMode.eUpdate && string.IsNullOrEmpty(txtbNewPassword.Text) && !string.IsNullOrEmpty(txtbConfirmPassword.Text)))
            {
                ErrorProvider1.SetError(txtbNewPassword, "Please Enter a PassWord here!");
                return;
            }
            if ((_Mode == enMode.eAddNew && string.IsNullOrEmpty(txtbConfirmPassword.Text))||(_Mode == enMode.eUpdate && txtbConfirmPassword.Text!=txtbNewPassword.Text))
            {
                ErrorProvider1.SetError(txtbConfirmPassword, "Please Repeat the entered PassWord here!");
                return;
            }

            if (txtbNewPassword.Text!=txtbConfirmPassword.Text)
            {
                ErrorProvider1.SetError(txtbConfirmPassword, "The confirmed password does not match the entered password");
                return;
            }

            _User.UserName = txtbUserName.Text;
            if (!string.IsNullOrEmpty(txtbNewPassword.Text))//handle update user case: when the password not changed
                _User.Password = txtbNewPassword.Text;
            
            _User.IsActive = rbActive.Checked;

            if (GlobalSettings.CurrentUser.UserID == _User.UserID && rbInactive.Checked)
            {
                if (MessageBox.Show("are you sure you want to inactivate your account?,You will not be able to login again to your account!", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    _User.IsActive = true;
                }
                else
                {
                    if (_User.Save())
                    { GlobalSettings.CloseAllFormsAndReturnToLoginForm(); return; }
                }
            }

             if (_User.Save())
             {

                 lbFormMode.Text = "Update User";
                 lbUserID.Text = _User.UserID.ToString();
                 _UserID = _User.UserID;
                uC_PersonInfoWithFilter1.DisableFilter();

                 // change current user Info in main screen after updating it's info : 
                 if (_Mode == enMode.eUpdate && _User.UserID == GlobalSettings.CurrentUser.UserID)
                 {
                     if (MainForm.instance.lbCurrentUserName.Text != txtbUserName.Text)
                         MainForm.instance.lbCurrentUserName.Text = txtbUserName.Text;

                     // update current user object in global settings class: 
                     GlobalSettings.CurrentUser = clsUsers.FindByUserID(GlobalSettings.CurrentUser.UserID);
                 }

                 _Mode = enMode.eUpdate;

                 MessageBox.Show("Data saved successfully.", "Save Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else MessageBox.Show("Operation Failed,Data has not been Saved!", "Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;


        }

        private void txtbUserName_Leave(object sender, EventArgs e)
        {
            if (IsUserNameAlreadyExist(txtbUserName.Text))
            {
                ErrorProvider1.SetError(txtbUserName, "This username is already in use. Please choose a different username");
                return;
            }
            ErrorProvider1.SetError(txtbUserName, string.Empty);
        }

        private void txtbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtbNewPassword.Text != txtbConfirmPassword.Text)
            {
                ErrorProvider1.SetError(txtbConfirmPassword, "The confirmed password does not match the entered password");
                return;
            }
            ErrorProvider1.SetError(txtbConfirmPassword, string.Empty);
        }

        private void txtbPassword_TextChanged(object sender, EventArgs e)
        {
            if (_Mode == enMode.eAddNew && string.IsNullOrEmpty(txtbNewPassword.Text))
            {
                ErrorProvider1.SetError(txtbNewPassword, "Please Enter a PassWord here!");
                return;
            }
            ErrorProvider1.SetError(txtbNewPassword, string.Empty);
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            Add_EditePeopleForm AddPersonForm = new Add_EditePeopleForm(-1);
           
            AddPersonForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uC_PersonInfoWithFilter1_WhenPersonIsFound(int obj)
        {
            //obj is the selected personID
            if (_Mode == enMode.eAddNew && obj > -1)
            {
                _User.PersonID = obj;
            }
        }

       
    }
}
