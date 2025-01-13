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
    public partial class ManageDriversForm : Form
    {
        DataTable _DriversTable;

        public ManageDriversForm()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManageDriversForm_Load(object sender, EventArgs e)
        {
            _DriversTable = clsDrivers.GetAllDrivers();
            dgvDrivers.DataSource = _DriversTable.DefaultView;
            lbDriversCount.Text=dgvDrivers.Rows.Count.ToString();

            if (dgvDrivers.ColumnCount==6)
            {
                dgvDrivers.Columns[0].HeaderText = "Driver ID";
                dgvDrivers.Columns[0].Width = 100;

                dgvDrivers.Columns[1].HeaderText = "Person ID";
                dgvDrivers.Columns[1].Width = 100;

                dgvDrivers.Columns[2].HeaderText = "National No";
                dgvDrivers.Columns[2].Width = 120;

                dgvDrivers.Columns[3].HeaderText = "Full Name";
                dgvDrivers.Columns[3].Width = 350;

                dgvDrivers.Columns[4].HeaderText = "Date";
                
                dgvDrivers.Columns[5].HeaderText = "Active Licenses";
            }

            cmbFilterBy.SelectedIndex = 0;
        }

        private void txtbFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (cmbFilterBy.SelectedItem.ToString() == "PersonID" || cmbFilterBy.SelectedItem.ToString() == "DriverID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; return;
                }
            }
            if (cmbFilterBy.SelectedItem.ToString() == "FullName")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-')
                {
                    e.Handled = true; return;
                }
            }
            if (cmbFilterBy.SelectedItem.ToString() == "NationalNo")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-')
                {
                    e.Handled = true; return;
                }
            }
        }

        private void txtbFilter_TextChanged(object sender, EventArgs e)
        {
            _DriversTable.DefaultView.RowFilter = $"CONVERT({cmbFilterBy.SelectedItem},'System.String') like'%{txtbFilter.Text}%'";
            dgvDrivers.DataSource = _DriversTable.DefaultView;
            lbDriversCount.Text = dgvDrivers.Rows.Count.ToString();
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbFilterBy.SelectedItem.ToString() == "None")
            {
                _DriversTable.DefaultView.RowFilter =string.Empty;
                dgvDrivers.DataSource = _DriversTable.DefaultView;
                lbDriversCount.Text = dgvDrivers.Rows.Count.ToString();
                txtbFilter.Visible = false;
            }
            else
            {
                txtbFilter.Visible = true;
                txtbFilter.Clear();
                txtbFilter.Focus();
            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicensesHistoryForm form = new LicensesHistoryForm(Convert.ToInt32(dgvDrivers.CurrentRow.Cells[1].Value));
            form.ShowDialog();
        }

        private void contextMenuStripDrivers_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStripDrivers.Enabled = (dgvDrivers.Rows.Count > 0);
        }


    }
}
