using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLDBusiness.clsLocalLicense;

namespace DVLDBusiness
{
    public class clsInternationalLicense : clsLicense
    {
        public clsLocalLicense LocalLicense {  get; set; }

        private clsInternationalLicense(clsApplication Application, clsLocalLicense LocalLicense, clsUser CreatedByUser)
        {
            this.LicenseID = -1;
            this.Application = Application;
            this.Driver = Driver;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now.AddYears(1);
            this.IsActive = true;
            this.CreatedByUser = CreatedByUser;

            this.LocalLicense = LocalLicense;

            this.Mode = enMode.AddNew;
        }

        private clsInternationalLicense(int LicenseID, clsApplication Application,
            clsDriver Driver, clsLocalLicense LocalLicense,
                   DateTime IssueDate, DateTime ExpirationDate,
                   bool IsActive, clsUser CreatedByUser)
        {
            this.LicenseID = LicenseID;
            this.Application = Application;
            this.Driver = Driver;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUser = CreatedByUser;

            this.LocalLicense = LocalLicense;

            this.Mode = enMode.Update;
        }
        private bool _AddNewLicense()
        {
            this.LicenseID = clsInternationalLicenseDataAccess.IssueInternationalDrivingLicense(
                Application.ApplicationID, LocalLicense.LicenseID, CreatedByUser.UserID);

            return (this.LicenseID != -1);
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
            }

            return false;
        }

        static public clsInternationalLicense Find(int InternationalLicenseID)
        {
            int ApplicationID = -1, DriverID = -1, IssuedUsingLocalLicenseID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;
            bool IsActive = false;

            if (clsInternationalLicenseDataAccess.GetInternationalLicenseByID(InternationalLicenseID,
                ref  ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate,
                ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new clsInternationalLicense(InternationalLicenseID, clsApplication.Find(ApplicationID),
                    clsDriver.Find(DriverID), clsLocalLicense.Find(IssuedUsingLocalLicenseID),
                    IssueDate, ExpirationDate, IsActive, clsUser.Find(CreatedByUserID));
            }
            else
            {
                return null;
            }
        }

        static public clsInternationalLicense Add(clsApplication Application,
            clsLocalLicense LocalLicense, clsUser CreatedByUser)
        {
            if (Application != null && LocalLicense != null && LocalLicense.LicenseClass.LicenseClassID == 3)
            {
                 return new clsInternationalLicense(Application, LocalLicense, CreatedByUser);
            }
            else
            {
                return null;
            }
        }

        static public DataTable GetLicenseList(string Value = "", string ColumnName = "")
        {
            return clsInternationalLicenseDataAccess.GetLicenseList(Value, ColumnName);
        }

        public static bool IsInternationalDrivingLicenseIssued(int LicenseID)
        {
            return clsInternationalLicenseDataAccess.IsInternationalDrivingLicenseIssued(LicenseID);
        }
    }
}
