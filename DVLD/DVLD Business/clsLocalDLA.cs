using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dotools;

namespace DVLDBusiness
{
    public class clsLocalDLA : clsApplication
    {
        public int? LocalDLAID {  get; set; }
        public clsLicenseClass LicenseClass { get; set; }
        public short PassedTests { get; private set; }
        public short CurrentTestTrials { get; set; }
        public clsTestType CurrentTestType { get; set; }

        public clsLocalDLA(clsPerson ApplicantPerson, clsUser CreatedByUser) 
            : base(ApplicantPerson, clsApplicationType.Find(clsApplicationType.enApplicationTypeID.NewLocalDrivingLicenseService), CreatedByUser)
        {
            this.LocalDLAID = -1;
            this.LicenseClass = null;

            Mode = enMode.AddNew;
        }

        private clsLocalDLA(int LocalDLAID, clsLicenseClass LicenseClass, short PassedTests, short CurrentTestTrials,
            clsTestType CurrentTestType, clsApplication Application)
            : base(Application) 
        {
            this.LocalDLAID = LocalDLAID;
            this.LicenseClass = LicenseClass;
            this.PassedTests = PassedTests;
            this.CurrentTestTrials = CurrentTestTrials;
            this.CurrentTestType = CurrentTestType;

            Mode = enMode.Update;
        }

        private clsLocalDLA(clsLocalDLADataAccess.clsLocalDrivingLicenseApplicationData LocalDrivingLicenseApplicationData)
            : base(clsApplication.Find(LocalDrivingLicenseApplicationData.ApplicationID))
        {
            this.LocalDLAID = LocalDrivingLicenseApplicationData.LocalDrivingLicenseApplicationID.Value;
            this.LicenseClass = clsLicenseClass.Find((clsLicenseClass.enLicenseClassID)LocalDrivingLicenseApplicationData.LicenseClassID);
            this.PassedTests = LocalDrivingLicenseApplicationData.PassedTests;
            this.CurrentTestTrials = LocalDrivingLicenseApplicationData.CurrentTestTrials;
            this.CurrentTestType = clsTestType.Find((clsTestType.enTestTypeID)LocalDrivingLicenseApplicationData.CurrentTestTypeID);

            Mode = enMode.Update;
        }

        private bool _AddNewLocalDLA()
        {
            if (base._Add())
            {
                clsLocalDLADataAccess.clsLocalDrivingLicenseApplicationData LocalDrivingLicenseApplicationData
                = new clsLocalDLADataAccess.clsLocalDrivingLicenseApplicationData()
                {
                    LocalDrivingLicenseApplicationID = null,
                    ApplicationID = this.ApplicationID.Value,
                    LicenseClassID = Convert.ToInt32(this.LicenseClass.LicenseClassID)
                };

                this.LocalDLAID = clsLocalDLADataAccess.AddNew(LocalDrivingLicenseApplicationData);

                return (LocalDLAID != -1);
            }

            return false;
        }

        private bool _UpdateLocalDLA()
        {
            if (base._Update())
            {
                clsLocalDLADataAccess.clsLocalDrivingLicenseApplicationData LocalDrivingLicenseApplicationData
                = new clsLocalDLADataAccess.clsLocalDrivingLicenseApplicationData()
                {
                    LocalDrivingLicenseApplicationID = this.LocalDLAID,
                    ApplicationID = this.ApplicationID.Value,
                    LicenseClassID = Convert.ToInt32(this.LicenseClass.LicenseClassID)
                };

                return clsLocalDLADataAccess.Update(LocalDrivingLicenseApplicationData);
            }

            return false;
        }

        public override bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewLocalDLA())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLocalDLA();
            }

            return false;
        }

        public bool DoesAttendTestType(clsTestType.enTestTypeID TestType)
        {
            return clsLocalDLADataAccess.DoesAttendTestType(this.LocalDLAID.Value, Convert.ToInt32(TestType));
        }

        public bool DoesPassTestType(clsTestType.enTestTypeID TestType)
        {
            return clsLocalDLADataAccess.DoesPassTestType(this.LocalDLAID.Value, Convert.ToInt32(TestType));
        }

        public byte TotalTrialsPerTest(clsTestType.enTestTypeID TestType)
        {
            return clsLocalDLADataAccess.TotalTrialsPerTest(this.LocalDLAID.Value, Convert.ToInt32(TestType));
        }

        static public new clsLocalDLA Find(int LocalDLAID)
        {
            clsLocalDLADataAccess.clsLocalDrivingLicenseApplicationData LocalDrivingLicenseApplicationData
                = new clsLocalDLADataAccess.clsLocalDrivingLicenseApplicationData();

            LocalDrivingLicenseApplicationData.LocalDrivingLicenseApplicationID = LocalDLAID;

            if (clsLocalDLADataAccess.GetLocalDLAByID(LocalDrivingLicenseApplicationData))
            {
                return new clsLocalDLA(LocalDrivingLicenseApplicationData);
            }
            else
            {
                return null;
            }
        }

        static public  clsLocalDLA FindByApplicationID(int ApplicationID)
        {
            clsLocalDLADataAccess.clsLocalDrivingLicenseApplicationData LocalDrivingLicenseApplicationData
                = new clsLocalDLADataAccess.clsLocalDrivingLicenseApplicationData();

            LocalDrivingLicenseApplicationData.ApplicationID = ApplicationID;

            if (clsLocalDLADataAccess.GetLocalDLAByApplicationID(LocalDrivingLicenseApplicationData))
            {
                return new clsLocalDLA(LocalDrivingLicenseApplicationData);
            }
            else
            {
                return null;
            }
        }


        static public bool DoesAttendTestType(int LocalDLAID, clsTestType.enTestTypeID TestType)
        {
            return clsLocalDLADataAccess.DoesAttendTestType(LocalDLAID, Convert.ToInt32(TestType));
        }

        static public byte TotalTrialsPerTest(int LocalDLAID, clsTestType.enTestTypeID TestType)
        {
            return clsLocalDLADataAccess.TotalTrialsPerTest(LocalDLAID, Convert.ToInt32(TestType));
        }

        static public int GetApplicationID(int LocalDLAID)
        {
            return clsLocalDLADataAccess.GetApplicationID(LocalDLAID);
        }

        static public bool IsLocalDLAExist(int LocalDLAID)
        {
            return clsLocalDLADataAccess.IsLocalDLAExist(LocalDLAID);
        }

        static public bool IsApplicationRequiredOrCompleted(int ApplicantPersonID, clsLicenseClass.enLicenseClassID LicenseClassID)
        {
            return clsLocalDLADataAccess.IsApplicationRequiredOrCompleted(ApplicantPersonID, Convert.ToInt32(LicenseClassID));
        }

        static public bool Delete(int LocalDLAID)
        {
            return clsLocalDLADataAccess.Delete(LocalDLAID);
        }

        static public new bool CancelApplication(int LocalDLAID)
        {
            return clsApplication.CancelApplication(clsLocalDLA.Find(LocalDLAID).ApplicationID.Value);
        }

        static public new bool IsCancelled(int LocalDLAID)
        {
            return clsApplication.IsCancelled(GetApplicationID(LocalDLAID));
        }

        static public new bool IsCompleted(int LocalDLAID)
        {
            return clsApplication.IsCompleted(GetApplicationID(LocalDLAID));
        }

        static public DataTable GetLDLApplications()
        {
            return clsLocalDLADataAccess.GetAllLocalDLA();
        }

        static public DataTable GetLDLApplications(string Value, string FieldName)
        {
            return clsLocalDLADataAccess.GetAllLocalDLA(new clsDataTypes.clsFilterData(Value, FieldName));
        }
    }
}
