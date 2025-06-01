using CustomControls;
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

namespace DVLD
{
    public partial class UCPersonCardWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;

        public UCPersonCardWithFilter()
        {
            InitializeComponent();
        }

        public bool FilterEnabled
        { 
            get
            {
                return ucFilter1.Enabled;
            }

            set
            {
                ucFilter1.Enabled = value;
            }
        }

        public string FilterBox
        {  
            get
            {
                return ucFilter1.TextBoxValue;
            }
            set
            {
                ucFilter1.TextBoxValue = value;
            }
        } 
      
        public clsPerson Person
        {
            get
            {
                return ucPersonCard1.PersonInfo;
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmUpdateAndAddPerson AddPersonForm = new frmUpdateAndAddPerson();
            AddPersonForm.OnPersonAdded += AddPersonForm_OnPersonAdded;
            AddPersonForm.ShowDialog();
        }

        private void AddPersonForm_OnPersonAdded(int PersonID)
        {
            ucFilter1.TextBoxValue = PersonID.ToString();
        }

        private void ucFilter1_SearchButtonClick(object sender, CustomControls.UCFilter2.ResultEventArgs e)
        {
            bool IsFound = false;

            if (!string.IsNullOrEmpty(e.Value))
            {
                switch (e.FieldName)
                {
                    case "PersonID":
                        IsFound = ucPersonCard1.SetPerson(int.Parse(e.Value));
                        break;

                    case "NationalNo":
                        IsFound = ucPersonCard1.SetPerson(e.Value);
                        break;
                }
            }

            if (IsFound)
                OnPersonSelected?.Invoke(ucPersonCard1.PersonInfo.PersonID.Value);
            else
                ucPersonCard1.Clear();
        }

        public void TextFocus()
        {
            ucFilter1.TextFocus();
        }
    }
}
