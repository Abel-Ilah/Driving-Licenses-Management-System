using System;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsTests
    {
        private enum enModes { AddNewMode=1,UpdateMode=2}
        enModes _Mode;
        public int TestID { get;private set; }
        public int TestAppointmentID { get; set;}
        public bool Result { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTests()
        { 
            TestID = -1;
            TestAppointmentID = -1;
            Result = false;
            Notes = string.Empty;
            CreatedByUserID = -1;

            _Mode=enModes.AddNewMode;
        }

        private bool _AddNewTest()
        {
         TestID = clsTestsDataAccessLayer.AddNewTest(TestAppointmentID, Result, Notes, CreatedByUserID);
         return TestID != -1;
        }
        private bool _UpdateTest()
        {
            return true;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enModes.AddNewMode:
                    if (_AddNewTest())
                    {
                        _Mode = enModes.UpdateMode;
                        return true;
                    }
                    break;
                case enModes.UpdateMode:
                    return _UpdateTest();
            }
            return false;
        }

        public static bool DidPersonPassTheTest(int LocalDrivingLicenseApplicationID,byte TestTypeID)
        {
            return clsTestsDataAccessLayer.DidPersonPassTheExam(LocalDrivingLicenseApplicationID, TestTypeID);
        }

    }

}
