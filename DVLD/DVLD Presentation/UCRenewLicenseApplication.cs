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
    public partial class UCRenewLicenseApplication : UserControl
    {
        clsLocalLicense RenewedLocalLicense;

        public UCRenewLicenseApplication()
        {
            InitializeComponent();
            FillApplicationInfo();
        }

        public void FillApplicationInfo()
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationFees.Text = clsApplicationType.Find(2).Fees.ToString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            lblCreatedBy.Text = clsGeneralProperties.RegisteredUser.UserName;
        }

        public void Clear()
        {
            RenewedLocalLicense = null;

            lblOldLicenseID.Text = "???";
            lblRenewLicenseAppID.Text = "???";
            lblRenewedLicenseID.Text = "???";
            lblLicenseFees.Text = "???";
            lblTotalFees.Text = "???";
        }

        public void RenewLicense(clsApplication Application)
        {
            if ((RenewedLocalLicense = clsLocalLicense.Renew(Application, ucLicenseCardWithFilter1.License,
                    clsGeneralProperties.RegisteredUser)) != null)
            {
                RenewedLocalLicense.Notes = txtNotes.Text;

                if (RenewedLocalLicense.Save())
                {
                    lblRenewLicenseAppID.Text = Application.ApplicationID.ToString();
                    lblRenewedLicenseID.Text = RenewedLocalLicense.LicenseID.ToString();

                    ucLicenseCardWithFilter1.License.IsActive = false;
                    ucLicenseCardWithFilter1.License.Save();

                    MessageBox.Show("The license has been successfully renewed, and its ID " + 
                        RenewedLocalLicense.LicenseID.ToString(),
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
                lblOldLicenseID.Text = ucLicenseCardWithFilter1.License.LicenseID.ToString();
                lblLicenseFees.Text = ucLicenseCardWithFilter1.License.LicenseClass.ClassFees.ToString();
                lblTotalFees.Text = Convert.ToString(ucLicenseCardWithFilter1.License.LicenseClass.ClassFees
                    + clsApplicationType.Find(2).Fees);
                btnShowLicensesHistory.Enabled = true;

                if (ucLicenseCardWithFilter1.License.IsActive)
                {
                    if (ucLicenseCardWithFilter1.License.ExpirationDate < DateTime.Now)
                    {
                        btnRenew.Enabled = true;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("This license is not expired. It will expire on " +
                            ucLicenseCardWithFilter1.License.ExpirationDate.ToShortDateString(),
                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, it looks like the license has already been renewed.",
                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            btnRenew.Enabled = false;
            btnShowNewLicenseInfo.Enabled = false;
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This license will be renewed with a new ID, and the previous ID will be canceled. Do you want to proceed?",
                      "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsApplication Application =
                        new clsApplication(ucLicenseCardWithFilter1.License.Driver.Person,
                        clsApplicationType.Find(2), clsGeneralProperties.RegisteredUser);

                if (Application.Save())
                {
                    RenewLicense(Application);
                }

                btnRenew.Enabled = false;
            }
        }

        private void btnShowLicensesHistory_Click(object sender, EventArgs e)
        {
            frmLicenseHistory LicenseHistoryForm = new
                frmLicenseHistory(ucLicenseCardWithFilter1.License.Driver.DriverID);
            LicenseHistoryForm.ShowDialog();
        }

        private void btnShowNewLicenseInfo_Click(object sender, EventArgs e)
        {
            frmLicenseCard LicenseCardForm = new frmLicenseCard(ucLicenseCardWithFilter1.License.LicenseID);
            LicenseCardForm.ShowDialog();
        }
    }
}
