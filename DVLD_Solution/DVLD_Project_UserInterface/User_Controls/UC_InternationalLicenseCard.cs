using BusinessLayer;
using System.ComponentModel;
using System.Drawing;
using System;
using System.Windows.Forms;
using UserInterface.Properties;

namespace UserInterface
{
    public partial class UC_InternationalLicenseCard : UserControl
    {
        clsInternationalLicenses _InternationalLicense;
        clsDrivers _Driver;
        public UC_InternationalLicenseCard()
        {
            InitializeComponent();
        }

        public void ResetInternationalLicenseCard()
        {
            lbName.Text = "[??????]";
            lbInternationalLicenseID.Text = "[??????]";
            lbLicenseID.Text = "[??????]";
            lbNationalNo.Text = "[??????]";
            lbGender.Text = "[??????]";
            lbIssueDate.Text = "[??????]";
            lbStatus.Text = "[??????]";
            lbDateOfBirth.Text = "[??????]";
            lbDriverID.Text = "[??????]";
            lbExpirationDate.Text = "[??????]";

            pbDriverImage.Image = Resources.MissedImage;
        }
        public void ShowInternationalLicenseInfo(int InternationalLicenseID)
        {
            ResetInternationalLicenseCard();
            _InternationalLicense = clsInternationalLicenses.Find(InternationalLicenseID);
            if (_InternationalLicense == null)
            {
                MessageBox.Show("International License Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Driver = clsDrivers.Find(_InternationalLicense.DriverID);
            if (_Driver != null)
            {
                lbName.Text = _Driver.PersonInfo.FullName;
                lbNationalNo.Text = _Driver.PersonInfo.NationalNo;
                lbGender.Text = (_Driver.PersonInfo.Gender == 0) ? "Male" : "Female";
                lbDateOfBirth.Text = _Driver.PersonInfo.DateOfBirth.ToShortDateString();
                lbDriverID.Text = _Driver.DriverID.ToString();
                if (!string.IsNullOrEmpty(_Driver.PersonInfo.ImagePath))
                {
                    try { pbDriverImage.ImageLocation = _Driver.PersonInfo.ImagePath; }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The Driver's image path was not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pbDriverImage.Image = Resources.MissedImage;
                        GlobalSettings.LoggingAnException("DVLD", ex.Message);
                    }
                }
                else pbDriverImage.Image = (_Driver.PersonInfo.Gender == 0) ? Resources.Male_512 : Resources.Female_512;
            }
            lbInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lbLicenseID.Text = _InternationalLicense.LocalLicenseID.ToString();
            lbIssueDate.Text = _InternationalLicense.IssueDate.ToShortDateString();
            
            if (_InternationalLicense.IsActive)
            {
                lbStatus.Text = "Active";
                lbStatus.ForeColor = Color.Green;
            }
            else
            {
                lbStatus.Text = "Inactive";
                lbStatus.ForeColor = Color.Red;
            }
            lbExpirationDate.Text = _InternationalLicense.ExpirationDate.ToShortDateString();
        }

    }
}
