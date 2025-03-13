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

            ApplicationType = clsApplicationType.Find(3);
            FillApplicationInfo();
        }

        public void FillApplicationInfo()
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationFees.Text = ApplicationType.Fees.ToString();
            lblCreatedBy.Text = clsGeneralProperties.RegisteredUser.UserName;
        }

        public void Clear()
        {
            ReplacedLocalLicense = null;

            lblOldLicenseID.Text = "???";
            lblRApplicationID.Text = "???";
            lblReplacedLicenseID.Text = "???";
        }

        private void ReplacementLicense(clsApplication Application)
        {
            if (rbLost.Checked)
                ReplacedLocalLicense = ucLicenseCardWithFilter1.License.ReplacementForLost(Application,
                clsGeneralProperties.RegisteredUser);
            else
                ReplacedLocalLicense = ucLicenseCardWithFilter1.License.ReplacementForDamaged(Application,
                   clsGeneralProperties.RegisteredUser);

            if (ReplacedLocalLicense  != null)
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
            frmLicenseCard LicenseCardForm = new frmLicenseCard(ReplacedLocalLicense.LicenseID);
            LicenseCardForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ucLicenseCardWithFilter1.SearchBoxValue))
                ucLicenseCardWithFilter1.FillLicenseInfo(Convert.ToInt32(ucLicenseCardWithFilter1.SearchBoxValue));

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

        private void ReplacementOptions_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLost.Checked)
                ApplicationType = clsApplicationType.Find(3);
            else
                ApplicationType = clsApplicationType.Find(4);

            lblApplicationFees.Text = ApplicationType.Fees.ToString();
        }
    }
}
