using BusinessLayer;
using System;
using System.Windows.Forms;


namespace UserInterface
{
    public partial class DetainLicenseForm : Form
    {
        clsDetainLicenses _NewDetain;

        int _LocalLicenseID;
        public DetainLicenseForm()
        {
           InitializeComponent();

            txtbFineFees.ContextMenu = new ContextMenu();
        }

        private void DetainLicenseForm_Load(object sender, EventArgs e)
        {
            lbDetainDate.Text=DateTime.Now.ToShortDateString();
            lbUserName.Text = GlobalSettings.CurrentUser.UserName;
        }

        void ResetDefaultValues()
        {
            btnShowLicenseInfo.Enabled = false;
            btnShowLicensesHistory.Enabled = false;
            btnDetain.Enabled = false;
            lbLicenseID.Text = "[??????]";
            lbDetainID.Text = "[??????]";
            txtbFineFees.Clear();
        }
        private void uC_LocalLicenseCardWithFilter1_WhenLicenseIsFound(int obj)
        {
            ResetDefaultValues();

            if (obj == -1) return;

            _LocalLicenseID = obj;
            lbLicenseID.Text = _LocalLicenseID.ToString();

            btnShowLicensesHistory.Enabled = true;

            if (clsDetainLicenses.IsLicenseDetained(_LocalLicenseID))
            {
                MessageBox.Show($"This License is already Detained!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnDetain.Enabled = true;
        }

        private void btnShowLicensesHistory_Click(object sender, EventArgs e)
        {
            LicensesHistoryForm frm = new LicensesHistoryForm(clsLicenses.GetPersonIdOfLicenseOwner(_LocalLicenseID));
            frm.ShowDialog();
        }

        private void txtbFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || (e.KeyChar == '.' && !((TextBox)sender).Text.Contains(".")) )
            {
                return;
            }
            e.Handled = true;
        }

        private void txtbFineFees_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbFineFees.Text))
            {
                MessageBox.Show("Please enter The fine fees!", "Empty value Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbFineFees.Focus();
                return;
            }

            decimal FineFees = 0;
            if (!decimal.TryParse(txtbFineFees.Text,out FineFees))
            {
              MessageBox.Show("Please enter a valid fees!\n ex[255.50 | 125 ... ]", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              txtbFineFees.Clear();
              txtbFineFees.Focus();
              return;
            }
            if (MessageBox.Show("Are you sure you want to Detain this license?", "Confirm Detain", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                _NewDetain = new clsDetainLicenses();
                _NewDetain.LicensesID = _LocalLicenseID;
                _NewDetain.DetainDate = DateTime.Now;
                _NewDetain.FineFees = FineFees;
                _NewDetain.CreatedUserID = GlobalSettings.CurrentUser.UserID;
                _NewDetain.IsReleased = false;
                if (_NewDetain.Save())
                {
                    lbDetainID.Text = _NewDetain.DetainID.ToString();
                    btnShowLicenseInfo.Enabled = true;
                    btnDetain.Enabled = false;
                    MessageBox.Show("License Detained successfully.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Operation Failed.", "Detain Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnShowLicenseInfo_Click(object sender, EventArgs e)
        {
            ShowLicenseInfoForm form = new ShowLicenseInfoForm(_LocalLicenseID);
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
