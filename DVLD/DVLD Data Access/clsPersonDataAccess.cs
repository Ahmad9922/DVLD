using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using Dotools;

namespace DVLDDataAccess
{
    public class clsPersonDataAccess
    {
        public class clsPersonData
        {
            public int? PersonID { get; set; }
            public string NationalNo { get; set; }
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public string ThirdName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public byte Gendor { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public int CountryID { get; set; }
            public string ImagePath { get; set; }
        }


        public static bool GetPersonByID(clsPersonData PersonData)
        {
            string Query = @"SELECT * FROM People
                       	     Where PersonID = @PersonID";

            return clsAdoQueryExecutor.ExecuteQuery(Command => 
            {
               return clsAdoQueryExecutor.ExecuteReader(Command, PersonData);

            }, Query, new SqlParameter("@PersonID", PersonData.PersonID));
        }

        public static bool GetPersonByNationalNo(clsPersonData PersonData)
        {
            string Query = @"SELECT * FROM People
	                         where NationalNo = @NationalNo;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, PersonData);

            }, Query, new SqlParameter("@NationalNo", PersonData.NationalNo));
        }

        public static string GetImagePath(int PersonID)
        {
            string Query = "SELECT ImagePath FROM People WHERE PersonID = @PersonID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToString(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, new SqlParameter("@PersonID", PersonID));
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

        public static int AddNewPerson(clsPersonData PersonData)
        {
            string Query = @"INSERT INTO [dbo].[People]
                             ([NationalNo] ,[FirstName] ,[SecondName] ,[ThirdName]
                             ,[LastName] ,[DateOfBirth] ,[Gendor] ,[Address] ,[Phone]
                             ,[Email] ,[NationalityCountryID] ,[ImagePath])
                              VALUES
                             (@NationalNo ,@FirstName ,@SecondName ,@ThirdName ,@LastName
                             ,@DateOfBirth ,@Gendor ,@Address ,@Phone ,@Email
                             ,(Select CountryID From Countries Where CountryName = @NationalityCountryID)
                             ,@ImagePath)
                              SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));
                
            }, Query, PersonData);
        }

        public static bool UpdatePerson(clsPersonData PersonData)
        {
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
                             ,[NationalityCountryID] = (Select [CountryID] From Countries Where CountryName = @NationalityCountryID)
                             ,[ImagePath] = @ImagePath
                              WHERE PersonID = @PersonID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, PersonData) > 0;
        }

        public static bool DeletePerson(int PersonID)
        {
            string Query = @"DELETE FROM [People] WHERE PersonID = @PersonID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, new SqlParameter("@PersonID", PersonID) ) > 0;
        }

        public static DataTable GetAllPeople()
        {
            string Query = @"SELECT People.PersonID as [Person ID], People.NationalNo as [National No],
                             People.FirstName as [First Name], People.SecondName as [Second Name],
                             People.ThirdName as [Third Name], People.LastName as [Last Name],
                             People.DateOfBirth as [Date Of Birth],
                       	     CASE
                       	     When People.Gendor = 0 Then 'Male'
                       	     When People.Gendor = 1 Then 'Female'
                       	     End as Gendor,
                             People.Address, People.Phone, People.Email, Countries.CountryName as [Country Name]
                             FROM People INNER JOIN
                             Countries ON People.CountryID = Countries.CountryID ";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }

        public static DataTable GetAllPeople(clsDataTypes.clsFilterData FilterData)
        {
            string Query = @"SELECT * FROM ( SELECT People.PersonID as [Person ID], People.NationalNo as [National No],
                             People.FirstName as [First Name], People.SecondName as [Second Name],
                             People.ThirdName as [Third Name], People.LastName as [Last Name],
                             People.DateOfBirth as [Date Of Birth],
                       	     CASE
                       	     When People.Gendor = 0 Then 'Male'
                       	     When People.Gendor = 1 Then 'Female'
                       	     End as Gendor,
                             People.Address, People.Phone, People.Email, Countries.CountryName as [Country Name]
                             FROM People INNER JOIN
                             Countries ON People.CountryID = Countries.CountryID ) People_View";

            if (FilterData.FieldName == "Gendor")
            {
                FilterData.FilterStyle = clsDataTypes.clsFilterData.enFilterStyle.Equals;
            }

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FilterData);

            }, Query);
        }

        public static bool ISPersonExist(int PersonID)
        {
            string Query = @"Select R = 1 From People Where PersonID = @PersonID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@PersonID", PersonID)) != null;
        }

        public static bool ISPersonExist(string NationalNo)
        {
            string Query = @"Select R = 1 From People Where NationalNo = @NationalNo";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@NationalNo", NationalNo)) != null;
        }
    }
}
