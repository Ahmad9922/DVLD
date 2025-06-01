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
    public class clsCountryDataAccess
    {
        public class clsCountryData
        {
            public int? CountryID { get; set; }
            public string CountryName { get; set; }
        }

        public static bool GetCountryByID(clsCountryData CountryData)
        {
            string Query = @"SELECT * FROM Countries
                       	     where CountryID = @CountryID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, CountryData);

            }, Query, new SqlParameter("@CountryID", CountryData.CountryID));
        }


        public static bool GetCountryByName(clsCountryData CountryData)
        {
            string Query = @"SELECT * FROM Countries
                       	     where CountryName = @CountryName";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, CountryData);

            }, Query, new SqlParameter("@CountryName", CountryData.CountryName));
        }

        public static List<string> GetAllCountries()
        {
            string Query = @"SELECT * FROM Countries ORDER BY CountryName;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<string>(Command, 0);

            }, Query);
        }
    }
}
