using System;
using DVLDDataAccess;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DVLDBusiness
{
    public class clsPerson
    {
        public enum enGendor { Male = 0, Female = 1 }

        public int PersonID { get; private set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public enGendor Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string NationalityCountry { get; set; }
        public string ImagePath { get; set; }
      
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode { get; private set; }

        public string FullName
        { get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; } }

        public clsPerson()
        {
            this.PersonID = -1;
            this.NationalNo = string.Empty;
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.ThirdName = string.Empty;
            this.LastName = string.Empty;
            this.DateOfBirth = DateTime.MinValue;
            this.Gendor = enGendor.Male;
            this.Address = string.Empty;
            this.Phone = string.Empty;
            this.Email = string.Empty;
            this.NationalityCountry = string.Empty;
            this.ImagePath = string.Empty;

            Mode = enMode.AddNew;
        }

        protected clsPerson(int PersonID, string NationalNo, string FirstName, string SecondName,
             string ThirdName, string LastName, DateTime DateOfBirth, enGendor Gendor, string Address, string Phone,
             string Email, string NationalityCountry, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountry = NationalityCountry;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }

        private bool FieldsValidation()
        {
            if (string.IsNullOrEmpty(FirstName))
                return false;

            if (string.IsNullOrEmpty(SecondName))
                return false;

            if (string.IsNullOrEmpty(LastName))
                return false;

            if (string.IsNullOrEmpty(NationalNo))
                return false;

            if (string.IsNullOrEmpty(Phone))
                return false;

            if (string.IsNullOrEmpty(Address))
                return false;

            return true;
        }

        private bool _AddNewPerson()
        {          
            this.PersonID = clsPersonDataAccess.AddNewPerson(NationalNo,  FirstName,  SecondName,
              ThirdName,  LastName,  DateOfBirth, Convert.ToInt16(Gendor),  Address,  Phone,
              Email,  NationalityCountry,  ImagePath);

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPersonDataAccess.UpdatePerson(PersonID, NationalNo, FirstName, SecondName,
              ThirdName, LastName, DateOfBirth, Convert.ToInt16(Gendor), Address, Phone,
              Email, NationalityCountry, ImagePath);
        }

        public bool Save()
        {
            if (!FieldsValidation())
                return false;

            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();
            }

            return false;
        }

        static public clsPerson Find(int PersonID)
        {
            string NationalNo = string.Empty, FirstName = string.Empty,
                SecondName = string.Empty, ThirdName = string.Empty,
                LastName = string.Empty, Address = string.Empty,
                Phone = string.Empty, Email = string.Empty, ImagePath = string.Empty,
                NationalityCountry = string.Empty;

            DateTime DateOfBirth = DateTime.MinValue;

            short Gendor = -1;

            if (clsPersonDataAccess.GetPersonByID(ref PersonID, ref NationalNo, ref FirstName, ref SecondName,
                ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor,
                ref Address, ref Phone, ref Email, ref NationalityCountry, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName,
                    ThirdName, LastName, DateOfBirth, (enGendor)Gendor, Address, Phone, Email, NationalityCountry, ImagePath);
            }
            else
            {
                return null;
            }
        }

        static public clsPerson Find(string NationalNo)
        {
              string FirstName = string.Empty,
                SecondName = string.Empty, ThirdName = string.Empty,
                LastName = string.Empty, Address = string.Empty,
                Phone = string.Empty, Email = string.Empty, ImagePath = string.Empty,
                NationalityCountry = string.Empty;

            DateTime DateOfBirth = DateTime.MinValue;

            short Gendor = -1;

            int PersonID = -1;

            if (clsPersonDataAccess.GetPersonByNationalNo(ref PersonID, ref NationalNo, ref FirstName, ref SecondName,
                ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor,
                ref Address, ref Phone, ref Email, ref NationalityCountry, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName,
                    ThirdName, LastName, DateOfBirth, (enGendor)Gendor, Address, Phone, Email, NationalityCountry, ImagePath);
            }
            else
            {
                return null;
            }
        }

        static public bool Delete(int PersonID)
        {
            return clsPersonDataAccess.DeletePerson(PersonID);
        }

        static public DataTable PeopleList(string Filter = "", string ColumnName = "")
        {
            return clsPersonDataAccess.GetAllPeople(Filter, ColumnName);
        }

        static public bool IsPersonExist(int PersonID)
        {
            return clsPersonDataAccess.ISPersonExist(PersonID);
        }

        static public bool IsPersonExist(string NationalNo)
        {
            return clsPersonDataAccess.ISPersonExist(NationalNo);
        }
    }
}
