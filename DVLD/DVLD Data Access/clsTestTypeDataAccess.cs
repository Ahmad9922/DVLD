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
    public class clsTestTypeDataAccess
    {
        public class clsTestTypeData
        {
            public int? TestTypeID { get; set; }
            public string TestTypeTitle { get; set; }
            public string TestTypeDescription { get; set; }
            public decimal TestTypeFees { get; set; }
        }

        public static bool GetTestTypeByID(clsTestTypeData TestTypeData)
        {
            string Query = @"SELECt * FROM TestTypes
                       	     where TestTypeID = @TestTypeID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, TestTypeData);

            }, Query, new SqlParameter("@TestTypeID", TestTypeData.TestTypeID));
        }

        public static int AddNew(clsTestTypeData TestTypeData)
        {
            string Query = @"INSERT INTO [dbo].[TestTypes] ( 
                             [TestTypeTitle], [TestTypeDescription], [TestTypeFees])
                              VALUES ( @TestTypeTitle, @TestTypeDescription, @TestTypeFees)
                              SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, TestTypeData);
        }


        public static bool Update(clsTestTypeData TestTypeData)
        {
            string Query = @"UPDATE [dbo].[TestTypes] SET 
                             [TestTypeTitle] = @TestTypeTitle,
                             [TestTypeDescription] = @TestTypeDescription,
                             [TestTypeFees] = @TestTypeFees WHERE TestTypeID = @TestTypeID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, TestTypeData) > 0;
        }

        public static DataTable GetTestTypes()
        {
            string Query = @"SELECt * FROM TestTypes;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }
    }
}
