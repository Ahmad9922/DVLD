using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccess
{
    public class clsLocalLicenseDataAccess
    {
        public static bool GetDrivingLicenseByID(ref int LicenseID, ref int ApplicationID,
           ref int DriverID, ref int LicenseClassID, ref DateTime IssueDate, ref DateTime ExpirationDate,
           ref string Notes, ref float PaidFees, ref bool IsActive, ref short IssueReason, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Licenses
                       	     where LicenseID = @LicenseID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ApplicationID = Convert.ToInt32(reader["ApplicationID"]);
                    DriverID = Convert.ToInt32(reader["DriverID"]);
                    LicenseClassID = Convert.ToInt32(reader["LicenseClass"]);
                    IssueDate = Convert.ToDateTime(reader["IssueDate"]);
                    ExpirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    Notes = Convert.ToString(reader["Notes"]);
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                    IssueReason = Convert.ToInt16(reader["IssueReason"]);
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

        public static int IssueLocalDrivingLicense(int ApplicationID,
           int DriverID, int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate,
           string Notes, float PaidFees, bool IsActive, short IssueReason, int CreatedByUserID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[Licenses]
                             ([ApplicationID] ,[DriverID] ,[LicenseClass] ,[IssueDate] ,[ExpirationDate]
                             ,[Notes] ,[PaidFees] ,[IsActive] ,[IssueReason] ,[CreatedByUserID])
                             VALUES
                             (@ApplicationID
                             ,@DriverID
                             ,@LicenseClassID
                             ,@IssueDate
                             ,@ExpirationDate
                             ,@Notes
                             ,@PaidFees
                             ,@IsActive
                             ,@IssueReason
                             ,@CreatedByUserID)
                             SELECT SCOPE_IDENTITY();
 
                             UPDATE Applications SET ApplicationStatus = 3, LastStatusDate = GETDATE()
                             WHERE ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

            if (string.IsNullOrEmpty(Notes))
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notes", Notes);

            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
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

        public static bool UpdateDrivingLicense(int LicenseID, int ApplicationID,
           int DriverID, int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate,
           string Notes, float PaidFees, bool IsActive, short IssueReason, int CreatedByUserID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE [dbo].[Licenses]
                             SET [ApplicationID] = @ApplicationID
                                ,[DriverID] = @DriverID
                                ,[LicenseClass] = @LicenseClassID
                                ,[IssueDate] = @IssueDate
                                ,[ExpirationDate] = @ExpirationDate
                                ,[Notes] = @Notes
                                ,[PaidFees] = @PaidFees
                                ,[IsActive] = @IsActive
                                ,[IssueReason] = @IssueReason
                                ,[CreatedByUserID] = @CreatedByUserID
                                 WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

            if (string.IsNullOrEmpty(Notes))
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notes", Notes);

            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return RowsAffected > 0;
        }

        static private string GetFilteringQueryByColumns(string ColumnName)
        {
            string Query = @"SELECT Licenses.LicenseID, Licenses.ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive
                             FROM Licenses INNER JOIN
                             LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID ";

            if (ColumnName == "DriverID")
                return Query += "WHERE DriverID = @Value;";

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

        public static int GetLicenseID(int LocalDLAID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT LicenseID FROM Licenses
                             WHERE ApplicationID = 
                             (SELECT ApplicationID FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDLAID)";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDLAID", LocalDLAID);
          
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

        public static bool IsLocalLicenseIssued(int ApplicationID)
        {
            object Result = null;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Select R = 1 From Licenses Where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
