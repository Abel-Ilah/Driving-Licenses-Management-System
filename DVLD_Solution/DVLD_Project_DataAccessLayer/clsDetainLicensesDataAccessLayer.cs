using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public static class clsDetainLicensesDataAccessLayer
    {

        public static int AddNewDetain(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            int RecordID = -1;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string Query = " Insert Into  DetainedLicenses Values(@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,@IsReleased,@ReleaseDate,@ReleasedByUserID,@ReleaseApplicationID);select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            command.Parameters.AddWithValue("@DetainDate", DetainDate);

            command.Parameters.AddWithValue("@FineFees", FineFees);

            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            command.Parameters.AddWithValue("@IsReleased", IsReleased);

            if (ReleaseDate.HasValue)
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate.Value);
            else command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);

            if (ReleasedByUserID.HasValue)
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID.Value);
            else command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);

            if (ReleaseApplicationID.HasValue)
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID.Value);
            else command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int x))
                {
                    RecordID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return RecordID;

        }

        public static bool UpdateDetain(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string Query = "Update DetainedLicenses set LicenseID=@LicenseID,DetainDate=@DetainDate,FineFees=@FineFees," +
                           "CreatedByUserID=@CreatedByUserID,IsReleased=@IsReleased,ReleaseDate=@ReleaseDate," +
                           "ReleasedByUserID=@ReleasedByUserID,ReleaseApplicationID=@ReleaseApplicationID " +
                           " where DetainID = @DetainID ;";


            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            command.Parameters.AddWithValue("@DetainDate", DetainDate);

            command.Parameters.AddWithValue("@FineFees", FineFees);

            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            command.Parameters.AddWithValue("@IsReleased", IsReleased);

            if (ReleaseDate.HasValue)
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate.Value);
            else command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);

            if (ReleasedByUserID.HasValue)
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID.Value);
            else command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);

            if (ReleaseApplicationID.HasValue)
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID.Value);
            else command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);


            try
            {
                connection.Open();
               
                if (command.ExecuteNonQuery()>0)
                   IsUpdated= true;
                
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return IsUpdated ;

        }

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable Table = new DataTable();

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = "SELECT  DetainedLicenses.DetainID, DetainedLicenses.LicenseID, DetainedLicenses.DetainDate," +
                           " DetainedLicenses.IsReleased, DetainedLicenses.ReleaseDate, DetainedLicenses.FineFees, People.NationalNo," +
                           " FullName = People.FirstName+' '+ People.SecondName + ' '+ISNULL(People.ThirdName, '') +' '+ People.LastName " +
                           " FROM DetainedLicenses INNER JOIN  Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID " +
                           "INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID " +
                           "INNER JOIN People ON Drivers.PersonID = People.PersonID";
            SqlCommand command=new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    Table.Load(reader);

                reader.Close();
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }

            return Table;
        }

        public static bool IsLicenseDetained(int LocalLicenseID)
        {
            bool IsDetainedLicense = false;
            
            SqlConnection connection=new SqlConnection(clsSettings.ConnectionString);

            string Query = "select 1 from DetainedLicenses where LicenseID=@LocalLicenseID and IsReleased=0;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);
            try
            {
                connection.Open();
                object result=command.ExecuteScalar();
                if (result!=null && int.TryParse(result.ToString(),out int x ) && x==1)
                {
                    IsDetainedLicense=true;
                }
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return IsDetainedLicense;
        }

        public static bool GetLastDetainInfo(int LicenseID,ref int DetainID,ref DateTime DetainDate,ref decimal FineFees,ref int CreatedByUserID,ref bool IsReleased,ref DateTime? ReleaseDate,ref int? ReleasedByUserID,ref int? ReleaseApplicationID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string Query = " select top 1 * from DetainedLicenses where LicenseID=@LicenseID " +
                           " Order By DetainDate Desc;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader=command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    DetainID = (int)reader[0];
                    DetainDate = Convert.ToDateTime(reader[2]);
                    FineFees = Convert.ToDecimal(reader[3]);
                    CreatedByUserID = (int)reader[4];
                    IsReleased = Convert.ToBoolean(reader[5]);

                    if (reader[6] == DBNull.Value)
                        ReleaseDate = null;
                    else
                        ReleaseDate = (DateTime)reader[6];


                    if (reader[7] == DBNull.Value)
                        ReleasedByUserID = null;
                    else
                        ReleasedByUserID = (int)reader[7];


                    if (reader[8] == DBNull.Value)
                        ReleaseApplicationID = null;
                    else
                        ReleaseApplicationID = (int)reader[8];
                }
                reader.Close();
            }
            catch (Exception ex) { clsSettings.LoggingAnException("DVLD", ex.Message); }
            finally { connection.Close(); }
            return IsFound;
        }
  

    }
}
