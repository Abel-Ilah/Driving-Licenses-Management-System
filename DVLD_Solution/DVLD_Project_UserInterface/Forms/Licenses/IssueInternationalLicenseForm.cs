using BusinessLayer;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class IssueInternationalLicenseForm : Form
    {
       
        clsLicenses LocalLicense;
        clsInternationalLicenses NewInternationalLicense = new clsInternationalLicenses();
        int _PersonID = -1;

        public IssueInternationalLicenseForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uC_LicenseCardWithFilter1_WhenLicenseIsFound(int obj)
        {
         
          btnShowLicenseInfo.Enabled = false;
          btnShowLicensesHistory.Enabled = false;
          btnIssue.Enabled = false;
          lbLocalLicenseID.Text = "[??????]";

          if (obj == -1) return;
          
          LocalLicense = clsLicenses.FindLicenseByLicenseID(obj);
          if (LocalLicense==null)
          {
            MessageBox.Show($"This license no longer exists in the system", "Search result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
          _PersonID = clsLicenses.GetPersonIdOfLicenseOwner(LocalLicense.LicenseID);

          lbLocalLicenseID.Text = LocalLicense.LicenseID.ToString();

          btnShowLicensesHistory.Enabled = true;

          int ActiveInternationalLicenseIdOfDriver = clsInternationalLicenses.GetActiveInternationalLicenseID(LocalLicense.DriverID);
          if (ActiveInternationalLicenseIdOfDriver != -1)
          {
              MessageBox.Show($"Person already have an active International license with ID={ActiveInternationalLicenseIdOfDriver}", "Duplication Data Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return;
          }
          if (LocalLicense.LicenseClassID!=3)
          {
              MessageBox.Show("This type of license is denied \nThe system accept only \n[Class 3 - Ordinary Driving License] ", "License Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return;
          }
          if (!LocalLicense.IsActive)
          {
              MessageBox.Show($"This license is no longer active", "Inactivated license", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return;
          }
          if (LocalLicense.ExpirationDate<DateTime.Now)
          {
              MessageBox.Show($"This license expired on {LocalLicense.ExpirationDate}", "Expired license", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return;
          }

          btnIssue.Enabled = true;

        }

        private void btnShowLicenseInfo_Click(object sender, EventArgs e)
        {
            if (NewInternationalLicense.InternationalLicenseID == -1) return;
            ShowInternationalLicenseInfoForm form = new ShowInternationalLicenseInfoForm(NewInternationalLicense.InternationalLicenseID);
            form.ShowDialog();
        }

        private void btnShowLicensesHistory_Click(object sender, EventArgs e)
        {
          LicensesHistoryForm frm = new LicensesHistoryForm(_PersonID);
            frm.ShowDialog();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            clsApplications application = new clsApplications();
            application.ApplicantPersonID= _PersonID;
            application.ApplicationDate = DateTime.Now;
            application.ApplicationTypeID = 6;
            application.ApplicationStatus = 1;
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = clsApplicationTypes.Find(6).ApplicationFees;
            application.CreatedByUserID=GlobalSettings.CurrentUser.UserID;
            if (application.Save())
            {
                lbApplicationID.Text=application.ApplicationID.ToString();

                NewInternationalLicense.ApplicationID = application.ApplicationID;
                NewInternationalLicense.DriverID = LocalLicense.DriverID;
                NewInternationalLicense.LocalLicenseID = LocalLicense.LicenseID;
                NewInternationalLicense.IssueDate= DateTime.Now;
                NewInternationalLicense.ExpirationDate=NewInternationalLicense.IssueDate.AddYears(1);
                NewInternationalLicense.IsActive = true;
                NewInternationalLicense.CreatedByUserID = GlobalSettings.CurrentUser.UserID;

                if (NewInternationalLicense.Save())
                {
                    lbInternationalLicenseID.Text = NewInternationalLicense.InternationalLicenseID.ToString();

                    application.ApplicationStatus = 3;
                    application.LastStatusDate= DateTime.Now;
                    application.Save();

                    btnIssue.Enabled = false;
                    btnShowLicenseInfo.Enabled = true;

                    MessageBox.Show("Data Saved Successfully.","Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operation Failed!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Failed to save the New Application", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void IssueInternationalLicenseForm_Load(object sender, EventArgs e)
        {
            lbApplicationDate.Text= DateTime.Now.ToShortDateString();
            lbIssueDate.Text = DateTime.Now.ToShortDateString();
            lbExpirationDate.Text = DateTime.Now.AddYears(1).ToShortDateString() ;
            lbFees.Text = clsApplicationTypes.Find(6).ApplicationFees.ToString();
            lbUserName.Text = GlobalSettings.CurrentUser.UserName;
        }
    }
}
