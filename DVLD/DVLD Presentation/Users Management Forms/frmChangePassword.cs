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
    public partial class frmChangePassword : Form
    {


        public frmChangePassword(int UserID)
        {
            InitializeComponent();

            ucUserCard1.SetUser(UserID);
            ucChangePassword1.SetUserToChangePassword(ucUserCard1.User);
            
        }

      
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ucChangePassword1.Save())
            {
                MessageBox.Show("The password has been saved successfully.",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save. Please check the inputs.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
