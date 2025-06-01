using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static DVLDBusiness.clsPerson;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDBusiness
{
    public class clsLocalLicense : clsLicense
    {
        public enum enIssueReason { None = 0, FirstTime = 1, Renew = 2, ReplacementForLost = 3, ReplacementForDamage = 4 }

        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public enIssueReason IssueReason {  get; protected set; }
        public bool IsDetain
        {
            get
            {
                return clsDetain.IsLicenseDetained(this.LicenseID.Value);
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
            DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees,
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

        private clsLocalLicense(clsLocalLicenseDataAccess.clsLicenseData LicenseData)
        {
            this.LicenseID = LicenseData.LicenseID;
            this.Application = clsApplication.Find(LicenseData.ApplicationID);
            this.Driver = clsDriver.Find(LicenseData.DriverID);
            this.LicenseClass = clsLicenseClass.Find((clsLicenseClass.enLicenseClassID)LicenseData.LicenseClass);
            this.IssueDate = LicenseData.IssueDate;
            this.ExpirationDate = LicenseData.ExpirationDate;
            this.Notes = LicenseData.Notes;
            this.PaidFees = LicenseData.PaidFees;
            this.IsActive = LicenseData.IsActive;
            this.IssueReason = (enIssueReason)LicenseData.IssueReason;
            this.CreatedByUser = clsUser.Find(LicenseData.CreatedByUserID);

            this.Mode = enMode.Update;
        }

        public bool IsLicenseExpired()
        {
            return ExpirationDate < DateTime.Now;
        }

        private bool _Add()
        {
            clsLocalLicenseDataAccess.clsLicenseData LicenseData
               = new clsLocalLicenseDataAccess.clsLicenseData()
               {
                   LicenseID = this.LicenseID,
                   ApplicationID = Application.ApplicationID.Value,
                   DriverID = Driver.DriverID.Value,
                   LicenseClass = Convert.ToInt32(LicenseClass.LicenseClassID),
                   IssueDate = IssueDate,
                   ExpirationDate = ExpirationDate,
                   Notes = Notes,
                   PaidFees = PaidFees,
                   IsActive = IsActive,
                   IssueReason = Convert.ToByte(IssueReason),
                   CreatedByUserID = CreatedByUser.UserID.Value
               };

            this.LicenseID = clsLocalLicenseDataAccess.IssueLocalDrivingLicense(LicenseData);

            return (this.LicenseID != -1);
        }

        private bool _Update()
        {
            clsLocalLicenseDataAccess.clsLicenseData LicenseData = new clsLocalLicenseDataAccess.clsLicenseData();

            LicenseData.LicenseID = LicenseID;
            LicenseData.ApplicationID = Application.ApplicationID.Value;
            LicenseData.DriverID = Driver.DriverID.Value;
            LicenseData.LicenseClass = Convert.ToInt32(LicenseClass.LicenseClassID);
            LicenseData.IssueDate = IssueDate;
            LicenseData.ExpirationDate = ExpirationDate;
            LicenseData.Notes = Notes;
            LicenseData.PaidFees = PaidFees;
            LicenseData.IsActive = IsActive;
            LicenseData.IssueReason = Convert.ToByte(IssueReason);
            LicenseData.CreatedByUserID = CreatedByUser.UserID.Value;

            return clsLocalLicenseDataAccess.Update(LicenseData);
        }


        public bool Save()
        {
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

        public clsLocalLicense Renew(string Notes, clsApplication Application, clsUser CreatedByUser)
        {
            if (Application == null || Application.ApplicationType.ApplicationTypeID !=
                clsApplicationType.enApplicationTypeID.RenewDrivingLicenseService)
                return null;
         
            clsLocalLicense RenewedLocalLicense = new clsLocalLicense(Application, clsDriver.FindByPerson(
                Application.ApplicantPerson.PersonID.Value), this.LicenseClass, CreatedByUser, IssueReason);

            RenewedLocalLicense.Notes = Notes;

            if (RenewedLocalLicense.Save())
            {
                this.IsActive = false;

                if (this.Save())
                {
                    return RenewedLocalLicense;
                }
            }

            return null;
        }

        public clsLocalLicense Replace(clsApplication Application, clsUser CreatedByUser)
        {
            if (Application == null)
                return null;

            enIssueReason IssueReason = enIssueReason.None;

            if (Application.ApplicationType.ApplicationTypeID ==
                clsApplicationType.enApplicationTypeID.ReplacementforaLostDrivingLicense)
            {
                IssueReason = enIssueReason.ReplacementForLost;
            }
            else if (Application.ApplicationType.ApplicationTypeID ==
                clsApplicationType.enApplicationTypeID.ReplacementforaDamagedDrivingLicense)
            { 
                IssueReason = enIssueReason.ReplacementForDamage;
            }
            else
            {
                return null; 
                // The application must be of type 'Lost Replacement' or 'Damaged Replacement'
                // to proceed with the replacement process.
            }

            clsLocalLicense ReplacedLocalLicense = new clsLocalLicense(Application, clsDriver.FindByPerson(
                Application.ApplicantPerson.PersonID.Value), this.LicenseClass, CreatedByUser, IssueReason);

            ReplacedLocalLicense.Notes = this.Notes;

            if (ReplacedLocalLicense.Save())
            {
                this.IsActive = false;

                if (this.Save())
                {
                    return ReplacedLocalLicense;
                }
            }

            return null;
        }

        public clsDetain Detain(decimal FineFees, clsUser CreatedByUser)
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
            clsDetain Detain = clsDetain.FindByDetainedLicense(this.LicenseID.Value);

            if (Detain != null)
                return Detain.Release(Application, CreatedByUser);

            return false;
        }

        static public clsLocalLicense Find(int LicenseID)
        {
            clsLocalLicenseDataAccess.clsLicenseData LicenseData = new clsLocalLicenseDataAccess.clsLicenseData();

            LicenseData.LicenseID = LicenseID;

            if (clsLocalLicenseDataAccess.GetDrivingLicenseByID(LicenseData))
            {
                return new clsLocalLicense(LicenseData);
            }
            else
            {
                return null;
            }
        }

        static public clsLocalLicense Add(clsLocalDLA LocalDLA, clsUser CreatedByUser)
        {
            if (LocalDLA != null && CreatedByUser != null)
            {
                return new clsLocalLicense(LocalDLA,
                    clsDriver.FindByPerson(LocalDLA.ApplicantPerson.PersonID.Value), LocalDLA.LicenseClass,
                    CreatedByUser, enIssueReason.FirstTime);
            }
            else
            {
                return null;
            }
        }

        static public DataTable GetLicenseList(int DriverID = -1)
        {
            return clsLocalLicenseDataAccess.GetLicenseList(DriverID);
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
