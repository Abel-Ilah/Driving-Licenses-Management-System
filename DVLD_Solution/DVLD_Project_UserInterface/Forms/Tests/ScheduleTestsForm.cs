using BusinessLayer;
using System;
using System.Windows.Forms;
using UserInterface.Properties;

namespace DataAccessLayer
{
    public partial class ScheduleTestsForm : Form
    {
        private clsTestTypes.enTestTypes _TestType = clsTestTypes.enTestTypes.VisionTest;

        int _LocalDrivingLicenseApplicationID=-1;
        int _TestAppointmentID = -1;
        public ScheduleTestsForm(int LocalDrivingLicenseApplicationId, clsTestTypes.enTestTypes TestType,int TestAppointmentID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID= LocalDrivingLicenseApplicationId;
            _TestType = TestType;
            _TestAppointmentID= TestAppointmentID;
        }
        private void ScheduleTestsForm_Load(object sender, EventArgs e)
        {
            uC_AddOrEditTestAppointment1.TestType= _TestType;
            uC_AddOrEditTestAppointment1.ShowAppointmentInfo(_LocalDrivingLicenseApplicationID, _TestAppointmentID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uC_AddOrEditTestAppointment1_WhenAppointmentSaved(bool obj)
        {
            bool IsAppointmentSaved = obj;
            if (IsAppointmentSaved)
            {
                MessageBox.Show("Data Saved successfully.","Result",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show("Operation Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
