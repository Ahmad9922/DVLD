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
    public partial class UCAddUpdateApplication : UserControl
    {
        //// Accepts two types, where one inherits from the other, at runtime.
        //private Type Application {  get; set; }

        struct stApplicationInfo
        {
            public clsApplicationType ApplicationType { get; set; }
            public clsPerson ApplicantPerson { get; set; }
            public clsLicenseClass LicenseClass { get; set; }
            public bool IsPersonSelected
            {
                get
                {
                    return ApplicantPerson != null;
                }
            }
        }

        private stApplicationInfo ApplicationInfo;

        public UCAddUpdateApplication()
        {
            InitializeComponent();
            InitializeValues();
        }

        private void InitializeValues()
        {
            _LoadApplicationTypeInComboBox();
            _LicenseClassesInComboBox();

            ApplicationInfo.ApplicationType = clsApplicationType.Find
                (clsApplicationType.enApplicationTypeID.NewLocalDrivingLicenseService);

            nudApplicationPaidFees.Value = ApplicationInfo.ApplicationType?.ApplicationFees ?? 0;

            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
        }

        private void _LoadApplicationTypeInComboBox()
        {
            cbApplicationType.Items.AddRange(clsApplicationType.GetApplicationTypesTitles().ToArray());

            if (cbApplicationType.Items.Count > 0)
                cbApplicationType.SelectedIndex = 0;
        }

        private void _LicenseClassesInComboBox()
        {
            cbLicenseClasses.Items.AddRange(clsLicenseClass.LicenseClassList().ToArray());

            if (cbLicenseClasses.Items.Count > 0)
                cbLicenseClasses.SelectedIndex = 0;
        }

        private void FillInfo(clsApplication Application)
        {
            ApplicationInfo.ApplicantPerson = Application.ApplicantPerson;
            ApplicationInfo.ApplicationType = Application.ApplicationType;
            
            nudApplicationPaidFees.Value = Application.PaidFees;
            lblApplicantPersonID.Text = Application.ApplicantPerson.PersonID.ToString();
            lblApplicationDate.Text = Application.ApplicationDate.ToShortDateString();
            cbApplicationType.Text = Application.ApplicationType.ApplicationTypeTitle;
        }

        public void UpdateApplication(int ApplicationID)
        {
            clsApplication Application = clsApplication.Find(ApplicationID);

            if (Application != null)
            {
                FillInfo(Application);
            }
        }

        public void UpdateLocalDrivingLicenseApplication(int ApplicationID)
        {
            clsLocalDLA LocalDrivingLicenseApplication = clsLocalDLA.FindByApplicationID(ApplicationID);

            if (LocalDrivingLicenseApplication != null)
            {
                ApplicationInfo.LicenseClass = LocalDrivingLicenseApplication.LicenseClass;

                FillInfo(LocalDrivingLicenseApplication);

                cbLicenseClasses.Text = LocalDrivingLicenseApplication.LicenseClass.ClassName;
                nudClassPaidFees.Value = LocalDrivingLicenseApplication.PaidFees;
            }
        }

        private bool SubmitApplication()
        {
            switch (ApplicationInfo.ApplicationType.ApplicationTypeID)
            {
                case clsApplicationType.enApplicationTypeID.NewLocalDrivingLicenseService:

                    clsLocalDLA LocalDLA = new clsLocalDLA(ApplicationInfo.ApplicantPerson, clsGeneralProperties.RegisteredUser);
                    LocalDLA.LicenseClass = clsLicenseClass.Find(cbLicenseClasses.Text);

                    return LocalDLA.Save();

                default:
                    clsApplication Application = new clsApplication(ApplicationInfo.ApplicantPerson, 
                        ApplicationInfo.ApplicationType, clsGeneralProperties.RegisteredUser);

                    return Application.Save();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (SubmitApplication())
            {
                MessageBox.Show("The application has been Submitted successfully .",
                           "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to submit the application.. If the problem persists," +
                            " please seek assistance from the Service and Maintenance Center",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetApplicationTypeProperties()
        {
            nudApplicationPaidFees.Value = Convert.ToDecimal(ApplicationInfo.ApplicationType.ApplicationFees);

            switch (ApplicationInfo.ApplicationType.ApplicationTypeID)
            {
                case clsApplicationType.enApplicationTypeID.NewLocalDrivingLicenseService:
                    btnSubmit.Visible = false;
                    btnNext.Visible = true;
                    break;

                default:
                    btnSubmit.Visible = true;
                    btnNext.Visible = false;
                    break;
            }
        }

        private void SetLicenseClassesProperties()
        {
            nudClassPaidFees.Value = ApplicationInfo.LicenseClass.ClassFees;
            lblMinimumAllowedAge.Text = ApplicationInfo.LicenseClass.MinimumAllowedAge.ToString();
        }

        private void cbApplicationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplicationInfo.ApplicationType = clsApplicationType.Find(cbApplicationType.Text);

            SetApplicationTypeProperties();
        }

        private void cbLicenseClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplicationInfo.LicenseClass = clsLicenseClass.Find(cbLicenseClasses.Text);

            SetLicenseClassesProperties();
        }

        private void btnPersonSearch_Click(object sender, EventArgs e)
        {
            frmFindPerson FindPersonForm = new frmFindPerson();
            FindPersonForm.OnPersonSelected += FindPersonForm_OnPersonSelected;
            FindPersonForm.ShowDialog();
        }

        private void FindPersonForm_OnPersonSelected(clsPerson ApplicantPerson)
        {
            ApplicationInfo.ApplicantPerson = ApplicantPerson;
            lblApplicantPersonID.Text = ApplicationInfo.ApplicantPerson.PersonID.ToString();

            btnNext.Enabled = true;
            btnSubmit.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnSubmit.Visible = true;
            tcSubmissionSteps.SelectTab(1);
        }

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            tcSubmissionSteps.SelectTab(0);
        }
    }
}
