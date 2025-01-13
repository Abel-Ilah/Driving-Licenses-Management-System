using BusinessLayer;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class ShowLicenseInfoForm : Form
    {
        int _licenseID;
        public ShowLicenseInfoForm(int LicenseID)
        {
            InitializeComponent();
            _licenseID= LicenseID;
        }

        private void ShowLicenseInfoForm_Load(object sender, EventArgs e)
        {
            if (!clsLicenses.IsLicenseExist(_licenseID))
            {
                MessageBox.Show($"There is no License with the entered ID=[{_licenseID}].", "License Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }
            uC_LicenseCard1.ShowLicenseInfo(_licenseID);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
