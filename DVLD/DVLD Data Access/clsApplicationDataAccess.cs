using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Dotools;

namespace DVLDDataAccess
{
    public class clsApplicationDataAccess
    {
        public class clsApplicationData
        {
            public int? ApplicationID { get; set; }
            public int ApplicantPersonID { get; set; }
            public DateTime ApplicationDate { get; set; }
            public int ApplicationTypeID { get; set; }
            public byte ApplicationStatus { get; set; }
            public DateTime LastStatusDate { get; set; }
            public decimal PaidFees { get; set; }
            public int CreatedByUserID { get; set; }
        }

        public static bool GetApplicationByID(clsApplicationData ApplicationData)
        {
            string Query = @"SELECT * FROM Applications
                             WHERE ApplicationID = @ApplicationID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, ApplicationData);

            }, Query, new SqlParameter("@ApplicationID", ApplicationData.ApplicationID));
        }

        public static int Add(clsApplicationData ApplicationData)
        {
            string Query = @"INSERT INTO [dbo].[Applications] ( 
                             [ApplicantPersonID], [ApplicationDate], [ApplicationTypeID], [ApplicationStatus], [LastStatusDate], [PaidFees], [CreatedByUserID])
                              VALUES ( @ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID)
                              SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, ApplicationData);
        }


        public static bool Update(clsApplicationData ApplicationData)
        {
            string Query = @"UPDATE [dbo].[Applications] SET
                             [ApplicantPersonID] = @ApplicantPersonID,
                             [ApplicationDate] = @ApplicationDate,
                             [ApplicationTypeID] = @ApplicationTypeID,
                             [ApplicationStatus] = @ApplicationStatus,
                             [LastStatusDate] = @LastStatusDate,
                             [PaidFees] = @PaidFees,
                             [CreatedByUserID] = @CreatedByUserID WHERE ApplicationID = @ApplicationID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, ApplicationData) > 0;
        }

        public static bool CancelApplication(int ApplicationID)
        {
            string Query = @"IF ((SELECT ApplicationStatus FROM Applications WHERE ApplicationID = @ApplicationID) != 3)
                             BEGIN
                             UPDATE [dbo].[Applications]
                             SET [ApplicationStatus] = 2
                             WHERE ApplicationID = @ApplicationID;

                             UPDATE Applications SET LastStatusDate = GETDATE()
                             WHERE ApplicationID = @ApplicationID;

                             END";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, new SqlParameter("@ApplicationID", ApplicationID)) > 0;
        }

        public static bool IsApplicationCancelled(int ApplicationID)
        {
            string Query = @"SELECT R = 1 FROM Applications
                             WHERE ApplicationID = @ApplicationID
                             AND Applications.ApplicationStatus = 2;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@ApplicationID", ApplicationID)) != null;
        }

        public static bool IsApplicationCompleted(int ApplicationID)
        {
            string Query = @"SELECT R = 1 FROM Applications
                             WHERE ApplicationID = @ApplicationID 
                             AND Applications.ApplicationStatus = 3;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@ApplicationID", ApplicationID)) != null;
        }

        public static DataTable GetApplications()
        {
            string Query = @"SELECT * FROM ( SELECT ApplicationID AS [Application ID], CONCAT_WS(' ', FirstName, SecondName, ThirdName, LastName) AS [Full Name],
                                             ApplicationDate AS [Application Date], ApplicationTypeTitle AS [Application Type Title],
                                             
                                             CASE
                                             WHEN ApplicationStatus = 1 THEN 'New'
                                             WHEN ApplicationStatus = 2 THEN 'Cancelled'
                                             WHEN ApplicationStatus = 3 THEN 'Completed'
                                             END AS [Application Status], PaidFees AS [Paid Fees], UserName AS [Created By User]
                                             
                                             FROM Applications INNER JOIN
                                             People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN
                                             ApplicationTypes ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID INNER JOIN
                                             Users ON Applications.CreatedByUserID = Users.UserID ) Applications_View";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);

        }

        public static DataTable GetApplications(clsDataTypes.clsFilterData FilterData)
        {
            string Query = @"SELECT * FROM ( SELECT ApplicationID AS [Application ID], CONCAT_WS(' ', FirstName, SecondName, ThirdName, LastName) AS [Full Name],
                                             ApplicationDate AS [Application Date], ApplicationTypeTitle AS [Application Type Title],
                                             
                                             CASE
                                             WHEN ApplicationStatus = 1 THEN 'New'
                                             WHEN ApplicationStatus = 2 THEN 'Cancelled'
                                             WHEN ApplicationStatus = 3 THEN 'Completed'
                                             END AS [Application Status], PaidFees AS [Paid Fees], UserName AS [Created By User]
                                             
                                             FROM Applications INNER JOIN
                                             People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN
                                             ApplicationTypes ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID INNER JOIN
                                             Users ON Applications.CreatedByUserID = Users.UserID ) Applications_View";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FilterData);

            }, Query);

        }
    }
}
