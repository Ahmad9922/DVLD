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

        public event Action<int> OnLicenseSelected;

        public bool FilterEnable
        { 
            get
            {
                return ucFilter.FilterEnabled;
            }

            set
            {
                ucFilter.FilterEnabled = value;
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

        public clsFilterProperty[] FilterProperties
        {
            get
            {
                return ucFilter.FilterProperties;
            }

            set
            {
                ucFilter.FilterProperties = value;
            }
        }


        private void Filter_FilterResultChange(string arg1, string arg2)
        {
            ucLicenseCard1.FillLocalLicenseInfo(int.Parse(arg1));
            OnLicenseSelected?.Invoke(ucLicenseCard1.License?.LicenseID ?? -1);
        }

        public void FillLicenseInfo(int LicenseID)
        {
            ucFilter.TextBoxFocus();
            ucFilter.SearchBoxValue = LicenseID.ToString();
            ucLicenseCard1.FillLocalLicenseInfo(LicenseID);
            OnLicenseSelected?.Invoke(ucLicenseCard1.License?.LicenseID ?? -1);
        }

        public void Clear()
        {
            ucLicenseCard1.Clear();
        }

        private void Filter_SearchButtonClick(string arg1, string arg2)
        {
            ucLicenseCard1.FillLocalLicenseInfo(int.Parse(arg1));
            OnLicenseSelected?.Invoke(ucLicenseCard1.License?.LicenseID ?? -1);
        }
    }
}
