using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dotools;

namespace DVLDDataAccess
{
    public class clsLocalDLADataAccess
    {
        public class clsLocalDrivingLicenseApplicationData
        {
            public int? LocalDrivingLicenseApplicationID { get; set; }
            public int ApplicationID { get; set; }
            public int LicenseClassID { get; set; }
            public byte CurrentTestTrials { get; set; }
            public byte PassedTests { get; set; }
            public int CurrentTestTypeID { get; set; }
        }


        public static bool GetLocalDLAByID(clsLocalDrivingLicenseApplicationData LocalDrivingLicenseApplicationData)
        {
            string Query = @"SELECT *, CAST( (SELECT COUNT(TestResult) From Tests INNER JOIN
                             TestAppointments ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                             WHERE TestResult = 0 AND LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationData AND TestTypeID = PassedTests + 1 ) AS tinyint) AS CurrentTestTrials, CurrentTestTypeID = CAST(PassedTests + 1 AS tinyint) FROM (
                             SELECT LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID,
                             LocalDrivingLicenseApplications.ApplicationID, LicenseClasses.LicenseClassID,
                             CAST( (SELECT Count(TestTypeID) FROM Tests INNER JOIN TestAppointments
                             ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                             WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationData AND Tests.TestResult != 0) AS tinyint) AS PassedTests FROM
                             LocalDrivingLicenseApplications INNER JOIN
                             LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationData ) LocalDrivingLicenseApplication ";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, LocalDrivingLicenseApplicationData);

            }, Query, new SqlParameter("@LocalDrivingLicenseApplicationData", LocalDrivingLicenseApplicationData.LocalDrivingLicenseApplicationID));
        }

        public static bool GetLocalDLAByApplicationID(clsLocalDrivingLicenseApplicationData LocalDrivingLicenseApplicationData)
        {
            string Query = @"DECLARE @LocalDrivingLicenseApplicationID INT;

                             SELECT @LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID FROM LocalDrivingLicenseApplications
                             WHERE ApplicationID = @ApplicationID;
                             
                             SELECT *, CAST( (SELECT COUNT(TestResult) From Tests INNER JOIN
                             TestAppointments ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                             WHERE TestResult = 0 AND LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = PassedTests + 1 ) AS tinyint) AS CurrentTestTrials, CurrentTestTypeID = CAST(PassedTests + 1 AS tinyint) FROM (
                             SELECT LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID,
                             LocalDrivingLicenseApplications.ApplicationID, LicenseClasses.LicenseClassID,
                             CAST( (SELECT Count(TestTypeID) FROM Tests INNER JOIN TestAppointments
                             ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                             WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND Tests.TestResult != 0) AS tinyint) AS PassedTests FROM
                             LocalDrivingLicenseApplications INNER JOIN
                             LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ) LocalDrivingLicenseApplication ";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, LocalDrivingLicenseApplicationData);

            }, Query, new SqlParameter("@ApplicationID", LocalDrivingLicenseApplicationData.ApplicationID));
        }

        public static int AddNew(clsLocalDrivingLicenseApplicationData LocalDrivingLicenseApplicationData)
        {
            string Query = @"INSERT INTO [dbo].[LocalDrivingLicenseApplications] ( 
            [ApplicationID], [LicenseClassID])
             VALUES ( @ApplicationID, @LicenseClassID)
             SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, LocalDrivingLicenseApplicationData);
        }

        public static bool Update(clsLocalDrivingLicenseApplicationData LocalDrivingLicenseApplicationData)
        {
            string Query = @"UPDATE [dbo].[LocalDrivingLicenseApplications] SET 
            [ApplicationID] = @ApplicationID,
            [LicenseClassID] = @LicenseClassID WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, LocalDrivingLicenseApplicationData) > 0;

        }

        public static bool Delete(int LocalDrivingLicenseApplicationID)
        {
            string Query = @"DELETE FROM [LocalDrivingLicenseApplications] WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, new SqlParameter("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID)) > 0;

        }

        public static DataTable GetAllLocalDLA()
        {
            string Query = @"SELECT * FROM ( SELECT LocalDrivingLicenseApplicationID AS [Local Driving License Application ID],
                             ClassName AS [Class Name], NationalNo AS [National No],
                             FullName AS [Full Name], ApplicationDate AS [Application Date],
                             PassedTestCount AS [Passed Tests], Status
                             FROM LocalDrivingLicenseApplications_View ) LocalDrivingLicenseApplications_View ";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }

        public static DataTable GetAllLocalDLA(clsDataTypes.clsFilterData FilterData)
        {
            string Query = @"SELECT * FROM ( SELECT LocalDrivingLicenseApplicationID AS [Local Driving License Application ID],
                             ClassName AS [Class Name], NationalNo AS [National No],
                             FullName AS [Full Name], ApplicationDate AS [Application Date],
                             PassedTestCount AS [Passed Tests], Status
                             FROM LocalDrivingLicenseApplications_View ) LocalDrivingLicenseApplications_View ";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FilterData);

            }, Query);
        }

        public static bool IsLocalDLAExist(int LocalDLAID)
        {
            string Query = @"Select R = 1 From LocalDrivingLicenseApplications Where LocalDrivingLicenseApplicationID = @LocalDLAID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@LocalDLAID", LocalDLAID)) != null;
        }

        public static bool IsApplicationRequiredOrCompleted(int ApplicantPersonID, int LicenseClassID)
        {
            string Query = @"SELECT R = 1 FROM Applications INNER JOIN LocalDrivingLicenseApplications
                             ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                             WHERE Applications.ApplicantPersonID = @ApplicantPersonID 
                             AND LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                             AND Applications.ApplicationStatus != 2;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter[]
            { 
                new SqlParameter("@ApplicantPersonID", ApplicantPersonID),
                new SqlParameter("@LicenseClassID", LicenseClassID)

            }) != null;
        }

        public static int GetApplicationID(int LocalDLAID)
        {
            string Query = @"SELECT ApplicationID FROM LocalDrivingLicenseApplications
                             WHERE LocalDrivingLicenseApplicationID = @LocalDLAID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, new SqlParameter("@LocalDLAID", LocalDLAID));
        }

        public static bool DoesAttendTestType(int LocalDLAID, int TestTypeID)
        {
            string Query = @"SELECT TOP 1 R = 1 FROM TestAppointments INNER JOIN Tests
                             ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                             WHERE LocalDrivingLicenseApplicationID = @LocalDLAID AND TestTypeID = @TestTypeID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter[]
            {
                 new SqlParameter("@LocalDLAID", LocalDLAID),
                 new SqlParameter("@TestTypeID", TestTypeID)
            
            }) != null;
        }

        public static bool DoesPassTestType(int LocalDLAID, int TestTypeID)
        {
            string Query = @"SELECT TOP 1 R = 1 FROM TestAppointments INNER JOIN Tests
                             ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                             WHERE LocalDrivingLicenseApplicationID = @LocalDLAID AND TestTypeID = @TestTypeID AND TestResult = 1";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter[]
            {
                 new SqlParameter("@LocalDLAID", LocalDLAID),
                 new SqlParameter("@TestTypeID", TestTypeID)

            }) != null;
        }

        public static byte TotalTrialsPerTest(int LocalDLAID, int TestTypeID)
        {
            string Query = @"SELECT COUNT(TestTypeID) FROM TestAppointments INNER JOIN Tests
                             ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                             WHERE LocalDrivingLicenseApplicationID = @LocalDLAID AND TestTypeID = @TestTypeID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToByte(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, new SqlParameter[]
            {
                 new SqlParameter("@LocalDLAID", LocalDLAID),
                 new SqlParameter("@TestTypeID", TestTypeID)

            });
        }
    }
}
