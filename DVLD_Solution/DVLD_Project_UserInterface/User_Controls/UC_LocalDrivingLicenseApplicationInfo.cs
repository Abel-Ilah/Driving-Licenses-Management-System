using BusinessLayer;
using System;

using System.Windows.Forms;

namespace UserInterface
{
    public partial class UC_LocalDrivingLicenseApplicationInfo : UserControl
    {
      


        clsLocalDrivingLicenseApplications _LocalDrivingLicenseApplication;
        public UC_LocalDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        void SetDefaultValues()
        {
            lbDrivingLicenseApplicationID.Text = "[???????]";
            lbPassedTests.Text = "[???????]";
            lbLicenseClass.Text = "[???????]";

            lbApplicationID.Text = "[???????]";
            lbFees.Text = "[???????]";
            lbUserName.Text = "[???????]";
            lbApplicationType.Text = "[???????]";
            lbApplicantFullName.Text = "[???????]";
            lbStatus.Text = "[???????]";
            lbApplicationDate.Text = "[???????]";
            lbLastStatusDate.Text = "[???????]";

            lbApplicantFullName.Enabled = false;
        }

        string GetStatusName(byte statusID)
        {
            string [] Status ={ "New","Canceled","Completed"};
            return Status[statusID - 1];
        }

        public void ShowLocalDrivingLicenseApplicationInfo(int LocalDrivingLicenseApplicationID)
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplications.Find(LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication==null)
            {
                MessageBox.Show("This application is no longer exist in the system!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetDefaultValues();
                return;
            }
            lbDrivingLicenseApplicationID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lbPassedTests.Text=clsLocalDrivingLicenseApplications.GetPassedTestsCount(LocalDrivingLicenseApplicationID).ToString()+"/3";
            lbLicenseClass.Text = clsLicenseClasses.GetLicenseClassName(_LocalDrivingLicenseApplication.LicenseClassID);

            if (_LocalDrivingLicenseApplication.ApplicationStatus==3)
                btnShowLicenseInfo.Enabled = true;

            lbApplicationID.Text = _LocalDrivingLicenseApplication.ApplicationID.ToString();
            lbFees.Text= _LocalDrivingLicenseApplication.PaidFees.ToString();
            lbUserName.Text = clsUsers.FindByUserID(_LocalDrivingLicenseApplication.CreatedByUserID).UserName;
            lbApplicationType.Text = clsApplicationTypes.Find(_LocalDrivingLicenseApplication.ApplicationTypeID).ApplicationTypeTitle;
            lbApplicantFullName.Text= clsPeople.Find(_LocalDrivingLicenseApplication.ApplicantPersonID).FullName;
            lbStatus.Text = GetStatusName(_LocalDrivingLicenseApplication.ApplicationStatus);
            lbApplicationDate.Text=_LocalDrivingLicenseApplication.ApplicationDate.ToShortDateString();
            lbLastStatusDate.Text=_LocalDrivingLicenseApplication.LastStatusDate.ToShortDateString();

            lbApplicantFullName.Enabled = true;
           
        }

        public void UpdatePassedTests()
        {
            if (_LocalDrivingLicenseApplication!=null)
            {
                lbPassedTests.Text = clsLocalDrivingLicenseApplications.GetPassedTestsCount(_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID).ToString() + "/3";
            }
        }
        private void lbApplicantFullName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_LocalDrivingLicenseApplication!=null)
            {
                PersonInfoForm form = new PersonInfoForm(_LocalDrivingLicenseApplication.ApplicantPersonID);
                form.ShowDialog();
            }
        }

        private void btnShowLicenseInfo_Click(object sender, EventArgs e)
        {
            int LicenseID = clsLicenses.GetLicenseIdByApplicationID(_LocalDrivingLicenseApplication.ApplicationID);
            if (LicenseID ==-1)
            {
                MessageBox.Show("License Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ShowLicenseInfoForm frm = new ShowLicenseInfoForm(LicenseID);
            frm.ShowDialog();
        }
    }
}
