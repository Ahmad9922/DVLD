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
    public partial class frmUpdateAndAddPerson : Form
    {
        public event Action<int> OnPersonAdded;

        public frmUpdateAndAddPerson(int PersonID)
        {
            InitializeComponent();

            UCAddPerson1.LoadCountries();
            this.Text = "Update Person";
            lblMode.Text = "Update Person";
            UCAddPerson1.SetPerson(PersonID);
        }

        public frmUpdateAndAddPerson()
        {
            InitializeComponent();

            UCAddPerson1.LoadCountries();
            UCAddPerson1.OnPersonAdded += AddPerson_OnPersonAdded;
            this.Text = "Add New Person";
            lblMode.Text = "Add New Person";
        }

        private void AddPerson_OnPersonAdded(int PersonID)
        {
            if (OnPersonAdded != null)
                OnPersonAdded.Invoke(PersonID);
        }

        private void ucAddPerson1_SaveComplete()
        {
            this.Text = "Update Person";
            lblMode.Text = "Update Person";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (UCAddPerson1.SavePerson())
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
