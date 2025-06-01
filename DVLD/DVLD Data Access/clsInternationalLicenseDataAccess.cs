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
    public class clsInternationalLicenseDataAccess
    {
        public class clsInternationalLicenseData
        {
            public int? InternationalLicenseID { get; set; }
            public int ApplicationID { get; set; }
            public int DriverID { get; set; }
            public int IssuedUsingLocalLicenseID { get; set; }
            public DateTime IssueDate { get; set; }
            public DateTime ExpirationDate { get; set; }
            public bool IsActive { get; set; }
            public int CreatedByUserID { get; set; }

        }

        public static bool GetInternationalLicenseByID(clsInternationalLicenseData InternationalLicenseData)
        {
            string Query = @"SELECT * FROM InternationalLicenses
                       	     where InternationalLicenseID = @InternationalLicenseID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, InternationalLicenseData);

            }, Query, new SqlParameter("@InternationalLicenseID", InternationalLicenseData.InternationalLicenseID));
        }

        public static int Add(clsInternationalLicenseData InternationalLicenseData)
        {
            string Query = @"INSERT INTO [dbo].[InternationalLicenses] ( 
            [ApplicationID], [DriverID], [IssuedUsingLocalLicenseID], [IssueDate], [ExpirationDate], [IsActive], [CreatedByUserID])
             VALUES ( @ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID)
             SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, InternationalLicenseData);
        }

        public static bool Update(clsInternationalLicenseData InternationalLicenseData)
        {
            string Query = @"UPDATE [dbo].[InternationalLicenses] SET 
                             [ApplicationID] = @ApplicationID,
                             [DriverID] = @DriverID,
                             [IssuedUsingLocalLicenseID] = @IssuedUsingLocalLicenseID,
                             [IssueDate] = @IssueDate,
                             [ExpirationDate] = @ExpirationDate,
                             [IsActive] = @IsActive,
                             [CreatedByUserID] = @CreatedByUserID WHERE InternationalLicenseID = @InternationalLicenseID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, InternationalLicenseData) > 0;
        }

        public static bool IsInternationalDrivingLicenseIssued(int IssuedUsingLocalLicenseID)
        {
            string Query = @"Select R = 1 From InternationalLicenses Where IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID)) != null;
        }

        public static DataTable GetLicenseList()
        {
            string Query = @"SELECT InternationalLicenseID AS [Int License ID], ApplicationID AS [Application ID],
                             DriverID AS [Driver ID], IssuedUsingLocalLicenseID AS [L License ID], IssueDate AS [Issue Date],
                             ExpirationDate AS [Expiration Date], IsActive AS [Is Active]
                             FROM InternationalLicenses;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }

        public static DataTable GetLicenseList(clsDataTypes.clsFilterData FilterData)
        {
            string Query = @"SELECT * FROM ( SELECT InternationalLicenseID AS [Int License ID], ApplicationID AS [Application ID],
                             DriverID AS [Driver ID], IssuedUsingLocalLicenseID AS [L License ID], IssueDate AS [Issue Date],
                             ExpirationDate AS [Expiration Date], IsActive AS [Is Active]
                             FROM InternationalLicenses ) InternationalLicenses_View ";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FilterData);

            }, Query);
        }
    }
}
