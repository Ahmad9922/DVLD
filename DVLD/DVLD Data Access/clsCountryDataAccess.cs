using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccess
{
    public class clsCountryDataAccess
    {
        public static List<string> GetAllCountries()
        {
            List<string> lCountries = new List<string>();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Countries ORDER BY CountryName;";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lCountries.Add(Convert.ToString(reader["CountryName"]));
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return lCountries;
        }
    }
}
