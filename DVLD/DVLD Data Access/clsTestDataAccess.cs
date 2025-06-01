using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dotools;

namespace DVLDDataAccess
{
    static public class clsTestDataAccess
    {
        public class clsTestData
        {
            public int? TestID { get; set; }
            public int? TestAppointmentID { get; set; }
            public bool TestResult { get; set; }
            public string Notes { get; set; }
            public int CreatedByUserID { get; set; }
        }

        public static bool GetByID(clsTestData TestData)
        {
            string Query = "SELECT * FROM Tests WHERE TestID = @TestID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, TestData);

            }, Query, new SqlParameter("@TestID", TestData.TestID));

        }

        public static int AddNew(clsTestData TestData)
        {
            string Query = @"INSERT INTO [dbo].[Tests] ( 
                             [TestResult], [Notes], [CreatedByUserID])
                             VALUES ( @TestResult, @Notes, @CreatedByUserID)
                             SELECT SCOPE_IDENTITY();

            UPDATE [dbo].[TestAppointments]
            SET
            [IsLocked] = 1
            WHERE TestAppointmentID = @TestAppointmentID;

            IF ((SELECT TestAppointments.RetakeTestApplicationID FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID ) iS NOT NULL)
            BEGIN
            UPDATE Applications 
            SET ApplicationStatus = 3
            WHERE ApplicationID = (SELECT TestAppointments.RetakeTestApplicationID FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID )
            END";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, TestData);
        }

        public static bool Update(clsTestData TestData)
        {
            string Query = @"UPDATE [dbo].[Tests] SET 
                             [TestResult] = @TestResult,
                             [Notes] = @Notes,
                             [CreatedByUserID] = @CreatedByUserID WHERE TestID = @TestID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, TestData) > 0;
        }
    }
}
