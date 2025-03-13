using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace DVLDDataAccess
{
    public class clsPersonDataAccess
    {
        public static bool GetPersonByID(ref int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName,
             ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref short Gendor, ref string Address, ref string Phone,
             ref string Email, ref string NationalityCountry, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName,
                             People.ThirdName, People.LastName, People.DateOfBirth, People.Gendor,
                             People.Address, People.Phone, People.Email, Countries.CountryName, 
                             People.ImagePath
                             FROM People INNER JOIN
                             Countries ON People.NationalityCountryID = Countries.CountryID
                       	     where PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    NationalNo = Convert.ToString(reader["NationalNo"]);
                    FirstName = Convert.ToString(reader["FirstName"]);
                    SecondName = Convert.ToString(reader["SecondName"]);
                    ThirdName = Convert.ToString(reader["ThirdName"]);
                    LastName = Convert.ToString(reader["LastName"]);
                    DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    Gendor = Convert.ToInt16(reader["Gendor"]);
                    Address = Convert.ToString(reader["Address"]);
                    Phone = Convert.ToString(reader["Phone"]);
                    Email = Convert.ToString(reader["Email"]);
                    NationalityCountry = Convert.ToString(reader["CountryName"]);
                    ImagePath = Convert.ToString(reader["ImagePath"]);
                    IsFound = true;
                }
                else
                {
                    IsFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool GetPersonByNationalNo(ref int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName,
             ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref short Gendor, ref string Address, ref string Phone,
             ref string Email, ref string NationalityCountry, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName,
                             People.ThirdName, People.LastName, People.DateOfBirth, 
                       	     People.Gendor,
                             People.Address, People.Phone, People.Email, Countries.CountryName, 
                             People.ImagePath
                             FROM People INNER JOIN
                             Countries ON People.NationalityCountryID = Countries.CountryID
	                         where NationalNo = @NationalNo;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    NationalNo = Convert.ToString(reader["NationalNo"]);
                    FirstName = Convert.ToString(reader["FirstName"]);
                    SecondName = Convert.ToString(reader["SecondName"]);
                    ThirdName = Convert.ToString(reader["ThirdName"]);
                    LastName = Convert.ToString(reader["LastName"]);
                    DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    Gendor = Convert.ToInt16(reader["Gendor"]);
                    Address = Convert.ToString(reader["Address"]);
                    Phone = Convert.ToString(reader["Phone"]);
                    Email = Convert.ToString(reader["Email"]);
                    NationalityCountry = Convert.ToString(reader["CountryName"]);
                    ImagePath = Convert.ToString(reader["ImagePath"]);
                    IsFound = true;
                }
                else
                {
                    IsFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static string GetImagePath(int PersonID)
        {
            string ImagePath = null;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT ImagePath FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                ImagePath = Convert.ToString(Result);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return ImagePath;
        }

        static private string GetImagePath(string ImagePath, string PreviousGuidPath)
        {
            if (!File.Equals(ImagePath, PreviousGuidPath))
                return @"C:\DVLD\Persons Images\" + Guid.NewGuid().ToString() + ".png";
            else
                return ImagePath;
        }

        private static void SetImageInImageFolder(string NewImagePath, string PreviousGuidPath, string NewGuidPath)
        {
            if (File.Equals(NewImagePath, PreviousGuidPath))
                return;

            if (!string.IsNullOrEmpty(NewImagePath))
                File.Copy(NewImagePath, NewGuidPath);

            if (!string.IsNullOrEmpty(PreviousGuidPath))
                File.Delete(PreviousGuidPath);
        }

        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName,
             string ThirdName, string LastName, DateTime DateOfBirth, short Gendor, string Address, string Phone,
             string Email, string NationalityCountry, string ImagePath)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[People]
           ([NationalNo]
           ,[FirstName]
           ,[SecondName]
           ,[ThirdName]
           ,[LastName]
           ,[DateOfBirth]
           ,[Gendor]
           ,[Address]
           ,[Phone]
           ,[Email]
           ,[NationalityCountryID]
           ,[ImagePath])
     VALUES
           (@NationalNo
           ,@FirstName
           ,@SecondName
           ,@ThirdName
           ,@LastName
           ,@DateOfBirth
           ,@Gendor
           ,@Address
           ,@Phone
           ,@Email
           ,(Select CountryID From Countries Where CountryName = @NationalityCountry)
           ,@ImagePath)
            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (string.IsNullOrEmpty(Email))
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Email", Email);

            command.Parameters.AddWithValue("@NationalityCountry", NationalityCountry);

            if (string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", clsDataAccessSettings.NewGuidPath);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    PersonID = InsertedID;
                }

                SetImageInImageFolder(ImagePath, "", GetImagePath(PersonID));
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return PersonID;
        }

        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName,
             string ThirdName, string LastName, DateTime DateOfBirth, short Gendor, string Address, string Phone,
             string Email, string NationalityCountry, string ImagePath)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE [dbo].[People]
                             SET [NationalNo] = @NationalNo
                             ,[FirstName] = @FirstName
                             ,[SecondName] = @SecondName
                             ,[ThirdName] = @ThirdName
                             ,[LastName] = @LastName
                             ,[DateOfBirth] = @DateOfBirth
                             ,[Gendor] = @Gendor
                             ,[Address] = @Address
                             ,[Phone] = @Phone
                             ,[Email] = @Email
                             ,[NationalityCountryID] = (Select [CountryID] From Countries Where CountryName = @NationalityCountry)
                             ,[ImagePath] = @ImagePath
                              WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (string.IsNullOrEmpty(Email))
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Email", Email);

            command.Parameters.AddWithValue("@NationalityCountry", NationalityCountry);

            string PreviousGuidPath = GetImagePath(PersonID);

            if (string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", GetImagePath(ImagePath, PreviousGuidPath));

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();

                SetImageInImageFolder(ImagePath, PreviousGuidPath, GetImagePath(PersonID));
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return RowsAffected > 0;
        }

        public static bool DeletePerson(int PersonID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"DELETE FROM [People] WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            string ImagePath = GetImagePath(PersonID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();

                if (!string.IsNullOrEmpty(ImagePath))
                    File.Delete(ImagePath);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return RowsAffected > 0;
        }

        private static string _GetFilterStatement(string ColumnName)
        {
            string FilterStatement = "";
          
            if (ColumnName == "PersonID")
                return FilterStatement += "WHERE PersonID LIKE '%' + @Filter + '%';";

            if (ColumnName == "NationalNo")
                return FilterStatement += "WHERE NationalNo LIKE '%' + @Filter + '%';";

            if (ColumnName == "FirstName")
                return FilterStatement += "WHERE FirstName LIKE '%' + @Filter + '%';";

            if (ColumnName == "SecondName")
                return FilterStatement += "WHERE SecondName LIKE '%' + @Filter + '%';";

            if (ColumnName == "ThirdName")
                return FilterStatement += "WHERE ThirdName LIKE '%' + @Filter + '%';";

            if (ColumnName == "LastName")
                return FilterStatement += "WHERE LastName LIKE '%' + @Filter + '%';";

            if (ColumnName == "Gendor")
                return FilterStatement += "WHERE Gendor Like @Filter;";

            if (ColumnName == "Phone")
                return FilterStatement += "WHERE Phone LIKE '%' + @Filter + '%';";

            if (ColumnName == "Email")
                return FilterStatement += "WHERE Email LIKE '%' + @Filter + '%';";

            return FilterStatement;
        }

        public static DataTable GetAllPeople(string Filter = "", string ColumnName = "")
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName,
                             People.ThirdName, People.LastName, People.DateOfBirth, 
                       	     CASE
                       	     When People.Gendor = 0 Then 'Male'
                       	     When People.Gendor = 1 Then 'Female'
                       	     End as Gendor,
                             People.Address, People.Phone, People.Email, Countries.CountryName
                             FROM People INNER JOIN
                             Countries ON People.NationalityCountryID = Countries.CountryID ";

            if (!string.IsNullOrEmpty(Filter))
                Query += _GetFilterStatement(ColumnName);

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Filter", Filter);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DT.Load(reader);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return DT;
        }

        public static bool ISPersonExist(int PersonID)
        {
            object Result = null;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Select R = 1 From People Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                Result = command.ExecuteScalar();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return Result != null;
        }

        public static bool ISPersonExist(string NationalNo)
        {
            object Result = null;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Select R = 1 From People Where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                Result = command.ExecuteScalar();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return Result != null;
        }
    }
}
