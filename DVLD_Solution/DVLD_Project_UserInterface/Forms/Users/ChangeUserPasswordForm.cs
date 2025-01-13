using BusinessLayer;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class ChangeUserPasswordForm : Form
    {
        int _UserID = -1;
        clsUsers _User;
        public ChangeUserPasswordForm(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void ChangeUserPasswordForm_Load(object sender, EventArgs e)
        {
            _User = clsUsers.FindByUserID(_UserID);
            if (_UserID<=-1 || _User==null)
            {
                MessageBox.Show("This User Doesn't Exist!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            uC_UserInfo1.LoadUserInfo(_User.UserID);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                PassWorderrorProvider.SetError(((TextBox)sender), "Please Enter a PassWord here!");
                btnSave.Enabled = false;
                return;
            }
            PassWorderrorProvider.SetError(((TextBox)sender), string.Empty);
            btnSave.Enabled = true;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }

        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true; return;
            }
        }

        private void txtbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbConfirmPassword.Text))
            {
                PassWorderrorProvider.SetError((txtbConfirmPassword), "Please Enter a PassWord here!");
                btnSave.Enabled = false;
                return;
            }
            PassWorderrorProvider.SetError((txtbConfirmPassword), string.Empty);
            btnSave.Enabled = true;

            if (txtbNewPassword.Text != txtbConfirmPassword.Text)
            {
                PassWorderrorProvider.SetError(txtbConfirmPassword, "The confirmed password does not match the entered password");
                return;
            }
            PassWorderrorProvider.SetError(txtbConfirmPassword, string.Empty);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsEncryption.ComputeHash(txtbCurrentPassWord.Text) != _User.Password)
            {
                PassWorderrorProvider.SetError(txtbCurrentPassWord, "Wrong Password");
                txtbConfirmPassword.Focus();
                return;
            }

            if (txtbNewPassword.Text != txtbConfirmPassword.Text)
            {
                PassWorderrorProvider.SetError(txtbConfirmPassword, "The confirmed password does not match the entered password");
                txtbConfirmPassword.Focus();
                return;
            }

            if (txtbNewPassword.Text==_User.Password)
            {
                MessageBox.Show("The new password should not be the same as the current password.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbNewPassword.Clear();
                txtbConfirmPassword.Clear();
                return;
            }
            _User.Password=txtbNewPassword.Text;
            if (_User.Save())
            {
                GlobalSettings.CurrentUser.Password = _User.Password;
                MessageBox.Show("Data saved successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else MessageBox.Show("Operation Failed,Data has not been Saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
