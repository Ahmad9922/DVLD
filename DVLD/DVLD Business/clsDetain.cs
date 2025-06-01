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
    public class clsDetain
    {
        public int DetainID { get; set; }
        public clsLocalLicense DetainedLicense { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public clsUser CreatedByUser { get; set; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public clsUser ReleasedByUser { get; set; }
        public clsApplication ReleaseApplicationByUser { get; set; }

        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode { get; private set; }

        public clsDetain(clsLocalLicense DetainedLicense, clsUser CreatedByUser)
        {
            this.DetainID = -1;
            this.DetainedLicense = DetainedLicense;
            this.DetainDate = DateTime.Now;
            this.FineFees = FineFees;
            this.CreatedByUser = CreatedByUser;

            this.IsReleased = false;
            this.ReleaseDate = null;
            this.ReleasedByUser = null;
            this.ReleaseApplicationByUser = null;


            this.Mode = enMode.AddNew;
        }

        private clsDetain(int DetainID, clsLocalLicense DetainedLicense, DateTime DetainDate, decimal FineFees,
            clsUser CreatedByUser, bool IsRelease, DateTime? ReleaseDate, clsUser ReleasedByUser,
            clsApplication ReleaseApplicationByUser)
        {
            this.DetainID = DetainID;
            this.DetainedLicense = DetainedLicense;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUser = CreatedByUser;
            this.IsReleased = IsRelease;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUser = ReleasedByUser;
            this.ReleaseApplicationByUser = ReleaseApplicationByUser;

            this.Mode = enMode.Update;
        }

        private bool _AddNewDetain()
        {
            clsDetainDataAccess.clsDetainData DetainData
            = new clsDetainDataAccess.clsDetainData()
            {
                DetainID = null,
                LicenseID = this.DetainedLicense.LicenseID.Value,
                DetainDate = this.DetainDate,
                FineFees = this.FineFees,
                CreatedByUserID = this.CreatedByUser.UserID.Value,
                IsReleased = this.IsReleased,
                ReleaseDate = this.ReleaseDate,
                ReleasedByUserID = this.ReleasedByUser.UserID,
                ReleaseApplicationID = this.ReleaseApplicationByUser.ApplicationID,
            };

            this.DetainID = clsDetainDataAccess.AddNew(DetainData);

            return (DetainID != -1);
        }

        private bool _UpdateDetain()
        {
            clsDetainDataAccess.clsDetainData DetainData
            = new clsDetainDataAccess.clsDetainData()
            {
            
                DetainID = this.DetainID,
                LicenseID = this.DetainedLicense.LicenseID.Value,
                DetainDate = this.DetainDate,
                FineFees = this.FineFees,
                CreatedByUserID = this.CreatedByUser.UserID.Value,
                IsReleased = this.IsReleased,
                ReleaseDate = this.ReleaseDate,
                ReleasedByUserID = this.ReleasedByUser.UserID,
                ReleaseApplicationID = this.ReleaseApplicationByUser.ApplicationID,
            };

            return clsDetainDataAccess.Update(DetainData);
        }

        internal bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewDetain())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateDetain();
            }

            return false;
        }

        public bool Release(clsApplication Application, clsUser CreatedByUser)
        {
            this.ReleaseApplicationByUser = Application;
            this.ReleasedByUser = CreatedByUser;
            this.ReleaseDate = DateTime.Now;
            this.IsReleased = true;

            return Save();
        }

        static public clsDetain Find(int DetainID)
        {
            clsDetainDataAccess.clsDetainData DetainedLicenseData = new clsDetainDataAccess.clsDetainData();

            DetainedLicenseData.DetainID = DetainID;

            if (clsDetainDataAccess.GetDetainByDetainID(DetainedLicenseData))
            {
                return new clsDetain(DetainID, clsLocalLicense.Find(DetainedLicenseData.LicenseID), DetainedLicenseData.DetainDate, DetainedLicenseData.FineFees,
                    clsUser.Find(DetainedLicenseData.CreatedByUserID), DetainedLicenseData.IsReleased, DetainedLicenseData.ReleaseDate, clsUser.Find(DetainedLicenseData.ReleasedByUserID.Value),
                    clsApplication.Find(DetainedLicenseData.ReleaseApplicationID.Value));
            }
            else
            {
                return null;
            }
        }

        static public clsDetain FindByDetainedLicense(int DetainedLicense)
        {
            clsDetainDataAccess.clsDetainData DetainedLicenseData = new clsDetainDataAccess.clsDetainData();

            DetainedLicenseData.LicenseID = DetainedLicense;

            if (clsDetainDataAccess.GetDetainByDetainedLicenseID(DetainedLicenseData))
            {
                return new clsDetain(DetainedLicenseData.DetainID.Value, clsLocalLicense.Find(DetainedLicenseData.LicenseID), DetainedLicenseData.DetainDate, DetainedLicenseData.FineFees,
                    clsUser.Find(DetainedLicenseData.CreatedByUserID), DetainedLicenseData.IsReleased, DetainedLicenseData.ReleaseDate, clsUser.Find(DetainedLicenseData.ReleasedByUserID.Value),
                    clsApplication.Find(DetainedLicenseData.ReleaseApplicationID.Value));
            }
            else
            {
                return null;
            }
        }

        static public DataTable GetDetainsList()
        {
            return clsDetainDataAccess.GetDetainsList();
        }

        static public DataTable GetDetainsList(string Value, string FieldName)
        {
            return clsDetainDataAccess.GetDetainsList(new clsDataTypes.clsFilterData(Value, FieldName));
        }

        static public bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainDataAccess.IsLicenseDetained(LicenseID);
        }
    }
}
