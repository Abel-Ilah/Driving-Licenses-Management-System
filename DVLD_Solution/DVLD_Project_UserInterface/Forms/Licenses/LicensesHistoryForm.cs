using BusinessLayer;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class LicensesHistoryForm : Form
    {
        int _personID;
        int _DriverID;
        public LicensesHistoryForm(int PersonID)
        {
            InitializeComponent();
            _personID=PersonID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowDriverLicenses_Load(object sender, EventArgs e)
        {
            uC_PersonInfoWithFilter1.ShowPersonInfoInCard(_personID);
            uC_PersonInfoWithFilter1.DisableFilter();

            _DriverID = clsDrivers.GetDriverID(_personID);

            if (_DriverID != -1)
                uC_DriverLicenses1.ShowDriverLicenses(_DriverID);
        }

      
    }
}
