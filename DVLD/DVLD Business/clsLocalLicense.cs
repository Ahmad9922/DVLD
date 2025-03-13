using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusiness
{
    public class clsLocalLicense : clsLicense
    {
        public enum enIssueReason { FirstTime = 1, Renew = 2, ReplacementForLost = 3, ReplacementForDamage = 4 }

        public string Notes { get; set; }
        public float PaidFees { get; set; }
        public enIssueReason IssueReason {  get; protected set; }
        public bool IsDetain
        {
            get
            {
                return clsDetain.IsLicenseDetained(this.LicenseID);
            }
        }

        private clsLocalLicense(clsApplication Application, clsDriver Driver,
            clsLicenseClass LicenseClass, clsUser CreatedByUser, enIssueReason IssueReason)
        {
            this.LicenseID = -1;
            this.Application = Application;
            this.Driver = Driver;
            this.LicenseClass = LicenseClass;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now.AddYears(LicenseClass.DefaultValidityLength);
            this.Notes = null;
            this.PaidFees = LicenseClass.ClassFees;
            this.IsActive = true;
            this.IssueReason = IssueReason;
            this.CreatedByUser = CreatedByUser;

            this.Mode = enMode.AddNew;
        }

        private clsLocalLicense(int LicenseID, clsApplication Application, clsDriver Driver, clsLicenseClass LicenseClass,
            DateTime IssueDate, DateTime ExpirationDate, string Notes, float PaidFees,
            bool IsActive, enIssueReason IssueReason, clsUser CreatedByUser)
        {
            this.LicenseID = LicenseID;
            this.Application = Application;
            this.Driver = Driver;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUser = CreatedByUser;

            this.Mode = enMode.Update;
        }

        private bool _AddNewLicense()
        {
            this.LicenseID = clsLocalLicenseDataAccess.IssueLocalDrivingLicense(Application.ApplicationID,
                Driver?.DriverID ?? clsDriver.AddDriver(Application.ApplicantPerson.PersonID, CreatedByUser.UserID),
                LicenseClass.LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive,
                Convert.ToInt16(IssueReason), CreatedByUser.UserID);

            return (this.LicenseID != -1);
        }

        private bool _UpdateLicense()
        {
            return clsLocalLicenseDataAccess.UpdateDrivingLicense(LicenseID, Application.ApplicationID,
                Driver.DriverID,
                LicenseClass.LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive,
                Convert.ToInt16(IssueReason), CreatedByUser.UserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLicense();
            }

            return false;
        }

        public clsLocalLicense ReplacementForLost(clsApplication Application, clsUser CreatedByUser)
        {
            if (Application != null && Application.ApplicationType.ApplicationTypeID == 3)
            {
                clsLocalLicense ReplacedLocalLicense = new clsLocalLicense(Application, clsDriver.FindByPerson(
                    Application.ApplicantPerson.PersonID), this.LicenseClass, CreatedByUser, enIssueReason.ReplacementForLost);

                ReplacedLocalLicense.Notes = this.Notes;

                if (ReplacedLocalLicense.Save())
                {
                    this.IsActive = false;

                    if (this.Save())
                    {
                        return ReplacedLocalLicense;
                    }
                }
            }

            return null;
        }

        public clsLocalLicense ReplacementForDamaged(clsApplication Application, clsUser CreatedByUser)
        {
            if (Application != null && Application.ApplicationType.ApplicationTypeID == 4)
            {
                clsLocalLicense ReplacedLocalLicense = new clsLocalLicense(Application, clsDriver.FindByPerson(
                    Application.ApplicantPerson.PersonID), this.LicenseClass, CreatedByUser, enIssueReason.ReplacementForDamage);

                ReplacedLocalLicense.Notes = this.Notes;

                if (ReplacedLocalLicense.Save())
                {
                    this.IsActive = false;

                    if (this.Save())
                    {
                        return ReplacedLocalLicense;
                    }
                }
            }

            return null;
        }

        public clsDetain Detain(float FineFees, clsUser CreatedByUser)
        {
            clsDetain Detain = new clsDetain(this, CreatedByUser);
            Detain.FineFees = FineFees;

            if (Detain.Save())
            {
                return Detain;
            }

            return null;
        }

        public bool ReleaseDetained(clsApplication Application, clsUser CreatedByUser)
        {
            clsDetain Detain = clsDetain.FindByDetainedLicense(this.LicenseID);

            if (Detain != null)
                return Detain.Release(Application, CreatedByUser);

            return false;
        }

        static public clsLocalLicense Find(int LicenseID)
        {
            int ApplicationID = -1, DriverID = -1, LicenseClassID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;
            string Notes = string.Empty;
            float PaidFees = 0;
            bool IsActive = false;
            short IssueReason = 0;

            if (clsLocalLicenseDataAccess.GetDrivingLicenseByID(ref LicenseID, ref ApplicationID, ref DriverID, ref LicenseClassID,
                ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLocalLicense(LicenseID, clsApplication.Find(ApplicationID), clsDriver.Find(DriverID),
                    clsLicenseClass.Find(LicenseClassID), IssueDate, ExpirationDate, Notes, PaidFees, IsActive,
                    (enIssueReason)IssueReason, clsUser.Find(CreatedByUserID));
            }
            else
            {
                return null;
            }
        }

        static public clsLocalLicense Add(clsLocalDLA LocalDLA, clsUser CreatedByUser)
        {
            if (LocalDLA != null)
            {
                return new clsLocalLicense(clsApplication.Find(LocalDLA.ApplicationID),
                    clsDriver.FindByPerson(LocalDLA.ApplicantPerson.PersonID), LocalDLA.LicenseClass,
                    CreatedByUser, enIssueReason.FirstTime);
            }
            else
            {
                return null;
            }
        }

        static public clsLocalLicense Renew(clsApplication Application, clsLocalLicense OldLicense, clsUser CreatedByUser)
        {
            if (Application != null && OldLicense != null)
            {
                return new clsLocalLicense(Application, clsDriver.FindByPerson(Application.ApplicantPerson.PersonID),
                    OldLicense.LicenseClass, CreatedByUser, enIssueReason.Renew);
            }
            else
            {
                return null;
            }
        }

        static public clsLocalLicense Replace(clsApplication Application, clsLocalLicense OldLicense, clsUser CreatedByUser)
        {
            if (Application != null && OldLicense != null)
            {
                return new clsLocalLicense(Application, clsDriver.FindByPerson(Application.ApplicantPerson.PersonID),
                    OldLicense.LicenseClass, CreatedByUser, enIssueReason.Renew);
            }
            else
            {
                return null;
            }
        }

        static public DataTable GetLicenseList(string Value = "", string ColumnName = "")
        {
            return clsLocalLicenseDataAccess.GetLicenseList(Value, ColumnName);
        }

        static public int GetLicenseID(int LocalDLAID)
        {
            return clsLocalLicenseDataAccess.GetLicenseID(LocalDLAID);
        }

        static public bool IsLocalLicenseIssued(int LocalDLAID)
        {
            return clsLocalLicenseDataAccess.IsLocalLicenseIssued(clsLocalDLA.GetApplicationID(LocalDLAID));
        }
    }
}
