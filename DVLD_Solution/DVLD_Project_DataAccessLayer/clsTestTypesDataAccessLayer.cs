using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsTestTypesDataAccessLayer
    {
        public  static DataTable GetAllTestTypes()
        {
            DataTable TestTypesDataTable = new DataTable();

            SqlConnection connection =new SqlConnection(clsSettings.ConnectionString);
            string Query = "select TestTypeID as ID,TestTypeTitle as Title,TestTypeDescription as Description,TestTypeFees as Fees from TestTypes";
            SqlCommand command= new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    TestTypesDataTable.Load(reader);
                
                reader.Close();
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return TestTypesDataTable;
      
        }

        public static bool FindTestType(byte TestTypeID,ref string TestTypeTitle,ref string TestTypeDescription,ref decimal TestTypeFees)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "select TestTypeID as ID,TestTypeTitle as Title,TestTypeDescription as Description,TestTypeFees as Fees from TestTypes where TestTypeID=@TestTypeID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    TestTypeTitle = (string)reader[1];
                    TestTypeDescription = (string)reader[2];
                    TestTypeFees = (decimal)reader[3];
                }
                reader.Close();
            }
            catch (Exception ex) { IsFound = false; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return IsFound;
          
        }

        public static bool UpdateTestType(byte TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            bool IsUpdated = false;

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "Update TestTypes set TestTypeTitle=@TestTypeTitle, TestTypeDescription=@TestTypeDescription,TestTypeFees=@TestTypeFees" +
                            " where TestTypeID=@TestTypeID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            Command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            Command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);

            try
            {
                Connection.Open();
                if (Command.ExecuteNonQuery() > 0)
                    IsUpdated = true;

            }
            catch (Exception ex) { IsUpdated = false; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { Connection.Close(); }
            return IsUpdated;



        }
    }

    

}
