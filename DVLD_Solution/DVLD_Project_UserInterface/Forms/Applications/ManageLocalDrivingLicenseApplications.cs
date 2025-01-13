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
    public partial class ManageLocalDrivingLicenseApplications : Form
    {
        DataTable _LocalDrivingLicenseApplicationsTable;


        public ManageLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }


        private void RefreshApplicationsList()
        {
            _LocalDrivingLicenseApplicationsTable = clsLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications();
            dgvApplications.DataSource = _LocalDrivingLicenseApplicationsTable.DefaultView;
            lbNumberOfApplications.Text = dgvApplications.Rows.Count.ToString();
        }
        private void ManageLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            RefreshApplicationsList();

            dgvApplications.Columns[0].HeaderText = "L.D.L.AppID";
            dgvApplications.Columns[0].Width = 90;

            dgvApplications.Columns[1].HeaderText = "Class Name";
            dgvApplications.Columns[1].Width = 250;

            dgvApplications.Columns[2].HeaderText = "National No";
            dgvApplications.Columns[2].Width = 110;

            dgvApplications.Columns[3].HeaderText = "Full Name";
            dgvApplications.Columns[3].Width = 330;

            dgvApplications.Columns[4].HeaderText = "Application Date";
            dgvApplications.Columns[4].Width = 150;

            dgvApplications.Columns[5].HeaderText = "Passed Tests";
            dgvApplications.Columns[5].Width = 120;

            dgvApplications.Columns[6].HeaderText = "Status";
           
            cmbFilterBy.SelectedIndex= 0;
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterBy.SelectedItem.ToString() == "None")
            {
                _LocalDrivingLicenseApplicationsTable.DefaultView.RowFilter = string.Empty;
                dgvApplications.DataSource = _LocalDrivingLicenseApplicationsTable.DefaultView;
                txtbFilter.Visible = false;
                lbNumberOfApplications.Text = _LocalDrivingLicenseApplicationsTable.DefaultView.Count.ToString();
            }
            else
            {
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
            if (cmbFilterBy.SelectedItem.ToString() == "L.D.L.AppID" )
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; return;
                }
            }
            if (cmbFilterBy.SelectedItem.ToString() == "National No")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
            }
            if (cmbFilterBy.SelectedItem.ToString() == "Status")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true; return;
                }
            }
        }

        private void txtbFilter_TextChanged(object sender, EventArgs e)
        {

            byte ColumnIndex = 0;

            switch (cmbFilterBy.SelectedItem)
            {
                case "L.D.L.AppID":
                    ColumnIndex = 0;
                    break;
                case "National No":
                    ColumnIndex = 2;
                    break;
                case "Full Name":
                    ColumnIndex = 3;
                    break;
                case "Status":
                    ColumnIndex = 6;
                    break;
            }

            _LocalDrivingLicenseApplicationsTable.DefaultView.RowFilter = $"CONVERT({_LocalDrivingLicenseApplicationsTable.Columns[ColumnIndex].ColumnName},'System.String') like'%{txtbFilter.Text}%'";

            dgvApplications.DataSource = _LocalDrivingLicenseApplicationsTable.DefaultView;

          lbNumberOfApplications.Text = _LocalDrivingLicenseApplicationsTable.DefaultView.Count.ToString();
        }

        private void btnAddLocalDrivingLicenseApplication_Click(object sender, EventArgs e)
        {
            AddOrEditLocalDrivingLicenseApplicationsForm frm = new AddOrEditLocalDrivingLicenseApplicationsForm(-1);
            frm.ShowDialog();
            RefreshApplicationsList();
        }

        private void scheDuleTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            AddOrEditLocalDrivingLicenseApplicationsForm frm = new AddOrEditLocalDrivingLicenseApplicationsForm(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            RefreshApplicationsList();
        }

        private void contextMenuStripApplications_Opening(object sender, CancelEventArgs e)
        {
            string SelectedApplicationStatus = dgvApplications.CurrentRow.Cells[6].Value.ToString();
            byte PassedTestsCount = Convert.ToByte(dgvApplications.CurrentRow.Cells[5].Value);

            updateToolStripMenuItem.Enabled = (SelectedApplicationStatus == "New" && PassedTestsCount == 0) ? true : false;

            cancelApplicationToolStripMenuItem.Enabled = (SelectedApplicationStatus == "New") ? true : false;

            scheDuleVisionTestToolStripMenuItem.Enabled = (PassedTestsCount == 0);
            scheduleWrittenTestToolStripMenuItem.Enabled = (PassedTestsCount == 1);
            scheduleStreetTestToolStripMenuItem.Enabled = (PassedTestsCount == 2);

            scheDuleTestsToolStripMenuItem.Enabled = (PassedTestsCount < 3 && SelectedApplicationStatus == "New");

            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled=(PassedTestsCount == 3 && SelectedApplicationStatus=="New");

            showLicenseToolStripMenuItem.Enabled= (PassedTestsCount == 3 && SelectedApplicationStatus == "Completed");

        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you want to Cancel this application ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                clsLocalDrivingLicenseApplications application = clsLocalDrivingLicenseApplications.Find(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value));
                if (application==null)
                {
                    MessageBox.Show("This Application is No longer exist in the system!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                application.ApplicationStatus = 2;
                application.LastStatusDate = DateTime.Now;

                if (application.Save())
                {
                    MessageBox.Show("Application has been canceled successfully.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshApplicationsList();
                }
                else MessageBox.Show("Operation Failed", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you want to Delete this application ?", "Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsLocalDrivingLicenseApplications.Delete(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Application has been Deleted successfully.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshApplicationsList();
                }
                else MessageBox.Show("This Application Can't be deleted because Data linked with it!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void scheDuleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestsAppointmentsForm form =new TestsAppointmentsForm(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value),clsTestTypes.enTestTypes.VisionTest);
            form.ShowDialog();
            RefreshApplicationsList();
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestsAppointmentsForm form = new TestsAppointmentsForm(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value), clsTestTypes.enTestTypes.WrittenTest);
            form.ShowDialog();
            RefreshApplicationsList();
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestsAppointmentsForm form = new TestsAppointmentsForm(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value), clsTestTypes.enTestTypes.DrivingTest);
            form.ShowDialog();
            RefreshApplicationsList();
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueDrivingLicenseForm frm = new IssueDrivingLicenseForm(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            RefreshApplicationsList();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localDrivingLicenseApplicationID= Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value);
            int ApplicationID = clsLocalDrivingLicenseApplications.Find(localDrivingLicenseApplicationID).ApplicationID;
            int LicenseID=clsLicenses.GetLicenseIdByApplicationID(ApplicationID);
            ShowLicenseInfoForm form = new ShowLicenseInfoForm(LicenseID);
            form.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLocalDrivingLicenseApplicationInfoForm frm = new ShowLocalDrivingLicenseApplicationInfoForm(Convert.ToInt32(dgvApplications.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsPeople.GetPersonID(dgvApplications.CurrentRow.Cells[2].Value.ToString());

            LicensesHistoryForm form = new LicensesHistoryForm(PersonID);
            form.ShowDialog();
        }
    }
}
