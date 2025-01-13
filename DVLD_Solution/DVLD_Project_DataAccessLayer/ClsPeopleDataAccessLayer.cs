using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   

    public class ClsPeopleDataAccessLayer
    {
       
        public static int AddNewPerson(string IDCardNumber, string FirstName, string SecondName,
            string ThirdName, string LastName, string Email, string Phone, DateTime BirthDate,
            byte Gender, string Address, int CountryID, string ImagePath)
        {
            int ID = -1;

            SqlConnection Connection=new SqlConnection(clsSettings.ConnectionString);
            string Query = "insert Into People values (@IDCardNumber,@FirstName," +
                           "@SecondName,@ThirdName,@LastName,@BirthDate," +
                           "@Gender,@Address,@Phone,@Email,@CountryID,@ImagePath);" +
                           "select SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query,Connection);

            Command.Parameters.AddWithValue("@IDCardNumber", IDCardNumber);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@BirthDate", BirthDate);
            Command.Parameters.AddWithValue("@Gender", Gender);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@CountryID", CountryID);

            if (string.IsNullOrEmpty(ThirdName))
                Command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            else
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);

            if (string.IsNullOrEmpty(Email))
                Command.Parameters.AddWithValue("@Email", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Email", Email);

            if (string.IsNullOrEmpty(ImagePath))
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            
            try
            {
                Connection.Open();
                object Result= Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int x))
                    ID = Convert.ToInt32(Result);
            }
            catch (Exception ex) { ID = -1; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { Connection.Close(); }

            return ID;

        }


        public static bool UpdatePerson(int PersonID,string IDCardNumber, string FirstName, string SecondName,
         string ThirdName, string LastName, string Email, string Phone, DateTime BirthDate,
         byte Gender, string Address, int CountryID, string ImagePath)
        {
            bool IsUpdated = false;

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "Update People set NationalNo=@IDCardNumber, FirstName=@FirstName,SecondName=@SecondName,ThirdName=@ThirdName,LastName=@LastName," +
                "Email=@Email,Phone=@Phone,Address=@Address,DateOfBirth=@BirthDate,Gender=@Gender,NationalityCountryID=@CountryID,ImagePath=@ImagePath " +
                " where PersonID=@PersonID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@IDCardNumber", IDCardNumber);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@BirthDate", BirthDate);
            Command.Parameters.AddWithValue("@Gender", Gender);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@CountryID", CountryID);

            if (string.IsNullOrEmpty(ThirdName))
                Command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ThirdName", ThirdName);

            if (string.IsNullOrEmpty(Email))
                Command.Parameters.AddWithValue("@Email", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Email", Email);

            if (string.IsNullOrEmpty(ImagePath))
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);

            try
            {
                Connection.Open();
                if (Command.ExecuteNonQuery()>0)
                   IsUpdated = true;
            }
            catch (Exception ex)
            {
               IsUpdated= false; clsSettings.LoggingAnException("DVLD", ex.Message);
            }
            finally { Connection.Close(); }

            return IsUpdated;

        }


      public static  bool DeletePerson(int PersonID)
        {
            bool IsDeleted = false;

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "Delete from People where PersonID=@PersonID";
            SqlCommand Command=new SqlCommand(Query,Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                Connection.Open();
                if (Command.ExecuteNonQuery()>0)
                    IsDeleted = true;
                
            }
            catch (Exception ex) { IsDeleted = false; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { Connection.Close(); }
           return IsDeleted;

        }

        public static int GetPersonIDByNationalNo(string NationalNo)
        {
            int ID= -1;

            SqlConnection Connection=new SqlConnection(clsSettings.ConnectionString);

            string Query = "select PersonID from People where NationalNo=@NationalNo;";

            SqlCommand command = new SqlCommand(Query,Connection);
            command.Parameters.AddWithValue ("@NationalNo", NationalNo);

            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null) ID = Convert.ToInt32(Result) ;

            }
            catch (Exception ex) { ID = -1; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { Connection.Close(); }
            return ID;

        }

        
        public static bool IsPersonExist(int PersonID)
        {
            bool IsExist=false;

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);

            string Query = "select 1 from People where PersonID=@PersonID;";

            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null) IsExist = true ;

            }
            catch (Exception ex) { IsExist = false; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { Connection.Close(); }
            return IsExist;

        }

        public static bool FindPersonByID(int PersonID,ref string IDCardNumber, ref string FirstName, ref string SecondName,
           ref string ThirdName, ref string LastName, ref string Email, ref string Phone, ref DateTime BirthDate,
           ref byte Gender, ref string Address, ref int CountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "select * from People where PersonID=@PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                   
                    IDCardNumber = (string)Reader["NationalNo"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    LastName = (string)Reader["LastName"];
                    Phone = (string)Reader["Phone"];
                    Address = (string)Reader["Address"];
                    BirthDate = (DateTime)Reader["DateOfBirth"];
                    Gender = (byte)Reader["Gender"];
                    CountryID = (int)Reader["NationalityCountryID"];

                    if (Reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)Reader["ThirdName"];
                    else
                        ThirdName = "";

                    if (Reader["Email"] != DBNull.Value)
                        Email = (string)Reader["Email"];
                    else
                        Email = "";
                   
                    if (Reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)Reader["ImagePath"];
                    else
                        ImagePath = "";

                    IsFound = true;
                }
                Reader.Close();

            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }

            finally { Connection.Close(); }

            return IsFound;
        }

        public static bool FindPersonByNationalNo(string NationalNo,ref int PersonID, ref string FirstName, ref string SecondName,
              ref string ThirdName, ref string LastName, ref string Email, ref string Phone, ref DateTime BirthDate,
              ref byte Gender, ref string Address, ref int CountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "select * from People where NationalNo=@NationalNo";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
  
                    PersonID = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    LastName = (string)Reader["LastName"];
                    Phone = (string)Reader["Phone"];
                    Address = (string)Reader["Address"];
                    BirthDate = (DateTime)Reader["DateOfBirth"];
                    Gender = (byte)Reader["Gender"];
                    CountryID = (int)Reader["NationalityCountryID"];

                    if (Reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)Reader["ThirdName"];
                    else
                        ThirdName = "";

                    if (Reader["Email"] != DBNull.Value)
                        Email = (string)Reader["Email"];
                    else
                        Email = "";

                    if (Reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)Reader["ImagePath"];
                    else
                        ImagePath = "";

                    IsFound = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }

            finally { Connection.Close(); }

            return IsFound;
        }


        public static DataTable GetPeopleList()
        {
            DataTable PeopleDataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "SELECT        PersonID, NationalNo, FirstName, LastName,DateOfBirth,\r\n\t\t\t  Gender=case when People.Gender=0 then 'Male'\r\n\t\t\t               when People.Gender=1 then 'Female'\r\n\t\t\t\t      ENd,\r\n              People.Address, Phone, \r\n              Email, CountryName as Country\r\nFROM          People INNER JOIN Countries \r\nON            People.NationalityCountryID = Countries.CountryID;";
            SqlCommand command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows) PeopleDataTable.Load(Reader);
                
                Reader.Close();
            }
            catch (Exception ex ) { clsSettings.LoggingAnException("DVLD", ex.Message); }
           finally { Connection.Close(); }

            return PeopleDataTable;
        }




    }

}
