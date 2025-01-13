using System;

using System.Windows.Forms;

namespace UserInterface
{
    public partial class UserInfoForm : Form
    {
        int _UserID=-1;
        public UserInfoForm(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            uC_UserInfo1.LoadUserInfo(_UserID);
        }
    }
}
