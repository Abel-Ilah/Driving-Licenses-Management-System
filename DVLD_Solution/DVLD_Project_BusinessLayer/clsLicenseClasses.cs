using System;
using System.Data;
using DataAccessLayer;
namespace BusinessLayer
{
    public class clsLicenseClasses
    {
        public int LicenseClassID { get; private set; }
        public string ClassName { get; private set; }
        public string ClassDescription { get; private set; }
        public byte MinimumAllowedAge { get; private set; }
        public byte DefaultValidityLength { get; private set; }
        public decimal Fees { get; private set; }


      private  clsLicenseClasses(int licenseclassid,string classname,string classdescription,byte minimumallowedage,byte defaultvaliditylength,decimal fees)
        { 
            LicenseClassID = licenseclassid;
            ClassName = classname;
            ClassDescription = classdescription;
            MinimumAllowedAge = minimumallowedage;
            DefaultValidityLength = defaultvaliditylength;
            Fees = fees;
        }
      public static DataTable GetLicenseClassesList()
        {
            
            return clsDrivingLicenseClassesDataAccessLayer.GetLicenseClassesList();
        }

      public static clsLicenseClasses Find(int LicensesClassID)
      {
            string classname = "", classdescription = "";
            byte minimumallowedage = 0, defaultvaliditylength = 0;
            decimal fees = 0;

            if (clsDrivingLicenseClassesDataAccessLayer.GetLicenseClassInfo(LicensesClassID,ref classname,ref classdescription,ref minimumallowedage,ref defaultvaliditylength,ref fees))
            {
                return new clsLicenseClasses(LicensesClassID, classname, classdescription, minimumallowedage, defaultvaliditylength, fees);
            }
            return null;
      }

      public static string GetLicenseClassName(int LicensesClassID)
        {
            return clsDrivingLicenseClassesDataAccessLayer.GetLicenseClassName(LicensesClassID);
        }
    }
}
