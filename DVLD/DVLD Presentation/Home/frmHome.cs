using DVLD;
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

namespace DVLDPresentation
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void tmsiManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes ManageApplicationTypesForm = new frmManageApplicationTypes();
            ManageApplicationTypesForm.ShowDialog();
        }

        private void tmsiManageTestTypes_Click(object sender, EventArgs e)
        {
            frmManageTestTypes ManageTestTypesForm = new frmManageTestTypes();
            ManageTestTypesForm.ShowDialog();
        }

        private void LocalDrivingLicenseApplications_Click(object sender, EventArgs e)
        {
            frmLDLApplications LDLApplicationsForm = new frmLDLApplications();
            LDLApplicationsForm.ShowDialog();
        }

        private void tsmiLocalLicense_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateLocalDLA AddAndUpdateLocalDLAForm = new frmAddAndUpdateLocalDLA();
            AddAndUpdateLocalDLAForm.ShowDialog();
        }

        private void tsmiInternationalLicense_Click(object sender, EventArgs e)
        {
            frmIssueInternationalDrivingLicense IssueInternationalDrivingLicenseForm
                = new frmIssueInternationalDrivingLicense();
            IssueInternationalDrivingLicenseForm.ShowDialog();
        }

        private void internationalDrivingLiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalDLApplications InternationalDLApplicationsForm = new
                frmInternationalDLApplications();
            InternationalDLApplicationsForm.ShowDialog();
        }

        private void tsmiRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            frmRenewDrivingLicense RenewDrivingLicenseForm = new frmRenewDrivingLicense();
            RenewDrivingLicenseForm.ShowDialog();
        }

        private void tsmiReplacemecnt_Click(object sender, EventArgs e)
        {
            frmReplacementLicense ReplacementLicenseForm = new frmReplacementLicense();
            ReplacementLicenseForm.ShowDialog();
        }

        private void tsmiDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense DetainLicenseForm = new frmDetainLicense();
            DetainLicenseForm.ShowDialog();
        }

        private void tsmiManageDetainedLicenses_Click(object sender, EventArgs e)
        {
            frmDetainedLicenses DetainedLicensesForm = new frmDetainedLicenses();
            DetainedLicensesForm.ShowDialog();
        }

        private void tsmiReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense ReleaseDetainedLicenseForm = new frmReleaseDetainedLicense();
            ReleaseDetainedLicenseForm.ShowDialog();
        }
    }
}
