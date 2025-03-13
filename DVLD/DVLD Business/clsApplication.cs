using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static DVLDBusiness.clsPerson;

namespace DVLDBusiness
{
    public class clsApplication
    {
        public enum enApplicationStatus { New = 1, Completed = 3, Canceled = 2 }

        public int ApplicationID { get; set; }
        public clsPerson ApplicantPerson { get; protected set; }
        public DateTime ApplicationDate { get; set; }
        public clsApplicationType ApplicationType { get; protected set; }
        public enApplicationStatus ApplicationStatus { get; protected set; }
        public DateTime LastStatusDate { get; set; }
        public float PaidFees { get; set; }
        public clsUser CreatedByUser { get; protected set; }

        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode { get; protected set; }

        public clsApplication(clsPerson ApplicantPerson, clsApplicationType ApplicationType, clsUser CreatedByUser) 
        {
            this.ApplicationID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationStatus = enApplicationStatus.New;
            this.LastStatusDate = this.ApplicationDate;

            this.PaidFees = ApplicationType.Fees;
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
            enApplicationStatus ApplicationStatus, DateTime LastStatusDate, float PaidFees, clsUser CreatedByUser)
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

        protected virtual bool _AddNewApplication()
        {
           this.ApplicationID = clsApplicationDataAccess.AddNewApplication(this.ApplicantPerson.PersonID, this.ApplicationDate, this.ApplicationType.ApplicationTypeID, 
               Convert.ToInt16(this.ApplicationStatus), this.LastStatusDate, this.PaidFees, this.CreatedByUser.UserID);

            return this.ApplicationID != -1;
        }

        protected virtual bool _UpdateApplication()
        {
            return clsApplicationDataAccess.UpdateApplication(this.ApplicationID, this.ApplicantPerson.PersonID, this.ApplicationDate, this.ApplicationType.ApplicationTypeID,
                Convert.ToInt16(this.ApplicationStatus), this.LastStatusDate, this.PaidFees, this.CreatedByUser.UserID);
        }

        public virtual bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplication();
            }

            return false;
        }

        static public clsApplication Find(int ApplicationID)
        {
            int ApplicantPersonID = -1, ApplicationTypeID = -1, CreatedByUserID = -1;

            DateTime ApplicationDate = DateTime.MinValue, LastStatusDate = DateTime.MinValue;

            short ApplicationStatus = 0;

            float PaidFees = 0;

            if (clsApplicationDataAccess.GetApplicationByID(ref ApplicationID, ref ApplicantPersonID, ref ApplicationDate,
               ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new clsApplication(ApplicationID, clsPerson.Find(ApplicantPersonID), ApplicationDate, clsApplicationType.Find(ApplicationTypeID),
                   (enApplicationStatus)ApplicationStatus, LastStatusDate, PaidFees, clsUser.Find(CreatedByUserID));
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
    }
}
