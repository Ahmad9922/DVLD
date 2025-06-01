using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVLDBusiness
{
    public class clsApplicationType
    {
        public enum enApplicationTypeID
        {
            None = 0,
            NewLocalDrivingLicenseService = 1,
            RenewDrivingLicenseService = 2,
            ReplacementforaLostDrivingLicense = 3,
            ReplacementforaDamagedDrivingLicense = 4,
            ReleaseDetainedDrivingLicsense = 5,
            NewInternationalLicense = 6,
            RetakeTest = 7
        }

        public enApplicationTypeID ApplicationTypeID {  get; protected set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }

        private clsApplicationType(enApplicationTypeID ApplicationTypeID, string Title, decimal Fees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = Title;
            this.ApplicationFees = Fees;
        }

        private clsApplicationType(clsApplicationTypeDataAccess.clsApplicationTypeData ApplicationTypeData)
        {
            this.ApplicationTypeID = (enApplicationTypeID)ApplicationTypeData.ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeData.ApplicationTypeTitle;
            this.ApplicationFees = ApplicationTypeData.ApplicationFees;
        }


        private bool _UpdateApplicationType()
        {
            clsApplicationTypeDataAccess.clsApplicationTypeData ApplicationTypeData
            = new clsApplicationTypeDataAccess.clsApplicationTypeData()
            {
                ApplicationTypeID = Convert.ToInt32(this.ApplicationTypeID),
                ApplicationTypeTitle = this.ApplicationTypeTitle,
                ApplicationFees = this.ApplicationFees,
            };

            return clsApplicationTypeDataAccess.Update(ApplicationTypeData);

        }

        public bool Save()
        {
            return _UpdateApplicationType();
        }

        public static clsApplicationType Find(enApplicationTypeID ApplicationTypeID)
        {
            clsApplicationTypeDataAccess.clsApplicationTypeData ApplicationTypeData = new clsApplicationTypeDataAccess.clsApplicationTypeData();

            ApplicationTypeData.ApplicationTypeID = Convert.ToInt32(ApplicationTypeID);

            if (clsApplicationTypeDataAccess.GetApplicationTypeByID(ApplicationTypeData))
            {
                return new clsApplicationType(ApplicationTypeID, ApplicationTypeData.ApplicationTypeTitle, ApplicationTypeData.ApplicationFees);
            }
            else
            {
                return null;
            }
        }

        public static clsApplicationType Find(string ApplicationTypeTitle)
        {
            clsApplicationTypeDataAccess.clsApplicationTypeData ApplicationTypeData = new clsApplicationTypeDataAccess.clsApplicationTypeData();

            ApplicationTypeData.ApplicationTypeTitle = ApplicationTypeTitle;

            if (clsApplicationTypeDataAccess.GetApplicationTypeByTitle(ApplicationTypeData))
            {
                return new clsApplicationType(ApplicationTypeData);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetApplicationTypesList()
        {
            return clsApplicationTypeDataAccess.GetApplicationTypes();
        }

        public static List<string> GetApplicationTypesTitles()
        {
            return clsApplicationTypeDataAccess.GetApplicationTypesTitles();
        }
    }
}
