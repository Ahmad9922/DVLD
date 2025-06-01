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
    public partial class frmIssueDrivingLicense : Form
    {
        public frmIssueDrivingLicense(int LocalDLAID)
        {
            InitializeComponent();
            
            ucLocalDLACard1.FillApplicatoin(LocalDLAID);
            ucIssueDrivingLicense1.AddLicense(LocalDLAID);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (ucIssueDrivingLicense1.Save())
            {
                this.Close();
            }
        }
    }
}
