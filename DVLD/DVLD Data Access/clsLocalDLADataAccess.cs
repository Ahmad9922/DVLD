using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccess
{
    public class clsLocalDLADataAccess
    {
        public static bool GetLocalDLAByID(ref int LocalDLAID, ref int ApplicationID, ref int LicenseClassID,
            ref short PassedTests, ref short CurrentTestTrials, ref int CurrentTestTypeID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT *, CurrentTestTrials =
                             (SELECT COUNT(TestResult) From Tests INNER JOIN
                             TestAppointments ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                             WHERE TestResult = 0 AND LocalDrivingLicenseApplicationID = @LocalDLAID AND TestTypeID = PassedTests + 1 ), CurrentTestTypeID = PassedTests + 1 FROM (
                             SELECT LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID,
                             LocalDrivingLicenseApplications.ApplicationID, LicenseClasses.LicenseClassID,
                             PassedTests = (SELECT Count(TestTypeID) FROM Tests INNER JOIN TestAppointments
                             ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                             WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LocalDLAID AND Tests.TestResult != 0) FROM
                             LocalDrivingLicenseApplications INNER JOIN
                             LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID
                             WHERE LocalDrivingLicenseApplicationID = @LocalDLAID ) LocalDrivingLicenseApplication";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDLAID", LocalDLAID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ApplicationID = Convert.ToInt32(reader["ApplicationID"]);
                    LicenseClassID = Convert.ToInt32(reader["LicenseClassID"]);
                    PassedTests = Convert.ToInt16(reader["PassedTests"]);
                    CurrentTestTrials = Convert.ToInt16(reader["CurrentTestTrials"]);
                    CurrentTestTypeID = Convert.ToInt16(reader["CurrentTestTypeID"]);
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

        public static int AddNewLocalDLA(int ApplicationID, int LicenseClassID)
        {
            int LocalDLAID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[LocalDrivingLicenseApplications]
                             ([ApplicationID], [LicenseClassID])
                             VALUES
                             (@ApplicationID, @LicenseClassID)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    LocalDLAID = InsertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return LocalDLAID;
        }

        public static bool UpdateLocalDLA(int LocalDLAID, int ApplicationID, int LicenseClassID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE [dbo].[LocalDrivingLicenseApplications]
                             SET [ApplicationID] = @ApplicationID
                                ,[LicenseClassID] = @LicenseClassID
                             WHERE LocalDrivingLicenseApplicationID = @LocalDLAID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDLAID", LocalDLAID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
         

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

        public static bool DeleteLocalDLA(int LocalDLAID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"DELETE FROM [LocalDrivingLicenseApplications]
                             WHERE LocalDrivingLicenseApplicationID = @LocalDLAID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDLAID", LocalDLAID);

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

        private static string _GetFilteringQueryByColumns(string ColumnName, string Filter)
        {
            string Query = @"SELECT LocalDrivingLicenseApplicationID AS LocalDLAID,
                             ClassName AS [Class Name], NationalNo AS [National No],
                             FullName AS [Full Name], ApplicationDate AS [Application Date],
                             PassedTestCount AS [Passed Tests], Status
                             FROM LocalDrivingLicenseApplications_View ";
            
            if (string.IsNullOrEmpty(Filter) || Filter == "All")
                return Query;

            if (ColumnName == "LocalDLAID")
                return Query += "WHERE LocalDrivingLicenseApplicationID LIKE '%' + @Filter + '%';";

            if (ColumnName == "Class Name")
                return Query += "WHERE ClassName LIKE '%' + @Filter + '%';";

            if (ColumnName == "National No")
                return Query += "WHERE NationalNo LIKE '%' + @Filter + '%';";

            if (ColumnName == "Full Name")
                return Query += "WHERE FullName LIKE '%' + @Filter + '%';";

            if (ColumnName == "Passed Tests")
                return Query += "WHERE PassedTestCount LIKE '%' + @Filter + '%';";

            if (ColumnName == "Status")
                return Query += "WHERE Status LIKE '%' + @Filter + '%';";

            return Query;
        }

        public static DataTable GetAllLocalDLA(string Filter = "", string ColumnName = "")
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = _GetFilteringQueryByColumns(ColumnName, Filter);

            SqlCommand command = new SqlCommand(Query, connection);

            if (!string.IsNullOrEmpty(Filter))
                command.Parameters.AddWithValue("@Filter", Filter);

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

        public static bool IsLocalDLAExist(int LocalDLAID)
        {
            object Result = null;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Select R = 1 From LocalDrivingLicenseApplications Where LocalDrivingLicenseApplicationID = @LocalDLAID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDLAID", LocalDLAID);

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

        public static bool IsApplicationRequiredOrCompleted(int ApplicantPersonID, int LicenseClassID)
        {
            object Result = null;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT R = 1 FROM Applications INNER JOIN LocalDrivingLicenseApplications
                             ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                             WHERE Applications.ApplicantPersonID = @ApplicantPersonID 
                             AND LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                             AND Applications.ApplicationStatus != 2;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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

        public static int GetApplicationID(int LocalDLAID)
        {
            int ApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT ApplicationID FROM LocalDrivingLicenseApplications
                             WHERE LocalDrivingLicenseApplicationID = @LocalDLAID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDLAID", LocalDLAID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    ApplicationID = InsertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return ApplicationID;
        }

    }
}
