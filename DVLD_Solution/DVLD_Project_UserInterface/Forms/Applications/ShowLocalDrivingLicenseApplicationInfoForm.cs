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
    public partial class ShowLocalDrivingLicenseApplicationInfoForm : Form
    {
        int _LocalDrivingLicenseApplicationID;
        public ShowLocalDrivingLicenseApplicationInfoForm(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID= LocalDrivingLicenseApplicationID;
        }

        private void ShowLocalDrivingLicenseApplicationInfoForm_Load(object sender, EventArgs e)
        {
            uC_LocalDrivingLicenseApplicationInfo1.ShowLocalDrivingLicenseApplicationInfo(_LocalDrivingLicenseApplicationID);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
