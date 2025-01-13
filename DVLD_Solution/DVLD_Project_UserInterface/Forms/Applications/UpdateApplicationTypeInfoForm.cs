using BusinessLayer;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class UpdateApplicationTypeInfoForm : Form
    {
        int _ApplicationTypeID;
        clsApplicationTypes _ApplicationType;

        public UpdateApplicationTypeInfoForm(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID= ApplicationTypeID;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar!='.')
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbTitle.Text)|| string.IsNullOrEmpty(txtbFees.Text))
            {
                btnSave.Enabled = false;
                return;
            }
            btnSave.Enabled = true;
        }

        private void UpdateApplicationTypeInfoForm_Load(object sender, EventArgs e)
        {
            txtbTitle.Focus();

            _ApplicationType = clsApplicationTypes.Find(_ApplicationTypeID);
            if (_ApplicationType==null)
            {
                MessageBox.Show("This Application Type no longer exists in the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            lbID.Text = _ApplicationType.ID.ToString();
            txtbTitle.Text = _ApplicationType.ApplicationTypeTitle;
            txtbFees.Text = _ApplicationType.ApplicationFees.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtbFees.Text.Trim()==_ApplicationType.ApplicationFees.ToString().Trim()&& txtbTitle.Text.Trim()==_ApplicationType.ApplicationTypeTitle.Trim())
                return;
            

            if (!decimal.TryParse(txtbFees.Text,out decimal result))
            {
                MessageBox.Show("Please enter a valid Fees\n Ex:{15.50 || 25.75 || 10.00}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtbFees.Clear();
                txtbFees.Focus();
                return;
            }
            _ApplicationType.ApplicationTypeTitle = txtbTitle.Text.Trim();
            _ApplicationType.ApplicationFees = Convert.ToDecimal(txtbFees.Text.Trim());
            if (_ApplicationType.Update())
            {
                MessageBox.Show("Application Type has been updated successfully.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else MessageBox.Show("Operation Failed", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }

     
    }
}
