using DataAccessLayer;
using System;
using System.Data;


namespace BusinessLayer
{
    public  class clsPeople
    {
        public int ID { get;private set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }
         string _FullName()
        {
            string FullName = "";
            FullName += FirstName + " ";
            FullName += SecondName + " ";

            if (!string.IsNullOrEmpty(ThirdName))
               FullName += ThirdName + " ";

            FullName += LastName;

            return FullName;
        }
        public string FullName { get { return _FullName(); } }


        private enum enMode { eAddNew=1,eUpdate=2}

        enMode _Mode;

        public clsPeople()
        {
            ID = -1;
            NationalNo =string.Empty;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            DateOfBirth = DateTime.MinValue;
            Gender = 0;
            Address = string.Empty;
            CountryID = -1;
            ImagePath = string.Empty;

            _Mode=enMode.eAddNew;
        }

       protected clsPeople(int ID ,string IDCardNumber, string FirstName, string SecondName,
                               string ThirdName, string LastName, string Email, string Phone, DateTime BirthDate,
                               byte Gender, string Address, int CountryID, string ImagePath)
        {
            _Mode = enMode.eUpdate;

            this.ID= ID;
            this.NationalNo = IDCardNumber;
            this.Address = Address;
            this.CountryID = CountryID;
            this.Email = Email;
            this.Phone = Phone;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = BirthDate;
            this.Gender = Gender;
            this.ImagePath = ImagePath;
        }

        public static int GetPersonID(string NationalID)
        {
            return ClsPeopleDataAccessLayer.GetPersonIDByNationalNo(NationalID);
        }

        public static bool IsPersonExist(int PersonID)
        {
            return ClsPeopleDataAccessLayer.IsPersonExist(PersonID);
        }
        public static clsPeople Find(int PersonID)
        {
            string IDCardNumber = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "",
                    Email = "", Phone = "", Address = "", ImagePath = "";

            DateTime DateOfBirth = DateTime.Now;
            byte Gender = 0;
            int CountryID = -1;

            if (ClsPeopleDataAccessLayer.FindPersonByID(PersonID,ref IDCardNumber, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref Email, ref Phone, ref DateOfBirth, ref Gender, ref Address, ref CountryID, ref ImagePath))
            {
                return new clsPeople(PersonID, IDCardNumber, FirstName, SecondName, ThirdName, LastName, Email, 
                                     Phone, DateOfBirth, Gender, Address, CountryID, ImagePath);
            }
            else
            {
                return null;
            }

        }
        public static clsPeople Find(string NationalNo)
        {
           string FirstName = "", SecondName = "", ThirdName = "", LastName = "",
                    Email = "", Phone = "", Address = "", ImagePath = "";

            DateTime DateOfBirth = DateTime.Now;
            byte Gender = 0;
            int CountryID = -1,PersonID=-1;

            if (ClsPeopleDataAccessLayer.FindPersonByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref Email, ref Phone, ref DateOfBirth, ref Gender, ref Address, ref CountryID, ref ImagePath))
            {
                return new clsPeople(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, Email,
                                     Phone, DateOfBirth, Gender, Address, CountryID, ImagePath);
            }
                return null;
            
        }

        private bool _AddNew()
        {
            ID=ClsPeopleDataAccessLayer.AddNewPerson(NationalNo, FirstName, SecondName, ThirdName, LastName, Email, Phone,DateOfBirth,Gender,Address,CountryID,ImagePath);
            return ID > -1;
        }
        private bool _Update() 
        {
            return ClsPeopleDataAccessLayer.UpdatePerson(ID, NationalNo, FirstName, SecondName, ThirdName, LastName, Email, 
                                                         Phone, DateOfBirth, Gender, Address, CountryID, ImagePath);
        }

        public  bool Save()
        {
            switch(_Mode)
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

        public static bool Delete(int PersonID)
        { return ClsPeopleDataAccessLayer.DeletePerson(PersonID); }

        public static DataTable GetPeopleList()
        {
            return ClsPeopleDataAccessLayer.GetPeopleList();
        }
        
    }
}
