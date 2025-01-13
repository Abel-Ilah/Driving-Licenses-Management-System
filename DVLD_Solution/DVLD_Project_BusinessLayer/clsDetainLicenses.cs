using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class clsDetainLicenses
    {
        public int DetainID { get;private set; }
        public int LicensesID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReleasedByUserID { get; set; }
        public int? ReleaseApplicationID { get; set; }

        private enum enMode { eAddNew = 1, eUpdate = 2 }

        enMode _Mode;
        public clsDetainLicenses() 
        {
            DetainID = -1;
            LicensesID = -1;
            DetainDate = DateTime.Now;
            FineFees = 0;
            CreatedUserID = -1;
            IsReleased = false;
            ReleaseDate = null;
            ReleasedByUserID = null;
            ReleaseApplicationID = null;

            _Mode=enMode.eAddNew;
        }

        private clsDetainLicenses(int detainID, int licensesID, DateTime detainDate, decimal fineFees, int createdUserID, bool isReleased, DateTime? releaseDate, int? releasedByUserID, int? releaseApplicationID)
        {

            DetainID = detainID;
            LicensesID = licensesID;
            DetainDate = detainDate;
            FineFees = fineFees;
            CreatedUserID = createdUserID;
            IsReleased = isReleased;
            ReleaseDate = releaseDate;
            ReleasedByUserID = releasedByUserID;
            ReleaseApplicationID = releaseApplicationID;

            _Mode = enMode.eUpdate;
        }

        protected bool _AddNew()
        {
            DetainID = clsDetainLicensesDataAccessLayer.AddNewDetain(LicensesID, DetainDate, FineFees, CreatedUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);

            return DetainID != -1;
        }

        private bool _Update()
        {
            return clsDetainLicensesDataAccessLayer.UpdateDetain(DetainID,LicensesID, DetainDate, FineFees, CreatedUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
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

        public static clsDetainLicenses FindLastDetain(int LocalLicenseID)
        {
            int detainId = -1;
            DateTime detainDate = DateTime.Now;
            decimal fineFees = 0;
            int createdByUserId = -1;
            bool isReleased = false;
            DateTime? releaseDate = null;
            int? releasedByUserId = null;
            int? releaseApplicationId = null;

            if (clsDetainLicensesDataAccessLayer.GetLastDetainInfo(LocalLicenseID,ref detainId,ref detainDate,ref fineFees,ref createdByUserId,ref isReleased,ref releaseDate,ref releasedByUserId,ref releaseApplicationId))
            {
                return new clsDetainLicenses(detainId, LocalLicenseID, detainDate, fineFees, createdByUserId, isReleased, releaseDate, releasedByUserId, releaseApplicationId);
            }
            return null;
        }

        public static bool IsLicenseDetained(int licenseID)
        {
            return clsDetainLicensesDataAccessLayer.IsLicenseDetained(licenseID);
        }

        public static DataTable GetAllDetainOperations()
        {
            return clsDetainLicensesDataAccessLayer.GetAllDetainedLicenses();
        }

    }
}
