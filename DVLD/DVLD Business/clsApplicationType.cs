using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVLDBusiness
{
    public class clsApplicationType
    {
        public int ApplicationTypeID {  get; set; }
        public string Title { get; set; }
        public float Fees { get; set; }

        private clsApplicationType(int ApplicationTypeID, string Title, float Fees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.Title = Title;
            this.Fees = Fees;
        }

        private bool _UpdateApplicationType()
        {
            return clsApplicationTypeDataAccess.UpdateUser(ApplicationTypeID, Title, Fees);
        }

        public bool Save()
        {
            return _UpdateApplicationType();
        }

        public static clsApplicationType Find(int ApplicationTypeID)
        {
            string Title = string.Empty;
            float Fees = 0;

            if (clsApplicationTypeDataAccess.GetApplicationTypeByID(ref ApplicationTypeID, ref Title, ref Fees))
            {
                return new clsApplicationType(ApplicationTypeID, Title, Fees);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetApplicationTypesList()
        {
            return clsApplicationTypeDataAccess.GetApplicationTypes();
        }
    }
}
