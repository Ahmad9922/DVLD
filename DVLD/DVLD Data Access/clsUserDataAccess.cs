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
    public class clsUserDataAccess
    {
        public class clsUserData
        {
            public int? UserID { get; set; }
            public int PersonID { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public bool IsActive { get; set; }
        }

        public static bool GetUserByID(clsUserData UserData)
        {
            string Query = @"SELECT * FROM Users
                       	     where UserID = @UserID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, UserData);

            }, Query, new SqlParameter("@UserID", UserData.UserID));
        }

        public static bool GetUserByUserName(clsUserData UserData)
        {
            string Query = @"SELECT * From Users
	                         where UserName = @UserName;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, UserData);

            }, Query, new SqlParameter("@UserName", UserData.UserName));
        }

        public static bool GetUserByUserNameAndPassword(clsUserData UserData)
        {
            string Query = @"SELECT * From Users
	                         where UserName = @UserName And Password = @Password;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, UserData);

            }, Query, new SqlParameter[] { new SqlParameter("@UserName", UserData.UserName),
                new SqlParameter("@Password", UserData.Password) });
        }

        public static int AddNewUser(clsUserData UserData)
        {
            string Query = @"INSERT INTO [dbo].[Users]
                            ([PersonID]
                            ,[UserName]
                            ,[Password]
                            ,[IsActive]) VALUES
                            (@PersonID
                            ,@UserName
                            ,@Password
                            ,@IsActive)
                             SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, UserData);
        }

        public static bool UpdateUser(clsUserData UserData)
        {
            string Query = @"UPDATE [dbo].[Users]
                             SET [PersonID] = @PersonID
                                ,[UserName] = @UserName
                                ,[Password] = @Password
                                ,[IsActive] = @IsActive
                                WHERE UsersID = @UsersID";

            int RowsAffected = clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, UserData);

            return RowsAffected > 0;
        }

        public static bool DeleteUser(int UserID)
        {
            string Query = @"DELETE FROM [Users] WHERE UserID = @UserID;";

            int RowsAffected = clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, new SqlParameter("@UserID", UserID));

            return RowsAffected > 0;
        }

        public static DataTable GetAllUsers()
        {
            string Query = @"SELECT Users.UserID as [User ID], Users.PersonID as [Person ID],
                             [Full Name] = People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName,
                             Users.UserName as [User Name], Users.IsActive as [Is Active]
                             FROM  Users INNER JOIN
                             People ON Users.PersonID = People.PersonID ";


            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }

        public static DataTable GetAllUsers(clsDataTypes.clsFilterData FilterData)
        {
            string Query = @"SELECT * FROM ( SELECT Users.UserID as [User ID], Users.PersonID as [Person ID],
                             [Full Name] = People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName,
                             Users.UserName as [User Name], Users.IsActive as [Is Active]
                             FROM  Users INNER JOIN
                             People ON Users.PersonID = People.PersonID ) Users_View ";


            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FilterData);

            }, Query);
        }

        public static bool ISUserExist(int UserID)
        {
            string Query = @"Select R = 1 From Users Where UserID = @UserID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@UserID", UserID)) != null;
        }

        public static bool ISUserExist(string UserName)
        {
            string Query = @"Select R = 1 From Users Where UserName = @UserName";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@UserName", UserName)) != null;
        }

        public static bool IsPersonExist(int PersonID)
        {
            string Query = @"Select R = 1 From Users Where PersonID = @PersonID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@PersonID", PersonID)) != null;
        }
    }
}
