using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusiness
{
    public class clsTestAppointment
    {

        public int TestAppointmentID { get; private set; }
        public clsTestType TestType { get; private set; }
        public clsLocalDLA LocalDLA { get; private set; }
        public clsApplication RetakeTestApplication { get; set; }
        public DateTime AppointmentDate { get; set; }
        public float PaidFees { get; private set; }
        public clsUser CreatedByUser { get; private set; }
        public bool IsLocked { get; private set; }

        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode { get; private set; }

        private clsTestAppointment(clsLocalDLA LocalDLA, clsApplication RetakeTestApplication, clsUser CreatedByUser)
        {
            this.TestAppointmentID = -1;
            this.LocalDLA = LocalDLA;
            this.RetakeTestApplication = RetakeTestApplication;
            this.TestType = _SetTestTypeByPassedTest(LocalDLA.PassedTests);
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = TestType.Fees;
            this.CreatedByUser = CreatedByUser;
            this.IsLocked = true;

            Mode = enMode.AddNew;
        }

        private clsTestAppointment(int TestAppointmentID, clsTestType TestType, clsLocalDLA LocalDLA, 
            clsApplication RetakeTestApplication, DateTime AppointmentDate, float PaidFees, clsUser CreatedByUser,
            bool IsLocked)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestType = TestType;
            this.LocalDLA = LocalDLA;
            this.RetakeTestApplication = RetakeTestApplication;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUser = CreatedByUser;
            this.IsLocked = IsLocked;

            Mode = enMode.Update;
        }

        private clsTestType _SetTestTypeByPassedTest(short PassedTest)
        {
            if (PassedTest < 3)
                return clsTestType.Find(PassedTest + 1);
            else
                return null;
        }

        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentDataAccess.AddNewTestAppointment(TestType.TestTypeID, LocalDLA.LocalDLAID,
                RetakeTestApplication?.ApplicationID ?? -1,
                AppointmentDate, PaidFees, CreatedByUser.UserID, !IsLocked);

            return (this.TestAppointmentID != -1);
        }

        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentDataAccess.UpdateTestAppointment(TestAppointmentID, TestType.TestTypeID, LocalDLA.LocalDLAID,
                RetakeTestApplication?.ApplicationID ?? -1,
                AppointmentDate, PaidFees, CreatedByUser.UserID, IsLocked);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewTestAppointment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTestAppointment();
            }

            return false;
        }

        static public clsTestAppointment Find(int TestAppointmentID)
        {
            int TestTypeID = -1, LocalDLAID = -1, RetakeTestApplicationID = -1, CreatedByUserID = -1;
            DateTime AppointmentDate = DateTime.Now;
            float PaidFees = 0;
            bool IsLocked = false;


            if (clsTestAppointmentDataAccess.GetTestAppointmentByID(TestAppointmentID, ref TestTypeID, ref LocalDLAID,
                ref RetakeTestApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked))
            {
                return new clsTestAppointment(TestAppointmentID, clsTestType.Find(TestTypeID), clsLocalDLA.Find(LocalDLAID),
                   clsApplication.Find(RetakeTestApplicationID), AppointmentDate, PaidFees, clsUser.Find(CreatedByUserID), IsLocked);
            }
            else
            {
                return null;
            }
        }

        static public clsTestAppointment Add(clsLocalDLA LocalDLA, clsUser CreatedByUser, clsApplication RetakeTestApplication = null)
        {
            if (LocalDLA != null && CreatedByUser != null)
            {
                return new clsTestAppointment(LocalDLA, RetakeTestApplication, CreatedByUser);
            }
            else
            {
                return null;
            }
        }

        static public DataTable TestAppointmentsList(int LocalDLAID, clsTestType.enTestType TestType)
        {
            return clsTestAppointmentDataAccess.GetTestAppointments(LocalDLAID, Convert.ToInt32(TestType));
        }

        static public bool IsAppointmentLocked(int TestAppointment)
        {
            return clsTestAppointment.Find(TestAppointment).IsLocked;
        }

        static public bool IsThereAnActiveAppointment(int LocalDLAID, clsTestType.enTestType TestType)
        {
            return clsTestAppointmentDataAccess.IsThereAnActiveAppointment(LocalDLAID, Convert.ToInt32(TestType));
        }
    }
}
