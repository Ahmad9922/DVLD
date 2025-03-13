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
    public partial class UCAddLocalDLA : UserControl
    {
        private clsLocalDLA LocalDLA;

        public event Action OnSaveCompleted;

        enum enMode { AddNew = 0, Upadate = 1 }
        enMode Mode { get; set; }

        public UCAddLocalDLA()
        {
            InitializeComponent();

            Mode = enMode.AddNew;
        }

        public void SetLocalDLA(int LocalDLAID)
        {
            if ( (LocalDLA = clsLocalDLA.Find(LocalDLAID)) != null)
            {
                ucPersonCardWithFilter1.FilterBox = LocalDLA.ApplicantPerson.PersonID.ToString();
                lblApplicationIDValue.Text = LocalDLAID.ToString();
                lblApplicationDateValue.Text = LocalDLA.ApplicationDate.ToShortDateString();
                cbCountries.SelectedItem = LocalDLA.LicenseClass.ClassName;
                lblApplicationFeesValue.Text = LocalDLA.PaidFees.ToString();
                lblCreatedByValue.Text = LocalDLA.CreatedByUser.UserName;
                Mode = enMode.Upadate;
            }

            ucPersonCardWithFilter1.FilterEnabled = false;
        }

        private void LoadLicenseClasses()
        {
            cbCountries.Items.AddRange(clsLicenseClass.LicenseClassList().ToArray());
            cbCountries.SelectedIndex = 2;
        }

        public void FillApplicationInfo()
        {
            LoadLicenseClasses();
            lblApplicationIDValue.Text = "???";
            lblApplicationDateValue.Text = DateTime.Now.ToShortDateString();
            lblApplicationFeesValue.Text = clsApplicationType.Find(1).Fees.ToString();
            lblCreatedByValue.Text = clsGeneralProperties.RegisteredUser.UserName;
        }

        private bool IsPersonSelected()
        {
            if (ucPersonCardWithFilter1.Person == null)
            {
                MessageBox.Show("You must select a person to make them a user.",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }

            return true;
        }

        private bool IsAgeAllowedForClass()
        {
            short MinimumAllowedAge = clsLicenseClass.Find(
                Convert.ToString(cbCountries.SelectedItem)).MinimumAllowedAge;

            if (DateTime.Now.AddYears(-MinimumAllowedAge) > ucPersonCardWithFilter1.Person.DateOfBirth)
            {
                MessageBox.Show("Sorry, the minimum allowed age to obtain this class is 18 years.",
                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public void SelectApplicationInfoTab()
        {
            if (IsPersonSelected())
                tcLevelsSave.SelectTab(1);
            else
                tcLevelsSave.SelectTab(0);
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            SelectApplicationInfoTab();
        }

        private bool InfoValidation()
        {
            if (!IsPersonSelected())
                return false;

            if (!IsAgeAllowedForClass())
                return false;

            if (clsLocalDLA.IsApplicationRequiredOrCompleted(ucPersonCardWithFilter1.Person.PersonID,
                clsLicenseClass.GetID(Convert.ToString(cbCountries.SelectedItem))))
            {
                
                MessageBox.Show("Sorry, you cannot apply for a license of the same type more than once for the same person" +
                           " unless the previous application has been cancelled.",
                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private void AddLocalDLAInfo()
        {
            LocalDLA = new clsLocalDLA(ucPersonCardWithFilter1.Person, clsGeneralProperties.RegisteredUser);

            LocalDLA.ApplicationDate = DateTime.Now;
            LocalDLA.LastStatusDate = LocalDLA.ApplicationDate;

            LocalDLA.LicenseClass = clsLicenseClass.Find(cbCountries.SelectedItem.ToString());
        }

        private void UpdateLocalDLAInfo()
        {
            LocalDLA.LicenseClass = clsLicenseClass.Find(cbCountries.SelectedItem.ToString());
        }

        public bool Save()
        {
            if (InfoValidation())
            {
                switch (Mode)
                {
                    case enMode.AddNew:
                        AddLocalDLAInfo();
                        break;

                    case enMode.Upadate:
                        UpdateLocalDLAInfo();
                        break;
                }

                if (LocalDLA.Save())
                {
                    lblApplicationIDValue.Text = LocalDLA.LocalDLAID.ToString();

                    MessageBox.Show("The Application has been saved successfully .",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                else
                {
                    MessageBox.Show("Failed to save the Application. If the problem persists," +
                        " please seek assistance from the Service and Maintenance Center",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        private void tcLevelsSave_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 1)
                SelectApplicationInfoTab();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.Save())
            {
                if (OnSaveCompleted != null)
                    OnSaveCompleted.Invoke();
            }
        }
    }
}
