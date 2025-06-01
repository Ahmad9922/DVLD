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
    public partial class UCTakeTest : UserControl
    {
        private clsTest Test;

        public event Action ONSaveCompleted;

        public UCTakeTest()
        {
            InitializeComponent();
        }

        public void InitializeTest(clsTestAppointment TestAppointment)
        {
            Test = new clsTest(TestAppointment, clsGeneralProperties.RegisteredUser);
        }

        private void SetTestresultInfo()
        {
            Test.TestResult = rbPass.Checked;
            Test.Notes = guna2TextBox1.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetTestresultInfo();

            if (Test.Save())
            {
                lblTestID.Text = Test.TestID.ToString();

                MessageBox.Show("The Test has been saved successfully .",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (ONSaveCompleted != null)
                    ONSaveCompleted.Invoke();
            }
            else
            {
                MessageBox.Show("Failed to save the Test. If the problem persists," +
                   " please seek assistance from the Service and Maintenance Center",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
