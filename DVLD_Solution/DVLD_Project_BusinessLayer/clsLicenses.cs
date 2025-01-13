using System;
using System.Data;
using System.Xml.Linq;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsLicenses
    {
        public int LicenseID { get; private set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClassID { get; set; }
        public DateTime IssueDate {  get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        private enum enModes { AddNewMode=1,UpdateMode=2 }
        enModes _Mode;

        public clsLicenses()
        {
            LicenseID = -1;
            ApplicationID=-1;
            DriverID = -1;
            LicenseClassID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate=DateTime.Now;
            Notes = string.Empty;
            PaidFees = 0;
            IsActive = false;
            IssueReason = 0;
            CreatedByUserID = -1;

            _Mode = enModes.AddNewMode;
        }

        private clsLicenses(int licenseID, int applicationID, int driverID, int licenseClassID, DateTime issueDate, DateTime expirationDate, string notes, decimal paidFees, bool isActive, byte issueReason, int createdByUserID)
        {
            LicenseID = licenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClassID = licenseClassID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
            _Mode = enModes.UpdateMode;
        }
   
        private bool _AddNew()
        {
            LicenseID = clsLicensesDataAccessLayer.AddNewLicense(ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            return LicenseID != -1;
        }

        private bool _Update()
        {
            return clsLicensesDataAccessLayer.UpdateLicense(LicenseID,ApplicationID,DriverID, LicenseClassID, IssueDate,ExpirationDate, Notes,PaidFees,IsActive, IssueReason, CreatedByUserID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enModes.AddNewMode:
                    if (_AddNew())
                    {
                        _Mode = enModes.UpdateMode;
                        return true;
                    }
                    break;
                case enModes.UpdateMode:
                    return _Update();
                   
            }
            return false;
        }
        
        public static clsLicenses FindLicenseByLicenseID(int LicenseID)
        {
            int applicationId = -1, driverID = -1, licenseClassId = -1, createdByUserId = -1;
            DateTime issueDate=DateTime.Now, expirationDate=DateTime.Now;
            string notes = string.Empty;
            decimal paidFees = 0;
            bool isActive = false;
            byte issueReason = 0;

            if (clsLicensesDataAccessLayer.FindLicenseByLicenseID(LicenseID,ref applicationId, ref driverID, ref licenseClassId, ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive, ref issueReason, ref createdByUserId))
            {
                return new clsLicenses(LicenseID,applicationId, driverID,licenseClassId, issueDate, expirationDate, notes, paidFees, isActive, issueReason, createdByUserId);
            }
            return null;
        }

        public static DataTable GetLocalLicenses(int DriverID)
        {
            return clsLicensesDataAccessLayer.GetDriverLocalLicenses(DriverID);
        }

        public static int GetLicenseIdByApplicationID(int ApplicationID)
        {
            return clsLicensesDataAccessLayer.GetLicenseIdByApplicationId(ApplicationID);
        }

        public static bool IsLicenseExist(int LicenseID)
        {
            return clsLicensesDataAccessLayer.IsLicenseExist(LicenseID);
        }

        public static int GetPersonIdOfLicenseOwner(int LicenseID) 
        {
            return clsLicensesDataAccessLayer.GetPersonIdOfLicenseOwner(LicenseID);
        }


    }


}
