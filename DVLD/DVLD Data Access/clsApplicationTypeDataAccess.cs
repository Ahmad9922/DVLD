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
    public class clsApplicationTypeDataAccess
    {
        public class clsApplicationTypeData
        {
            public int? ApplicationTypeID { get; set; }
            public string ApplicationTypeTitle { get; set; }
            public decimal ApplicationFees { get; set; }
        }

        public static bool GetApplicationTypeByID(clsApplicationTypeData ApplicationTypeData)
        {
            string Query = @"SELECt * FROM ApplicationTypes
                       	     where ApplicationTypeID = @ApplicationTypeID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, ApplicationTypeData);

            }, Query, new SqlParameter("@ApplicationTypeID", ApplicationTypeData.ApplicationTypeID));
        }

        public static bool GetApplicationTypeByTitle(clsApplicationTypeData ApplicationTypeData)
        {
            string Query = @"SELECt * FROM ApplicationTypes
                       	     where ApplicationTypeTitle = @ApplicationTypeTitle;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, ApplicationTypeData);

            }, Query, new SqlParameter("@ApplicationTypeTitle", ApplicationTypeData.ApplicationTypeTitle));
        }

        public static bool Update(clsApplicationTypeData ApplicationTypeData)
        {
            string Query = @"UPDATE [dbo].[ApplicationTypes] SET 
                             [ApplicationTypeTitle] = @ApplicationTypeTitle,
                             [ApplicationFees] = @ApplicationFees WHERE ApplicationTypeID = @ApplicationTypeID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, ApplicationTypeData) > 0;
        }

        public static DataTable GetApplicationTypes()
        {
            string Query = @"SELECt * FROM ApplicationTypes;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }

        public static List<string> GetApplicationTypesTitles()
        {
            string Query = @"SELECT ApplicationTypeTitle FROM ApplicationTypes;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<string>(Command, 0);

            }, Query);
        }
    }
}
