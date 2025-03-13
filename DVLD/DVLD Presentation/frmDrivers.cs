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
    public partial class frmDrivers : Form
    {
        public frmDrivers()
        {
            InitializeComponent();
        }

        private void ucDriversList_Load(object sender, EventArgs e)
        {
            ucDriversList.SetList(clsDriver.GetDriversList());
        }

        private void ucDriversList_FilterResultChange(string arg1, string arg2)
        {
            ucDriversList.SetList(clsDriver.GetDriversList(arg1, arg2));
        }

        private void tsmiShowDriverLicenseHistory_Click(object sender, EventArgs e)
        {
            frmLicenseHistory LicenseHistoryForm =
                new frmLicenseHistory(Convert.ToInt32(ucDriversList.SelectedRow.Cells[0].Value));
            LicenseHistoryForm.ShowDialog();
        }
    }
}
