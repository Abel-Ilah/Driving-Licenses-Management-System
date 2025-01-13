using DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
namespace BusinessLayer
{
    public class clsLocalDrivingLicenseApplications:clsApplications
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }
         
        private enum enMode { eAddNew = 1, eUpdate = 2 }
        enMode _Mode;

        public clsLocalDrivingLicenseApplications()
        :base()
        {
            LocalDrivingLicenseApplicationID = -1;
            LicenseClassID = -1;
            
            _Mode = enMode.eAddNew;
        }

        private clsLocalDrivingLicenseApplications(int applicationID, int applicantPersonID, int applicationTypeID, DateTime applicationDate, byte applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID,int LocalDrivingLicenseApplicationId,int LicenseClassID)
        :base(applicationID, applicantPersonID, applicationTypeID, applicationDate,applicationStatus, lastStatusDate,paidFees, createdByUserID)
        {
            LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationId;
            this.LicenseClassID = LicenseClassID;
             _Mode = enMode.eUpdate;
        }

        private new bool _AddNew()
        {
          if (base.Save())
                LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationsDataAccessLayer.AddNewLocalDrivingLicenseApplication(ApplicationID, LicenseClassID);

            return LocalDrivingLicenseApplicationID > -1;
        }

        private bool _Update()
        {
            return  base.Save() && clsLocalDrivingLicenseApplicationsDataAccessLayer.UpdateLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, LicenseClassID);
        }
       
        public static new clsLocalDrivingLicenseApplications  Find(int DrivingLicenseApplicationID)
        {
            int applicationId = -1, LicenseClassId = -1;
            
            if (clsLocalDrivingLicenseApplicationsDataAccessLayer.FindLocalDrivingLicenseApplication(DrivingLicenseApplicationID, ref applicationId, ref LicenseClassId))
            {
                clsApplications application = clsApplications.Find(applicationId);
                if (application != null)
                {
                    return new clsLocalDrivingLicenseApplications(application.ApplicationID, application.ApplicantPersonID, application.ApplicationTypeID, application.ApplicationDate, application.ApplicationStatus, application.LastStatusDate, application.PaidFees, application.CreatedByUserID, DrivingLicenseApplicationID, LicenseClassId);
                }
            }
            return null;
        }

        public override bool Save()
        {
            switch (_Mode)
            {
                case enMode.eAddNew:
                    if (_AddNew())
                    {
                        _Mode = enMode.eUpdate;
                        return true;
                    }
                    break;
                case enMode.eUpdate:
                    return _Update();
            }
            return false;
        }

        public static bool IsExist(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccessLayer.IsApplicationExist(LocalDrivingLicenseApplicationID);
        }
        public static int GetActiveLocalDrivingLicenseApplicationID(int ApplicantPersonId,int LicenseClassId)
        {
            return clsLocalDrivingLicenseApplicationsDataAccessLayer.GetActiveOrCompletedLocalDrivingLicenseApplicationID(ApplicantPersonId, LicenseClassId,1);
        }
        public static int GetCompletedLocalDrivingLicenseApplicationID(int ApplicantPersonId, int LicenseClassId)
        {
            return clsLocalDrivingLicenseApplicationsDataAccessLayer.GetActiveOrCompletedLocalDrivingLicenseApplicationID(ApplicantPersonId, LicenseClassId, 3);
        }
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationsDataAccessLayer.GetAllLocalDrivingLicenseApplications();
        }
        
        public static new bool  Delete(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID =Find(LocalDrivingLicenseApplicationID).ApplicationID;
            return clsLocalDrivingLicenseApplicationsDataAccessLayer.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID) && clsApplications.Delete(ApplicationID);
        }
   
        public static byte GetPassedTestsCount(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccessLayer.GetPassedTestsCount(LocalDrivingLicenseApplicationID);
        }

    }
}
