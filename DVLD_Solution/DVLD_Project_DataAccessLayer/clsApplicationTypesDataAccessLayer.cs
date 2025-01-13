using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsApplicationTypesDataAccessLayer
    {
        public static DataTable GetAllApplicationsTypes()
        {
            DataTable ApplicationsTypesTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "select ApplicationTypeID as ID,ApplicationTypeTitle as Title,ApplicationFees as Fees from ApplicationTypes;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    ApplicationsTypesTable.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex) { ApplicationsTypesTable = null; clsSettings.LoggingAnException("DVLD", ex.Message) ; } 
            finally {  Connection.Close();}

            return ApplicationsTypesTable;
        }

        public static bool UpdateApplicationTypeInfo(int ApplicationTypeID,string ApplicationTypeTitle,decimal ApplicationFees) 
        {
            bool IsUpdated = false;

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "Update ApplicationTypes set ApplicationTypeTitle=@ApplicationTypeTitle, ApplicationFees=@ApplicationFees" +
                            " where ApplicationTypeID=@ApplicationTypeID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            Command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

            try
            {
                Connection.Open();
                if (Command.ExecuteNonQuery() > 0)
                    IsUpdated = true;

            }
            catch (Exception ex) { IsUpdated = false; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { Connection.Close();}
            return IsUpdated;
        }

        public static bool FindApplicationType(int ApplicationTypeID,ref string ApplicationTypeTitle,ref decimal ApplicationFees)    
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "Select * from ApplicationTypes where ApplicationTypeID=@ApplicationTypeID;";

            SqlCommand Command =new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            try
            {
                Connection.Open();
                SqlDataReader reader=Command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationTypeTitle =(string) reader["ApplicationTypeTitle"];
                    ApplicationFees = (decimal)reader["ApplicationFees"];
                }
                reader.Close();
            }
            catch (Exception ex) { IsFound = false; clsSettings.LoggingAnException("DVLD", ex.Message); } 
            finally { Connection.Close();}
            return IsFound;
        }




    }
}
