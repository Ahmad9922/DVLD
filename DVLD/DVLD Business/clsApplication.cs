using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Dotools;
using static DVLDBusiness.clsPerson;

namespace DVLDBusiness
{
    public class clsApplication
    {
        public enum enApplicationStatus { New = 1, Completed = 3, Canceled = 2 }

        public int? ApplicationID { get; protected set; }
        public clsPerson ApplicantPerson { get; set; }
        public DateTime ApplicationDate { get; set; }
        public clsApplicationType ApplicationType { get; set; }
        public enApplicationStatus ApplicationStatus { get; protected set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public clsUser CreatedByUser { get; protected set; }

        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode { get; protected set; }


        public clsApplication(clsPerson ApplicantPerson, clsApplicationType ApplicationType, clsUser CreatedByUser) 
        {
            this.ApplicationID = null;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationStatus = enApplicationStatus.New;
            this.LastStatusDate = this.ApplicationDate;

            this.PaidFees = ApplicationType.ApplicationFees;
            this.CreatedByUser = CreatedByUser;
            this.ApplicationType = ApplicationType;
            this.ApplicantPerson = ApplicantPerson;

            Mode = enMode.AddNew;
        }

        protected clsApplication(clsApplication Application)
        {
            this.ApplicationID = Application.ApplicationID;
            this.ApplicantPerson = Application.ApplicantPerson;
            this.ApplicationDate = Application.ApplicationDate;
            this.ApplicationType = Application.ApplicationType;
            this.ApplicationStatus = Application.ApplicationStatus;
            this.LastStatusDate = Application.LastStatusDate;
            this.PaidFees = Application.PaidFees;
            this.CreatedByUser = Application.CreatedByUser;

            Mode = enMode.Update;
        }

        protected clsApplication(int ApplicationID, clsPerson ApplicantPerson, DateTime ApplicationDate, clsApplicationType ApplicationType,
            enApplicationStatus ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, clsUser CreatedByUser)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPerson = ApplicantPerson;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationType = ApplicationType;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUser = CreatedByUser;

            Mode = enMode.Update;
        }

        protected bool _Add()
        {
            clsApplicationDataAccess.clsApplicationData ApplicationData = new clsApplicationDataAccess.clsApplicationData();

            ApplicationData.ApplicationID = ApplicationID;
            ApplicationData.ApplicantPersonID = ApplicantPerson.PersonID.Value;
            ApplicationData.ApplicationDate = ApplicationDate;
            ApplicationData.ApplicationTypeID = Convert.ToInt32(ApplicationType.ApplicationTypeID);
            ApplicationData.ApplicationStatus = Convert.ToByte(ApplicationStatus);
            ApplicationData.LastStatusDate = LastStatusDate;
            ApplicationData.PaidFees = PaidFees;
            ApplicationData.CreatedByUserID = CreatedByUser.UserID.Value;

            this.ApplicationID = clsApplicationDataAccess.Add(ApplicationData);

            return this.ApplicationID != null;
        }

        protected bool _Update()
        {
            clsApplicationDataAccess.clsApplicationData ApplicationData = new clsApplicationDataAccess.clsApplicationData();

            ApplicationData.ApplicationID = ApplicationID;
            ApplicationData.ApplicantPersonID = ApplicantPerson.PersonID.Value;
            ApplicationData.ApplicationDate = ApplicationDate;
            ApplicationData.ApplicationTypeID = Convert.ToInt32(ApplicationType.ApplicationTypeID);
            ApplicationData.ApplicationStatus = Convert.ToByte(ApplicationStatus);
            ApplicationData.LastStatusDate = LastStatusDate;
            ApplicationData.PaidFees = PaidFees;
            ApplicationData.CreatedByUserID = CreatedByUser.UserID.Value;

            return clsApplicationDataAccess.Update(ApplicationData);
        }

        public virtual bool Save()
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

                case enMode.Update:

                    return _Update();
            }

            return false;
        }

        static public clsApplication Find(int ApplicationID)
        {
            clsApplicationDataAccess.clsApplicationData ApplicationData = new clsApplicationDataAccess.clsApplicationData();

            ApplicationData.ApplicationID = ApplicationID;

            if (clsApplicationDataAccess.GetApplicationByID(ApplicationData))
            {
                return new clsApplication(ApplicationID, clsPerson.Find(ApplicationData.ApplicantPersonID), ApplicationData.ApplicationDate,
                    clsApplicationType.Find((clsApplicationType.enApplicationTypeID)ApplicationData.ApplicationTypeID),
                   (enApplicationStatus)ApplicationData.ApplicationStatus, ApplicationData.LastStatusDate, ApplicationData.PaidFees, clsUser.Find(ApplicationData.CreatedByUserID));
            }
            else
            {
                return null;
            }
        }

        static public bool CancelApplication(int ApplicationID)
        {
            return clsApplicationDataAccess.CancelApplication(ApplicationID);
        }

        static public bool IsCancelled(int ApplicationID)
        {
            return clsApplicationDataAccess.IsApplicationCancelled(ApplicationID);
        }

        static public bool IsCompleted(int ApplicationID)
        {
            return clsApplicationDataAccess.IsApplicationCompleted(ApplicationID);
        }

        public static DataTable GetApplications()
        {
            return clsApplicationDataAccess.GetApplications();
        }

        public static DataTable GetApplications(string Value, string FieldName)
        {
            return clsApplicationDataAccess.GetApplications(new clsDataTypes.clsFilterData(Value, FieldName));
        }
    }
}
