using System;
using DVLDDataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusiness
{
    public class clsCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        private clsCountry(int CountryID, string CountryName)
        {
            this.CountryID = CountryID = 0;
            this.CountryName = CountryName;
        }

        public static clsCountry Find(int CountryID)
        {
            clsCountryDataAccess.clsCountryData CountryData = new clsCountryDataAccess.clsCountryData();

            CountryData.CountryID = CountryID;

            if (clsCountryDataAccess.GetCountryByID(CountryData))
            {
                return new clsCountry(CountryID, CountryData.CountryName);
            }
            else
            {
                return null;
            }
        }

        public static clsCountry Find(string CountryName)
        {
            clsCountryDataAccess.clsCountryData CountryData = new clsCountryDataAccess.clsCountryData();

            CountryData.CountryName = CountryName;

            if (clsCountryDataAccess.GetCountryByName(CountryData))
            {
                return new clsCountry(CountryData.CountryID.Value, CountryName);
            }
            else
            {
                return null;
            }
        }

        public static List<string> CountriesList()
        {
           return clsCountryDataAccess.GetAllCountries(); 
        }
    }
}
