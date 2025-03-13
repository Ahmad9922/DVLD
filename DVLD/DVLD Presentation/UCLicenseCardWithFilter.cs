using DVLDBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD.UCFilter;

namespace DVLD
{
    public partial class UCLicenseCardWithFilter : UserControl
    {
        public UCLicenseCardWithFilter()
        {
            InitializeComponent();
        }

        public event Action<string, string> FilterResultChange;

        public bool FilterEnable
        { 
            get
            {
                return ucFilter.Enabled;
            }

            set
            {
                ucFilter.Enabled = value;
            }
        }

        public clsLocalLicense License
        {
            get
            {
                return ucLicenseCard1.License;
            }

            set
            {
                ucLicenseCard1.License = value;
            }
        }

        public string SearchBoxValue
        {
            get
            {
                return ucFilter.SearchBoxValue;
            }

            set
            {
                ucFilter.SearchBoxValue = value;
            }
        }

        public string FilterTitle
        {
            get
            {
                return ucFilter.Title;
            }

            set
            {
                ucFilter.Title = value;
            }
        }

        public string[] FieldName
        {
            get
            {
                return ucFilter.FieldName;
            }

            set
            {
                ucFilter.FieldName = value;
            }
        }

        public enFieldMask[] FieldMask
        {
            get
            {
                return ucFilter.FieldMask;
            }

            set
            {
                ucFilter.FieldMask = value;
            }
        }

        public enSearchType[] SearchType
        {
            get
            {
                return ucFilter.SearchType;
            }

            set
            {
                ucFilter.SearchType = value;
            }
        }

        private void Filter_FilterResultChange(string arg1, string arg2)
        {
            if (FilterResultChange != null)
                FilterResultChange.Invoke(arg1, arg2);
        }

        public void FillLicenseInfo(int LicenseID)
        {
            ucLicenseCard1.FillLocalLicenseInfo(LicenseID);
        }

        public void Clear()
        {
            ucLicenseCard1.Clear();
        }
    }
}
