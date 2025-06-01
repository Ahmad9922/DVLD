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
    public class clsDriverDataAccess
    {
        public class clsDriverData
        {
            public int? DriverID { get; set; }
            public int PersonID { get; set; }
            public int CreatedByUserID { get; set; }
            public DateTime CreatedDate { get; set; }
        }

        public static bool GetDriverByDriverID(clsDriverData DriverData)
        {
            string Query = @"SELECT * FROM Drivers
                       	     WHERE DriverID = @DriverID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, DriverData);

            }, Query, new SqlParameter("@DriverID", DriverData.DriverID));
        }

        public static bool GetDriverByPersonID(clsDriverData DriverData)
        {
            string Query = @"SELECT * FROM Drivers
                       	     WHERE PersonID = @PersonID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, DriverData);

            }, Query, new SqlParameter("@PersonID", DriverData.PersonID));
        }

        public static int Add(clsDriverData DriverData)
        {
            string Query = @"INSERT INTO [dbo].[Drivers] ( 
            [PersonID], [CreatedByUserID], [CreatedDate])
             VALUES ( @PersonID, @CreatedByUserID, @CreatedDate)
             SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, DriverData);
        }

        public static bool Update(clsDriverData DriverData)
        {
            string Query = @"UPDATE [dbo].[Drivers] SET 
            [PersonID] = @PersonID,
            [CreatedByUserID] = @CreatedByUserID,
            [CreatedDate] = @CreatedDate WHERE DriverID = @DriverID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, DriverData) > 0;
        }

        public static DataTable GetDrivers()
        {
            string Query = @"SELECT DriverID AS [Driver ID], PersonID AS [Person ID],
                             NationalNo AS [National No], FullName AS [Full Name],
                             CreatedDate AS [Created Date], NumberOfActiveLicenses AS
                             [Number Of Active Licenses]
                             FROM Drivers_View ";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }

        public static DataTable GetDrivers(clsDataTypes.clsFilterData FilterData)
        {
            string Query = @"SELECT * FROM ( SELECT DriverID AS [Driver ID], PersonID AS [Person ID],
                             NationalNo AS [National No], FullName AS [Full Name],
                             CreatedDate AS [Created Date], NumberOfActiveLicenses AS
                             [Number Of Active Licenses]
                             FROM Drivers_View ) Driver_View ";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FilterData);

            }, Query);
        }

        public static bool IsPersonDriver(int PersonID)
        {
            string Query = @"Select R = 1 From Drivers Where PersonID = @PersonID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@PersonID", PersonID)) != null;
        }
    }
}
