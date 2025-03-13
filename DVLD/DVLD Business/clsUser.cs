using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static DVLDBusiness.clsUser;

namespace DVLDBusiness
{
    public class clsUser
    {
        public int UserID { get; set; }
        public clsPerson Person { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode { get; private set; }

        public clsUser()
        {
            UserID = -1;
            Person = null;
            UserName = string.Empty;
            Password = string.Empty;
            IsActive = false;

            Mode = enMode.AddNew;
        }

        private clsUser(int UserID, clsPerson Person, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.Person = Person;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }

        private bool FieldsValidation()
        {
            if (Person == null)
                return false;

            if (string.IsNullOrEmpty(UserName))
                return false;

            if (string.IsNullOrEmpty(Password))
                return false;

            return true;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserDataAccess.AddNewUser(Person.PersonID, UserName, Password, IsActive);  

            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(UserID, Person.PersonID, UserName, Password, IsActive);
        }

        public bool Save()
        {
            if (!FieldsValidation())
                return false;

            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();
            }

            return false;
        }

        static public clsUser Find(int UserID)
        {
            int PersonID = -1;
            string UserName = string.Empty, Password = string.Empty;
            bool IsActive = false;

            if (clsUserDataAccess.GetUserByID(ref UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, clsPerson.Find(PersonID), UserName, Password, IsActive);
            }
            else
            {
                return null;
            }
        }

        static public clsUser Find(string UserName)
        {
            int UserID = -1, PersonID = -1;
            string Password = string.Empty;
            bool IsActive = false;

            if (clsUserDataAccess.GetUserByUserName(ref UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, clsPerson.Find(PersonID), UserName, Password, IsActive);      
            }
            else
            {
                return null;
            }
        }

        static public clsUser Find(string UserName, string Password)
        {
            int UserID = -1, PersonID = -1;
            bool IsActive = false;

            if (clsUserDataAccess.GetUserByUserNameAndPassword(ref UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, clsPerson.Find(PersonID), UserName, Password, IsActive);
            }
            else
            {
                return null;
            }
        }

        static public bool Delete(int UserID)
        {
            return clsUserDataAccess.DeleteUser(UserID);
        }

        static public DataTable UsersList(string Filter = "", string ColumnName = "")
        {
            return clsUserDataAccess.GetAllUsers(Filter, ColumnName);
        }

        static public bool IsPersonExist(int PersonID)
        {
            return clsUserDataAccess.IsPersonExist(PersonID);
        }

        static public bool IsUserExist(string UserName)
        {
            return clsUserDataAccess.ISUserExist(UserName);
        }

        static public bool IsUserExist(int UserID)
        {
            return clsUserDataAccess.ISUserExist(UserID);
        }
    }
}
