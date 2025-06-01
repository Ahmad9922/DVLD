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
    public partial class frmLicenseCard : Form
    {
        public frmLicenseCard(int LicenseID, bool IsLocal = true)
        {
            InitializeComponent();

            if (IsLocal)
                ucLicenseCard1.FillLocalLicenseInfo(LicenseID);
            else
                ucLicenseCard1.FillInternationalLicenseInfo(LicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
