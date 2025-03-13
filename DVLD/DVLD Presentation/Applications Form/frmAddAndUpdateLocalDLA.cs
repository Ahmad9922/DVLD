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
    public partial class frmAddAndUpdateLocalDLA : Form
    {
        public frmAddAndUpdateLocalDLA()
        {
            InitializeComponent();
            ucAddLocalDLA.FillApplicationInfo();
        }

        public frmAddAndUpdateLocalDLA(int LocalDLAID)
        {
            InitializeComponent();

            ucAddLocalDLA.FillApplicationInfo();
            ucAddLocalDLA.SetLocalDLA(LocalDLAID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ucAddLocalDLA.Save())
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucAddLocalDLA_OnSaveCompleted()
        {
            this.Close();
        }
    }
}
