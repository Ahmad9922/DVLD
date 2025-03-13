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
    public partial class frmDetainedLicenses : Form
    {
        public frmDetainedLicenses()
        {
            InitializeComponent();

            ucListWithFilter.SetList(clsDetain.GetDetainsList());
            ucListWithFilter.SetComboBoxItems("Is Release", new List<object> { "All", "Yes", "No" });
        }

        private string ConvertIsReleaseField(string Value)
        {
            if (Value == "All")
                return "";
            else if (Value == "Yes")
                return "1";
            else
                return "0";
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense DetainLicenseForm = new frmDetainLicense();
            DetainLicenseForm.ShowDialog();

            ucListWithFilter.SetList(clsDetain.GetDetainsList());
        }

        private void ucListWithFilter_FilterResultChange(string Value, string ColumnName)
        {
            if (ColumnName == "Is Release")
                Value = ConvertIsReleaseField(Value);

            ucListWithFilter.SetList(clsDetain.GetDetainsList(Value, ColumnName));
        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense ReleaseDetainedLicenseForm = new frmReleaseDetainedLicense();
            ReleaseDetainedLicenseForm.ShowDialog();
        }

        private void tsmiShowDriverLicenseHistory_Click(object sender, EventArgs e)
        {
            frmLicenseHistory LicenseHistoryForm = new
                frmLicenseHistory(clsDetain.Find(Convert.ToInt32(ucListWithFilter.SelectedRow.Cells[0].Value)).
                DetainedLicense.Driver.DriverID);
            LicenseHistoryForm.ShowDialog();
        }

        private void ShowPersonDetails_Click(object sender, EventArgs e)
        {
            frmPersonCard PersonCardForm
                = new frmPersonCard
                (clsPerson.Find(Convert.ToString(ucListWithFilter.SelectedRow.Cells["National No"].Value)).PersonID);

            PersonCardForm.ShowDialog();
        }

        private void ShowLicenseDetails_Click(object sender, EventArgs e)
        {
            frmLicenseCard frmLicenseCard =
                new frmLicenseCard(Convert.ToInt32(ucListWithFilter.SelectedRow.Cells[1].Value));
            frmLicenseCard.ShowDialog();
        }

        private void tsmiReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense ReleaseDetainedLicenseForm =
                new frmReleaseDetainedLicense(Convert.ToInt32(ucListWithFilter.SelectedRow.Cells[1].Value));
            ReleaseDetainedLicenseForm.ShowDialog();

            ucListWithFilter.SetList(clsDetain.GetDetainsList());
        }
    }
}
