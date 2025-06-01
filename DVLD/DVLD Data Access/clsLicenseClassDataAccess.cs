using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dotools;

namespace DVLDDataAccess
{
    public class clsLicenseClassDataAccess
    {
        public class clsLicenseClassData
        {
            public int? LicenseClassID { get; set; }
            public string ClassName { get; set; }
            public string ClassDescription { get; set; }
            public byte MinimumAllowedAge { get; set; }
            public byte DefaultValidityLength { get; set; }
            public decimal ClassFees { get; set; }
        }

        public static bool GetLicenseClassByID(clsLicenseClassData LicenseClassData)
        {
            string Query = @"SELECt * FROM LicenseClasses
                       	     WHERE LicenseClassID = @LicenseClassID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, LicenseClassData);

            }, Query, new SqlParameter("@LicenseClassID", LicenseClassData.LicenseClassID));
        }

        public static bool GetLicenseClassByClassName(clsLicenseClassData LicenseClassData)
        {
            string Query = @"SELECt * FROM LicenseClasses
                       	     WHERE ClassName = @ClassName;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, LicenseClassData);

            }, Query, new SqlParameter("@ClassName", LicenseClassData.ClassName));
        }

        public static List<string> GetAllLicenseClasses()
        {
            string Query = @"SELECT ClassName FROM LicenseClasses;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<string>(Command, 0);

            }, Query);
        }
    }
}
