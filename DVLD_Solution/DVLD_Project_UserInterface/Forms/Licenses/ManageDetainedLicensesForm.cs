using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class ManageDetainedLicensesForm : Form
    {
        DataTable _DetainedLicenses;
        public ManageDetainedLicensesForm()
        {
            InitializeComponent();
            txtbFilter.ContextMenu=new ContextMenu();
        }

        void FilterDataGridView(string filter)
        {
            _DetainedLicenses.DefaultView.RowFilter = filter;
            dgvDetainedLicenses.DataSource = _DetainedLicenses.DefaultView;
            lbRecordsCount.Text = dgvDetainedLicenses.Rows.Count.ToString();
        }

        void InitializeDataGridView()
        {
            if (dgvDetainedLicenses.Columns.Count==8)
            {
                dgvDetainedLicenses.Columns[0].HeaderText = "Detain ID";
                dgvDetainedLicenses.Columns[1].HeaderText = "License ID";
                dgvDetainedLicenses.Columns[2].HeaderText = "Detain Date";
                dgvDetainedLicenses.Columns[3].HeaderText = "Is Released";
                dgvDetainedLicenses.Columns[4].HeaderText = "Release Date";
                dgvDetainedLicenses.Columns[5].HeaderText = "Fine Fees";
                dgvDetainedLicenses.Columns[6].HeaderText = "National No";
                dgvDetainedLicenses.Columns[7].HeaderText = "Full Name";

                dgvDetainedLicenses.Columns[0].Width = 100;
                dgvDetainedLicenses.Columns[1].Width = 110;
                dgvDetainedLicenses.Columns[3].Width = 100;
                dgvDetainedLicenses.Columns[5].Width = 100;
                dgvDetainedLicenses.Columns[6].Width = 130;
            }
        }
        private void ManageDetainedLicensesForm_Load(object sender, EventArgs e)
        {
            _DetainedLicenses=clsDetainLicenses.GetAllDetainOperations();

            FilterDataGridView("");

            InitializeDataGridView();

            cmbFilterBy.SelectedIndex = 0;
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDataGridView("");

            if (cmbFilterBy.SelectedItem.ToString() == "None")
            {
                txtbFilter.Visible = false;
                cmbIsReleased.Visible = false;
            }

            else
            {
                if (cmbFilterBy.SelectedItem.ToString() == "IsReleased")
                {
                    txtbFilter.Visible = false;
                    cmbIsReleased.Visible = true;
                    cmbIsReleased.SelectedItem = "All";
                    return;
                }
                cmbIsReleased.Visible = false;
                txtbFilter.Visible = true;

                txtbFilter.Clear();
                txtbFilter.Focus();
            }
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
            if (cmbFilterBy.SelectedItem.ToString()=="DetainID" || cmbFilterBy.SelectedItem.ToString() == "LicenseID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; return;
                }
            }
            if (cmbFilterBy.SelectedItem.ToString() == "NationalNo")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar!='-')
                {
                    e.Handled = true; return;
                }
            }
        }

        private void cmbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Filter = "";
            switch (cmbIsReleased.SelectedItem)
            {
                case "Detained":
                    Filter = "IsReleased=false";
                    break;
                case "Released":
                    Filter = "IsReleased=true";
                    break;
            }
            FilterDataGridView(Filter);
        }

        private void txtbFilter_TextChanged(object sender, EventArgs e)
        {
            string Filter = Filter = $"CONVERT({cmbFilterBy.SelectedItem},'System.String') like'%{txtbFilter.Text}%'"; ;
           
            FilterDataGridView(Filter);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            ReleaseLicenseForm frm = new ReleaseLicenseForm();
            frm.ShowDialog();

            _DetainedLicenses = clsDetainLicenses.GetAllDetainOperations();
            FilterDataGridView("");
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            DetainLicenseForm frm = new DetainLicenseForm();
            frm.ShowDialog();

            _DetainedLicenses = clsDetainLicenses.GetAllDetainOperations();
            FilterDataGridView("");
        }

        private void contextMenuStripDetainedLicenses_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            contextMenuStripDetainedLicenses.Enabled = (dgvDetainedLicenses.Rows.Count > 0);
            bool IsReleased = Convert.ToBoolean(dgvDetainedLicenses.CurrentRow.Cells[3].Value);
            contextMenuStripDetainedLicenses.Items[4].Enabled = (!IsReleased);
        }

        private void showPersonDetaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsPeople.GetPersonID(dgvDetainedLicenses.CurrentRow.Cells[6].Value.ToString());
            PersonInfoForm frm = new PersonInfoForm(PersonID);
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicenseInfoForm frm = new ShowLicenseInfoForm(Convert.ToInt32(dgvDetainedLicenses.CurrentRow.Cells[1].Value));
            frm.ShowDialog();
        }

        private void sToolStripMenuItemLicenseHistory_Click(object sender, EventArgs e)
        {
            int PersonID = clsPeople.GetPersonID(dgvDetainedLicenses.CurrentRow.Cells[6].Value.ToString());
            LicensesHistoryForm form = new LicensesHistoryForm(PersonID);
            form.ShowDialog();
        }

        private void ReleaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseLicenseForm form = new ReleaseLicenseForm(Convert.ToInt32(dgvDetainedLicenses.CurrentRow.Cells[1].Value));
            form.ShowDialog();
            _DetainedLicenses = clsDetainLicenses.GetAllDetainOperations();
            FilterDataGridView("");
        }
    }
}
