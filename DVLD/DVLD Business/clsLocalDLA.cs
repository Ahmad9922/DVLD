using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusiness
{
    public class clsLocalDLA : clsApplication
    {
        public int LocalDLAID {  get; set; }
        public clsLicenseClass LicenseClass { get; set; }
        public short PassedTests { get; private set; }
        public short CurrentTestTrials { get; set; }
        public clsTestType CurrentTestType { get; set; }

        public clsLocalDLA(clsPerson ApplicantPerson, clsUser CreatedByUser) 
            : base(ApplicantPerson, clsApplicationType.Find(1), CreatedByUser)
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

        private bool _AddNewLocalDLA()
        {
            if (base._AddNewApplication())
            {
                this.LocalDLAID = clsLocalDLADataAccess.AddNewLocalDLA(this.ApplicationID, this.LicenseClass.LicenseClassID);

                return this.LocalDLAID != -1;
            }

            return false;
        }

        private bool _UpdateLocalDLA()
        {
            if (base._UpdateApplication())
            {
                return clsLocalDLADataAccess.UpdateLocalDLA(this.LocalDLAID, this.ApplicationID, this.LicenseClass.LicenseClassID);
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

        static public new clsLocalDLA Find(int LocalDLAID)
        {
            int LicenseClassID = -1;
            int ApplicationID = -1;
            int CurrentTestTypeID = -1;

            short PassedTests = 0, CurrentTestTrials = 0;

            if (clsLocalDLADataAccess.GetLocalDLAByID(ref LocalDLAID, ref ApplicationID, ref LicenseClassID, ref PassedTests, ref CurrentTestTrials, ref CurrentTestTypeID))
            {
                return new clsLocalDLA(LocalDLAID, clsLicenseClass.Find(LicenseClassID), PassedTests, CurrentTestTrials, clsTestType.Find(CurrentTestTypeID), clsApplication.Find(ApplicationID));
            }
            else
            {
                return null;
            }
        }

        static public int GetApplicationID(int LocalDLAID)
        {
            return clsLocalDLADataAccess.GetApplicationID(LocalDLAID);
        }

        static public bool IsLocalDLAExist(int LocalDLAID)
        {
            return clsLocalDLADataAccess.IsLocalDLAExist(LocalDLAID);
        }

        static public bool IsApplicationRequiredOrCompleted(int ApplicantPersonID, int LicenseClassID)
        {
            return clsLocalDLADataAccess.IsApplicationRequiredOrCompleted(ApplicantPersonID, LicenseClassID);
        }

        static public bool Delete(int LocalDLAID)
        {
            return clsLocalDLADataAccess.DeleteLocalDLA(LocalDLAID);
        }

        static public new bool CancelApplication(int LocalDLAID)
        {
            return clsApplication.CancelApplication(clsLocalDLA.Find(LocalDLAID).ApplicationID);
        }

        static public new bool IsCancelled(int LocalDLAID)
        {
            return clsApplication.IsCancelled(GetApplicationID(LocalDLAID));
        }

        static public new bool IsCompleted(int LocalDLAID)
        {
            return clsApplication.IsCompleted(GetApplicationID(LocalDLAID));
        }

        static public DataTable GetLDLApplications(string ColumnName = "", string Filter = "")
        {
            return clsLocalDLADataAccess.GetAllLocalDLA(ColumnName, Filter);
        }
    }
}
