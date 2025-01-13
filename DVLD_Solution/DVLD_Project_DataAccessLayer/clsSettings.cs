using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Configuration;
namespace DataAccessLayer
{
    public static class clsSettings
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        
        public static void LoggingAnException(string SourceName, string ExceptionDetails)
        {
            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");
            }
            EventLog.WriteEntry(SourceName, ExceptionDetails, EventLogEntryType.Error);
        }
        public static Dictionary<string,int> GetGeneralStatistics()
        {
            Dictionary<string, int> Record = null;

            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "select * from GeneralStatistics";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
             SqlDataReader reader = command.ExecuteReader();
             if (reader.Read())
             {
                    Record = new Dictionary<string, int>
                    {
                        { "PeopleCount", Convert.ToInt32(reader[0]) },
                        { "UsersCount", Convert.ToInt32(reader[1]) },
                        { "DriversCount", Convert.ToInt32(reader[2]) },
                        { "LocalLicensesCount", Convert.ToInt32(reader[3]) },
                        { "InternationalLicensesCount", Convert.ToInt32(reader[4]) },
                        { "DetainedLicensesCount", Convert.ToInt32(reader[5]) }
                    };
                }
            }
            catch (Exception) { }
            finally { connection.Close(); }
            return Record;
        }
    
    
    }

    
}
