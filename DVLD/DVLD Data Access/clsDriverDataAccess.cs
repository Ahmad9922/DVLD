using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccess
{
    public class clsDriverDataAccess
    {
        public static bool GetDriverByDriverID(int DriverID, ref int PersonID, ref int CreatedByUserID,
            ref DateTime CreatedDate)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Drivers
                       	     WHERE DriverID = @DriverID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    IsFound = true;
                }
                else
                {
                    IsFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool GetDriverByPersonID(ref int DriverID, int PersonID, ref int CreatedByUserID,
           ref DateTime CreatedDate)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Drivers
                       	     WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DriverID = Convert.ToInt32(reader["DriverID"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    IsFound = true;
                }
                else
                {
                    IsFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static int AddDriver(int PersonID, int CreatedByUserID)
        {
            int DriverID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[Drivers]
                             ([PersonID]
                             ,[CreatedByUserID]
                             ,[CreatedDate])
                             VALUES
                             (@PersonID
                             ,@CreatedByUserID
                             ,GETDATE())
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    DriverID = InsertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return DriverID;
        }

        static string _SetQuery(string Value, string ColumnName)
        {
            string Query = @"SELECt * FROM Drivers_View ";

            if (string.IsNullOrEmpty(Value) || Value == "All")
                return Query;

            switch (ColumnName)
            {
                case "DriverID":
                    return Query += "WHERE DriverID LIKE '%' + @Value + '%';";

                case "PersonID":
                    return Query += "WHERE PersonID LIKE '%' + @Value + '%';";

                case "NationalNo":
                    return Query += "WHERE NationalNo LIKE '%' + @Value + '%';";

                case "FullName":
                    return Query += "WHERE FullName LIKE '%' + @Value + '%';";

                case "NumberOfActiveLicenses":
                    return Query += "WHERE NumberOfActiveLicenses LIKE '%' + @Value + '%';";
            }

            return Query;
        }

        public static DataTable GetDrivers(string Value = "", string ColumnName = "")
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = _SetQuery(Value, ColumnName);

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Value", Value);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DT.Load(reader);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return DT;
        }

        public static bool IsPersonDriver(int PersonID)
        {
            object Result = null;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Select R = 1 From Drivers Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                Result = command.ExecuteScalar();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return Result != null;
        }

    }
}
