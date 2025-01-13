using BusinessLayer;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class RenewLocalLicenseForm : Form
    {
        clsLicenses _OldLocalLicense;
        clsLicenses _NewLocalLicense;
        clsApplications _Application;
        int _PersonID = -1;
        byte _NewLicenseValidityLength = 0;
        decimal _ApplicationFees = 0;
        decimal _NewLicenseFees = 0;

        public RenewLocalLicenseForm()
        {
            InitializeComponent();
           
        }

        private void RenewLocalLicenseForm_Load(object sender, EventArgs e)
        {
            lbApplicationDate.Text = DateTime.Now.ToShortDateString();
            lbIssueDate.Text = DateTime.Now.ToShortDateString();
            _ApplicationFees = clsApplicationTypes.Find(2).ApplicationFees;
            lbApplicationFees.Text = _ApplicationFees.ToString();
            lbUserName.Text = GlobalSettings.CurrentUser.UserName;
        }

        private void uC_LocalLicenseCardWithFilter1_WhenLicenseIsFound(int obj)
        {
            btnShowLicenseInfo.Enabled = false;
            btnShowLicensesHistory.Enabled = false;
            btnIssue.Enabled = false;
            lbOldLicenseID.Text = "[??????]";
            lbApplicationID.Text= "[??????]";

            if (obj == -1) return;

            _OldLocalLicense = clsLicenses.FindLicenseByLicenseID(obj);
            if (_OldLocalLicense == null)
            {
                MessageBox.Show($"This license no longer exists in the system", "Search result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _PersonID = clsLicenses.GetPersonIdOfLicenseOwner(_OldLocalLicense.LicenseID);

            lbOldLicenseID.Text = _OldLocalLicense.LicenseID.ToString();

            _NewLicenseValidityLength = clsLicenseClasses.Find(_OldLocalLicense.LicenseClassID).DefaultValidityLength;
            _NewLicenseFees = clsLicenseClasses.Find(_OldLocalLicense.LicenseClassID).Fees;

            lbExpirationDate.Text = DateTime.Now.AddYears(_NewLicenseValidityLength).ToShortDateString();
            lbLicenseFees.Text = _NewLicenseFees.ToString();
            lbTotalFees.Text = $"{_ApplicationFees + _NewLicenseFees}";


            btnShowLicensesHistory.Enabled = true;

            if (!_OldLocalLicense.IsActive)
            {
                MessageBox.Show($"This license is no longer active", "Inactivated license", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_OldLocalLicense.ExpirationDate > DateTime.Now)
            {
                MessageBox.Show($"This license is not yet Expired!\nIt Will expire on {_OldLocalLicense.ExpirationDate}", "Active license", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnIssue.Enabled = true;
        }

        private void btnShowLicensesHistory_Click(object sender, EventArgs e)
        {
            LicensesHistoryForm frm = new LicensesHistoryForm(_PersonID);
            frm.ShowDialog();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
           
            _Application = new clsApplications();

            _Application.ApplicantPersonID = _PersonID;
            _Application.ApplicationDate = DateTime.Now;
            _Application.ApplicationTypeID = 2;
            _Application.ApplicationStatus = 1;
            _Application.LastStatusDate = DateTime.Now;
            _Application.PaidFees = _ApplicationFees;
            _Application.CreatedByUserID = GlobalSettings.CurrentUser.UserID;

            if (_Application.Save())
            {
                lbApplicationID.Text = _Application.ApplicationID.ToString();

               _NewLocalLicense = new clsLicenses();

               _NewLocalLicense.ApplicationID = _Application.ApplicationID;
               _NewLocalLicense.DriverID=_OldLocalLicense.DriverID;
               _NewLocalLicense.LicenseClassID = _OldLocalLicense.LicenseClassID;
               _NewLocalLicense.IssueDate = DateTime.Now;
               _NewLocalLicense.ExpirationDate= DateTime.Now.AddYears(_NewLicenseValidityLength);
               _NewLocalLicense.Notes = txtbNotes.Text;
               _NewLocalLicense.PaidFees = _NewLicenseFees;
               _NewLocalLicense.IsActive = true;
               _NewLocalLicense.IssueReason = 2;
               _NewLocalLicense.CreatedByUserID= GlobalSettings.CurrentUser.UserID;


                if (_NewLocalLicense.Save())
                {
                    lbRenewedlLicenseID.Text = _NewLocalLicense.LicenseID.ToString();

                    _Application.ApplicationStatus = 3;
                    _Application.LastStatusDate = DateTime.Now;
                    _Application.Save();

                    btnIssue.Enabled = false;
                    btnShowLicenseInfo.Enabled = true;

                    MessageBox.Show("Data Saved Successfully.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _OldLocalLicense.IsActive = false;
                    if (!_OldLocalLicense.Save())
                        MessageBox.Show("Failed to deactivate the old license!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Failed to save the New License!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Failed to save the New Application", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowLicenseInfo_Click(object sender, EventArgs e)
        {
            if (_NewLocalLicense.LicenseID == -1) return;
            ShowLicenseInfoForm form = new ShowLicenseInfoForm(_NewLocalLicense.LicenseID);
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
