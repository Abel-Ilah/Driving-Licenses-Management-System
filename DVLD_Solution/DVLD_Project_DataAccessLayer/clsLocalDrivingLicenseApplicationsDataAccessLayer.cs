using System;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class clsLocalDrivingLicenseApplicationsDataAccessLayer
    {
        public static int AddNewLocalDrivingLicenseApplication(int ApplicationID,int LicenseClassID)
        {
            int NewLocalDrivingLicenseApplicationID = -1;

            SqlConnection connection =new SqlConnection(clsSettings.ConnectionString);
            string Query = "insert into LocalDrivingLicenseApplications values(@ApplicationID,@LicenseClassID);" +
                           "select SCOPE_IDENTITY();";

            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                object result= command.ExecuteScalar();
                if (result!=null && int.TryParse(result.ToString(),out int x))
                {
                    NewLocalDrivingLicenseApplicationID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex) { NewLocalDrivingLicenseApplicationID = -1; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return NewLocalDrivingLicenseApplicationID;

        }

        public static bool FindLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "select * from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;

                    LocalDrivingLicenseApplicationID = (int)Reader["LocalDrivingLicenseApplicationID"];
                    ApplicationID = (int)Reader["ApplicationID"];
                    LicenseClassID = (int)Reader["LicenseClassID"];

                    Reader.Close();
                }

            }
            catch (Exception ex) { IsFound = false; clsSettings.LoggingAnException("DVLD", ex.Message); }

            finally { Connection.Close(); }

            return IsFound;

        }

        public static int GetActiveOrCompletedLocalDrivingLicenseApplicationID(int ApplicantPersonId,int LicenseClassID,byte ApplicationStatus)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "SELECT Top 1 LocalDrivingLicenseApplicationID FROM LocalDrivingLicenseApplications  INNER JOIN Applications " +
                " ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID " +
                "where ApplicantPersonID=@ApplicantPersonId and LicenseClassID=@LicenseClassID and ApplicationStatus=@ApplicationStatus";

           SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonId", ApplicantPersonId);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            try
            {
                connection.Open();
                object result=command.ExecuteScalar();
                if (result!=null && int.TryParse(result.ToString(),out int x))
                    ID = Convert.ToInt32(result);
            }
            catch (Exception ex) { ID = -1; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close();}
            return ID;
        }

        public static bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int LicenseClassID)
        {
            bool IsUpdated=false;
            SqlConnection connection =new SqlConnection(clsSettings.ConnectionString);
            string Query = "Update LocalDrivingLicenseApplications Set LicenseClassID=@LicenseClassID where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
           SqlCommand command=new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                if (command.ExecuteNonQuery()>0)
                {
                    IsUpdated = true;
                }
            }
            catch (Exception ex) { IsUpdated = false; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close();}
            return IsUpdated;   
        }

       public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable LocalDrivingLicenseApplicationsTable = new DataTable();

            SqlConnection connection =new SqlConnection(clsSettings.ConnectionString);
            string Query = "select * from LocalDrivingLicenseApplications_View;";
            SqlCommand command=new SqlCommand(Query,connection);
            try
            {
                connection.Open();
                SqlDataReader reader= command.ExecuteReader();
                if (reader.HasRows)
                {
                    LocalDrivingLicenseApplicationsTable.Load(reader);
                }
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close();}
            return LocalDrivingLicenseApplicationsTable;

        }

        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "Delete from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
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

        public static bool IsApplicationExist(int LocalDrivingLicenseApplicationID)
        {
            bool IsExist=false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "select 1 from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID;";

            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                connection.Open();
                object result= command.ExecuteScalar();
                if (result!=null && int.TryParse(result.ToString(),out int x))
                    IsExist = true;
                
            }
            catch (Exception ex) { IsExist = false; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return IsExist;
        }

        public static byte GetPassedTestsCount(int LocalDrivingLicenseApplicationID)
        {
            byte PassedTestsCount = 0;

            SqlConnection connection= new SqlConnection(clsSettings.ConnectionString);
            string Query = "SELECT  count(TestAppointments.TestTypeID)" +
                          " FROM   LocalDrivingLicenseApplications INNER JOIN  TestAppointments" +
                          " ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID " +
                          "INNER JOIN  Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID " +
                          "where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and TestResult=1;";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                connection.Open();
                object result= command.ExecuteScalar();
                if (result!=null && int.TryParse(result.ToString(),out int x))
                    PassedTestsCount = Convert.ToByte(result);
                
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return PassedTestsCount;
        }

    }
}
