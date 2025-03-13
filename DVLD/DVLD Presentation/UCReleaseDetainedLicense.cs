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
    public partial class UCReleaseDetainedLicense : UserControl
    {
        public UCReleaseDetainedLicense()
        {
            InitializeComponent();
            FillInitialInfo();
        }

        public bool FilterEnable
        {
            get
            {
                return ucLicenseCardWithFilter1.FilterEnable;   
            }

            set
            {
                ucLicenseCardWithFilter1.FilterEnable = value;
            }
        }

        public void ReleaseDetainedLicense(int LicenseID)
        {
            FillDetainedLicenseInfo(LicenseID);
            btnSearch.Enabled = false;
        }

        private void FillDetainedLicenseInfo(int LicenseID)
        {
            ucLicenseCardWithFilter1.FillLicenseInfo(LicenseID);

            if (ucLicenseCardWithFilter1.License != null)
            {
                btnShowLicensesHistory.Enabled = true;

                if (ucLicenseCardWithFilter1.License.IsDetain)
                {
                    FillDetainInfo();
                    btnRelease.Enabled = true;
                    return;
                }
                else
                {
                    MessageBox.Show("Sorry, There is no detained license with the ID you entered.",
                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            btnRelease.Enabled = false;
            btnShowLicenseInfo.Enabled = false;
        }

        private void FillInitialInfo()
        {
            lblApplicationFees.Text = clsApplicationType.Find(5).Fees.ToString();
            lblCreatedBy.Text = clsGeneralProperties.RegisteredUser.UserName;
        }

        private void FillDetainInfo()
        {
            clsDetain Detain = clsDetain.FindByDetainedLicense
                   (ucLicenseCardWithFilter1.License.LicenseID);

            float FineFees = Detain.FineFees;

            lblDetainID.Text = Detain.DetainID.ToString();
            lblDetainDate.Text = Detain.DetainDate.ToShortDateString();
            lblLicenseID.Text = ucLicenseCardWithFilter1.License.LicenseID.ToString();
            lblFineFees.Text = FineFees.ToString();
            lblTotalFees.Text = Convert.ToString(FineFees + clsApplicationType.Find(5).Fees);
        }

        private void ReleaseDetainedLicense(clsApplication Application)
        {
            if (ucLicenseCardWithFilter1.License.ReleaseDetained(Application, clsGeneralProperties.RegisteredUser))
            {
                lblApplicationID.Text = Application.ApplicationID.ToString();

                MessageBox.Show("The license has been successfully Released.",
                  "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnShowLicenseInfo.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ucLicenseCardWithFilter1.SearchBoxValue))
                FillDetainedLicenseInfo(Convert.ToInt32(ucLicenseCardWithFilter1.SearchBoxValue));
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The selected license will be released. Do you want to proceed?",
                      "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsApplication Application =
                        new clsApplication(ucLicenseCardWithFilter1.License.Driver.Person,
                        clsApplicationType.Find(5), clsGeneralProperties.RegisteredUser);

                if (Application.Save())
                {
                    ReleaseDetainedLicense(Application);
                }

                btnRelease.Enabled = false;
            }
        }

        private void btnShowLicensesHistory_Click(object sender, EventArgs e)
        {
            frmLicenseHistory LicenseHistoryForm = new
                frmLicenseHistory(ucLicenseCardWithFilter1.License.Driver.DriverID);
            LicenseHistoryForm.ShowDialog();
        }

        private void btnShowLicenseInfo_Click(object sender, EventArgs e)
        {
            frmLicenseCard LicenseCardForm = new frmLicenseCard(ucLicenseCardWithFilter1.License.LicenseID);
            LicenseCardForm.ShowDialog();
        }
    }
}
