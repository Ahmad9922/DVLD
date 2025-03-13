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
    public partial class frmLDLApplications : Form
    {
        private int SelectedLocalDLAID 
        {
            get
            {
                return Convert.ToInt32(ucListWithFilter.SelectedRow.Cells[0].Value);
            }
        }

        public frmLDLApplications()
        {
            InitializeComponent();
        }

        private void frmLDLApplications_Load(object sender, EventArgs e)
        {
            ucListWithFilter.SetList(clsLocalDLA.GetLDLApplications());
            ucListWithFilter.SetComboBoxItems("Passed Tests", new List<object> { "0", "1", "2", "3" });
            ucListWithFilter.SetComboBoxItems("Status", new List<object> { "New", "Completed", "Cancelled" });
        }

        private void LoadApplications()
        {

        }

        private void ucListWithFilter_FilterResultChange(string arg1, string arg2)
        {
            ucListWithFilter.SetList(clsLocalDLA.GetLDLApplications(arg1, arg2));
        }

        private void AddApplication_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateLocalDLA AddAndUpdateLocalDLAForm = new frmAddAndUpdateLocalDLA();
            AddAndUpdateLocalDLAForm.ShowDialog();

            ucListWithFilter.SetList(clsLocalDLA.GetLDLApplications());
        }

        private void CancelApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this Application with the ID : "
                + SelectedLocalDLAID.ToString(),
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (!clsTestAppointment.IsThereAnActiveAppointment(SelectedLocalDLAID, clsTestType.enTestType.Vision))
                {
                    if (clsLocalDLA.CancelApplication(SelectedLocalDLAID))
                    {
                        MessageBox.Show("The Application has been successfully cancelled.",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("This Application cannot be cancelled because it is completed ",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You cannot cancel this application. It contains an active test appointment.",
                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ucListWithFilter.SetList(clsLocalDLA.GetLDLApplications());
        }

        private void EditApplication_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateLocalDLA AddAndUpdateLocalDLAForm =
                new frmAddAndUpdateLocalDLA(SelectedLocalDLAID);
            AddAndUpdateLocalDLAForm.ShowDialog();

            ucListWithFilter.SetList(clsLocalDLA.GetLDLApplications());
        }

        private void DeleteApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Application with the ID : "
               + ucListWithFilter.SelectedRow.Cells[0].Value.ToString(),
                       "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                       MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (clsLocalDLA.Delete(SelectedLocalDLAID))
                {
                    MessageBox.Show("The Application has been successfully deleted.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This Application cannot be deleted because they are linked to " +
                        "other entities in the system.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ucListWithFilter.SetList(clsLocalDLA.GetLDLApplications());
        }

        private void ScheduleVisionTest_Click(object sender, EventArgs e)
        {
            frmTestAppointment frmTestAppointment
                = new frmTestAppointment(SelectedLocalDLAID);

            frmTestAppointment.ShowDialog();

            ucListWithFilter.SetList(clsLocalDLA.GetLDLApplications());
        }

        private void EnableTestProperties(bool ScheduleTests, bool VisionTest, bool WrittenTest, bool StreetTest)
        {
            tsmiScheduleVisionTest.Enabled = VisionTest;
            tsmiScheduleWrittenTest.Enabled = WrittenTest;
            tsmiScheduleStreetTest.Enabled = StreetTest;
            tsmiScheduleTests.Enabled = ScheduleTests;

            tsmiEdit.Enabled = VisionTest;
            tsmiDelete.Enabled = VisionTest;
            tsmiCancelApplication.Enabled = ScheduleTests;
            tsmiIssueDrivingLicenseFirstTime.Enabled = !ScheduleTests;
            tsmiShowLicense.Enabled = false;
        }

        private void EnableCancellationProperties()
        {
            tsmiScheduleTests.Enabled = false;
            tsmiDelete.Enabled = true;
            tsmiEdit.Enabled = false;
            tsmiCancelApplication.Enabled = false;
            tsmiIssueDrivingLicenseFirstTime.Enabled = false;
            tsmiShowLicense.Enabled = false;
        }

        private void EnableCompletionProperties()
        {
            tsmiScheduleTests.Enabled = false;
            tsmiEdit.Enabled = false;
            tsmiDelete.Enabled = false;
            tsmiCancelApplication.Enabled = false;
            tsmiIssueDrivingLicenseFirstTime.Enabled = false;
            tsmiShowLicense.Enabled = true;
        }

        private void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (clsLocalDLA.IsCancelled(SelectedLocalDLAID))
            {
                EnableCancellationProperties();
                return;
            }

            if (clsLocalDLA.IsCompleted(SelectedLocalDLAID))
            {
                EnableCompletionProperties();
                return;
            }

            short PassedTests = Convert.ToInt16(ucListWithFilter.SelectedRow.Cells["Passed Tests"].Value);

            switch (PassedTests)
            {
                case 0:
                    EnableTestProperties(true, true, false, false);
                    break;

                case 1:
                    EnableTestProperties(true, false, true, false);
                    break;

                case 2:
                    EnableTestProperties(true, false, false, true);
                    break;

                case 3:
                    EnableTestProperties(false, false, false, false);
                    break;
            }
        }

        private void IssueDrivingLicenseFirstTime_Click(object sender, EventArgs e)
        {
            frmIssueDrivingLicense IssueDrivingLicenseForm = 
                new frmIssueDrivingLicense(SelectedLocalDLAID);
            IssueDrivingLicenseForm.ShowDialog();
        }

        private void tsmiShowLicense_Click(object sender, EventArgs e)
        {
            frmLicenseCard LicenseCardForm = new frmLicenseCard(clsLocalLicense.GetLicenseID(SelectedLocalDLAID));
            LicenseCardForm.ShowDialog();
        }

        private void tsmiShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            frmLicenseHistory LicenseHistoryForm =
                new frmLicenseHistory(clsDriver.FindByPerson(clsLocalDLA.Find(SelectedLocalDLAID)
                .ApplicantPerson.PersonID).DriverID);
            LicenseHistoryForm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDLACard LocalDLACardForm = new frmLocalDLACard(SelectedLocalDLAID);
            LocalDLACardForm.ShowDialog();
        }
    }
}
