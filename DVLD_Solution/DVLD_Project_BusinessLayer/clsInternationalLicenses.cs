using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsInternationalLicenses
    {
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }


        private enum enMode { eAddNew = 1, eUpdate = 2 }

        enMode _Mode;

        public clsInternationalLicenses()
        {

            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LocalLicenseID = -1;
            CreatedByUserID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            IsActive = false;

            _Mode = enMode.eAddNew;
        }

        private clsInternationalLicenses(int internationalLicenseId, int applicationId, int driverId, int localLicenseId, DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserId)
        {
            InternationalLicenseID = internationalLicenseId;
            ApplicationID = applicationId;
            DriverID = driverId;
            LocalLicenseID = localLicenseId;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            CreatedByUserID = createdByUserId;

            _Mode = enMode.eUpdate;
        }


        private bool _AddNew()
        {
            InternationalLicenseID = clsInternationalLicensesDataAccessLayer.AddNewInternationalLicense(ApplicationID, DriverID, LocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID); ;
            return InternationalLicenseID > -1;
        }
        private bool _Update()
        {
            return true;
        }

        public bool Save()
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

        public static clsInternationalLicenses Find(int internationalLicenseId)
        {
            int applicationId = -1, driverId = -1, localLicenseId = -1, createdByuserId = -1;
            DateTime issueDate = DateTime.Now, expirationDate = DateTime.Now;
            bool isActive = false;

            if (clsInternationalLicensesDataAccessLayer.FindInternationalLicenseByID(internationalLicenseId, ref applicationId, ref driverId, ref localLicenseId, ref issueDate, ref expirationDate, ref isActive, ref createdByuserId))
            {
                return new clsInternationalLicenses(internationalLicenseId, applicationId, driverId, localLicenseId, issueDate, expirationDate, isActive, createdByuserId);
            }
            return null;
        }

        public static int GetActiveInternationalLicenseID(int DriverID)
        {
            return clsInternationalLicensesDataAccessLayer.GetActiveInternationalLicenseID(DriverID);
        }

        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {
            return clsInternationalLicensesDataAccessLayer.GetDriverInternationalLicenses(DriverID);
        }
        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicensesDataAccessLayer.GetAllInternationalLicenses();
        }
    }
}
