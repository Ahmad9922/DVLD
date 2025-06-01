using DVLDBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmPeople : Form
    {
        private int SelectedPersonID { get { return Convert.ToInt32(ucPeopleList.SelectedRow.Cells[0].Value); } }

        public frmPeople()
        {
            InitializeComponent();
        }

        private void RefreshPeople()
        {
            ucPeopleList.SetList(clsPerson.PeopleList());
        }

        private void Form_Load(object sender, EventArgs e)
        {
            RefreshPeople();
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            frmUpdateAndAddPerson AddNewPersonForm = new frmUpdateAndAddPerson();
            AddNewPersonForm.ShowDialog();

            RefreshPeople();
        }

        private void EditPerson_Click(object sender, EventArgs e)
        {
            frmUpdateAndAddPerson AddNewPersonForm
                = new frmUpdateAndAddPerson(SelectedPersonID);
            AddNewPersonForm.ShowDialog();

            RefreshPeople();
        }

        private void DeletePerson_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this person with the ID : "
                + SelectedPersonID.ToString(),
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (clsPerson.Delete(SelectedPersonID))
                {
                    MessageBox.Show("The person has been successfully deleted.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This person cannot be deleted because they are linked to " +
                        "other entities in the system.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            RefreshPeople();
        }

        private void ShowDetails_Click(object sender, EventArgs e)
        {
            frmPersonCard frmPersonCard = new frmPersonCard(SelectedPersonID);
            frmPersonCard.ShowDialog();

            RefreshPeople();
        }

        private string ConvertGendorField(string Value)
        {
            if (Value == "All")
                return "";
            else if (Value == "Male")
                return "0";
            else
                return "1";
        }

        private void ucPeopleList_FilterValueChanged(object sender, CustomControls.UCFilter2.ResultEventArgs e)
        {
            ucPeopleList.SetList(clsPerson.PeopleList(e.Value, e.FieldName));
        }
    }
}
