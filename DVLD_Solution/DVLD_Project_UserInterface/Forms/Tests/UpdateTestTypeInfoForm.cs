using BusinessLayer;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class UpdateTestTypeInfoForm : Form
    {
        byte _TestTypeID;
        clsTestTypes _TestType;
        public UpdateTestTypeInfoForm(byte TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
        }

        private void UpdateTestTypeInfoForm_Load(object sender, EventArgs e)
        {

            _TestType = clsTestTypes.Find(_TestTypeID);
            if (_TestType == null)
            {
                MessageBox.Show("This Test Type no longer exists in the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            lbID.Text = _TestType.ID.ToString();
            txtbTitle.Text = _TestType.Title;
            txtbDescription.Text = _TestType.Description;
            txtbFees.Text = _TestType.Fees.ToString();

        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbTitle.Text) || string.IsNullOrEmpty(txtbDescription.Text) || string.IsNullOrEmpty(txtbFees.Text))
            {
                btnSave.Enabled = false;
                return;
            }
            btnSave.Enabled = true;
        }

        private void txtbFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtbFees_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtbFees.Text.Trim() == _TestType.Fees.ToString().Trim() && txtbTitle.Text.Trim() == _TestType.Title.Trim() && txtbDescription.Text.Trim() == _TestType.Description.Trim())
                return;


            if (!decimal.TryParse(txtbFees.Text, out decimal result))
            {
                MessageBox.Show("Please enter a valid Fees\n Ex:{15.50 || 25.75 || 10.00}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtbFees.Clear();
                txtbFees.Focus();
                return;
            }
            _TestType.Title = txtbTitle.Text.Trim();
            _TestType.Description =txtbDescription.Text.Trim();
            _TestType.Fees = Convert.ToDecimal(txtbFees.Text.Trim());
            if (_TestType.Update())
            {
                MessageBox.Show("Test Type has been updated successfully.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else MessageBox.Show("Operation Failed", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
