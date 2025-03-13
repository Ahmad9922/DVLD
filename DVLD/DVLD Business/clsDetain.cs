using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusiness
{
    public class clsDetain
    {
        public int DetainID { get; set; }
        public clsLocalLicense DetainedLicense { get; set; }
        public DateTime DetainDate { get; set; }
        public float FineFees { get; set; }
        public clsUser CreatedByUser { get; set; }
        public bool IsRelease { get; set; }
        public DateTime ReleaseDate { get; set; }
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

            this.IsRelease = false;
            this.ReleaseDate = DateTime.MinValue;
            this.ReleasedByUser = null;
            this.ReleaseApplicationByUser = null;


            this.Mode = enMode.AddNew;
        }

        private clsDetain(int DetainID, clsLocalLicense DetainedLicense, DateTime DetainDate, float FineFees,
            clsUser CreatedByUser, bool IsRelease, DateTime ReleaseDate, clsUser ReleasedByUser,
            clsApplication ReleaseApplicationByUser)
        {
            this.DetainID = DetainID;
            this.DetainedLicense = DetainedLicense;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUser = CreatedByUser;
            this.IsRelease = IsRelease;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUser = ReleasedByUser;
            this.ReleaseApplicationByUser = ReleaseApplicationByUser;

            this.Mode = enMode.Update;
        }

        private bool _AddNewDetain()
        {
            this.DetainID = clsDetainDataAccess.DetainLicense(DetainedLicense.LicenseID, DetainDate, FineFees,
                CreatedByUser.UserID,
                IsRelease,
                ReleaseDate,
                ReleasedByUser?.UserID ?? -1,
                ReleaseApplicationByUser?.ApplicationID ?? -1);

            return (this.DetainID != -1);
        }

        private bool _UpdateDetain()
        {
            return clsDetainDataAccess.UpdateDetain(DetainID, DetainedLicense.LicenseID, DetainDate, FineFees,
                CreatedByUser.UserID,
                IsRelease,
                ReleaseDate,
                ReleasedByUser?.UserID ?? -1,
                ReleaseApplicationByUser?.ApplicationID ?? -1);
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
            this.IsRelease = true;

            return Save();
        }

        static public clsDetain Find(int DetainID)
        {
            int DetainedLicense = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseApplicationByUserID = -1;
            DateTime DetainDate = DateTime.MinValue, ReleaseDate = DateTime.MinValue;

            float FineFees = 0;
            bool IsRelease = false;

            if (clsDetainDataAccess.GetDetainByDetainID(ref DetainID, ref DetainedLicense, ref DetainDate, ref FineFees,
               ref CreatedByUserID, ref IsRelease, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationByUserID))
            {
                return new clsDetain(DetainID, clsLocalLicense.Find(DetainedLicense), DetainDate, FineFees,
                    clsUser.Find(CreatedByUserID), IsRelease, ReleaseDate, clsUser.Find(ReleasedByUserID),
                    clsApplication.Find(ReleaseApplicationByUserID));
            }
            else
            {
                return null;
            }
        }

        static public clsDetain FindByDetainedLicense(int DetainedLicense)
        {
            int DetainID = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseApplicationByUserID = -1;
            DateTime DetainDate = DateTime.MinValue, ReleaseDate = DateTime.MinValue;

            float FineFees = 0;
            bool IsRelease = false;

            if (clsDetainDataAccess.GetDetainByDetainedLicenseID(ref DetainID, ref DetainedLicense, ref DetainDate, ref FineFees,
               ref CreatedByUserID, ref IsRelease, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationByUserID))
            {
                return new clsDetain(DetainID, clsLocalLicense.Find(DetainedLicense), DetainDate, FineFees,
                    clsUser.Find(CreatedByUserID), IsRelease, ReleaseDate, clsUser.Find(ReleasedByUserID),
                    clsApplication.Find(ReleaseApplicationByUserID));
            }
            else
            {
                return null;
            }
        }

        static public DataTable GetDetainsList(string Value = "", string ColumnName = "")
        {
            return clsDetainDataAccess.GetDetainsList(Value, ColumnName);
        }

        static public bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainDataAccess.IsLicenseDetained(LicenseID);
        }
    }
}
