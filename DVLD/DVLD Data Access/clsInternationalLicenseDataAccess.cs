using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccess
{
    public class clsInternationalLicenseDataAccess
    {
        public static bool GetInternationalLicenseByID(int InternationalLicenseID, ref int ApplicationID,
            ref int DriverID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate,
            ref bool IsActive, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM InternationalLicenses
                       	     where InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ApplicationID = Convert.ToInt32(reader["ApplicationID"]);
                    DriverID = Convert.ToInt32(reader["DriverID"]);
                    IssuedUsingLocalLicenseID = Convert.ToInt32(reader["IssuedUsingLocalLicenseID"]);
                    IssueDate = Convert.ToDateTime(reader["IssueDate"]);
                    ExpirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
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

        public static int IssueInternationalDrivingLicense(int ApplicationID,
            int IssuedUsingLocalLicenseID, int CreatedByUserID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[InternationalLicenses]
                             ([ApplicationID]
                             ,[DriverID]
                             ,[IssuedUsingLocalLicenseID]
                             ,[IssueDate]
                             ,[ExpirationDate]
                             ,[IsActive]
                             ,[CreatedByUserID])
                             VALUES
                             (@ApplicationID
                             ,(SELECT DriverID FROM Licenses WHERE LicenseID = @IssuedUsingLocalLicenseID)
                             ,@IssuedUsingLocalLicenseID
                             ,GETDATE()
                             ,DATEADD(YEAR, 1, GETDATE())
                             ,1
                             ,@CreatedByUserID)
                             SELECT SCOPE_IDENTITY();

                             UPDATE Applications SET ApplicationStatus = 3, LastStatusDate = GETDATE()
                             WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    LicenseID = InsertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return LicenseID;
        }

        public static bool IsInternationalDrivingLicenseIssued(int LicenseID)
        {
            object Result = null;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Select R = 1 From InternationalLicenses Where IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", LicenseID);

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

        static private string GetFilteringQueryByColumns(string ColumnName)
        {
            string Query = @"SELECT InternationalLicenseID AS [Int License ID], ApplicationID AS [Application ID],
                             DriverID AS [Driver ID], IssuedUsingLocalLicenseID AS [L License ID], IssueDate AS [Issue Date],
                             ExpirationDate AS [Expiration Date], IsActive AS [Is Active]
                             FROM InternationalLicenses ";

            if (ColumnName == "DriverID")
                return Query += "WHERE DriverID LIKE '%' + @Value + '%';";

            if (ColumnName == "IsActive")
                return Query += "WHERE IsActive LIKE '%' + @Value + '%';";

            return Query;
        }

        public static DataTable GetLicenseList(string Value = "", string ColumnName = "")
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = GetFilteringQueryByColumns(ColumnName);

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

    }
}
