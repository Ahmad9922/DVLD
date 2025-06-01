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
        public enum enLicenseClassID
        {
            None = 0,
            Class1SmallMotorcycle = 1,
            Class2HeavyMotorcycle = 2,
            Class3Ordinary = 3,
            Class4Commercial = 4,
            Class5Agricultural = 5,
            Class6SmallAndMediumBus = 6,
            Class7TruckAndHeavyVehicle = 7,
        }

        public enLicenseClassID LicenseClassID {  get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public short MinimumAllowedAge { get; set; }
        public short DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }

        private clsLicenseClass(enLicenseClassID LicenseClassID, string ClassName, string ClassDescription, short MinimumAllowedAge, short DefaultValidityLength, decimal ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }

        static public clsLicenseClass Find(enLicenseClassID LicenseClassID)
        {
            clsLicenseClassDataAccess.clsLicenseClassData LicenseClassData = new clsLicenseClassDataAccess.clsLicenseClassData();

            LicenseClassData.LicenseClassID = Convert.ToInt32(LicenseClassID);

            if (clsLicenseClassDataAccess.GetLicenseClassByID(LicenseClassData))
            {
                return new clsLicenseClass(LicenseClassID, LicenseClassData.ClassName, LicenseClassData.ClassDescription, LicenseClassData.MinimumAllowedAge,
                    LicenseClassData.DefaultValidityLength, LicenseClassData.ClassFees);
            }
            else
            {
                return null;
            }
        }

        static public clsLicenseClass Find(string ClassName)
        {
            clsLicenseClassDataAccess.clsLicenseClassData LicenseClassData = new clsLicenseClassDataAccess.clsLicenseClassData();

            LicenseClassData.ClassName = ClassName;

            if (clsLicenseClassDataAccess.GetLicenseClassByClassName(LicenseClassData))
            {
                return new clsLicenseClass((enLicenseClassID)LicenseClassData.LicenseClassID, LicenseClassData.ClassName, LicenseClassData.ClassDescription, LicenseClassData.MinimumAllowedAge,
                    LicenseClassData.DefaultValidityLength, LicenseClassData.ClassFees);
            }
            else
            {
                return null;
            }
        }

        static public enLicenseClassID GetID(string ClassName)
        {
            return clsLicenseClass.Find(ClassName).LicenseClassID;
        }

        static public List<string> LicenseClassList()
        {
            return clsLicenseClassDataAccess.GetAllLicenseClasses();
        }
    }
}
