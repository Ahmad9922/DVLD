using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dotools;

namespace DVLDDataAccess
{
    public class clsTestAppointmentDataAccess
    {
        public class clsTestAppointmentData
        {
            public int? TestAppointmentID { get; set; }
            public int TestTypeID { get; set; }
            public int LocalDrivingLicenseApplicationID { get; set; }
            public int? RetakeTestApplicationID { get; set; }
            public DateTime AppointmentDate { get; set; }
            public decimal PaidFees { get; set; }
            public int CreatedByUserID { get; set; }
            public bool IsLocked { get; set; }
        }


        public static bool GetByID(clsTestAppointmentData TestAppointmentData)
        {
            string Query = "SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, TestAppointmentData);

            }, Query, new SqlParameter("@TestAppointmentID", TestAppointmentData.TestAppointmentID));
        }

        public static int Add(clsTestAppointmentData TestAppointmentData)
        {
            string Query = @"INSERT INTO [dbo].[TestAppointments] ( 
                             [TestTypeID], [LocalDrivingLicenseApplicationID], [RetakeTestApplicationID],
                             [AppointmentDate], [PaidFees], [CreatedByUserID], [IsLocked])
                             VALUES ( @TestTypeID, @LocalDrivingLicenseApplicationID, @RetakeTestApplicationID, 
                             @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked)
                             SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, TestAppointmentData);
        }


        public static bool Update(clsTestAppointmentData TestAppointmentData)
        {
            string Query = @"UPDATE [dbo].[TestAppointments] SET 
                             [TestTypeID] = @TestTypeID,
                             [LocalDrivingLicenseApplicationID] = @LocalDrivingLicenseApplicationID,
                             [RetakeTestApplicationID] = @RetakeTestApplicationID,
                             [AppointmentDate] = @AppointmentDate,
                             [PaidFees] = @PaidFees,
                             [CreatedByUserID] = @CreatedByUserID,
                             [IsLocked] = @IsLocked WHERE TestAppointmentID = @TestAppointmentID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, TestAppointmentData) > 0;
        }


        public static DataTable GetTestAppointments(int LocalDLAID, int TestTypeID)
        {
            string Query = @"SELECT TestAppointmentID as [Appointment ID],
                             AppointmentDate as [Appointment Date],
	                         PaidFees as [Paid Fees],
	                         IsLocked as [Is Locked] FROM TestAppointments
	                         WHERE LocalDrivingLicenseApplicationID = @LocalDLAID And TestTypeID = @TestTypeID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query, new SqlParameter[]
            {
               new SqlParameter("@LocalDLAID", LocalDLAID),
               new SqlParameter("@TestTypeID", TestTypeID)

            });
        }

        public static bool IsThereAnActiveAppointment(int LocalDLAID, int TestTypeID)
        {
            string Query = @"SELECT distinct R = 1 From TestAppointments
                             WHERE LocalDrivingLicenseApplicationID = @LocalDLAID And IsLocked = 0 And TestTypeID = @TestTypeID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter[]
            {
                new SqlParameter("@LocalDLAID", LocalDLAID),
                new SqlParameter("@TestTypeID", TestTypeID)

            }) != null;
        }
    }
}
