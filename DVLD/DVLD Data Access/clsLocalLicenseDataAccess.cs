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
    public class clsLocalLicenseDataAccess
    {
        public class clsLicenseData
        {
            public int? LicenseID { get; set; }
            public int ApplicationID { get; set; }
            public int DriverID { get; set; }
            public int LicenseClass { get; set; }
            public DateTime IssueDate { get; set; }
            public DateTime ExpirationDate { get; set; }
            public string Notes { get; set; }
            public decimal PaidFees { get; set; }
            public bool IsActive { get; set; }
            public byte IssueReason { get; set; }
            public int CreatedByUserID { get; set; }
        }

        public static bool GetDrivingLicenseByID(clsLicenseData LicenseData)
        {
            string Query = @"SELECT * FROM Licenses
                       	     where LicenseID = @LicenseID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, LicenseData);

            }, Query, new SqlParameter("@LicenseID", LicenseData.LicenseID));
        }

        public static int IssueLocalDrivingLicense(clsLicenseData LicenseData)
        {
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

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, LicenseData);
        }

        public static bool Update(clsLicenseData LicenseData)
        {
            string Query = @"UPDATE [dbo].[Licenses] SET 
                             [ApplicationID] = @ApplicationID,
                             [DriverID] = @DriverID,
                             [LicenseClass] = @LicenseClass,
                             [IssueDate] = @IssueDate,
                             [ExpirationDate] = @ExpirationDate,
                             [Notes] = @Notes,
                             [PaidFees] = @PaidFees,
                             [IsActive] = @IsActive,
                             [IssueReason] = @IssueReason,
                             [CreatedByUserID] = @CreatedByUserID WHERE LicenseID = @LicenseID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, LicenseData) > 0;
        }

        public static DataTable GetLicenseList(int DriverID)
        {
            string Query = @"SELECT Licenses.LicenseID, Licenses.ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive
                             FROM Licenses INNER JOIN
                             LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID WHERE DriverID = @DriverID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }

        public static int GetLicenseID(int LocalDLAID)
        {
            string Query = @"SELECT LicenseID FROM Licenses
                             WHERE ApplicationID = 
                             (SELECT ApplicationID FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDLAID)";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, new SqlParameter("@LocalDLAID", LocalDLAID));
        }

        public static bool IsLocalLicenseIssued(int ApplicationID)
        {
            string Query = @"Select R = 1 From Licenses Where ApplicationID = @ApplicationID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@ApplicationID", ApplicationID)) != null;
        }
    }
}
