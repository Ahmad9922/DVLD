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

        private clsTestType.enTestTypeID _TestType;
        public clsTestType.enTestTypeID TestType
        {
            get
            { 
                return _TestType;
            }

            set
            {
                _TestType = value;

                PictureBox.Image = ImagesTestTypes.Images[_TestType.ToString()];
                gbAppointmentInfo.Text = _TestType.ToString() + " Test";
            }
        }

        public event Action ONSaveCompleted;

        public UCAddTestAppointment()
        {
            InitializeComponent();
        }

        private void FillAppointmentInfo()
        {
            dtAppointmentDate.Value = TestAppointment.AppointmentDate;
            lblILocalDLAID.Text = TestAppointment.LocalDLA.LocalDLAID.ToString();
            lblLicenseClass.Text = TestAppointment.LocalDLA.LicenseClass.ClassName;
            lblApplicantPersonName.Text = TestAppointment.LocalDLA.ApplicantPerson.FullName;
            lblTrial.Text = TestAppointment.LocalDLA.TotalTrialsPerTest(TestType).ToString();
            lblFees.Text = "$" + TestAppointment.TestType.TestTypeFees.ToString();
            gbAppointmentInfo.Text = TestType.ToString() + " Test";
        }

        private void FillRetakeTestInfo()
        {
            gbRetakeTestInfo.Enabled = true;

            if (TestAppointment.RetakeTestApplication.ApplicationID != -1)
                lblRTApplicationID.Text = TestAppointment.RetakeTestApplication.ApplicationID.ToString();
            else
                lblRTApplicationID.Text = "???";

            lblRTAFees.Text = "$" + TestAppointment.RetakeTestApplication.ApplicationType.ApplicationFees;
            lblTotalFees.Text = "$" + Convert.ToDecimal(TestAppointment.LocalDLA.CurrentTestType.TestTypeFees
                + TestAppointment.RetakeTestApplication.ApplicationType.ApplicationFees);
        }

        private void DisableTestAppointment()
        {
            btnSave.Enabled = false;
            dtAppointmentDate.Enabled = false;
            lblLockEditingMessage.Visible = true;
        }

        public bool UpdateAppointment(int TestAppointmentID)
        {
            if ((TestAppointment = clsTestAppointment.Find(TestAppointmentID)) != null)
            {
                if (TestAppointment.IsLocked)
                    DisableTestAppointment();

                if (TestAppointment.CreationMode == clsTestAppointment.enCreationMode.ScheduleRetakeTest)
                {
                    FillRetakeTestInfo();
                }

                return true;
            }

            return false;
        }

        private bool AddAppointment(int LocalDLAID, int TestAppointmentID)
        {
            clsLocalDLA LocalDLA = clsLocalDLA.Find(LocalDLAID);

            if (LocalDLA != null)
            {
                if (LocalDLA.DoesAttendTestType(TestType))
                {
                    if ((TestAppointment = clsTestAppointment.ScheduleRetakeTest(LocalDLA,
                        clsGeneralProperties.RegisteredUser)) != null)
                    {
                        FillRetakeTestInfo();
                        return true;
                    }
                }
                else
                {
                    if ((TestAppointment = clsTestAppointment.ScheduleFirstTime(LocalDLA,
                        clsGeneralProperties.RegisteredUser)) != null)
                        return true;
                }
            }

            return false;
        }

        public void LoadInfo(int LocalDLAID, int TestAppointmentID = -1)
        {
            if (TestAppointmentID == -1)
            {
                AddAppointment(LocalDLAID, TestAppointmentID);
            }
            else
            {
                UpdateAppointment(TestAppointmentID);
            }

            FillAppointmentInfo();
        }

        private void SetAppointment()
        {
            TestAppointment.AppointmentDate = dtAppointmentDate.Value;
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
