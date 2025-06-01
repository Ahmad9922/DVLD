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
    public partial class frmInternationalDLApplications : Form
    {
        public frmInternationalDLApplications()
        {
            InitializeComponent();
            ucListWithFilter.SetList(clsInternationalLicense.GetLicenseList());
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            frmIssueInternationalDrivingLicense IssueInternationalDrivingLicenseForm 
                = new frmIssueInternationalDrivingLicense();
            IssueInternationalDrivingLicenseForm.ShowDialog();
        }

        private void tsmiShowDriverLicenseHistory_Click(object sender, EventArgs e)
        {
            frmLicenseHistory LicenseHistoryForm = new
                frmLicenseHistory(Convert.ToInt32(ucListWithFilter.SelectedRow.Cells["Driver ID"].Value));
            LicenseHistoryForm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPersonCard PersonCardForm
                = new frmPersonCard
                (clsInternationalLicense.Find(Convert.ToInt32(ucListWithFilter.SelectedRow.Cells[0].Value))
                .Driver.Person.PersonID.Value);

            PersonCardForm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmLicenseCard frmLicenseCard =
                new frmLicenseCard(Convert.ToInt32(ucListWithFilter.SelectedRow.Cells[0].Value), false);
            frmLicenseCard.ShowDialog();
        }

        private void ucListWithFilter_FilterValueChanged(object sender, CustomControls.UCFilter2.ResultEventArgs e)
        {
            ucListWithFilter.SetList(clsInternationalLicense.GetLicenseList(e.Value, e.FieldName));
        }
    }
}
