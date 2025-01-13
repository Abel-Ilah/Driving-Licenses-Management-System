using BusinessLayer;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class ConfirmUserPassWordForm : Form
    {
        string _CurrentUserPassWord="";

        public  delegate void CheckUserPasswordEventHandler(bool IsUserPasswordCorrect);

        public  event CheckUserPasswordEventHandler DataBack;

      
        public ConfirmUserPassWordForm()
        {
            InitializeComponent();
            _CurrentUserPassWord = GlobalSettings.CurrentUser.Password; 
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (clsEncryption.ComputeHash(txtbPassWord.Text) != _CurrentUserPassWord)
            {
                MessageBox.Show("Wrong Password!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataBack?.Invoke(true);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(false);
            this.Close();
        }

        private void txtbPassWord_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbPassWord.Text))
            {
                btnConfirm.Enabled = true;
                return;
            }
            btnConfirm.Enabled = false;
        }

        private void txtbPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true; return;
            }
        }

        private void txtbPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
