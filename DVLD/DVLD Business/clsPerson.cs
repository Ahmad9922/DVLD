using System;
using DVLDDataAccess;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using Dotools;

namespace DVLDBusiness
{
    public class clsPerson
    {
        public enum enGendor { Male = 0, Female = 1 }

        public int? PersonID { get; private set; }
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
        public clsCountry NationalityCountry { get; set; }
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
            this.NationalityCountry = null;
            this.ImagePath = string.Empty;

            Mode = enMode.AddNew;
        }

        protected clsPerson(int PersonID, string NationalNo, string FirstName, string SecondName,
             string ThirdName, string LastName, DateTime DateOfBirth, enGendor Gendor, string Address, string Phone,
             string Email, clsCountry NationalityCountry, string ImagePath)
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

        protected clsPerson(clsPersonDataAccess.clsPersonData PersonInfo)
        {
            this.PersonID = PersonInfo.PersonID.Value;
            this.NationalNo = PersonInfo.NationalNo;
            this.FirstName = PersonInfo.FirstName;
            this.SecondName = PersonInfo.SecondName;
            this.ThirdName = PersonInfo.ThirdName;
            this.LastName = PersonInfo.LastName;
            this.DateOfBirth = PersonInfo.DateOfBirth;
            this.Gendor = (enGendor)PersonInfo.Gendor;
            this.Address = PersonInfo.Address;
            this.Phone = PersonInfo.Phone;
            this.Email = PersonInfo.Email;
            this.NationalityCountry = clsCountry.Find(PersonInfo.CountryID);
            this.ImagePath = PersonInfo.ImagePath;

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
            clsPersonDataAccess.clsPersonData PersonData
                = new clsPersonDataAccess.clsPersonData()
                {
                    PersonID = null,
                    NationalNo = NationalNo,
                    FirstName = FirstName,
                    SecondName = SecondName,
                    ThirdName = ThirdName,
                    LastName = LastName,
                    Email = Email,
                    Phone = Phone,
                    Gendor = Convert.ToByte(Gendor),
                    Address = Address,
                    DateOfBirth = DateOfBirth,
                    CountryID = NationalityCountry.CountryID,
                    ImagePath = ImagePath,
                };

            this.PersonID = clsPersonDataAccess.AddNewPerson(PersonData);

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            clsPersonDataAccess.clsPersonData PersonData
                = new clsPersonDataAccess.clsPersonData()
                {
                    PersonID = PersonID,
                    NationalNo = NationalNo,
                    FirstName = FirstName,
                    SecondName = SecondName,
                    ThirdName = ThirdName,
                    LastName = LastName,
                    Email = Email,
                    Phone = Phone,
                    Gendor = Convert.ToByte(Gendor),
                    Address = Address,
                    DateOfBirth = DateOfBirth,
                    CountryID = NationalityCountry.CountryID,
                    ImagePath = ImagePath
                };

            return clsPersonDataAccess.UpdatePerson(PersonData);
        }

        /// <summary>
        /// Saves the object data to the database and works in two modes: Add and Update.
        /// </summary>
        /// <returns></returns>
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
            clsPersonDataAccess.clsPersonData PersonInfo = new clsPersonDataAccess.clsPersonData();

            PersonInfo.PersonID = PersonID;

            if (clsPersonDataAccess.GetPersonByID(PersonInfo))
            {
                return new clsPerson(PersonInfo);
            }
            else
            {
                return null;
            }
        }

        static public clsPerson Find(string NationalNo)
        {
            clsPersonDataAccess.clsPersonData PersonInfo = new clsPersonDataAccess.clsPersonData();

            PersonInfo.NationalNo = NationalNo;

            if (clsPersonDataAccess.GetPersonByNationalNo(PersonInfo))
            {
                return new clsPerson(PersonInfo);
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

        static public DataTable PeopleList()
        {
            return clsPersonDataAccess.GetAllPeople();
        }

        static public DataTable PeopleList(string Value, string FieldName)
        {
            return clsPersonDataAccess.GetAllPeople(new clsDataTypes.clsFilterData(Value, FieldName));
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
