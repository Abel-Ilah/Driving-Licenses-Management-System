using BusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using UserInterface;

namespace DataAccessLayer
{
    public partial class UC_DriverLicenses : UserControl
    {
        DataTable _LocalLicenses;
        DataTable _InternationalLicenses;

        public UC_DriverLicenses()
        {
            InitializeComponent();
        }



        void LoadLocalLicensesToDataGridView(int DriverID)
        {
            _LocalLicenses = clsLicenses.GetLocalLicenses(DriverID);
           
            dgvlocalDriverLicenses.DataSource = _LocalLicenses.DefaultView;
           
            lbLocalLicensesCount.Text=dgvlocalDriverLicenses.Rows.Count.ToString();
            if (dgvlocalDriverLicenses.ColumnCount == 6)
            {
                dgvlocalDriverLicenses.Columns[0].HeaderText = "License ID";
                dgvlocalDriverLicenses.Columns[0].Width = 100;

                dgvlocalDriverLicenses.Columns[1].HeaderText = "Application ID";
                dgvlocalDriverLicenses.Columns[1].Width = 125;

                dgvlocalDriverLicenses.Columns[2].HeaderText = "License Class Name";
                dgvlocalDriverLicenses.Columns[2].Width = 250;

                dgvlocalDriverLicenses.Columns[3].HeaderText = "Issue Date";
                dgvlocalDriverLicenses.Columns[4].HeaderText = "Expiration Date";

                dgvlocalDriverLicenses.Columns[5].HeaderText = "Is Active";
                dgvlocalDriverLicenses.Columns[5].Width = 80;
            }

        }

        void LoadInternationalLicensesToDataGridView(int DriverID)
        {
            _InternationalLicenses = clsInternationalLicenses.GetDriverInternationalLicenses(DriverID);

            dgvInternationalDriverLicenses.DataSource = _InternationalLicenses.DefaultView;

            lbInternationalLicensesCount.Text = dgvInternationalDriverLicenses.Rows.Count.ToString();

            if (dgvInternationalDriverLicenses.ColumnCount == 6)
            {
                dgvInternationalDriverLicenses.Columns[0].HeaderText = "I.License ID";
                dgvInternationalDriverLicenses.Columns[1].HeaderText = "Application ID";
                dgvInternationalDriverLicenses.Columns[2].HeaderText = "L.License ID";
                dgvInternationalDriverLicenses.Columns[3].HeaderText = "Issue Date";
                dgvInternationalDriverLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvInternationalDriverLicenses.Columns[5].HeaderText = "Is Active";
               
            }
        }

        public void ShowDriverLicenses(int DriverID)
        {
            LoadLocalLicensesToDataGridView(DriverID);
            LoadInternationalLicensesToDataGridView(DriverID);
        }
      
        private void contextMenuStripLocalDriverLicenses_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStripLocalDriverLicenses.Enabled = (dgvlocalDriverLicenses.Rows.Count > 0);
        }

        private void contextMenuStripInternationalDriverLicenses_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStripInternationalDriverLicenses.Enabled = (dgvInternationalDriverLicenses.Rows.Count > 0);
        }


        private void showLocalLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicenseInfoForm frm = new ShowLicenseInfoForm(Convert.ToInt32(dgvlocalDriverLicenses.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void showInternationalLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInternationalLicenseInfoForm frm = new ShowInternationalLicenseInfoForm(Convert.ToInt32(dgvInternationalDriverLicenses.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }
    }
}
