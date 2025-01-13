using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsDrivingLicenseClassesDataAccessLayer
    {

        public static DataTable GetLicenseClassesList()
        {
            DataTable LicenseClassesTable= new DataTable();

            SqlConnection connection=new SqlConnection(clsSettings.ConnectionString);
            string Query = "select * from LicenseClasses;";
            SqlCommand command=new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader= command.ExecuteReader();
                if (reader.HasRows) { LicenseClassesTable.Load(reader); }
                reader.Close();
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return LicenseClassesTable;

        }

        public static string GetLicenseClassName(int LicenseClassID) 
        {
            string ClassName = string.Empty;
            SqlConnection connection =new SqlConnection(clsSettings.ConnectionString);
            string Query = "Select ClassName from LicenseClasses where LicenseClassID=@LicenseClassID;";
           SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                object result= command.ExecuteScalar();

                if (result != null) ClassName = result.ToString();
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return ClassName;
        }

        public static bool GetLicenseClassInfo(int LicenseClassID,ref string ClassName,ref string ClassDescription,ref byte MinimumAllowedAge,ref byte DefaultValidityLength,ref decimal ClassFees) 
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "Select * from LicenseClasses where LicenseClassID=@LicenseClassID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ClassName= (string)reader[1];
                    ClassDescription= (string)reader[2];
                    MinimumAllowedAge= Convert.ToByte(reader[3]);
                    DefaultValidityLength= Convert.ToByte(reader[4]);
                    ClassFees = Convert.ToDecimal(reader[5]);

                    IsFound= true;
                }
                reader.Close();
            }
            catch (Exception ex) { IsFound = false; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return IsFound;
        }
    }
}
