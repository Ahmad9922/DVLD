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
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            ucList1.DataSource = clsTestType.GetTestTypesList();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            frmUpdateTestType UpdateTestTypeForm = 
                new frmUpdateTestType(Convert.ToInt32(ucList1.SelectedRow.Cells[0].Value));

            UpdateTestTypeForm.ShowDialog();

            ucList1.DataSource = clsTestType.GetTestTypesList();
        }
    }
}
