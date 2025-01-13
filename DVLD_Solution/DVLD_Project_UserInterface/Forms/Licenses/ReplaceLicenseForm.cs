using BusinessLayer;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class ReplaceLicenseForm : Form
    {
        clsLicenses _OldLocalLicense;
        clsLicenses _ReplacedLocalLicense;
        clsApplications _Application;
        int _PersonID = -1;
        decimal _ApplicationFees = 0;
        decimal _ReplacedLicenseFees = 0;
        public ReplaceLicenseForm()
        {
            InitializeComponent();
        }

        void GetApplicationFeesBasedOnReplacementReason()
        {
            _ApplicationFees=(rbDamagedLicense.Checked) ? clsApplicationTypes.Find(4).ApplicationFees : clsApplicationTypes.Find(3).ApplicationFees;
            lbApplicationFees.Text = _ApplicationFees.ToString();
            lbTotalFees.Text = $"{_ApplicationFees + _ReplacedLicenseFees}";
        }
        int GetApplicationTypeID()
        {
            return (rbLostLicense.Checked) ? 3 : 4 ;
        }

        private void ReplaceLicenseForm_Load(object sender, EventArgs e)
        {
            rbDamagedLicense.Checked = true;
            GetApplicationFeesBasedOnReplacementReason();

            lbApplicationDate.Text = DateTime.Now.ToShortDateString();
            lbUserName.Text = GlobalSettings.CurrentUser.UserName;

        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            GetApplicationFeesBasedOnReplacementReason();
        }

        void ResetDefaultValues()
        {
            btnShowLicenseInfo.Enabled = false;
            btnShowLicensesHistory.Enabled = false;
            btnIssue.Enabled = false;
            gbReplaceLicenseReasons.Enabled = true;
            _ReplacedLicenseFees = 0;

            lbOldLicenseID.Text = "[??????]";
            lbApplicationID.Text = "[??????]";
            lbLicenseFees.Text = "[??????]";

            lbTotalFees.Text = $"{_ApplicationFees}";
        }

        private void uC_LocalLicenseCardWithFilter1_WhenLicenseIsFound(int obj)
        {
            ResetDefaultValues();

            if (obj == -1) return;

            _OldLocalLicense = clsLicenses.FindLicenseByLicenseID(obj);
            if (_OldLocalLicense == null)
            {
                MessageBox.Show($"This license no longer exists in the system", "Search result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _PersonID = clsLicenses.GetPersonIdOfLicenseOwner(_OldLocalLicense.LicenseID);

            lbOldLicenseID.Text = _OldLocalLicense.LicenseID.ToString();

            _ReplacedLicenseFees = clsLicenseClasses.Find(_OldLocalLicense.LicenseClassID).Fees;

            lbLicenseFees.Text = _ReplacedLicenseFees.ToString();
            lbTotalFees.Text = $"{_ApplicationFees + _ReplacedLicenseFees}";

            btnShowLicensesHistory.Enabled = true;

            if (!_OldLocalLicense.IsActive)
            {
                MessageBox.Show($"This license is no longer active", "license not Active", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_OldLocalLicense.ExpirationDate <= DateTime.Now)
            {
                MessageBox.Show($"You Must Renew this License,because it has already Expired on {_OldLocalLicense.ExpirationDate}", "Ac license", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnIssue.Enabled = true;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            _Application = new clsApplications();
            _Application.ApplicantPersonID = _PersonID;
            _Application.ApplicationDate = DateTime.Now;
            _Application.ApplicationTypeID = GetApplicationTypeID();
            _Application.ApplicationStatus = 1;
            _Application.LastStatusDate = DateTime.Now;
            _Application.PaidFees = _ApplicationFees;
            _Application.CreatedByUserID = GlobalSettings.CurrentUser.UserID;

            if (_Application.Save())
            {
                lbApplicationID.Text = _Application.ApplicationID.ToString();

                _ReplacedLocalLicense = new clsLicenses();
                _ReplacedLocalLicense.ApplicationID = _Application.ApplicationID;
                _ReplacedLocalLicense.DriverID = _OldLocalLicense.DriverID;
                _ReplacedLocalLicense.LicenseClassID = _OldLocalLicense.LicenseClassID;
                _ReplacedLocalLicense.IssueDate = DateTime.Now;
                _ReplacedLocalLicense.ExpirationDate = _OldLocalLicense.ExpirationDate;
                _ReplacedLocalLicense.Notes = _OldLocalLicense.Notes;
                _ReplacedLocalLicense.PaidFees = _ReplacedLicenseFees;
                _ReplacedLocalLicense.IsActive = true;
                _ReplacedLocalLicense.IssueReason = Convert.ToByte((rbLostLicense.Checked) ? 3 : 4);
                _ReplacedLocalLicense.CreatedByUserID = GlobalSettings.CurrentUser.UserID;

                if (_ReplacedLocalLicense.Save())
                {
                    lbRenewedlLicenseID.Text = _ReplacedLocalLicense.LicenseID.ToString();

                    _Application.ApplicationStatus = 3;
                    _Application.LastStatusDate = DateTime.Now;
                    _Application.Save();

                    btnIssue.Enabled = false;
                    gbReplaceLicenseReasons.Enabled = false;
                    btnShowLicenseInfo.Enabled = true;

                    MessageBox.Show("Data Saved Successfully.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _OldLocalLicense.IsActive = false;
                    if (!_OldLocalLicense.Save())
                        MessageBox.Show("Failed to deactivate the old license!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Failed to save the Replaced License!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Failed to save the New Application", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowLicensesHistory_Click(object sender, EventArgs e)
        {
            LicensesHistoryForm frm = new LicensesHistoryForm(_PersonID);
            frm.ShowDialog();
        }

        private void btnShowLicenseInfo_Click(object sender, EventArgs e)
        {
            if (_ReplacedLocalLicense.LicenseID == -1) return;
            ShowLicenseInfoForm form = new ShowLicenseInfoForm(_ReplacedLocalLicense.LicenseID);
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
