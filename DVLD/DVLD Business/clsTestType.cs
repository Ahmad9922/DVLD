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
        public enum enMode { AddNew = 1, Update = 2 }
        private enMode Mode { get; set; }

        public enum enTestTypeID { None = 0, Vision = 1, Written = 2, Street = 3};

        public enTestTypeID TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestTypeFees { get; set; }

        private clsTestType(enTestTypeID TestTypeID, string Title, string Description, decimal Fees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = Title;
            this.TestTypeDescription = Description;
            this.TestTypeFees = Fees;

            Mode = enMode.Update;
        }

        private clsTestType(clsTestTypeDataAccess.clsTestTypeData TestTypeData)
        {
            this.TestTypeID = (enTestTypeID)TestTypeData.TestTypeID.Value;
            this.TestTypeTitle = TestTypeData.TestTypeTitle;
            this.TestTypeDescription = TestTypeData.TestTypeDescription;
            this.TestTypeFees = TestTypeData.TestTypeFees;

            Mode = enMode.Update;
        }


        private bool _AddNew()
        {
            clsTestTypeDataAccess.clsTestTypeData TestTypeData
            = new clsTestTypeDataAccess.clsTestTypeData()
            {
                TestTypeID = null,
                TestTypeTitle = this.TestTypeTitle,
                TestTypeDescription = this.TestTypeDescription,
                TestTypeFees = this.TestTypeFees,
            };

            this.TestTypeID = (enTestTypeID)clsTestTypeDataAccess.AddNew(TestTypeData);

            return (TestTypeID != enTestTypeID.None);
        }

        private bool _Update()
        {
            clsTestTypeDataAccess.clsTestTypeData TestTypeData
            = new clsTestTypeDataAccess.clsTestTypeData()
            {

                TestTypeID = Convert.ToInt32(this.TestTypeID),
                TestTypeTitle = this.TestTypeTitle,
                TestTypeDescription = this.TestTypeDescription,
                TestTypeFees = this.TestTypeFees,
            };

            return clsTestTypeDataAccess.Update(TestTypeData);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNew())
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

        public static clsTestType Find(enTestTypeID TestTypeID)
        {
            clsTestTypeDataAccess.clsTestTypeData TestTypeData = new clsTestTypeDataAccess.clsTestTypeData();

            TestTypeData.TestTypeID = Convert.ToInt32(TestTypeID);

            if (clsTestTypeDataAccess.GetTestTypeByID(TestTypeData))
            {
                return new clsTestType(TestTypeData);
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

        public static enTestTypeID GetTestType(int LocalDLAID)
        {
            return Find((enTestTypeID)(clsLocalDLA.Find(LocalDLAID).PassedTests + 1)).TestTypeID;
        }
    }
}
