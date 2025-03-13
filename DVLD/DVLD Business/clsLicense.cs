using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusiness
{
    public abstract class clsLicense
    {
        public int LicenseID { get; set; }
        public clsApplication Application { get; set; }
        public clsDriver Driver { get; set; }
        public clsLicenseClass LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public clsUser CreatedByUser { get; set; }

        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode { get; protected set; }
    }
}
