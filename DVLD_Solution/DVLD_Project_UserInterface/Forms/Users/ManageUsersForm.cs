using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;
namespace UserInterface
{
    public partial class ManageUsersForm : Form
    {
        DataView _UsersDataView = new DataView();
      bool  _IsCurrentUserPasswordCorrect =false;
        public ManageUsersForm()
        {
            InitializeComponent();
        }

        void RefreshUsersListInDataGridView()
        {
            _UsersDataView = clsUsers.GetListOfUsers().DefaultView;
            dgvUsers.DataSource = _UsersDataView;
            dgvUsers.Columns[2].Width = 400;
            dgvUsers.Columns[3].Width = 180;
            lbNumberOfUsers.Text = dgvUsers.Rows.Count.ToString();
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            RefreshUsersListInDataGridView();
            cmbFilterBy.SelectedIndex = 0;

        }

        private void ShowDataGridViewWithNoFilter()
        {
            if (_UsersDataView != null)
            {
                _UsersDataView.RowFilter = "";
                dgvUsers.DataSource = _UsersDataView;
            }
        }
        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDataGridViewWithNoFilter();

            if (cmbFilterBy.SelectedItem.ToString() == "None")
            {
                txtbFilter.Visible = false;
                cmbIsActiveFilter.Visible = false;
            }

            else
            {
                if (cmbFilterBy.SelectedItem.ToString() == "IsActive")
                {
                    txtbFilter.Visible = false;

                    cmbIsActiveFilter.Visible = true;
                    cmbIsActiveFilter.SelectedItem = "All";
                    return;

                }
                cmbIsActiveFilter.Visible = false;
                txtbFilter.Visible = true;

                txtbFilter.Clear();
                txtbFilter.Focus();
            }
        }

        private void txtbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterBy.SelectedItem.ToString() == "PersonID" || cmbFilterBy.SelectedItem.ToString() == "UserID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; return;
                }
            }
            if (cmbFilterBy.SelectedItem.ToString() == "FullName")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true; return;
                }
            }
            if (cmbFilterBy.SelectedItem.ToString() == "UserName")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '@')
                {
                    e.Handled = true; return;
                }
            }


        }

        private void txtbFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtbFilter_TextChanged(object sender, EventArgs e)
        {
            _UsersDataView.RowFilter = $"CONVERT({cmbFilterBy.SelectedItem},'System.String') like'%{txtbFilter.Text}%'";
            dgvUsers.DataSource = _UsersDataView;
        }

        private void cmbIsActiveFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbIsActiveFilter.SelectedItem.ToString())
            {
                case "All":
                    _UsersDataView.RowFilter = "";
                    break;
                case "Yes":
                    _UsersDataView.RowFilter = "IsActive=true";
                    break;
                case "No":
                    _UsersDataView.RowFilter = "IsActive=false";
                    break;

            }
            dgvUsers.DataSource = _UsersDataView;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserIDToUpdate = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);
            if (UserIDToUpdate==GlobalSettings.CurrentUser.UserID)
            {
                ConfirmUserPassWordForm frm = new ConfirmUserPassWordForm();
                frm.DataBack += CheckIfUserPasswordCorrect;
                frm.ShowDialog();
                if (!_IsCurrentUserPasswordCorrect) return;
            }
            AddEditUsersForm UpdateUserForm = new AddEditUsersForm(UserIDToUpdate);
            UpdateUserForm.ShowDialog();
            RefreshUsersListInDataGridView();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddEditUsersForm AddNewUserForm = new AddEditUsersForm(-1);
            AddNewUserForm.ShowDialog();
            RefreshUsersListInDataGridView();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfoForm ShowUserInfoForm = new UserInfoForm(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
            ShowUserInfoForm.ShowDialog();
            RefreshUsersListInDataGridView();
        }
        public void CheckIfUserPasswordCorrect(bool IsUserPasswordCorrect)
        {
            _IsCurrentUserPasswordCorrect=IsUserPasswordCorrect;
        }
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
                ConfirmUserPassWordForm ConfirmPasswordFrm = new ConfirmUserPassWordForm();
                ConfirmPasswordFrm.DataBack += CheckIfUserPasswordCorrect;
                ConfirmPasswordFrm.ShowDialog();
                if (!_IsCurrentUserPasswordCorrect) return;

            if (MessageBox.Show("Are you sure you want to delete this User from the system ? ", "Confirm the operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                int UserIDToDelete = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);

                if (GlobalSettings.CurrentUser.UserID==UserIDToDelete)
                {
                    if (MessageBox.Show("You are trying to delete your account.Are you sure you want to continue? You will not be able to log in again after this process! ", "Confirm the Process", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        MessageBox.Show("operation has been cancelled", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (clsUsers.Delete(UserIDToDelete))
                        {
                            GlobalSettings.CloseAllFormsAndReturnToLoginForm();
                        }
                        else MessageBox.Show("Your account can't be deleted because it is linked to other data on the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }


                if (clsUsers.Delete(UserIDToDelete))
                {
                    MessageBox.Show("User has been deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshUsersListInDataGridView();
                }
                else
                    MessageBox.Show("This User can't be deleted because it is linked to other data on the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changePassWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeUserPasswordForm frm = new ChangeUserPasswordForm(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void contextMenuStripUsers_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            contextMenuStripUsers.Enabled = (dgvUsers.Rows.Count > 0);
        }
    }
}
