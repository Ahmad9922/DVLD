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
    public partial class UCTestAppointmentCard : UserControl
    {
        clsTestAppointment TestAppointment;

        public UCTestAppointmentCard()
        {
            InitializeComponent();
        }

        public void FillTestAppointmentInfo(int TestAppointmentID)
        {
            if ((TestAppointment = clsTestAppointment.Find(TestAppointmentID)) != null)
            {
                lblILocalDLAID.Text = TestAppointment.LocalDLA.LocalDLAID.ToString();
                lblApplicantPersonName.Text = TestAppointment.LocalDLA.ApplicantPerson.FullName;
                lblLicenseClass.Text = TestAppointment.LocalDLA.LicenseClass.ClassName;
                lblTrial.Text = TestAppointment.LocalDLA.CurrentTestTrials.ToString();
                lblDate.Text = TestAppointment.AppointmentDate.ToShortDateString();
                lblFees.Text = TestAppointment.LocalDLA.CurrentTestType.Fees.ToString();
            }
        }
    }
}
