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
        public int? TestAppointmentID { get; private set; }
        public clsTestType TestType { get; private set; }
        public clsLocalDLA LocalDLA { get; private set; }
        public clsApplication RetakeTestApplication { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; private set; }
        public clsUser CreatedByUser { get; private set; }
        public bool IsLocked { get; private set; }

        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode { get; private set; }

        public enum enCreationMode { ScheduleFirstTime = 1, ScheduleRetakeTest = 2 }
        public enCreationMode CreationMode { get; private set; }

        private clsTestAppointment(clsLocalDLA LocalDLA, clsApplication RetakeTestApplication, clsUser CreatedByUser)
        {
            this.TestAppointmentID = -1;
            this.LocalDLA = LocalDLA;
            this.RetakeTestApplication = RetakeTestApplication;
            this.TestType = _SetTestTypeByPassedTest(LocalDLA.PassedTests);
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = TestType.TestTypeFees;
            this.CreatedByUser = CreatedByUser;
            this.IsLocked = true;

            Mode = enMode.AddNew;
            CreationMode = RetakeTestApplication == null ?
                enCreationMode.ScheduleFirstTime : enCreationMode.ScheduleRetakeTest;
        }

        private clsTestAppointment(clsTestAppointmentDataAccess.clsTestAppointmentData TestAppointmentData)
        {
            TestAppointmentID = TestAppointmentData.TestAppointmentID;
            TestType = clsTestType.Find((clsTestType.enTestTypeID)TestAppointmentData.TestTypeID);
            LocalDLA = clsLocalDLA.Find(TestAppointmentData.LocalDrivingLicenseApplicationID);
            RetakeTestApplication = clsApplication.Find(TestAppointmentData.RetakeTestApplicationID.Value);
            AppointmentDate = TestAppointmentData.AppointmentDate;
            PaidFees = TestAppointmentData.PaidFees;
            CreatedByUser = clsUser.Find(TestAppointmentData.CreatedByUserID);
            IsLocked = TestAppointmentData.IsLocked;

            this.Mode = enMode.Update;
            CreationMode = RetakeTestApplication == null ?
                enCreationMode.ScheduleFirstTime : enCreationMode.ScheduleRetakeTest;
        }


        private clsTestType _SetTestTypeByPassedTest(short PassedTest)
        {
            if (PassedTest < 3)
                return clsTestType.Find((clsTestType.enTestTypeID)(PassedTest + 1));
            else
                return null;
        }

        private bool _Add()
        {
            clsTestAppointmentDataAccess.clsTestAppointmentData TestAppointmentData = new clsTestAppointmentDataAccess.clsTestAppointmentData();

            TestAppointmentData.TestAppointmentID = TestAppointmentID;
            TestAppointmentData.TestTypeID = Convert.ToInt32(TestType.TestTypeID);
            TestAppointmentData.LocalDrivingLicenseApplicationID = LocalDLA.LocalDLAID.Value;
            TestAppointmentData.RetakeTestApplicationID = RetakeTestApplication.ApplicationID.Value;
            TestAppointmentData.AppointmentDate = AppointmentDate;
            TestAppointmentData.PaidFees = PaidFees;
            TestAppointmentData.CreatedByUserID = CreatedByUser.UserID.Value;
            TestAppointmentData.IsLocked = IsLocked;

            this.TestAppointmentID = clsTestAppointmentDataAccess.Add(TestAppointmentData);

            return this.TestAppointmentID != null;
        }

        private bool _Update()
        {
            clsTestAppointmentDataAccess.clsTestAppointmentData TestAppointmentData = new clsTestAppointmentDataAccess.clsTestAppointmentData();

            TestAppointmentData.TestAppointmentID = TestAppointmentID;
            TestAppointmentData.TestTypeID = Convert.ToInt32(TestType.TestTypeID);
            TestAppointmentData.LocalDrivingLicenseApplicationID = LocalDLA.LocalDLAID.Value;
            TestAppointmentData.RetakeTestApplicationID = RetakeTestApplication.ApplicationID.Value;
            TestAppointmentData.AppointmentDate = AppointmentDate;
            TestAppointmentData.PaidFees = PaidFees;
            TestAppointmentData.CreatedByUserID = CreatedByUser.UserID.Value;
            TestAppointmentData.IsLocked = IsLocked;

            return clsTestAppointmentDataAccess.Update(TestAppointmentData);
        }


        public bool Save()
        {
            if (CreationMode == enCreationMode.ScheduleRetakeTest)
            {
               if (!RetakeTestApplication.Save())
                    return false;
            }

            switch (Mode)
            {
                case enMode.AddNew:

                    if (_Add())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _Update();
            }

            return false;
        }

        public static clsTestAppointment Find(int TestAppointmentID)
        {
            clsTestAppointmentDataAccess.clsTestAppointmentData TestAppointmentData = new clsTestAppointmentDataAccess.clsTestAppointmentData();

            TestAppointmentData.TestAppointmentID = TestAppointmentID;

            if (clsTestAppointmentDataAccess.GetByID(TestAppointmentData))
            {
                return new clsTestAppointment(TestAppointmentData);
            }
            else
            {
                return null;
            }
        }

        static public clsTestAppointment ScheduleFirstTime(clsLocalDLA LocalDLA, clsUser CreatedByUser)
        {
            if (LocalDLA != null && CreatedByUser != null)
            {
                return new clsTestAppointment(LocalDLA, null, CreatedByUser);
            }
            else
            {
                return null;
            }
        }

        static public clsTestAppointment ScheduleRetakeTest(clsLocalDLA LocalDLA, clsUser CreatedByUser)
        {
            if (LocalDLA != null && CreatedByUser != null)
            {
                return new clsTestAppointment(LocalDLA, new clsApplication(LocalDLA.ApplicantPerson,
                    clsApplicationType.Find(clsApplicationType.enApplicationTypeID.RetakeTest), CreatedByUser), CreatedByUser);
            }
            else
            {
                return null;
            }
        }

        static public DataTable TestAppointmentsList(int LocalDLAID, clsTestType.enTestTypeID TestType)
        {
            return clsTestAppointmentDataAccess.GetTestAppointments(LocalDLAID, Convert.ToInt32(TestType));
        }

        static public bool IsAppointmentLocked(int TestAppointment)
        {
            return clsTestAppointment.Find(TestAppointment).IsLocked;
        }

        static public bool IsThereAnActiveAppointment(int LocalDLAID, clsTestType.enTestTypeID TestType)
        {
            return clsTestAppointmentDataAccess.IsThereAnActiveAppointment(LocalDLAID, Convert.ToInt32(TestType));
        }
    }
}
