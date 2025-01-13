using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace DataAccessLayer
{
    public static class clsTestsAppointmentsDataAccessLayer
    {
        public static int AddNewTestAppointment(int testTypeID, int localDrivingLicenseApplicationID, DateTime date, decimal paidFees, int createdByUserID, bool isLocked)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "Insert into TestAppointments values(@testTypeID,@localDrivingLicenseApplicationID,@date,@paidFees,@createdByUserID,@isLocked);select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@testTypeID", testTypeID);
            command.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@paidFees", paidFees);
            command.Parameters.AddWithValue("@createdByUserID", createdByUserID);
            command.Parameters.AddWithValue("@isLocked", isLocked);
          
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int x))
                {
                    ID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex) { ID = -1; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return ID;

        }

        public static bool FindTestAppointment(int TestAppointmentID,ref int testTypeID, ref int localDrivingLicenseApplicationID,ref DateTime date,ref decimal paidFees,ref int createdByUserID,ref bool isLocked)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "Select * from TestAppointments where TestAppointmentID=@TestAppointmentID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            try
            {
                connection.Open();
                SqlDataReader reader= command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    testTypeID = Convert.ToInt32(reader[1]);
                    localDrivingLicenseApplicationID = (int)reader[2];
                    date = (DateTime)reader[3];
                    paidFees= Convert.ToDecimal(reader[4]);
                    createdByUserID = (int)reader[5];
                    isLocked = reader.GetBoolean(6);
                }
                reader.Close();
            }
            catch (Exception ex) { IsFound = false; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return IsFound;

        }

        public static bool UpdateTestAppointment(int TestAppointmentID, DateTime date, bool isLocked)
        {
            bool IsUpdated = false;
            
            SqlConnection connection =new SqlConnection(clsSettings.ConnectionString);
            string Query = "Update TestAppointments Set AppointmentDate=@date,IsLocked=@isLocked where TestAppointmentID=@TestAppointmentID;";

            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@isLocked", isLocked);

            try
            {
                connection.Open();
                if (command.ExecuteNonQuery()>0)
                    IsUpdated = true;
            }
            catch (Exception ex) { IsUpdated = false; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return IsUpdated;
           
        }

        public  static DataTable GetTestAppointments(int LocalDrivingLicenseApplicationID,byte TestTypeID)
        {
            DataTable table = new DataTable();

            SqlConnection connection=new SqlConnection(clsSettings.ConnectionString);
            string Query = "Select TestAppointmentID,AppointmentDate,PaidFees,IsLocked from TestAppointments where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and TestTypeID=@TestTypeID Order by AppointmentDate Desc;";
            SqlCommand command=new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader=command.ExecuteReader();
                if (reader.HasRows)
                {
                    table.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return table;
        }
       
  
    }

}
