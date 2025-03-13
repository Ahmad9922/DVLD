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
        public clsCountry()
        {

        }

        public static List<string> CountriesList()
        {
           return clsCountryDataAccess.GetAllCountries(); 
        }
    }
}
