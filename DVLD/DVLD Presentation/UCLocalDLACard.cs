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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class UCLocalDLACard : UserControl
    {
        public clsLocalDLA LocalDLA { get; set; }

        public UCLocalDLACard()
        {
            InitializeComponent();
        }

        public void FillApplicatoin(int LocalDLAID)
        {
            if ((LocalDLA = clsLocalDLA.Find(LocalDLAID)) != null)
            {
                lblILocalDLAD.Text = LocalDLA.LocalDLAID.ToString();
                lblApplaidForLicense.Text = LocalDLA.LicenseClass.ClassName;
                lblPassedTests.Text = LocalDLA.PassedTests.ToString();
                ucApplicationCard.FillApplication(LocalDLA.ApplicationID);

                if (clsLocalLicense.IsLocalLicenseIssued(LocalDLA.LocalDLAID))
                    btnViewLicenseInfo.Enabled = true;
            }
        }

        private void btnViewLicenseInfo_Click(object sender, EventArgs e)
        {
            frmLicenseCard LicenseCardForm =
                new frmLicenseCard(clsLocalLicense.GetLicenseID(LocalDLA.LocalDLAID));
            LicenseCardForm.ShowDialog();
        }
    }
}
