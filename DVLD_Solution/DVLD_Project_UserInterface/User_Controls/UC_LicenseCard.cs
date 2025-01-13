using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer;
using UserInterface.Properties;

namespace UserInterface
{
    public partial class UC_LicenseCard : UserControl
    {
        clsLicenses _License;
        clsDrivers _Driver;
        public UC_LicenseCard()
        {
            InitializeComponent();
        }
        public  void ResetLicenseCard()
        {
            lbLicenseClass.Text = "[??????]";
            lbName.Text = "[??????]";
            lbLicenseID.Text = "[??????]";
            lbNationalNo.Text = "[??????]";
            lbGender.Text = "[??????]";
            lbIssueDate.Text = "[??????]";
            lbIssueReason.Text = "[??????]";
            lbStatus.Text = "[??????]";
            lbDateOfBirth.Text = "[??????]";
            lbDriverID.Text = "[??????]";
            lbExpirationDate.Text = "[??????]";
            lbIsDetained.Text = "[??????]";
            pbDriverImage.Image = Resources.MissedImage;
        }
        string GetIssueReasonName(byte IssueReasonID)
        {
            string[] IssueReasons={ "", "First Time","Renew License","Replacement For Lost","Replacement For Damage"};
            return IssueReasons[IssueReasonID];
        }

        public void ShowLicenseInfo(int LicenseID)
        {
            ResetLicenseCard();
            _License =clsLicenses.FindLicenseByLicenseID(LicenseID);
            if (_License == null )
            {
                MessageBox.Show("License Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Driver = clsDrivers.Find(_License.DriverID);
            if (_Driver != null )
            {
                lbName.Text = _Driver.PersonInfo.FullName;
                lbNationalNo.Text = _Driver.PersonInfo.NationalNo;
                lbGender.Text = (_Driver.PersonInfo.Gender == 0) ? "Male" : "Female";
                lbDateOfBirth.Text = _Driver.PersonInfo.DateOfBirth.ToShortDateString();
                lbDriverID.Text = _Driver.DriverID.ToString();
                if (!string.IsNullOrEmpty(_Driver.PersonInfo.ImagePath))
                {
                    try { pbDriverImage.ImageLocation = _Driver.PersonInfo.ImagePath;}
                    catch (Exception ex)
                    {
                        MessageBox.Show("The Driver's image path was not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pbDriverImage.Image = Resources.MissedImage;
                        GlobalSettings.LoggingAnException("DVLD", ex.Message);
                    }
                }
                else pbDriverImage.Image = (_Driver.PersonInfo.Gender == 0) ? Resources.Male_512 : Resources.Female_512;
            }

            lbLicenseClass.Text = clsLicenseClasses.GetLicenseClassName(_License.LicenseClassID);
            lbLicenseID.Text=_License.LicenseID.ToString();
            lbIssueDate.Text = _License.IssueDate.ToShortDateString();
            lbIssueReason.Text = GetIssueReasonName(_License.IssueReason);
            if (_License.IsActive)
            {
                lbStatus.Text = "Active";
                lbStatus.ForeColor = Color.Green;
            }
            else
            {
                lbStatus.Text = "Inactive";
                lbStatus.ForeColor = Color.Red;
            }
            lbExpirationDate.Text=_License.ExpirationDate.ToShortDateString();


            if (clsDetainLicenses.IsLicenseDetained(_License.LicenseID))
            {
                lbIsDetained.Text = "Yes";
                lbIsDetained.ForeColor= Color.Red;
            }
            else
            {
                lbIsDetained.Text = "No";
                lbIsDetained.ForeColor = Color.Green;
            }

        }

    }
}
