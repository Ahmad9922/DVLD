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
    public partial class UCAddInternationalLicense : UserControl
    {
        clsInternationalLicense InternationalLicense;

        public UCAddInternationalLicense()
        {
            InitializeComponent();
        }

        public void FillApplicationInfo()
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblFees.Text = clsApplicationType.Find(6).Fees.ToString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            lblCreatedBy.Text = clsGeneralProperties.RegisteredUser.UserName;
        }

        public void Clear()
        {
            InternationalLicense = null;

            lblLocalLicenseID.Text = "???";
            lblInternationalLicenseAppID.Text = "???";
            lblInternationalLicenseID.Text = "???";
        }

        private void AddInternationalLicense(clsApplication Application)
        {
            if ((InternationalLicense = clsInternationalLicense.Add(Application,
                ucLicenseCardWithFilter1.License, clsGeneralProperties.RegisteredUser)) != null)
            {
                lblInternationalLicenseAppID.Text = Application.ApplicationID.ToString();

                if (InternationalLicense.Save())
                {
                    lblInternationalLicenseID.Text = InternationalLicense.LicenseID.ToString();

                    MessageBox.Show("The License has been saved successfully .",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnShowNewLicenseInfo.Enabled = true;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ucLicenseCardWithFilter1.SearchBoxValue))
                ucLicenseCardWithFilter1.FillLicenseInfo(Convert.ToInt32(ucLicenseCardWithFilter1.SearchBoxValue));

            if (ucLicenseCardWithFilter1.License != null)
            {
                btnShowLicensesHistory.Enabled = true;

                if (ucLicenseCardWithFilter1.License.IsActive
                    && (ucLicenseCardWithFilter1.License.ExpirationDate > DateTime.Now))
                {
                    if (ucLicenseCardWithFilter1.License.LicenseClass.LicenseClassID == 3)
                    {
                        if (!clsInternationalLicense.IsInternationalDrivingLicenseIssued
                            (ucLicenseCardWithFilter1.License.LicenseID))
                        {
                            lblLocalLicenseID.Text = ucLicenseCardWithFilter1.License.LicenseID.ToString();
                            btnIssue.Enabled = true;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("This person already has an active international license",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The ID does not belong to an Ordinary Driving License," +
                            " An ID number associated with a Class 3 license must be entered.",
                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The entered license is either inactive or expired.",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            btnIssue.Enabled = false;
            btnShowLicensesHistory.Enabled = false;
            ucLicenseCardWithFilter1.Clear();
            this.Clear();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (!clsInternationalLicense.
                IsInternationalDrivingLicenseIssued(ucLicenseCardWithFilter1.License.LicenseID))
            {
                clsApplication Application =
                    new clsApplication(ucLicenseCardWithFilter1.License.Driver.Person,
                    clsApplicationType.Find(6), clsGeneralProperties.RegisteredUser);

                if (Application.Save())
                {
                    AddInternationalLicense(Application);
                }
            }
        }

        private void btnShowLicensesHistory_Click(object sender, EventArgs e)
        {
            frmLicenseHistory LicenseHistoryForm = new
                frmLicenseHistory(ucLicenseCardWithFilter1.License.Driver.DriverID);
        }

        private void btnShowNewLicenseInfo_Click(object sender, EventArgs e)
        {
            frmLicenseCard LicenseCardForm = new frmLicenseCard(ucLicenseCardWithFilter1.License.LicenseID);
            LicenseCardForm.ShowDialog();
        }
    }
}
