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
    public partial class frmUpdateTestType : Form
    {
        private clsTestType TestType;

        public frmUpdateTestType(int TsetTypeID)
        {
            InitializeComponent();

            TestType = clsTestType.Find((clsTestType.enTestTypeID)TsetTypeID);

            FillTsetTypeInfo();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillTsetTypeInfo()
        {
            lblTestTypeIDValue.Text = TestType.TestTypeID.ToString();
            txtDescription.Text = TestType.TestTypeDescription;
            txtTitle.Text = TestType.TestTypeTitle;
            txtFees.Text = TestType.TestTypeFees.ToString();
        }

        private bool FieldsValidation()
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
                return false;

            if (string.IsNullOrEmpty(txtDescription.Text))
                return false;

            if (string.IsNullOrEmpty(txtFees.Text))
                return false;

            return true;
        }

        private void SetApplicationTypeInfo()
        {
            TestType.TestTypeTitle = txtTitle.Text;
            TestType.TestTypeDescription = txtDescription.Text;
            TestType.TestTypeFees = Convert.ToDecimal(txtFees.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FieldsValidation())
            {
                SetApplicationTypeInfo();

                if (TestType.Save())
                {
                    MessageBox.Show("The Test Type has been saved successfully .",
                           "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save the Test Type. If the problem persists," +
                            " please seek assistance from the Service and Maintenance Center",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Some fields are embty or invalid, please check all fields and try again .",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFees_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
