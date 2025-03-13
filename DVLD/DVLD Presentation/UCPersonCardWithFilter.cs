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
                return ucFilter1.SearchBoxValue;
            }
            set
            {
                ucFilter1.SearchBoxValue = value;
            }
        } 
      
        public clsPerson Person
        {
            get
            {
                return ucPersonCard1.PersonInfo;
            }
        }

        private void ucFilter1_FilterResultChange(string Value, string FieldName)
        {
            bool IsFound = false;

            if (!string.IsNullOrEmpty(Value))
            {
                switch (FieldName)
                {
                    case "PersonID":
                        IsFound = ucPersonCard1.SetPerson(int.Parse(Value));
                        break;

                    case "NationalNo":
                        IsFound = ucPersonCard1.SetPerson(Value);
                        break;
                }
            }
            if (!IsFound)
                ucPersonCard1.Clear();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmUpdateAndAddPerson AddPersonForm = new frmUpdateAndAddPerson();
            AddPersonForm.OnPersonAdded += AddPersonForm_OnPersonAdded;
            AddPersonForm.ShowDialog();
        }

        private void AddPersonForm_OnPersonAdded(int PersonID)
        {
            ucFilter1.SearchBoxValue = PersonID.ToString();
        }
    }
}
