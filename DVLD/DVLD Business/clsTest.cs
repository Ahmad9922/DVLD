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

        private bool _AddNewTest()
        {
            this.TestID = clsTestDataAccess.AddNewTest(TestAppointment.TestAppointmentID, TestResult,
                Notes, CreatedByUser.UserID, TestAppointment.LocalDLA.LocalDLAID);

            return (this.TestID != -1);
        }

        private bool _UpdateTest()
        {
            return clsTestDataAccess.UpdateTest(TestID, TestAppointment.TestAppointmentID, TestResult,
                Notes, CreatedByUser.UserID);
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
            int TestAppointmentID = -1, CreatedByUserID = -1;
            bool TestResult = false;
            string Notes = null;

            if (clsTestDataAccess.GetTestByID(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTest(TestID, clsTestAppointment.Find(TestAppointmentID), TestResult, Notes, clsUser.Find(CreatedByUserID));
            }
            else
            {
                return null;
            }
        }
    }
}
