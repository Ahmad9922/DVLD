using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusiness
{
    public class clsTestType
    {
        public enum enTestType { Vision = 1, Written = 2, Street = 3};
        public enTestType TestType { get; private set; }

        public int TestTypeID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Fees { get; set; }

        private clsTestType(int TestTypeID, string Title, string Description, float Fees)
        {
            this.TestTypeID = TestTypeID;
            this.Title = Title;
            this.Description = Description;
            this.Fees = Fees;

            TestType = (enTestType)TestTypeID;
        }

        private bool _UpdateTestType()
        {
            return clsTestTypeDataAccess.UpdateTestType(TestTypeID, Title, Description, Fees);
        }

        public bool Save()
        {
            return _UpdateTestType();
        }

        public static clsTestType Find(int TestTypeID)
        {
            string Title = string.Empty, Description = string.Empty;
            float Fees = 0;

            if (clsTestTypeDataAccess.GetTestTypeByID(ref TestTypeID, ref Title, ref Description, ref Fees))
            {
                return new clsTestType(TestTypeID, Title, Description, Fees);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetTestTypesList()
        {
            return clsTestTypeDataAccess.GetTestTypes();
        }

        public static enTestType GetTestType(int LocalDLAID)
        {
            return Find((clsLocalDLA.Find(LocalDLAID).PassedTests + 1)).TestType;
        }
    }
}
