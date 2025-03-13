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
    public partial class frmAddAndUpdateTestAppointment : Form
    {
        public frmAddAndUpdateTestAppointment(clsLocalDLA LocalDLA)
        {
            InitializeComponent();

            ucAddTestAppointment1.AddTestAppointment(LocalDLA);
        }

        public frmAddAndUpdateTestAppointment(int TestAppointmentID)
        {
            InitializeComponent();

            ucAddTestAppointment1.UpdateTestAppointment(TestAppointmentID);
        }

        private void AddTestAppointment_ONSaveCompleted()
        {
            this.Close();
        }
    }
}
