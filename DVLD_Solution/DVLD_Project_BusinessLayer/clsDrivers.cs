using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using DataAccessLayer;
namespace BusinessLayer
{
    public class clsDrivers
    {
        public int DriverID { get;private set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreateDate { get; set; }

        public clsPeople PersonInfo;

        private enum enModes { eAddNew = 1, eUpdate = 2 }

        enModes _Mode;

        public clsDrivers()
        {
         DriverID = -1;
         PersonID = -1;
         CreatedByUserID = -1;
         CreateDate=DateTime.Now;

         _Mode = enModes.eAddNew;
        }

        private clsDrivers(int driverID, int personID, int createdByUserID, DateTime createDate)
        {
            DriverID = driverID;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            CreateDate = createDate;

            PersonInfo = clsPeople.Find(PersonID);

            _Mode = enModes.eUpdate;
        }

        public static clsDrivers Find(int driverID)
        {
            int personId=-1, createdByUserID=-1;
            DateTime createDate = DateTime.Now;

            if (clsDriversDataAccessLayer.FindDriver(driverID,ref personId,ref createdByUserID,ref createDate))
            {
                return new clsDrivers(driverID,personId,createdByUserID,createDate);
            }
            return null;
        }

        public static int GetDriverID(int PersonId)
        {
            return clsDriversDataAccessLayer.GetDriverID(PersonId);
        }

        private bool _AddNew()
        {
            DriverID = clsDriversDataAccessLayer.AddNewDriver(PersonID, CreatedByUserID, CreateDate);
            return DriverID > -1;
        }

        private bool _Update()
        {
            return true;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enModes.eAddNew:
                    if (_AddNew())
                    {
                        _Mode = enModes.eUpdate;
                        return true;
                    }
                    break;
                case enModes.eUpdate:
                    return _Update();

            }
            return false;
        }


        public static DataTable GetAllDrivers()
        {
            return clsDriversDataAccessLayer.GetAllDrivers();
        }

    }



}
