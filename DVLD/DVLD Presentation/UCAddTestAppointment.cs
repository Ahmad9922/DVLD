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
    public partial class UCAddTestAppointment : UserControl
    {
        public clsTestAppointment TestAppointment {  get; set; }

        public clsApplication RetakeTestApplication { get; set; }

        public enum enMode { AddNew = 1, Update = 2 }
        enMode Mode;

        public event Action ONSaveCompleted;

        public UCAddTestAppointment()
        {
            InitializeComponent();
        }

        private void FillAppointmentInfo()
        {
            lblILocalDLAID.Text = TestAppointment.LocalDLA.LocalDLAID.ToString();
            lblLicenseClass.Text = TestAppointment.LocalDLA.LicenseClass.ClassName;
            lblApplicantPersonName.Text = TestAppointment.LocalDLA.ApplicantPerson.FullName;
            lblTrial.Text = TestAppointment.LocalDLA.CurrentTestTrials.ToString();
            lblFees.Text = "$" + TestAppointment.TestType.Fees.ToString();
            gbAppointmentInfo.Text = TestAppointment.LocalDLA.CurrentTestType.Title;
        }

        private void FillRetakeTestInfo()
        {
            gbRetakeTestInfo.Enabled = true;

            lblRTAFees.Text = "$" + RetakeTestApplication.ApplicationType.Fees;
            lblTotalFees.Text = "$" + Convert.ToString(TestAppointment.LocalDLA.CurrentTestType.Fees
                + RetakeTestApplication.ApplicationType.Fees);
        }

        private void DisableTestAppointment()
        {
            btnSave.Enabled = false;
            dtAppointmentDate.Enabled = false;
            lblLockEditingMessage.Visible = true;
        }

        public void UpdateTestAppointment(int TestAppointmentID)
        {
            if ((TestAppointment = clsTestAppointment.Find(TestAppointmentID)) != null)
            {
                FillAppointmentInfo();
                dtAppointmentDate.Value = TestAppointment.AppointmentDate;

                if (TestAppointment.IsLocked)
                    DisableTestAppointment();

                if (TestAppointment.LocalDLA.CurrentTestTrials > 0)
                {
                    lblRTApplicationID.Text = RetakeTestApplication.ApplicationID.ToString();
                    FillRetakeTestInfo();
                }
            }
        }

        public void AddTestAppointment(clsLocalDLA LocalDLA)
        {
            TestAppointment = clsTestAppointment.Add(LocalDLA, clsGeneralProperties.RegisteredUser);
            FillAppointmentInfo();

            if (TestAppointment.LocalDLA.CurrentTestTrials > 0)
            {
                RetakeTestApplication = new clsApplication(TestAppointment.LocalDLA.ApplicantPerson,
                    clsApplicationType.Find(7), clsGeneralProperties.RegisteredUser);

                FillRetakeTestInfo();
            }
        }

        private void SetAppointment()
        {
            TestAppointment.AppointmentDate = dtAppointmentDate.Value;

            if (RetakeTestApplication != null)
            {
                if (RetakeTestApplication.Save())
                {
                    TestAppointment.RetakeTestApplication = RetakeTestApplication;
                    lblRTApplicationID.Text = RetakeTestApplication.ApplicationID.ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetAppointment();

            if (TestAppointment.Save())
            {
                MessageBox.Show("The Appointment has been saved successfully .",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (ONSaveCompleted != null)
                    ONSaveCompleted.Invoke();
            }
            else
            {
                MessageBox.Show("Failed to save the Appointment. If the problem persists," +
                    " please seek assistance from the Service and Maintenance Center",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCAddTestAppointment_Load(object sender, EventArgs e)
        {
            dtAppointmentDate.MinDate = DateTime.Now;
        }
    }
}
