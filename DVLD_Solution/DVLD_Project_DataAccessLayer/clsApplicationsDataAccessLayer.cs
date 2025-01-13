using System;
using System.Data.SqlClient;



namespace DataAccessLayer
{
    public static class clsApplicationsDataAccessLayer
    {
        public static int AddNewApplication(int ApplicantPersonID,DateTime ApplicationDate,int ApplicationTypeID,Byte ApplicationStatus,DateTime LastStatusDate,decimal PaidFees,int CreatedByUserID)
        {
            int NewApplicationID = -1;

            SqlConnection connection=new SqlConnection(clsSettings.ConnectionString);
            string Query = "insert into Applications values(@ApplicantPersonID,@ApplicationDate," +
                "@ApplicationTypeID,@ApplicationStatus,@LastStatusDate,@PaidFees,@CreatedByUserID);" +
                "select SCOPE_IDENTITY();";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object result= command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(),out int x))
                {
                    NewApplicationID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex) 
            { 
                NewApplicationID = -1;
                clsSettings.LoggingAnException("DVLD", ex.Message);
            }
            finally { connection.Close(); }
            return NewApplicationID;

        }

        public static bool FindApplicationByApplicationID(int  ApplicationID,ref int ApplicantPersonID,ref DateTime ApplicationDate,ref int ApplicationTypeID, ref Byte ApplicationStatus, ref DateTime LastStatusDate, ref decimal PaidFees, ref int CreatedByUserID) 
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "select * from Applications where ApplicationID=@ApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;

                    ApplicantPersonID = (int)Reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)Reader["ApplicationDate"];
                    ApplicationTypeID = (int)Reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)Reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)Reader["LastStatusDate"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];

                    Reader.Close();
                }

            }
            catch (Exception ex) { IsFound = false; clsSettings.LoggingAnException("DVLD", ex.Message); }

            finally { Connection.Close(); }

            return IsFound;

        }

        public static bool UpdateApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, Byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            bool IsUpdated = false;


            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "Update Applications set ApplicantPersonID=@ApplicantPersonID, ApplicationDate=@ApplicationDate," +
                           "ApplicationTypeID=@ApplicationTypeID,ApplicationStatus=@ApplicationStatus,LastStatusDate=@LastStatusDate," +
                           "PaidFees=@PaidFees,CreatedByUserID=@CreatedByUserID " +
                           " where ApplicationID=@ApplicationID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
 
            try
            {
                Connection.Open();
                if (Command.ExecuteNonQuery() > 0)
                    IsUpdated = true;
            }
            catch (Exception ex) { IsUpdated = false; clsSettings.LoggingAnException("DVLD", ex.Message);  }
            finally { Connection.Close(); }

            return IsUpdated;
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "Delete from Applications where ApplicationID=@ApplicationID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                if (command.ExecuteNonQuery() > 0)
                    IsDeleted = true;

            }
            catch (Exception ex) { IsDeleted = false; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return IsDeleted;

        }


    }
}
