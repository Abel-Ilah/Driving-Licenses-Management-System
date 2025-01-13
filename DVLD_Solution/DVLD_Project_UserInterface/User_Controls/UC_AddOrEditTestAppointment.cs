using BusinessLayer;
using System;
using System.Windows.Forms;
using UserInterface.Properties;

namespace UserInterface
{
    public partial class UC_AddOrEditTestAppointment : UserControl
    {
        public event Action<bool> WhenAppointmentSaved;

        protected virtual void ISAppointmentSaved(bool IsAppointmentSaved)
        {
            Action<bool> handler = WhenAppointmentSaved;
            if (handler != null)
            {
                handler(IsAppointmentSaved);
            }
        }


        private clsTestTypes.enTestTypes _TestType = clsTestTypes.enTestTypes.VisionTest;
        public  clsTestTypes.enTestTypes TestType
        {
            get { return _TestType; } 

            set 
            { 
                _TestType = value;
                ShowDesignBasedOnTestType();
            }
        }

        private enum enModes { AddNewMode=1, UpdateMode=2}
        private enModes _Mode;

        int _Trial = 0;

        const decimal _RetakeTestFees = 5;

        clsTestsAppointments Appointment;

        public UC_AddOrEditTestAppointment()
        {
            InitializeComponent();
            calendarAppointmentDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
        }
       
        private void ShowDesignBasedOnTestType()
        {
            switch (_TestType)
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
        }

        private void CheckIfRetakeTest()
        {
            if ((_Mode == enModes.AddNewMode && _Trial > 0)|| _Mode == enModes.UpdateMode && _Trial > 1)
            {
                lbTitle.Text = "Schedule Retake Test";
                gbRetakeTest.Enabled = true;
                lbRetakeTestFees.Text = _RetakeTestFees.ToString();
                lbTotalFees.Text = $"{Appointment.PaidFees + _RetakeTestFees}";

                if (_Mode == enModes.UpdateMode && _Trial > 1)
                    lbRetakeTestAppointmentID.Text = Appointment.TestAppointmentID.ToString();
            }
            else
            {
                lbRetakeTestFees.Text = "0";
                lbTotalFees.Text = $"{Appointment.PaidFees}";
            }
        }
        public void ShowAppointmentInfo(int LocalDrivingLicenseApplicationId,int TestAppointmentId)
        {
            _Mode = (TestAppointmentId == -1) ? enModes.AddNewMode : enModes.UpdateMode;

            switch (_Mode)
            {
                case enModes.AddNewMode:
                    Appointment = new clsTestsAppointments();
                    Appointment.TestTypeID = (int)TestType;
                    Appointment.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationId;
                    Appointment.PaidFees = clsTestTypes.Find((byte)Appointment.TestTypeID).Fees;

                    calendarAppointmentDate.MinDate = DateTime.Now;
                    break;
                case enModes.UpdateMode:
                    Appointment = clsTestsAppointments.Find(TestAppointmentId);
                    if (Appointment == null)
                    {
                        MessageBox.Show("Appointment not Found!", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    calendarAppointmentDate.Value = Appointment.Date;
                    break;
            }
          
            lbDrivingLicenseApplicationID.Text = Appointment.LocalDrivingLicenseApplicationID.ToString();
            lbLicenseClass.Text = clsLicenseClasses.GetLicenseClassName(clsLocalDrivingLicenseApplications.Find(Appointment.LocalDrivingLicenseApplicationID).LicenseClassID);

            _Trial = clsTestsAppointments.GetTestAppointments(Appointment.LocalDrivingLicenseApplicationID, Convert.ToByte(Appointment.TestTypeID)).DefaultView.Count;
            lbTrialsCount.Text = _Trial.ToString();

            lbFullName.Text = clsPeople.Find(clsLocalDrivingLicenseApplications.Find(Appointment.LocalDrivingLicenseApplicationID).ApplicantPersonID).FullName;

            lbTestFees.Text = Appointment.PaidFees.ToString();

            CheckIfRetakeTest();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            switch (_Mode)
            {
                case enModes.AddNewMode:
                    Appointment.CreatedByUserID = GlobalSettings.CurrentUser.UserID;
                    Appointment.IsLocked = false;
                    break;
                case enModes.UpdateMode:
                    if (Appointment.Date == calendarAppointmentDate.Value) return;
                    if (calendarAppointmentDate.Value < DateTime.Now)
                    {
                        MessageBox.Show("Please choose a valid date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        calendarAppointmentDate.Focus();
                        return;
                    }
                    break;
            }
            Appointment.Date = calendarAppointmentDate.Value;

            if (Appointment.Save()) 
            {
                if (_Mode==enModes.AddNewMode && _Trial > 0) lbRetakeTestAppointmentID.Text = Appointment.TestAppointmentID.ToString();
                
                ISAppointmentSaved(true); 
            }
            else ISAppointmentSaved(false);

        }
    }
}
