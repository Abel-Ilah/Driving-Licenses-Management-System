using BusinessLayer;
using System;
using System.Windows.Forms;
using UserInterface.Properties;

namespace UserInterface
{
    public partial class UC_ScheduledTest : UserControl
    {
        int _TestID = -1;
        public int TestID { set { _TestID = value; lbTestID.Text = _TestID.ToString(); } }
        public UC_ScheduledTest()
        {
            InitializeComponent();
        }
        clsTestsAppointments _Appointment;

        private void ResetAppointmentCard()
        {
            lbDrivingLicenseApplicationID.Text = "[???????]";
            lbLicenseClass.Text = "[???????]";
            lbTrialsCount.Text = "[???????]";
            lbFullName.Text = "[???????]";
            lbAppointmentDate.Text = "[???????]";
            lbTestFees.Text = "[???????]";
            lbTestID.Text = "[Not Taken Yet]";
        }
        public void LoadTestAppointmentInfo(int TestAppointmentID)
        {
            _Appointment = clsTestsAppointments.Find(TestAppointmentID);
            if (_Appointment==null)
            {
                ResetAppointmentCard();
                return;
            }

            switch ((clsTestTypes.enTestTypes)_Appointment.TestTypeID)
            {
                case clsTestTypes.enTestTypes.VisionTest:
                    pbTestType.Image = Resources.Vision_512;
                    gbTestAppointment.Text = "Vision Test";
                    break;
                case clsTestTypes.enTestTypes.WrittenTest:
                    pbTestType.Image = Resources.Written_Test_512;
                    gbTestAppointment.Text = "Written Test";
                    break;
                case clsTestTypes.enTestTypes.DrivingTest:
                    pbTestType.Image = Resources.driving_test_512;
                    gbTestAppointment.Text = "Driving Test";
                    break;
            }


            lbDrivingLicenseApplicationID.Text = _Appointment.LocalDrivingLicenseApplicationID.ToString();
            lbLicenseClass.Text = clsLicenseClasses.GetLicenseClassName(clsLocalDrivingLicenseApplications.Find(_Appointment.LocalDrivingLicenseApplicationID).LicenseClassID);
            lbTrialsCount.Text = clsTestsAppointments.GetTestAppointments(_Appointment.LocalDrivingLicenseApplicationID, Convert.ToByte(_Appointment.TestTypeID)).DefaultView.Count.ToString();
            lbFullName.Text = clsPeople.Find(clsLocalDrivingLicenseApplications.Find(_Appointment.LocalDrivingLicenseApplicationID).ApplicantPersonID).FullName;
            lbAppointmentDate.Text=_Appointment.Date.ToShortDateString();
            lbTestFees.Text = _Appointment.PaidFees.ToString();
        }

       
    }
}
