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
    public class clsDetainDataAccess
    {
        public class clsDetainData
        {
            public int? DetainID { get; set; }
            public int LicenseID { get; set; }
            public DateTime DetainDate { get; set; }
            public decimal FineFees { get; set; }
            public int CreatedByUserID { get; set; }
            public bool IsReleased { get; set; }
            public DateTime? ReleaseDate { get; set; }
            public int? ReleasedByUserID { get; set; }
            public int? ReleaseApplicationID { get; set; }
        }

        public static bool GetDetainByDetainID(clsDetainData DetainedLicenseData)
        {
            string Query = @"SELECT * FROM DetainedLicenses
                       	     where DetainID = @DetainID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, DetainedLicenseData);

            }, Query, new SqlParameter("@DetainID", DetainedLicenseData.DetainID));
        }

        public static bool GetDetainByDetainedLicenseID(clsDetainData DetainedLicenseData)
        {
            string Query = @"SELECT * FROM DetainedLicenses
                       	     where LicenseID = @LicenseID AND IsReleased = 0;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, DetainedLicenseData);

            }, Query, new SqlParameter("@LicenseID", DetainedLicenseData.LicenseID));
        }

        public static int AddNew(clsDetainData DetainData)
        {
            string Query = @"INSERT INTO [dbo].[DetainedLicenses] ( 
                             [DetainDate], [FineFees], [CreatedByUserID], [IsReleased], [ReleaseDate], [ReleasedByUserID], [ReleaseApplicationID])
                             VALUES ( @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID)
                             SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, DetainData);
        }

        public static bool Update(clsDetainData DetainData)
        {
            string Query = @"UPDATE [dbo].[DetainedLicenses] SET 
                             [DetainDate] = @DetainDate,
                             [FineFees] = @FineFees,
                             [CreatedByUserID] = @CreatedByUserID,
                             [IsReleased] = @IsReleased,
                             [ReleaseDate] = @ReleaseDate,
                             [ReleasedByUserID] = @ReleasedByUserID,
                             [ReleaseApplicationID] = @ReleaseApplicationID WHERE DetainID = @DetainID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, DetainData) > 0;

        }

        public static DataTable GetDetainsList()
        {
            string Query = @"SELECT * FROM DetainedLicenses_View";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }

        public static DataTable GetDetainsList(clsDataTypes.clsFilterData FilterData)
        {
            string Query = @"SELECT * FROM DetainedLicenses_View";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FilterData);

            }, Query);
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            string Query = @"SELECT R = 1 FROM DetainedLicenses
                             WHERE LicenseID = @LicenseID AND IsReleased = 0;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@LicenseID", LicenseID)) != null;
        }
    }
}
