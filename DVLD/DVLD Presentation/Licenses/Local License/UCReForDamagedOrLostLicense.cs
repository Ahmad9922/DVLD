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
    public partial class UCReForDamagedOrLostLicense : UserControl
    {
        clsLocalLicense ReplacedLocalLicense;
        clsApplicationType ApplicationType;

        public UCReForDamagedOrLostLicense()
        {
            InitializeComponent();

            ApplicationType = clsApplicationType.Find(clsApplicationType.enApplicationTypeID.ReplacementforaLostDrivingLicense);
        }

        public void FillApplicationInfo()
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationFees.Text = ApplicationType.ApplicationFees.ToString();
            lblCreatedBy.Text = clsGeneralProperties.RegisteredUser.UserName;
        }

        private void ReplacementLicense(clsApplication Application)
        {
            if ((ReplacedLocalLicense = ucLicenseCardWithFilter1.License.Replace(Application,
                 clsGeneralProperties.RegisteredUser)) != null)
            {
                lblRApplicationID.Text = Application.ApplicationID.ToString();
                lblReplacedLicenseID.Text = ReplacedLocalLicense.LicenseID.ToString();

                MessageBox.Show("The license has been successfully replaced, and its ID " +
                    ReplacedLocalLicense.LicenseID.ToString(),
                  "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnShowNewLicenseInfo.Enabled = true;
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This license will be replaced with a new ID, and the previous ID will be canceled. Do you want to proceed?",
                     "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsApplication Application =
                        new clsApplication(ucLicenseCardWithFilter1.License.Driver.Person,
                        ApplicationType, clsGeneralProperties.RegisteredUser);

                if (Application.Save())
                {
                    ReplacementLicense(Application);
                }

                btnIssue.Enabled = false;
                ucLicenseCardWithFilter1.FilterEnable = false;
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
            frmLicenseCard LicenseCardForm = new frmLicenseCard(ReplacedLocalLicense.LicenseID.Value);
            LicenseCardForm.ShowDialog();
        }

        private void ReplacementOptions_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLost.Checked)
                ApplicationType = clsApplicationType.Find(clsApplicationType.enApplicationTypeID.ReplacementforaLostDrivingLicense);
            else
                ApplicationType = clsApplicationType.Find(clsApplicationType.enApplicationTypeID.ReplacementforaDamagedDrivingLicense);

            lblApplicationFees.Text = ApplicationType.ApplicationFees.ToString();
        }

        private void ucLicenseCardWithFilter1_OnLicenseSelected(int LicenseID)
        {
            if (ucLicenseCardWithFilter1.License != null)
            {
                lblOldLicenseID.Text = ucLicenseCardWithFilter1.License.LicenseID.ToString();
                btnShowLicensesHistory.Enabled = true;

                if (ucLicenseCardWithFilter1.License.IsActive)
                {
                    btnIssue.Enabled = true;
                    return;
                }
                else
                {
                    MessageBox.Show("This license is inactive. An active license must be entered for replacement.",
                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            btnIssue.Enabled = false;
            btnShowNewLicenseInfo.Enabled = false;
        }
    }
}
