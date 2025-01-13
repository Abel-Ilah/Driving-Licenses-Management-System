using BusinessLayer;
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
    public partial class UC_LocalLicenseCardWithFilter : UserControl
    {
        public event Action<int> WhenLicenseIsFound;
        protected virtual void LicenseIsFound(int licenseID)
        {
            Action<int> handler = WhenLicenseIsFound;
            if (handler != null)
            {
                handler(licenseID);
            }
        }


        private bool _EnableFilter;
        public bool EnableFilter
        {
            get { return _EnableFilter; }
            set
            {
                _EnableFilter = value;
                gbFilter.Enabled = _EnableFilter;
            }
        }

        public UC_LocalLicenseCardWithFilter()
        {
            InitializeComponent();
            txtbFind.ContextMenu= new ContextMenu();
        }

        public void QuickFind(int licenseID)
        {
            txtbFind.Text= licenseID.ToString();
            ExecuteFilter();
        }

        private void txtbFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtbFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; return;
            }
        }

        void ExecuteFilter()
        {
            if (string.IsNullOrEmpty(txtbFind.Text)) return;

            int LicenseID = Convert.ToInt32(txtbFind.Text);
            uC_LicenseCard1.ResetLicenseCard();
            if (!clsLicenses.IsLicenseExist(LicenseID))
            {
                MessageBox.Show($"There is no License with the entered ID=[{LicenseID}].", "License Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LicenseIsFound(-1);
                return;
            }
            uC_LicenseCard1.ShowLicenseInfo(LicenseID);
            LicenseIsFound(LicenseID);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            ExecuteFilter();
        }

    }

}
