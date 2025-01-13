using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsTestsDataAccessLayer
    {
        public static int AddNewTest(int TestAppointmentID,bool Result,string Notes,int CreatedByUserID)
        {
            int TestID = -1;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "insert Into Tests values(@TestAppointmentID,@Result,@Notes,@CreatedByUserID);select SCOPE_IDENTITY();";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@Result", Result);

            if (string.IsNullOrEmpty(Notes))
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notes", Notes);

            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
               object result= command.ExecuteScalar();
                if (result!=null && int.TryParse(result.ToString(),out int x))
                    TestID = Convert.ToInt32(result);
                
            }
            catch (Exception ex) { TestID = -1; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return TestID;
        }

        public static DataTable GetAllTestsOfPerson(int TestAppointmentID) 
        { 
            DataTable TestsTable=new DataTable();
            SqlConnection connection=new SqlConnection(clsSettings.ConnectionString);
            string Query = "Select * from Tests where TestAppointmentID=@TestAppointmentID;";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            try
            {
                connection.Open();
                SqlDataReader reader=command.ExecuteReader();
                if (reader.HasRows)
                    TestsTable.Load(reader);
                reader.Close();
                
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return TestsTable;
        }

        public static bool DidPersonPassTheExam(int LocalDrivingLicenseApplicationID,byte TestTypeID)
        {
            bool PersonPassedTheExam = false;
            SqlConnection connection=new SqlConnection(clsSettings.ConnectionString);
            string Query = "SELECT 1 FROM LocalDrivingLicenseApplications INNER JOIN TestAppointments  " +
                "ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID" +
                " INNER JOIN Tests " +
                "ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID " +
                "where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID" +
                " and TestTypeID=@TestTypeID and TestResult=1;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();
                  object result=command.ExecuteScalar();
                if (result!=null && int.TryParse(result.ToString(),out int x) && x==1)
                    PersonPassedTheExam = true;
                
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close (); }
            return PersonPassedTheExam;
        }

    }
}
