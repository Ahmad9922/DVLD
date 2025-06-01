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
    public partial class UCIssueDrivingLicense : UserControl
    {
        clsLocalLicense License;

        public UCIssueDrivingLicense()
        {
            InitializeComponent();
        }

        public void AddLicense(int LocalDLAID)
        {
            License = clsLocalLicense.Add(clsLocalDLA.Find(LocalDLAID),
                 clsGeneralProperties.RegisteredUser);
        }

        private void SetLicenseInfo()
        {
            License.Notes = txtNotes.Text;
            License.IssueDate = DateTime.Now;
        }

        public bool Save()
        {
            SetLicenseInfo();

            if (License.Save())
            {
                MessageBox.Show("The License has been saved successfully .",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            else
            {
                MessageBox.Show("Failed to save the License. If the problem persists," +
                        " please seek assistance from the Service and Maintenance Center",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
    }
}
