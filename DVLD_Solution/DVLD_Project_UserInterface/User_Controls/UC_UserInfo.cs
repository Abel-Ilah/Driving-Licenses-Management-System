using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class UC_UserInfo : UserControl
    {
        public UC_UserInfo()
        {
            InitializeComponent();
        }
       void ResetToInitialValues ()
        {
            lbAccountStatus.Text = "???????????";
            lbUserID.Text = "???????????";
            lbUserName.Text= "???????????";
            uC_PersonInfo1.LoadPersonInfo(-1);
        }
        public void LoadUserInfo(int UserID)
        {
            clsUsers User=clsUsers.FindByUserID(UserID);
            if (User == null)
            {
                MessageBox.Show("The person was not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetToInitialValues();
                return;
            }
            uC_PersonInfo1.LoadPersonInfo(User.PersonID);

            lbUserName.Text = User.UserName;
            lbUserID.Text=User.UserID.ToString();

            lbAccountStatus.Text = "Active";
            lbAccountStatus.ForeColor = Color.Green;
            if (!User.IsActive)
            {
                lbAccountStatus.Text = "Inactive";
                lbAccountStatus.ForeColor = Color.Red;
            }
              

        }

    }
}
