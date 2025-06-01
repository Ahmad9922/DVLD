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
    public partial class frmTestAppointment : Form
    {
        private clsTestType.enTestTypeID _TestType;

        public frmTestAppointment(int LocalDLAID)
        {
            InitializeComponent();

            LocalDLACard.FillApplicatoin(LocalDLAID);
            _TestType = clsTestType.GetTestType(LocalDLACard.LocalDLA.LocalDLAID.Value);
            LoadAppointments();

            gbTestAppointment.Text = _TestType.ToString() + " Test Appointments";
            PictureBox.Image = ImagesTestTypes.Images[Convert.ToString(_TestType)];
        }

        private void LoadAppointments()
        {
            ucList1.DataSource = clsTestAppointment.TestAppointmentsList(LocalDLACard.LocalDLA.LocalDLAID.Value, _TestType);
        }

        private void AddAppointment_Click(object sender, EventArgs e)
        {
            if (clsTestAppointment.IsThereAnActiveAppointment(LocalDLACard.LocalDLA.LocalDLAID.Value, _TestType))
            {
                MessageBox.Show("An appointment has already been scheduled." +
                    " You can set a new one if the applicant fails the test.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (LocalDLACard.LocalDLA.DoesPassTestType(_TestType))
            {
                MessageBox.Show("You cannot add an appointment. The applicant has already passed this test.",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmAddAndUpdateTestAppointment AddAndUpdateTestAppointmentForm
                        = new frmAddAndUpdateTestAppointment(LocalDLACard.LocalDLA.LocalDLAID.Value, _TestType);
            AddAndUpdateTestAppointmentForm.ShowDialog();

            LoadAppointments();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateTestAppointment AddAndUpdateTestAppointmentForm =
                new frmAddAndUpdateTestAppointment(LocalDLACard.LocalDLA.LocalDLAID.Value, _TestType,
                Convert.ToInt32(ucList1.SelectedRow.Cells[0].Value));
            AddAndUpdateTestAppointmentForm.ShowDialog();

            LoadAppointments();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (ucList1.SelectedRow == null)
                e.Cancel = true;
        }

        private void TakeTest_Click(object sender, EventArgs e)
        {
            if (!clsTestAppointment.IsAppointmentLocked(Convert.ToInt32(ucList1.SelectedRow.Cells[0].Value)))
            {
                frmTakeTest TakeTestForm = new frmTakeTest(Convert.ToInt32(ucList1.SelectedRow.Cells[0].Value));
                TakeTestForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("The applicant has already teken this test on the scheduled date",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LocalDLACard.FillApplicatoin(LocalDLACard.LocalDLA.LocalDLAID.Value);

            LoadAppointments();
        }
    }
}
