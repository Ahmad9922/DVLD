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
    public partial class UCDriverLicenses : UserControl
    {
        public UCDriverLicenses()
        {
            InitializeComponent();
        }

        public void FillLicenses(int DriverID)
        {
            ucLocalLicenseList.DataSource = clsLocalLicense.GetLicenseList(DriverID);
            ucInternationalLicenseList.DataSource = clsInternationalLicense.GetLicenseList(DriverID.ToString(), "Driver ID");
        }

        private void tsmiShowLicense_Click(object sender, EventArgs e)
        {
            frmLicenseCard LicenseCardForm =
               new frmLicenseCard(Convert.ToInt32(ucLocalLicenseList.SelectedRow.Cells[0].Value));
            LicenseCardForm.ShowDialog();
        }
    }
}
