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
    public partial class ManageInternationalLicensesApplicationsForm : Form
    {
        DataTable _InternationalLicenses;
        public ManageInternationalLicensesApplicationsForm()
        {
            InitializeComponent();
        }

        void RefreshDataGridView()
        {
            _InternationalLicenses = clsInternationalLicenses.GetAllInternationalLicenses();

            dgvInternationalLicenses.DataSource = _InternationalLicenses.DefaultView;

            lbInternationalLicensesCount.Text = dgvInternationalLicenses.Rows.Count.ToString();
        }
        void LoadAllInternationalLicensesToDataGridView()
        {
            RefreshDataGridView();

            if (dgvInternationalLicenses.ColumnCount == 7)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "I.License ID";
                dgvInternationalLicenses.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicenses.Columns[2].HeaderText = "Driver ID";
                dgvInternationalLicenses.Columns[3].HeaderText = "L.License ID";
                dgvInternationalLicenses.Columns[4].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[5].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[6].HeaderText = "Is Active";
            }
        }
        private void ManageInternationalLicensesApplicationsForm_Load(object sender, EventArgs e)
        {
            LoadAllInternationalLicensesToDataGridView();
            cmbFilterBy.SelectedIndex = 0;
        }

        private void FilterDataGridView(string Filter)
        {
             _InternationalLicenses.DefaultView.RowFilter = Filter;
              dgvInternationalLicenses.DataSource = _InternationalLicenses.DefaultView;
            lbInternationalLicensesCount.Text = dgvInternationalLicenses.Rows.Count.ToString();

        }
        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDataGridView("");

            if (cmbFilterBy.SelectedItem.ToString() == "None")
            {
                txtbFilter.Visible = false;
                cmbStatusFilter.Visible = false;
            }

            else
            {
                if (cmbFilterBy.SelectedItem.ToString() == "Status")
                {
                    txtbFilter.Visible = false;

                    cmbStatusFilter.Visible = true;
                    cmbStatusFilter.SelectedItem = "All";
                    return;
                }
                cmbStatusFilter.Visible = false;
                txtbFilter.Visible = true;

                txtbFilter.Clear();
                txtbFilter.Focus();
            }
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Filter = "";
            switch (cmbStatusFilter.SelectedItem.ToString())
            {
                case "All":
                    Filter = "";
                    break;
                case "Active":
                    Filter = "IsActive=true";
                    break;
                case "Inactive":
                    Filter = "IsActive=false";
                    break;
            }
            FilterDataGridView(Filter);
        }

        private void txtbFilter_TextChanged(object sender, EventArgs e)
        {
            string Filter = string.Empty;

            switch (cmbFilterBy.SelectedItem.ToString())
            {
                case "I.License ID":
                    Filter = $"CONVERT({dgvInternationalLicenses.Columns[0].Name},'System.String') like'%{txtbFilter.Text}%'";
                    break;
                case "Application ID":
                    Filter = $"CONVERT({dgvInternationalLicenses.Columns[1].Name},'System.String') like'%{txtbFilter.Text}%'";
                    break;
                case "Driver ID":
                    Filter = $"CONVERT({dgvInternationalLicenses.Columns[2].Name},'System.String') like'%{txtbFilter.Text}%'";
                    break;
                case "L.License ID":
                    Filter = $"CONVERT({dgvInternationalLicenses.Columns[3].Name},'System.String') like'%{txtbFilter.Text}%'";
                    break;
            }
            FilterDataGridView(Filter);
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; return;
            }
        }

        private void btnAddNewInternationalLicense_Click(object sender, EventArgs e)
        {
            IssueInternationalLicenseForm form = new IssueInternationalLicenseForm();
            form.ShowDialog();
            RefreshDataGridView();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contextMenuStripInternationalLicenses_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStripInternationalLicenses.Enabled=(dgvInternationalLicenses.Rows.Count>0);
        }

        private void showInternationalLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInternationalLicenseInfoForm form = new ShowInternationalLicenseInfoForm(Convert.ToInt32(dgvInternationalLicenses.CurrentRow.Cells[0].Value));
            form.ShowDialog();
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonInfoForm form = new PersonInfoForm(clsLicenses.GetPersonIdOfLicenseOwner(Convert.ToInt32(dgvInternationalLicenses.CurrentRow.Cells[3].Value)));
            form.ShowDialog();
        }
        private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicensesHistoryForm form = new LicensesHistoryForm(clsLicenses.GetPersonIdOfLicenseOwner(Convert.ToInt32(dgvInternationalLicenses.CurrentRow.Cells[3].Value)));
            form.ShowDialog();
        }
    }

}
