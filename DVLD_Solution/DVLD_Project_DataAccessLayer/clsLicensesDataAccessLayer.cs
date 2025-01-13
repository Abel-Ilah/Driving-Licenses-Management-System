using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public static class clsLicensesDataAccessLayer
    {
        public static int AddNewLicense(int applicationID, int driverID, int licenseClassID, DateTime issueDate, DateTime expirationDate, string notes, decimal paidFees, bool isActive, byte issueReason, int createdByUserID)
        {
            int LicenseID=-1;

            SqlConnection connection =new SqlConnection(clsSettings.ConnectionString);
            string Query = "Insert Into Licenses values(@applicationID,@driverID,@licenseClassID,@issueDate,@expirationDate," +
                           "@notes,@paidFees,@isActive,@issueReason,@createdByUserID); select SCOPE_IDENTITY();";
            SqlCommand command=new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@applicationID", applicationID);
            command.Parameters.AddWithValue("@driverID", driverID);
            command.Parameters.AddWithValue("@licenseClassID", licenseClassID);
            command.Parameters.AddWithValue("@issueDate", issueDate);
            command.Parameters.AddWithValue("@expirationDate", expirationDate);

            if (string.IsNullOrEmpty(notes))
               command.Parameters.AddWithValue("@notes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@notes", notes);

            command.Parameters.AddWithValue("@paidFees", paidFees);
            command.Parameters.AddWithValue("@isActive", isActive);
            command.Parameters.AddWithValue("@issueReason", issueReason);
            command.Parameters.AddWithValue("@createdByUserID", createdByUserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int x))
                    LicenseID = Convert.ToInt32(result);
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return LicenseID;
        }

        public static bool UpdateLicense(int LicenseID, int applicationID, int driverID, int licenseClassID, DateTime issueDate, DateTime expirationDate, string notes, decimal paidFees, bool isActive, byte issueReason, int createdByUserID)
        {
            bool IsUpdated=false;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "update Licenses set applicationID=@applicationID,driverID=@driverID,licenseClass=@licenseClassID,issueDate=@issueDate,expirationDate=@expirationDate,notes=@notes,paidFees=@paidFees,isActive=@isActive,issueReason=@issueReason,createdByUserID=@createdByUserID where LicenseID=@LicenseID";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@applicationID", applicationID);
            command.Parameters.AddWithValue("@driverID", driverID);
            command.Parameters.AddWithValue("@licenseClassID", licenseClassID);
            command.Parameters.AddWithValue("@issueDate", issueDate);
            command.Parameters.AddWithValue("@expirationDate", expirationDate);
            command.Parameters.AddWithValue("@paidFees", paidFees);
            command.Parameters.AddWithValue("@isActive", isActive);
            command.Parameters.AddWithValue("@issueReason", issueReason);
            command.Parameters.AddWithValue("@createdByUserID", createdByUserID);

            if (string.IsNullOrEmpty(notes))
                command.Parameters.AddWithValue("@notes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@notes", notes);

            try
            {
                connection.Open();
                if (command.ExecuteNonQuery()>0)
                    IsUpdated = true;
                
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return IsUpdated;
        }

        public static bool FindLicenseByLicenseID(int LicenseID, ref int applicationID, ref int driverID, ref int licenseClassID, ref DateTime issueDate, ref DateTime expirationDate, ref string notes, ref decimal paidFees, ref bool isActive, ref byte issueReason, ref int createdByUserID)
        { 
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "select * from Licenses where LicenseID=@LicenseID;";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    applicationID = Convert.ToInt32(reader[1]);
                    driverID = Convert.ToInt32(reader[2]);
                    licenseClassID= Convert.ToInt32(reader[3]);
                    issueDate = Convert.ToDateTime(reader[4]);
                    expirationDate = Convert.ToDateTime(reader[5]);

                    if (!string.IsNullOrEmpty(reader[6].ToString()))
                        notes = reader[6].ToString();

                    paidFees = Convert.ToDecimal(reader[7]);
                    isActive = Convert.ToBoolean(reader[8]);
                    issueReason = Convert.ToByte(reader[9]);
                    createdByUserID = Convert.ToInt32(reader[10]);
                    
                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception ex) { IsFound = false; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return IsFound;
           
        }

      
        public static bool IsLicenseExist(int LicenseID)
        {
            bool IsExist = false;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "select 1 from Licenses where LicenseID=@LicenseID;";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result!=null && int.TryParse(result.ToString(),out int x)&& x ==1)
                    IsExist = true;
            }
            catch (Exception ex) { IsExist = false; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return IsExist;
        }

        public static DataTable GetDriverLocalLicenses(int DriverID)
        {
            DataTable LicensesTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "SELECT Licenses.LicenseID, Licenses.ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive  " +
                           "FROM LicenseClasses INNER JOIN Licenses ON LicenseClasses.LicenseClassID = Licenses.LicenseClass where DriverID=@DriverID;";
            SqlCommand command =new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);
        

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    LicensesTable.Load(reader);

                reader.Close();
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return LicensesTable;
        }

        public static int GetLicenseIdByApplicationId(int ApplicationID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string Query = " Select LicenseID from Licenses  Where ApplicationID=@ApplicationID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(),out int x))
                {
                    LicenseID = Convert.ToInt32(Result);
                }
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return LicenseID;
        }

        public static int GetPersonIdOfLicenseOwner(int  LicenseID) 
        { 
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "SELECT People.PersonID  FROM   Drivers INNER JOIN  Licenses" +
                           " ON Drivers.DriverID = Licenses.DriverID INNER JOIN  People" +
                           " ON Drivers.PersonID = People.PersonID where LicenseID=@LicenseID";

            SqlCommand command=new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result!=null && int.TryParse(Result.ToString(),out int x))
                    PersonID = Convert.ToInt32(Result);
                
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return PersonID;
        }


    }
}
