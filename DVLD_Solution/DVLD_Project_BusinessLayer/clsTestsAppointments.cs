using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsTestsAppointments
    {
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime Date {  get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }


        enum enMode { AddNew=1,Update=3}
        enMode _Mode;

        public clsTestsAppointments() 
        {
            TestAppointmentID = -1;
            TestTypeID= -1;
            LocalDrivingLicenseApplicationID = -1;
            Date = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;
            IsLocked = false;

            _Mode=enMode.AddNew;
        }
        private clsTestsAppointments(int testAppointmentID, int testTypeID, int localDrivingLicenseApplicationID, DateTime date, decimal paidFees, int createdByUserID, bool isLocked)
        {
            TestAppointmentID = testAppointmentID;
            TestTypeID = testTypeID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            Date = date;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            IsLocked = isLocked;

            _Mode = enMode.Update;
        }

        bool _AddNew()
        {
            TestAppointmentID = clsTestsAppointmentsDataAccessLayer.AddNewTestAppointment(TestTypeID, LocalDrivingLicenseApplicationID, Date, PaidFees, CreatedByUserID, IsLocked);
            return TestAppointmentID != -1;
        }
        bool _Update()
        {
            return clsTestsAppointmentsDataAccessLayer.UpdateTestAppointment(TestAppointmentID, Date, IsLocked);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNew())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public static clsTestsAppointments Find(int testAppointmentID)
        {
            int testTypeId = -1, localDrivingLicenseAppId = -1, createdByUserId = -1;
            DateTime date = DateTime.Now;
            decimal paidFees = 0;
            bool isLocked = false;

            if (clsTestsAppointmentsDataAccessLayer.FindTestAppointment(testAppointmentID, ref testTypeId, ref localDrivingLicenseAppId,ref date,ref paidFees, ref createdByUserId, ref isLocked))
            {
                return new clsTestsAppointments(testAppointmentID,testTypeId,localDrivingLicenseAppId,date, paidFees, createdByUserId,isLocked);
            }
            return null;
        }

        public static DataTable GetTestAppointments(int LocalDrivingLicenseApplicationID,byte TestTypeId) 
       {
            return clsTestsAppointmentsDataAccessLayer.GetTestAppointments(LocalDrivingLicenseApplicationID,TestTypeId);
       }

    }
}
