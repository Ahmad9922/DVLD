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
    public class clsInternationalLicense : clsLicense
    {
        public clsLocalLicense UsedLocalLicenseForIssuance {  get; set; }

        private clsInternationalLicense(clsApplication Application, clsLocalLicense UsedLocalLicenseForIssuance, clsUser CreatedByUser)
        {
            this.LicenseID = null;
            this.Application = Application;
            this.Driver = null;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now.AddYears(1);
            this.IsActive = true;
            this.CreatedByUser = CreatedByUser;

            this.UsedLocalLicenseForIssuance = UsedLocalLicenseForIssuance;

            this.Mode = enMode.AddNew;
        }

        private clsInternationalLicense(int LicenseID, clsApplication Application,
            clsDriver Driver, clsLocalLicense UsedLocalLicenseForIssuance,
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

            this.UsedLocalLicenseForIssuance = UsedLocalLicenseForIssuance;

            this.Mode = enMode.Update;
        }

        private bool _Add()
        {
            clsInternationalLicenseDataAccess.clsInternationalLicenseData InternationalLicenseData = new clsInternationalLicenseDataAccess.clsInternationalLicenseData();

            InternationalLicenseData.InternationalLicenseID = LicenseID;
            InternationalLicenseData.ApplicationID = Application.ApplicationID.Value;
            InternationalLicenseData.DriverID = Driver.DriverID.Value;
            InternationalLicenseData.IssuedUsingLocalLicenseID = UsedLocalLicenseForIssuance.LicenseID.Value;
            InternationalLicenseData.IssueDate = IssueDate;
            InternationalLicenseData.ExpirationDate = ExpirationDate;
            InternationalLicenseData.IsActive = IsActive;
            InternationalLicenseData.CreatedByUserID = CreatedByUser.UserID.Value;

            this.LicenseID = clsInternationalLicenseDataAccess.Add(InternationalLicenseData);

            return this.LicenseID != null;
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
            }

            return false;
        }

        static public clsInternationalLicense Find(int InternationalLicenseID)
        {
            clsInternationalLicenseDataAccess.clsInternationalLicenseData InternationalLicenseData = new clsInternationalLicenseDataAccess.clsInternationalLicenseData();

            if (clsInternationalLicenseDataAccess.GetInternationalLicenseByID(InternationalLicenseData))
            {
                return new clsInternationalLicense(InternationalLicenseID, clsApplication.Find(InternationalLicenseData.ApplicationID),
                    clsDriver.Find(InternationalLicenseData.DriverID), clsLocalLicense.Find(InternationalLicenseData.IssuedUsingLocalLicenseID),
                    InternationalLicenseData.IssueDate, InternationalLicenseData.ExpirationDate, InternationalLicenseData.IsActive, clsUser.Find(InternationalLicenseData.CreatedByUserID));
            }
            else
            {
                return null;
            }
        }

        static public clsInternationalLicense Add(clsApplication Application,
            clsLocalLicense UsedLocalLicenseForIssuance, clsUser CreatedByUser)
        {
            if (Application != null && UsedLocalLicenseForIssuance != null && UsedLocalLicenseForIssuance.LicenseClass.LicenseClassID 
                == clsLicenseClass.enLicenseClassID.Class3Ordinary)
            {
                 return new clsInternationalLicense(Application, UsedLocalLicenseForIssuance, CreatedByUser);
            }
            else
            {
                return null;
            }
        }

        static public DataTable GetLicenseList()
        {
            return clsInternationalLicenseDataAccess.GetLicenseList();
        }

        static public DataTable GetLicenseList(string Value, string FieldName)
        {
            return clsInternationalLicenseDataAccess.GetLicenseList(new clsDataTypes.clsFilterData(Value, FieldName));
        }

        public static bool IsInternationalDrivingLicenseIssued(int LicenseID)
        {
            return clsInternationalLicenseDataAccess.IsInternationalDrivingLicenseIssued(LicenseID);
        }
    }
}
