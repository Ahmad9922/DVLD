using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLDBusiness.clsTestType;

namespace DVLDBusiness
{
    public class clsTest
    {
        public int TestID { get; set; }
        public clsTestAppointment TestAppointment { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public clsUser CreatedByUser { get; set; }
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode { get; private set; }

        public clsTest(clsTestAppointment TestAppointment, clsUser CreatedByUser)
        {
            this.TestID = -1;
            this.TestAppointment = TestAppointment;
            this.TestResult = false;
            this.Notes = string.Empty;
            this.CreatedByUser = CreatedByUser;

            this.Mode = enMode.AddNew;
        }

        private clsTest(int TestID, clsTestAppointment TestAppointment, bool TestResult, string Notes, clsUser CreatedByUser)
        {
            this.TestID = TestID;
            this.TestAppointment = TestAppointment;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUser = CreatedByUser;

            this.Mode = enMode.Update;
        }

        private clsTest(clsTestDataAccess.clsTestData TestData)
        {
            this.TestID = TestData.TestID.Value;
            this.TestAppointment = clsTestAppointment.Find(TestData.TestAppointmentID.Value);
            this.TestResult = TestData.TestResult;
            this.Notes = TestData.Notes;
            this.CreatedByUser = clsUser.Find(TestData.CreatedByUserID);
        }


        private bool _AddNewTest()
        {
            clsTestDataAccess.clsTestData TestData
            = new clsTestDataAccess.clsTestData()
            {
                TestID = null,
                TestAppointmentID = this.TestAppointment.TestAppointmentID,
                TestResult = this.TestResult,
                Notes = this.Notes,
                CreatedByUserID = this.CreatedByUser.UserID.Value,
            };

            this.TestID = clsTestDataAccess.AddNew(TestData);

            return (TestID != -1);

        }

        private bool _UpdateTest()
        {
            clsTestDataAccess.clsTestData TestData
            = new clsTestDataAccess.clsTestData()
            {
            
                TestID = this.TestID,
                TestAppointmentID = this.TestAppointment.TestAppointmentID,
                TestResult = this.TestResult,
                Notes = this.Notes,
                CreatedByUserID = this.CreatedByUser.UserID.Value,
            };

            return clsTestDataAccess.Update(TestData);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewTest())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTest();
            }

            return false;
        }

        static public clsTest Find(int TestID)
        {
            clsTestDataAccess.clsTestData TestData
            = new clsTestDataAccess.clsTestData();

            TestData.TestID = TestID;

            if (clsTestDataAccess.GetByID(TestData))
            {
                return new clsTest(TestData);
            }
            else
            {
                return null;
            }
        }
    }
}
