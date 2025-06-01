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
        public frmAddAndUpdateTestAppointment(int LocalDLA, clsTestType.enTestTypeID TestType, int TestAppointmentID = -1)
        {
            InitializeComponent();

            ucAddTestAppointment1.TestType = TestType;

            if (TestAppointmentID != -1)
                ucAddTestAppointment1.LoadInfo(LocalDLA, TestAppointmentID);
            else
                ucAddTestAppointment1.LoadInfo(LocalDLA);
        }

        private void AddTestAppointment_ONSaveCompleted()
        {
            this.Close();
        }
    }
}
