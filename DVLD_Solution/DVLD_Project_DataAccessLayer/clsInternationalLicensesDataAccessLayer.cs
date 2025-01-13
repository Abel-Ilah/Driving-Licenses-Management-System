using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsInternationalLicensesDataAccessLayer
    {
        public static int AddNewInternationalLicense(int ApplicationID, int DriverID, int LocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int RecordID = -1;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string Query = " Insert Into InternationalLicenses Values(@ApplicationID,@DriverID,@LocalLicenseID,@IssueDate,@ExpirationDate,@IsActive,@CreatedByUserID);select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int x))
                {
                    RecordID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return RecordID;

        }

        public static bool FindInternationalLicenseByID(int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref int LocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string Query = " Select * from InternationalLicenses  Where InternationalLicenseID=@InternationalLicenseID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    ApplicationID = Convert.ToInt32(reader[1]);
                    DriverID = Convert.ToInt32(reader[2]);
                    LocalLicenseID = Convert.ToInt32(reader[3]);
                    IssueDate = Convert.ToDateTime(reader[4]);
                    ExpirationDate = Convert.ToDateTime(reader[5]);
                    IsActive = Convert.ToBoolean(reader[6]);
                    CreatedByUserID = Convert.ToInt32(reader[7]);

                }
                reader.Close();
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return IsFound;
        }

        public static int GetActiveInternationalLicenseID(int DriverID)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string Query = "select top 1 InternationalLicenseID from InternationalLicenses where DriverID=@DriverID and IsActive=1 and ExpirationDate>GETDATE()\r\norder by IssueDate desc;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int x)) ID = Convert.ToInt32(Result);

            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return ID;
        }

 
        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {
            DataTable InternationalLicensesTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "select InternationalLicenseID,ApplicationID,LocalLicenseID,IssueDate,ExpirationDate,IsActive" +
                           " from InternationalLicenses where DriverID=@DriverID;";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    InternationalLicensesTable.Load(reader);

                reader.Close();
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return InternationalLicensesTable;
        }

        public static DataTable GetAllInternationalLicenses()
        {
            DataTable InternationalLicensesTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "select InternationalLicenseID,ApplicationID,DriverID,LocalLicenseID,IssueDate,ExpirationDate,IsActive" +
                           " from InternationalLicenses ;";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    InternationalLicensesTable.Load(reader);

                reader.Close();
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return InternationalLicensesTable;
        }
    }
}
