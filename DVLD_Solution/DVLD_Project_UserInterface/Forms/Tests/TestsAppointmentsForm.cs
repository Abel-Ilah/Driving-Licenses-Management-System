using BusinessLayer;
using DataAccessLayer;
using System;
using System.Data;
using System.Windows.Forms;
using UserInterface.Properties;

namespace UserInterface
{
    public partial class TestsAppointmentsForm : Form
    {
        private clsTestTypes.enTestTypes _TestType = clsTestTypes.enTestTypes.VisionTest;

        int _LocalDrivingLicenseApplicationID;

        DataTable TestAppointmentsTable;
      
       
        public TestsAppointmentsForm(int LocalDrivingLicenseApplicationID,clsTestTypes.enTestTypes TestType)
        {
            InitializeComponent();
          _TestType= TestType;
          _LocalDrivingLicenseApplicationID =LocalDrivingLicenseApplicationID;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefreshAppointmentsDataGridView()
        {
            TestAppointmentsTable = clsTestsAppointments.GetTestAppointments(_LocalDrivingLicenseApplicationID, (byte)_TestType);
            dgvTestAppointments.DataSource = TestAppointmentsTable.DefaultView;
            lbNumberOfAppointments.Text = dgvTestAppointments.RowCount.ToString();
        }
        private bool DoesPersonHaveActiveAppointment()
        {
            if (TestAppointmentsTable.Rows.Count == 0) return false;

            foreach (DataRow row in TestAppointmentsTable.Rows)
            {
                if (Convert.ToBoolean(row[3]) ==false)
                {
                    return true;
                }
            }
            return false;
        }
        private void TestsAppointmentsForm_Load(object sender, EventArgs e)
        {
           
            if (!clsLocalDrivingLicenseApplications.IsExist(_LocalDrivingLicenseApplicationID))
            {
                MessageBox.Show("this Application Is no longer exists in the system!", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                return;
            }
            uC_LocalDrivingLicenseApplicationCard.ShowLocalDrivingLicenseApplicationInfo(_LocalDrivingLicenseApplicationID);

            switch (_TestType)
            {
                case clsTestTypes.enTestTypes.VisionTest:
                    pbTestType.Image = Resources.Vision_512;
                    lbTestType.Text = "Vision Test Appointment";
                    break;
                case clsTestTypes.enTestTypes.WrittenTest:
                    pbTestType.Image = Resources.Written_Test_512;
                    lbTestType.Text = "Written Test Appointment";
                    break;
                case clsTestTypes.enTestTypes.DrivingTest:
                    pbTestType.Image = Resources.driving_test_512;
                    lbTestType.Text = "Driving Test Appointment";
                    break;
            }
            RefreshAppointmentsDataGridView();


        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (dgvTestAppointments.Rows.Count>0 && DoesPersonHaveActiveAppointment())
            {
                MessageBox.Show("You can't add new appointment because \n this Person already have an active appointment for this test!", "Active Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsTests.DidPersonPassTheTest(_LocalDrivingLicenseApplicationID,Convert.ToByte(_TestType)))
            {
                MessageBox.Show("The Person already Passed this Test!", "Exam Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                ScheduleTestsForm form = new ScheduleTestsForm(_LocalDrivingLicenseApplicationID,_TestType,-1);
                form.ShowDialog();
                RefreshAppointmentsDataGridView();
        }

        private void contextMenuStripAppointments_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dgvTestAppointments.Rows.Count == 0) return;
           
            bool IsLocked = Convert.ToBoolean(dgvTestAppointments.CurrentRow.Cells[3].Value);

            EditAppointmentToolStripMenuItem.Enabled= !IsLocked;
            TakeTestToolStripMenuItem.Enabled = !IsLocked;
        }

        private void EditAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleTestsForm form = new ScheduleTestsForm(_LocalDrivingLicenseApplicationID, _TestType,Convert.ToInt32(dgvTestAppointments.CurrentRow.Cells[0].Value));
            form.ShowDialog();
            RefreshAppointmentsDataGridView();
        }

        private void TakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakeTestForm frm = new TakeTestForm(Convert.ToInt32(dgvTestAppointments.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            RefreshAppointmentsDataGridView();
            uC_LocalDrivingLicenseApplicationCard.UpdatePassedTests();

        }
    }
}
