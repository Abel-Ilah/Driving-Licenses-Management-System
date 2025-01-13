using System;
using System.Data;
using System.Runtime.CompilerServices;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsApplicationTypes
    {

        public int ID { get;}
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }

        private clsApplicationTypes(int ID,string ApplicationTypeTitle,decimal ApplicationFees)
        { 
            this.ID = ID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
        }

        public static clsApplicationTypes Find(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = "";
            decimal ApplicationFees = 0;
            if (clsApplicationTypesDataAccessLayer.FindApplicationType(ApplicationTypeID,ref ApplicationTypeTitle,ref ApplicationFees))
            {
                return new clsApplicationTypes(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            }
            return null;
        }

        public bool Update()
        {
            return clsApplicationTypesDataAccessLayer.UpdateApplicationTypeInfo(ID, ApplicationTypeTitle, ApplicationFees);
        }

        public static DataTable GetAllApplicationsTypes()
        {
            return clsApplicationTypesDataAccessLayer.GetAllApplicationsTypes();
        }


    }
}
