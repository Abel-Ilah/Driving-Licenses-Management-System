
using System;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public static class clsUsersDataAccessLayer
    {

        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            int NewUserID = -1;

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "insert into Users values(@PersonID,@UserName,@Password,@IsActive);" +
                          "select SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int x))
                    NewUserID = Convert.ToInt32(Result);
            }
            catch (Exception ex) { NewUserID = -1; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { Connection.Close(); }

            return NewUserID;

        }

        public static bool IsUserExistByUserID(int UserID)
        {
            bool IsExist = false;

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);

            string Query = "select 1 from Users where UserID=@UserID;";

            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null) IsExist = true;

            }
            catch (Exception ex) { IsExist = false; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { Connection.Close(); }
            return IsExist;

        }

        public static bool IsPersonRelatedToAnyUser(int PersonID)
        {
            bool PersonIsRelatedToUser = false;

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);

            string Query = "select 1 from Users where PersonID=@PersonID;";

            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null) PersonIsRelatedToUser = true;

            }
            catch (Exception ex) { PersonIsRelatedToUser = false; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { Connection.Close(); }
            return PersonIsRelatedToUser;

        }

        public static int GetUserIdByUserName(string UserName)
        {
            int ID = -1;

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);

            string Query = "select UserID from Users where UserName=@UserName;";

            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null) ID = Convert.ToInt32(Result);
            }
            catch (Exception ex) { ID = -1; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { Connection.Close(); }
            return ID;
        }

        public static int GetUserIdByPersonID(int PersonID)
        {
            int ID = -1;

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);

            string Query = "select UserID from Users where PersonID=@PersonID;";

            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null) ID = Convert.ToInt32(Result);
            }
            catch (Exception ex) { ID = -1; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { Connection.Close(); }
            return ID;
        }

        public static int GetUserIdByNationalNo(string NationalNo)
        {
            int ID = -1;

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);

            string Query = "SELECT UserID FROM   People INNER JOIN Users ON People.PersonID = Users.PersonID where NationalNo=@NationalNo;";


            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null) ID = Convert.ToInt32(Result);
            }
            catch (Exception ex) { ID = -1; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { Connection.Close(); }
            return ID;
        }

        public static bool FindUserByUserID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "select * from Users where UserID=@UserID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                }
                reader.Close();
            }
            catch (Exception ex) { IsFound = false; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { Connection.Close(); }
            return IsFound;

        }

        public static bool FindUserByUseName(string UserName, ref int PersonID, ref int UserID, ref string Password, ref bool IsActive, bool CaseSensitive = false)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);

            string Query = "select * from Users where UserName=@UserName;";

            if (CaseSensitive == true) Query = "select * from Users where UserName=@UserName COLLATE SQL_Latin1_General_CP1_CS_AS;";

            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    Password = (string)reader["Password"];
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                }
                reader.Close();
            }
            catch (Exception ex) { IsFound = false; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { Connection.Close(); }
            return IsFound;

        }

        public static bool UpdateUserInfo(int UserID, string UserName, string Password, bool IsActive)
        {
            bool IsUpdated = false;

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "Update Users set UserName=@UserName,Password=@Password,IsActive=@IsActive where UserID=@UserID;";
            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                Connection.Open();

                if (command.ExecuteNonQuery() > 0)
                    IsUpdated = true;
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { Connection.Close(); }
            return IsUpdated;
        }

        public static bool DeleteUser(int UserID)
        {
            bool IsDeleted = false;

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "Delete from Users where UserID=@UserID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                Connection.Open();
                if (Command.ExecuteNonQuery() > 0)
                    IsDeleted = true;

            }
            catch (Exception ex) { IsDeleted = false; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { Connection.Close(); }
            return IsDeleted;

        }

        public static DataTable GetUsersList()
        {
            DataTable UsersDataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "SELECT UserID, Users.PersonID as PersonID," +
                          "FullName = People.FirstName+' '+ People.SecondName + ' '+ISNULL(People.ThirdName, '') +' '+ People.LastName," +
                          " UserName,IsActive " +
                            "FROM People INNER JOIN Users ON People.PersonID = Users.PersonID";
            SqlCommand command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows) UsersDataTable.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { Connection.Close(); }

            return UsersDataTable;
        }



    }


}
