using BusinessLayer;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class IssueDrivingLicenseForm : Form
    {
        int _LocalDrivingLicenseApplicationID;

        clsDrivers _driver;
        clsLicenses _License;
        clsLocalDrivingLicenseApplications _LocalDrivingLicenseApplication;

        public IssueDrivingLicenseForm(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID=LocalDrivingLicenseApplicationID;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IssueDrivingLicenseForm_Load(object sender, EventArgs e)
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplications.Find(_LocalDrivingLicenseApplicationID);
            if (_LocalDrivingLicenseApplication==null)
            {
               MessageBox.Show("this Application no longer exist in the system!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            uC_LocalDrivingLicenseApplicationInfo1.ShowLocalDrivingLicenseApplicationInfo(_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID);
            txtbNotes.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int DriverID = clsDrivers.GetDriverID(_LocalDrivingLicenseApplication.ApplicantPersonID);
            if (DriverID==-1)
            {
                _driver = new clsDrivers();
                _driver.PersonID = _LocalDrivingLicenseApplication.ApplicantPersonID;
                _driver.CreatedByUserID = GlobalSettings.CurrentUser.UserID;
                _driver.CreateDate = DateTime.Now;

                if (_driver.Save())
                    DriverID = _driver.DriverID;
                else
                {
                    MessageBox.Show("Failed to Add the New Driver!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            _License = new clsLicenses();
            _License.DriverID = DriverID;
            _License.ApplicationID = _LocalDrivingLicenseApplication.ApplicationID;
            _License.LicenseClassID = _LocalDrivingLicenseApplication.LicenseClassID;
            _License.IssueDate = DateTime.Now;
            _License.ExpirationDate = _License.IssueDate.AddYears((int)clsLicenseClasses.Find(_License.LicenseClassID).DefaultValidityLength);
            _License.Notes=txtbNotes.Text;
            _License.PaidFees = clsLicenseClasses.Find(_License.LicenseClassID).Fees;
            _License.IsActive = true;
            _License.IssueReason = 1;
            _License.CreatedByUserID = GlobalSettings.CurrentUser.UserID;
            if (_License.Save())
            {
                _LocalDrivingLicenseApplication.ApplicationStatus = 3;
                _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
                if (_LocalDrivingLicenseApplication.Save())
                {
                    MessageBox.Show("New License Has been added Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else MessageBox.Show("Failed to Update Application Status!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Failed to save License informations!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
        }
    }
}
