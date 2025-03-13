using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLDBusiness.clsLocalLicense;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDBusiness
{
    public class clsDriver
    {
        public int DriverID { get; set; }
        public clsPerson Person { get; private set; }
        public clsUser CreatedByUser { get; private set; }
        public DateTime CreatedDate { get; set; }

        private clsDriver(int DriverID, clsPerson Person, clsUser CreatedByUser, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.Person = Person;
            this.CreatedByUser = CreatedByUser;
            this.CreatedDate = CreatedDate;

        }

        static public clsDriver Find(int DriverID)
        {
            int PersonID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.MinValue;

            if (clsDriverDataAccess.GetDriverByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver(DriverID, clsPerson.Find(PersonID), clsUser.Find(CreatedByUserID), CreatedDate);
            }
            else
            {
                return null;
            }
        }

        static public clsDriver FindByPerson(int PersonID)
        {
            int DriverID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.MinValue;

            if (clsDriverDataAccess.GetDriverByPersonID(ref DriverID, PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver(DriverID, clsPerson.Find(PersonID), clsUser.Find(CreatedByUserID), CreatedDate);
            }
            else
            {
                return null;
            }
        }

        static public bool IsPersonDriver(int PersonID)
        {
            return clsDriverDataAccess.IsPersonDriver(PersonID);
        }

        static public int AddDriver(int PersonID, int CreatedByUserID)
        {
            return clsDriverDataAccess.AddDriver(PersonID, CreatedByUserID);
        }

        static public DataTable GetDriversList(string Value = "", string ColumnName = "")
        {
            return clsDriverDataAccess.GetDrivers(Value, ColumnName);
        }
    }
}
