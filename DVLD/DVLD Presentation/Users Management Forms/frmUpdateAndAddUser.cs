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
    public partial class frmUpdateAndAddUser : Form
    {
        enum Mode { AddNew = 0, Update = 1 }

        private Mode mode;

        public frmUpdateAndAddUser()
        {
            InitializeComponent();
            this.Text = "Add User";

            mode = Mode.AddNew;
        }

        public frmUpdateAndAddUser(int UserID)
        {
            InitializeComponent();
            this.Text = "Update User";

            ucAddUser.SetUser(UserID);
            ucPersonCardWithFilter1.FilterBox = clsUser.Find(UserID).Person.ToString();
            ucPersonCardWithFilter1.FilterEnabled = false;
            tcLevelsSave.SelectTab(1);

            mode = Mode.Update;
        }

        private bool IsThePersonAlreadyAUser()
        {
            if (mode == Mode.Update)
                return false;

            if (clsUser.IsPersonExist(ucPersonCardWithFilter1.Person.PersonID))
            {
                MessageBox.Show("This person is already a user. Each person in the system can have only one account.",
                    "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return true;
            }

            return false;
        }

        private bool IsPersonSelected()
        {
            if (ucPersonCardWithFilter1.Person == null)
            {
                MessageBox.Show("You must select a person to make them a user..",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }

            return true;
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            if (!IsPersonSelected())
                return;

            if (!IsThePersonAlreadyAUser())
                tcLevelsSave.SelectTab(1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (!IsThePersonAlreadyAUser())
            {
                if (ucAddUser.SaveUser(ucPersonCardWithFilter1.Person.PersonID))
                    this.Close();
            }
        }

        private void tcLevelsSave_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!IsPersonSelected())
            {
                e.Cancel = true;
                return;
            }

            if (IsThePersonAlreadyAUser())
                e.Cancel = true;

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {

        }
    }
}
