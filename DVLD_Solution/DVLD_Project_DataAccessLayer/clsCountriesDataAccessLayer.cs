using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsCountriesDataAccessLayer
    {
        public static int GetCountryID(string CountryName)
        {
            int CountryID = -1;
            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "Select * from Countries where CountryName=@CountryName";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                 Connection.Open();
                 object result= Command.ExecuteScalar();
                 if ( result != null )
                    CountryID = (int)result;
            }
            catch (Exception ex) { CountryID = -1; clsSettings.LoggingAnException("DVLD", ex.Message);  }
            finally
            {
                Connection.Close();
            }

            return CountryID;
        }

        public static string GetCountryName(int CountryID)
        {
            string CountryName = "";
            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "Select CountryName from Countries where CountryID=@CountryID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryID", CountryID);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();
                if (result != null)
                    CountryName = (string)result;
            }
            catch (Exception ex) { CountryName = ""; clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally
            {
                Connection.Close();
            }

            return CountryName;
        }

        public static DataTable GetCountriesList()
        {
            DataTable CountriesTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsSettings.ConnectionString);
            string cmdText = "Select * from Countries order by CountryName;";
            SqlCommand Command = new SqlCommand(cmdText, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    CountriesTable.Load(Reader);

                Reader.Close();
            }

            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }

            finally { Connection.Close(); }
            return CountriesTable;

        }
    }
}
