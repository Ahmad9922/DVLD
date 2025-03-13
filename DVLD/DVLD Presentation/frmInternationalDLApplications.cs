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

            ucListWithFilter.SetComboBoxItems("IsActive", new List<object> { "Yes", "No" });
        }

        private string ConvertActiveField(string Value)
        {
            if (Value == "All")
                return "";
            else if (Value == "Yes")
                return "1";
            else
                return "0";
        }

        private void ucListWithFilter_FilterResultChange(string Value, string FieldName)
        {
            if (FieldName == "IsActive")
                Value = ConvertActiveField(Value);

            ucListWithFilter.SetList(clsInternationalLicense.GetLicenseList(Value, FieldName));
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
                .Driver.Person.PersonID);

            PersonCardForm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmLicenseCard frmLicenseCard =
                new frmLicenseCard(Convert.ToInt32(ucListWithFilter.SelectedRow.Cells[0].Value), false);
            frmLicenseCard.ShowDialog();
        }
    }
}
