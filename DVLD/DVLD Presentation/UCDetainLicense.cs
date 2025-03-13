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
    public partial class UCDetainLicense : UserControl
    {
        clsDetain Detain;

        public UCDetainLicense()
        {
            InitializeComponent();
        }

        private void FillDetainInfo()
        {
            lblDetainDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedBy.Text = clsGeneralProperties.RegisteredUser.UserName;
        }

        private void DetainLicense()
        {
            if ((Detain = ucLicenseCardWithFilter1.License.Detain(Convert.ToSingle(nudFineFees.Value),
                clsGeneralProperties.RegisteredUser)) != null)
            {
                lblDetainID.Text = Detain.DetainID.ToString();

                MessageBox.Show("The license has been successfully Detained.",
                 "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnShowLicenseInfo.Enabled = true;
            }
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This license will be detained and deactivated. Are you sure you want to detain this license?",
                     "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DetainLicense();

                btnDetain.Enabled = false;
            }
        }

        private void btnShowNewLicenseInfo_Click(object sender, EventArgs e)
        {
            frmLicenseCard LicenseCardForm = new frmLicenseCard(ucLicenseCardWithFilter1.License.LicenseID);
            LicenseCardForm.ShowDialog();
        }

        private void btnShowLicensesHistory_Click(object sender, EventArgs e)
        {
            frmLicenseHistory LicenseHistoryForm = new
               frmLicenseHistory(ucLicenseCardWithFilter1.License.Driver.DriverID);
            LicenseHistoryForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ucLicenseCardWithFilter1.SearchBoxValue))
                ucLicenseCardWithFilter1.FillLicenseInfo(Convert.ToInt32(ucLicenseCardWithFilter1.SearchBoxValue));

            if (ucLicenseCardWithFilter1.License != null)
            {
                lblLicenseID.Text = ucLicenseCardWithFilter1.License.LicenseID.ToString();
                btnShowLicensesHistory.Enabled = true;

                if (!ucLicenseCardWithFilter1.License.IsDetain)
                {
                    btnDetain.Enabled = true;
                    return;
                }
                else
                {
                    MessageBox.Show("Sorry, this license is already detained.",
                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            btnDetain.Enabled = false;
            btnShowLicenseInfo.Enabled = false;
        }
    }
}
