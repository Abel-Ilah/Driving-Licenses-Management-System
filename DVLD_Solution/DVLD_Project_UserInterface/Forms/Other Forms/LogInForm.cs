using BusinessLayer;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UserInterface.Properties;
using Microsoft.Win32;

namespace UserInterface
{
    public partial class LogInForm : Form
    {
        public static LogInForm instance;
      
        public LogInForm()
        {
            InitializeComponent();
            instance = this;
            txtbPassWord.ContextMenu = new ContextMenu();
            txtbUserName.ContextMenu = new ContextMenu();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void SaveLoginInfoInRegistry(string username, string password, string Separator)
        {
            string KeyName = @"HKEY_CURRENT_USER\SOFTWARE\DVLD_LoginInfo";
            string ValueName = "LoginInfo";
            string LoginInfo = $"{username}{Separator}{clsEncryption.EncrypteText(password)}";
            try
            {
                Registry.SetValue(KeyName, ValueName, LoginInfo, RegistryValueKind.String);
            }
            catch (Exception ex)
            {
               MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               GlobalSettings.LoggingAnException("DVLD", ex.Message);
            }
        }
        private void LoadSavedLoginInfoToLoginScreen(string Separator)
        {
            string KeyName = @"HKEY_CURRENT_USER\SOFTWARE\DVLD_LoginInfo";
            string ValueName = "LoginInfo";
            try
            {
               string ValueData=Registry.GetValue(KeyName, ValueName,null) as string ;

                if (ValueData!=null)
                {
                    string[] separators = new string[] { Separator };

                    string[] LoginInfo = ValueData.Split(separators, StringSplitOptions.None);

                    txtbUserName.Text = LoginInfo[0].Trim();
                    txtbPassWord.Text = clsEncryption.DecryptText(LoginInfo[1].Trim());

                    chbRememberMe.Checked = true;
                }
                else
                    chbRememberMe.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GlobalSettings.LoggingAnException("DVLD", ex.Message);
            }
        }
      
        private void ShowMainForm()
        {
            this.Hide();
            MainForm frm=new MainForm(this);
            frm.ShowDialog();
            
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.Width += 6;
            btnLogin.Height += 6;
            btnLogin.Top -= 3;
            btnLogin.Left -= 3;

        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.Width -=6;
            btnLogin.Height -=6;
            btnLogin.Top +=3;
            btnLogin.Left +=3;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtbUserName.Text))
            {
                LoginErrorProvider.SetError(txtbUserName, "Please Enter A value here");
                return;
            }
            if (string.IsNullOrEmpty(txtbPassWord.Text))
            {
                LoginErrorProvider.SetError(txtbPassWord, "Please Enter A value here");
                return;
            }
            
            clsUsers User=clsUsers.FindByUserName(txtbUserName.Text,true);
            if (User==null)
            {
                LoginErrorProvider.SetError(txtbUserName, "This UserName Doesn't exist,Please enter a correct UserName");
                return;
            }
            if (clsEncryption.ComputeHash(txtbPassWord.Text) !=User.Password)
            {
                LoginErrorProvider.SetError(txtbPassWord, "Wrong Password");
                return;
            }
            if (!User.IsActive)
            {
                MessageBox.Show("This account is no longer active. Please contact your Admin!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

           GlobalSettings.CurrentUser = User;

            if (chbRememberMe.Checked)
                SaveLoginInfoInRegistry(txtbUserName.Text,txtbPassWord.Text, "#||#");
            
            ShowMainForm();
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbPassWord.Text)) return;
            
            if (btnViewPassword.Tag.ToString() == "PasswordIsHided")
            {
                txtbPassWord.PasswordChar = '\0';

                btnViewPassword.Tag = "PasswordIsShown";
                btnViewPassword.Image = Resources.HidePasswordIcon;
                return;
            }
            if (btnViewPassword.Tag.ToString() == "PasswordIsShown")
            {
                txtbPassWord.PasswordChar = '*';

                btnViewPassword.Tag = "PasswordIsHided";
                btnViewPassword.Image = Resources.ShowPasswordIcon;
            }
        }

        private void txtbUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '@')
            {
                e.Handled = true; return;
            }
        }

        private void txtbPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbUserName_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtbUserName.Text))
            {
                LoginErrorProvider.SetError(txtbUserName, "Please Enter A value here");
                return;
            }
            LoginErrorProvider.SetError(txtbUserName, string.Empty);
        }

        private void txtbPassWord_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbPassWord.Text))
            {
                LoginErrorProvider.SetError(txtbPassWord, "Please Enter A value here");
                return;
            }
            LoginErrorProvider.SetError(txtbPassWord, string.Empty);
        }

        private void txtbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            LoadSavedLoginInfoToLoginScreen("#||#");
        }

      
    }
}
