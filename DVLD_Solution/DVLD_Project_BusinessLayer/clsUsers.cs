using DataAccessLayer;
using System.Data;

namespace BusinessLayer
{
    public class clsUsers
    {

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsPeople PersonInfo;

        private enum enMode { eAddNew = 1, eUpdate = 2 }

        enMode _Mode;

        public clsUsers()
        {
            UserID = -1;
            PersonID = -1;
            UserName = string.Empty;
            Password = string.Empty;
            IsActive = false;

            _Mode = enMode.eAddNew;
        }

        private clsUsers(int userID, int personID, string userName, string password, bool isActive)
        {
            UserID = userID;
            PersonID = personID;
            UserName = userName;
            Password = password;
            IsActive = isActive;
            PersonInfo = clsPeople.Find(personID);
            _Mode = enMode.eUpdate;
        }


        public static bool IsUserExist(int UserID)
        {
            return clsUsersDataAccessLayer.IsUserExistByUserID(UserID);
        }

        public static bool IsUserExist(string UserName)
        {
            return GetUserIdByUserName(UserName)!=-1;
        }

        public static bool IsPersonRelatedToAnyUser(int PersonID)
        {
            return clsUsersDataAccessLayer.IsPersonRelatedToAnyUser(PersonID);
        }

        public static int GetUserIdByUserName(string UserName)
        {
            return clsUsersDataAccessLayer.GetUserIdByUserName(UserName);
        }

        public static int GetUserIdByPersonID(int PersonID)
        {
            return clsUsersDataAccessLayer.GetUserIdByPersonID(PersonID);
        }

        public static int GetUserIdByNationalNo(string NationalNo)
        {
            return clsUsersDataAccessLayer.GetUserIdByNationalNo(NationalNo);
        }

        public static clsUsers FindByUserID(int UserID)
        {
            int PersonID = -1;
            string userName = string.Empty;
            string password = string.Empty;
            bool IsActive = false;

            if (clsUsersDataAccessLayer.FindUserByUserID(UserID,ref PersonID,ref userName,ref password,ref IsActive))
            {
                return new clsUsers(UserID,PersonID, userName, password, IsActive);
            }
            return null;
        }

        public static clsUsers FindByUserName(string UserName,bool CaseSensitive=false)
        {
            int UserID = -1;
            int PersonID = -1;
            string password = string.Empty;
            bool IsActive = false;

            if (clsUsersDataAccessLayer.FindUserByUseName(UserName,ref PersonID,ref UserID,ref password,ref IsActive, CaseSensitive))
            {
                return new clsUsers(UserID,PersonID, UserName, password, IsActive);
            }
            return null;
        }

        private bool _AddNew()
        {
            Password = clsEncryption.ComputeHash(Password);
            UserID = clsUsersDataAccessLayer.AddNewUser(PersonID, UserName, Password, IsActive);
            return UserID > -1;
        }
        private bool _Update()
        {
            if (!clsEncryption.IsHash(Password))
               Password = clsEncryption.ComputeHash(Password);

            return clsUsersDataAccessLayer.UpdateUserInfo(UserID, UserName, Password, IsActive);
        }
        
        public  bool Save()
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

        public static bool Delete(int UserID)
        { return clsUsersDataAccessLayer.DeleteUser(UserID); }

        public static DataTable GetListOfUsers()
        {
            return clsUsersDataAccessLayer.GetUsersList();
        }


    }



}
