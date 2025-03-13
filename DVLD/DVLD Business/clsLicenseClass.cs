using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusiness
{
    public class clsLicenseClass
    {
        public int LicenseClassID {  get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public short MinimumAllowedAge { get; set; }
        public short DefaultValidityLength { get; set; }
        public float ClassFees { get; set; }

        private clsLicenseClass(int LicenseClassID, string ClassName, string ClassDescription, short MinimumAllowedAge, short DefaultValidityLength, float ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }

        static public clsLicenseClass Find(int LicenseClassID)
        {
            string ClassName = string.Empty, ClassDescription = string.Empty;
            short MinimumAllowedAge = 0, DefaultValidityLength = 0;
            float ClassFees = 0;

            if (clsLicenseClassDataAccess.GetLicenseClassByID(LicenseClassID, ref ClassName, ref ClassDescription, 
                ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge,
                    DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }
        }

        static public clsLicenseClass Find(string ClassName)
        {
            int LicenseClassID = -1;

            string ClassDescription = string.Empty;
            short MinimumAllowedAge = 0, DefaultValidityLength = 0;
            float ClassFees = 0;

            if (clsLicenseClassDataAccess.GetLicenseClassByClassName(ref LicenseClassID, ref ClassName, ref ClassDescription,
                ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge,
                    DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }
        }

        static public int GetID(string ClassName)
        {
            return clsLicenseClass.Find(ClassName).LicenseClassID;
        }

        static public List<string> LicenseClassList()
        {
            return clsLicenseClassDataAccess.GetAllLicenseClasses();
        }
    }
}
