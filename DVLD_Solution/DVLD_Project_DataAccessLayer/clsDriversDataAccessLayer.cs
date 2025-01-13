using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DataAccessLayer
{
    public static class clsDriversDataAccessLayer
    {
        public static int AddNewDriver(int PersonId,int CreatedByUserId,DateTime CreatedDate)
        {
            int DriverId = -1;

            SqlConnection connection=new SqlConnection(clsSettings.ConnectionString);
            string Query = "Insert Into Drivers values(@PersonId,@CreatedByUserId,@CreatedDate); select SCOPE_IDENTITY();";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonId", PersonId);
            command.Parameters.AddWithValue("@CreatedByUserId", CreatedByUserId);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

            try
            {
                connection.Open();
                object result=command.ExecuteScalar();
                if (result!=null && int.TryParse(result.ToString(),out int x))
                    DriverId = Convert.ToInt32(result);
                
            }
            catch (Exception ex) { DriverId = -1; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return DriverId;
        }

        public static bool FindDriver(int DriverID,ref int PersonID,ref int CreatedByUserID,ref DateTime CreatedDate)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "select * from Drivers where DriverID=@DriverID;";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader reader=command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = Convert.ToInt32(reader[1]);
                    CreatedByUserID = Convert.ToInt32(reader[2]);
                    CreatedDate= Convert.ToDateTime(reader[3]);

                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return IsFound;

        }

        public static int GetDriverID(int PersonID)
        {
            int DriverID = -1;
            SqlConnection connection=new SqlConnection(clsSettings.ConnectionString);
            string Query = "Select DriverID from Drivers where PersonID=@PersonID;";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                object result=command.ExecuteScalar();
                if (result!=null && int.TryParse(result.ToString(),out int x ))
                    DriverID = Convert.ToInt32(result);
                
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close();   }
            return DriverID;

        }

        public static DataTable GetAllDrivers()
        {
            DataTable DriversTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "select * from Drivers_View;";
            SqlCommand command =new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    DriversTable.Load(reader);
                reader.Close();
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return DriversTable;

        }

    }

}
