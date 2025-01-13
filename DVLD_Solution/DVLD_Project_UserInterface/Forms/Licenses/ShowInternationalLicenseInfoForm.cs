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
    public partial class ShowInternationalLicenseInfoForm : Form
    {
        int _InternationalLicenseID = -1;
        public ShowInternationalLicenseInfoForm(int internationalLicenseID)
        {
            InitializeComponent();
            _InternationalLicenseID = internationalLicenseID;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowInternationalLicenseInfoForm_Load(object sender, EventArgs e)
        {
            uC_InternationalLicenseCard1.ShowInternationalLicenseInfo(_InternationalLicenseID);
        }
    }
}
