using BusinessLayer;
using System;
using System.Windows.Forms;


namespace UserInterface
{
    public partial class ReleaseLicenseForm : Form
    {
        clsDetainLicenses _Detain;

        int _LocalLicenseID=-1;
        int _PersonID = -1;
        decimal _ApplicationFees=0;
        public ReleaseLicenseForm(int localLicenseID=-1)
        {
            InitializeComponent();
            _LocalLicenseID= localLicenseID;
        }

        private void ReleaseLicenseForm_Load(object sender, EventArgs e)
        {
          
            lbDetainDate.Text = DateTime.Now.ToShortDateString();
            lbUserName.Text = GlobalSettings.CurrentUser.UserName;
            _ApplicationFees = clsApplicationTypes.Find(5).ApplicationFees;
            lbApplicationFees.Text=_ApplicationFees.ToString();

            if (_LocalLicenseID != -1)
            {
                uC_LocalLicenseCardWithFilter1.QuickFind(_LocalLicenseID);
                uC_LocalLicenseCardWithFilter1.EnableFilter = false;
            }
        }

        void ResetDefaultValues()
        {
            btnShowLicenseInfo.Enabled = false;
            btnShowLicensesHistory.Enabled = false;
            btnRelease.Enabled = false;
            lbLicenseID.Text = "[??????]";
            lbDetainID.Text = "[??????]";
            lbFineFees.Text = "[??????]";
            lbTotalFees.Text = "[??????]";
            lbApplicationID.Text = "[??????]";
        }
        private void uC_LocalLicenseCardWithFilter1_WhenLicenseIsFound(int obj)
        {
            ResetDefaultValues();

            if (obj == -1) return;

            _LocalLicenseID = obj;

            lbLicenseID.Text = _LocalLicenseID.ToString();

            btnShowLicensesHistory.Enabled = true;

            _PersonID = clsLicenses.GetPersonIdOfLicenseOwner(_LocalLicenseID);

            _Detain = clsDetainLicenses.FindLastDetain(_LocalLicenseID);
            if (_Detain==null)
            {
                MessageBox.Show($"This license has never been detained!", "License not detained", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbDetainID.Text = _Detain.DetainID.ToString();
            lbFineFees.Text = _Detain.FineFees.ToString();
            lbTotalFees.Text = $"{_ApplicationFees + _Detain.FineFees}";
            if (_Detain.IsReleased && _Detain.ReleaseDate!=null)
            {
                MessageBox.Show($"This license already released on {_Detain.ReleaseDate}!", "License already released", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            btnRelease.Enabled = true;
        }

        private void btnShowLicensesHistory_Click(object sender, EventArgs e)
        {
            LicensesHistoryForm frm = new LicensesHistoryForm(_PersonID);
            frm.ShowDialog(); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
          if (MessageBox.Show("Are you sure you want to Release this license?", "Confirm Release", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          { 
                clsApplications Application = new clsApplications();

                Application.ApplicantPersonID = _PersonID;
                Application.ApplicationDate = DateTime.Now;
                Application.ApplicationTypeID = 2;
                Application.ApplicationStatus = 1;
                Application.LastStatusDate = DateTime.Now;
                Application.PaidFees = _ApplicationFees;
                Application.CreatedByUserID = GlobalSettings.CurrentUser.UserID;

                if (Application.Save())
                {
                    lbApplicationID.Text = Application.ApplicationID.ToString();

                    _Detain.IsReleased = true;
                    _Detain.ReleaseDate = DateTime.Now;
                    _Detain.ReleasedByUserID= GlobalSettings.CurrentUser.UserID;
                    _Detain.ReleaseApplicationID = Application.ApplicationID;

                    if (_Detain.Save())
                    {
                        lbDetainID.Text = _Detain.DetainID.ToString();
                        btnShowLicenseInfo.Enabled = true;
                        btnRelease.Enabled = false;
                        MessageBox.Show("License Released successfully.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Application.ApplicationStatus = 3;
                        Application.LastStatusDate = DateTime.Now;
                        Application.Save();
                    }
                    else
                        MessageBox.Show("Operation Failed.", "Release License Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    MessageBox.Show("Error : The system failed to add the new application!", "Save Application Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }

        private void btnShowLicenseInfo_Click(object sender, EventArgs e)
        {
            ShowLicenseInfoForm form = new ShowLicenseInfoForm(_LocalLicenseID);
            form.ShowDialog();
        }
    }
}
