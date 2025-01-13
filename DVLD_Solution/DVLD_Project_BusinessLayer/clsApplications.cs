using System;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsApplications
    {
        public int ApplicationID { get; protected set; }
        public int ApplicantPersonID { get; set; }
        public int ApplicationTypeID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public byte ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public Decimal PaidFees { get; set; }
        public int CreatedByUserID { get;  set; }

        private enum enMode { eAddNew = 1, eUpdate = 2 }

        enMode _Mode;


        public clsApplications()
        {
            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicationTypeID = -1;
            ApplicationDate=DateTime.Now;
            ApplicationStatus = 0;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;

            _Mode = enMode.eAddNew;
        }

        protected clsApplications(int applicationID, int applicantPersonID, int applicationTypeID, DateTime applicationDate, byte applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID)
        {
            ApplicationID = applicationID;
            ApplicantPersonID = applicantPersonID;
            ApplicationTypeID = applicationTypeID;
            ApplicationDate = applicationDate;
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;

            _Mode = enMode.eUpdate;
        }
   
       public static clsApplications Find(int ApplicationID)
        {
            int ApplicantPersonID = -1, ApplicationTypeID = -1, CreatedByUserID = -1;
            decimal PaidFees = 0;
            DateTime ApplicationDate = DateTime.Now, lastStatusDate = DateTime.Now;
            byte ApplicationStatus = 0;

            if (clsApplicationsDataAccessLayer.FindApplicationByApplicationID(ApplicationID,ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref lastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new clsApplications(ApplicationID,ApplicantPersonID,ApplicationTypeID,ApplicationDate,ApplicationStatus,lastStatusDate,PaidFees,CreatedByUserID);
            }
            return null;
        }
       
        protected bool _AddNew()
        {
            ApplicationID = clsApplicationsDataAccessLayer.AddNewApplication(ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);

            return ApplicationID != -1;
        }

        private bool _Update() 
        {
            return clsApplicationsDataAccessLayer.UpdateApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
        }

        public virtual bool Save()
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

       
        public static bool Delete(int  ApplicationID)
        {
            return clsApplicationsDataAccessLayer.DeleteApplication(ApplicationID);
        }
    
    }
}
