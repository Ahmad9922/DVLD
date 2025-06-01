using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dotools;

namespace DVLDBusiness
{
    public class clsDriver
    {
        public enum enMode
        {
            AddNew = 1,
            Update = 2,
        }

        public int? DriverID { get; private set; }
        public clsPerson Person { get; private set; }
        public clsUser CreatedByUser { get; private set; }
        public DateTime CreatedDate { get; private set; }

        public enMode Mode { get; private set; }

        private clsDriver(clsPerson Person, clsUser CreatedByUser)
        {
            this.DriverID = null;
            this.Person = Person;
            this.CreatedByUser = CreatedByUser;
            this.CreatedDate = DateTime.Now;

            this.Mode = enMode.AddNew;
        }

        private clsDriver(int DriverID, clsPerson Person, clsUser CreatedByUser, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.Person = Person;
            this.CreatedByUser = CreatedByUser;
            this.CreatedDate = CreatedDate;
        }

        private bool _Add()
        {
            clsDriverDataAccess.clsDriverData DriverData = new clsDriverDataAccess.clsDriverData();

            DriverData.DriverID = DriverID;
            DriverData.PersonID = Person.PersonID.Value;
            DriverData.CreatedByUserID = CreatedByUser.UserID.Value;
            DriverData.CreatedDate = CreatedDate;

            this.DriverID = clsDriverDataAccess.Add(DriverData);

            return this.DriverID != null;
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

        static public clsDriver Find(int DriverID)
        {
            clsDriverDataAccess.clsDriverData DriverData = new clsDriverDataAccess.clsDriverData();

            DriverData.DriverID = DriverID;

            if (clsDriverDataAccess.GetDriverByDriverID(DriverData))
            {
                return new clsDriver(DriverID, clsPerson.Find(DriverData.PersonID), clsUser.Find(DriverData.CreatedByUserID), DriverData.CreatedDate);
            }
            else
            {
                return null;
            }
        }

        static public clsDriver FindByPerson(int PersonID)
        {
            clsDriverDataAccess.clsDriverData DriverData = new clsDriverDataAccess.clsDriverData();

            DriverData.PersonID = PersonID;

            if (clsDriverDataAccess.GetDriverByPersonID(DriverData))
            {
                return new clsDriver(DriverData.DriverID.Value, clsPerson.Find(DriverData.PersonID), clsUser.Find(DriverData.CreatedByUserID), DriverData.CreatedDate);
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

        static public clsDriver Add(clsPerson Person, clsUser CreatedByUser)
        {
            if (Person != null && CreatedByUser != null)
            {
                return new clsDriver(Person, CreatedByUser);
            }
            else
            {
                return null;
            }
        }

        static public DataTable GetDriversList()
        {
            return clsDriverDataAccess.GetDrivers();
        }

        static public DataTable GetDriversList(string Value, string FieldName)
        {
            return clsDriverDataAccess.GetDrivers(new clsDataTypes.clsFilterData(Value, FieldName));
        }
    }
}
