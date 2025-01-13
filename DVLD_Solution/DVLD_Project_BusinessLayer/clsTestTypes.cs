using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsTestTypes
    {
         public byte ID { get; private set; }
         public string Title { get; set;}
         public string Description { get; set;}  
         public decimal Fees { get; set;}

        public enum enTestTypes {VisionTest=1,WrittenTest=2,DrivingTest };
        
        private clsTestTypes(byte TestTypeID,string TestTypeTitle,string TestTypeDescription,decimal TestTypeFees)
        { 
            ID = TestTypeID;
            Title = TestTypeTitle;
            Description = TestTypeDescription;
            Fees = TestTypeFees;
        }
        
         public static clsTestTypes Find(byte TestTypeID)
        {
            string Title = "", Description = "";
            decimal Fees = 0;

            if (clsTestTypesDataAccessLayer.FindTestType(TestTypeID,ref Title,ref Description,ref Fees))
            {
                return new clsTestTypes(TestTypeID,Title,Description,Fees);
            }
            return null;
        }
        
         public bool Update()
         {
             return clsTestTypesDataAccessLayer.UpdateTestType(ID,Title,Description,Fees);
         }
        
        public static DataTable GetAllTestTypes()
        {
            return clsTestTypesDataAccessLayer.GetAllTestTypes();
        }
    
    }
}
