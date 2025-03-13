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
    public partial class frmUpdateApplicationType : Form
    {
        clsApplicationType ApplicationType;

        public frmUpdateApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();

            ApplicationType = clsApplicationType.Find(ApplicationTypeID);

            FillApplicationTypeInfo();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillApplicationTypeInfo()
        {
            lblApplicationTypeIDValue.Text = ApplicationType.ApplicationTypeID.ToString();
            txtTitle.Text = ApplicationType.Title;
            txtFees.Text = ApplicationType.Fees.ToString();
        }

        private bool FieldsValidation()
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
                return false;

            if (string.IsNullOrEmpty(txtFees.Text))
                return false;

            return true;
        }

        private void SetApplicationTypeInfo()
        {
            ApplicationType.Title = txtTitle.Text;
            ApplicationType.Fees = Convert.ToSingle(txtFees.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FieldsValidation())
            {
                SetApplicationTypeInfo();

                if (ApplicationType.Save())
                {
                    MessageBox.Show("The Application Type has been saved successfully .",
                           "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save the Application Type. If the problem persists," +
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
            if (!float.TryParse(txtFees.Text, out float Result))
            {
                if (txtFees.Text.Length > 0)
                    txtFees.Text = txtFees.Text.Remove(txtFees.Text.Length - 1);

                txtFees.SelectionStart = txtFees.Text.Length;
            }
        }
    }
}
