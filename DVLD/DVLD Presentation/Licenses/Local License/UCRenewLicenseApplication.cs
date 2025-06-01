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
        }

        public void FillApplicationInfo()
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationFees.Text = clsApplicationType.Find(clsApplicationType.enApplicationTypeID.RenewDrivingLicenseService).ApplicationFees.ToString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedBy.Text = clsGeneralProperties.RegisteredUser.UserName;
        }

        public void RenewLicense(clsApplication Application)
        {
            if ((RenewedLocalLicense = ucLicenseCardWithFilter1.License.Renew(txtNotes.Text, Application,
                    clsGeneralProperties.RegisteredUser)) != null)
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

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This license will be renewed with a new ID, and the previous ID will be canceled. Do you want to proceed?",
                      "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsApplication Application =
                        new clsApplication(ucLicenseCardWithFilter1.License.Driver.Person,
                        clsApplicationType.Find(clsApplicationType.enApplicationTypeID.RenewDrivingLicenseService), clsGeneralProperties.RegisteredUser);

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
                frmLicenseHistory(ucLicenseCardWithFilter1.License.Driver.DriverID.Value);
            LicenseHistoryForm.ShowDialog();
        }

        private void btnShowNewLicenseInfo_Click(object sender, EventArgs e)
        {
            frmLicenseCard LicenseCardForm = new frmLicenseCard(ucLicenseCardWithFilter1.License.LicenseID.Value);
            LicenseCardForm.ShowDialog();
        }

        private void ucLicenseCardWithFilter1_OnLicenseSelected(int LicenseID)
        {
            if (ucLicenseCardWithFilter1.License != null)
            {
                lblOldLicenseID.Text = ucLicenseCardWithFilter1.License.LicenseID.ToString();
                lblLicenseFees.Text = ucLicenseCardWithFilter1.License.LicenseClass.ClassFees.ToString();
                lblTotalFees.Text = Convert.ToString(ucLicenseCardWithFilter1.License.LicenseClass.ClassFees
                    + clsApplicationType.Find(clsApplicationType.enApplicationTypeID.RenewDrivingLicenseService).ApplicationFees);
                lblExpirationDate.Text = DateTime.Now.AddYears
                    (ucLicenseCardWithFilter1.License.LicenseClass.DefaultValidityLength).ToShortDateString();
                txtNotes.Text = ucLicenseCardWithFilter1.License.Notes;
                btnShowLicensesHistory.Enabled = true;

                if (ucLicenseCardWithFilter1.License.IsActive)
                {
                    if (ucLicenseCardWithFilter1.License.IsLicenseExpired())
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
                    MessageBox.Show("Sorry, selected License is not Active, choose an active license.",
                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            btnRenew.Enabled = false;
            btnShowNewLicenseInfo.Enabled = false;
        }
    }
}
