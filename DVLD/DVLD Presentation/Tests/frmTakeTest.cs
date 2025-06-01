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
    public partial class frmTakeTest : Form
    {
        public frmTakeTest(int TestAppointmentID)
        {
            InitializeComponent();

            ucTestAppointmentCard1.FillTestAppointmentInfo(TestAppointmentID);
            ucTakeTest1.InitializeTest(clsTestAppointment.Find(TestAppointmentID));
        }

        private void ucTakeTest1_ONSaveCompleted()
        {
            this.Close();
        }
    }
}
