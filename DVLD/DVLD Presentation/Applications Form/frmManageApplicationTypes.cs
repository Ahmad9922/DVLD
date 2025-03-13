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
    public partial class frmManageApplicationTypes : Form
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void ucList1_Load(object sender, EventArgs e)
        {
            ucList1.DataSource = clsApplicationType.GetApplicationTypesList();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationType UpdateApplicationTypeForm
                = new frmUpdateApplicationType(Convert.ToInt32(ucList1.SelectedRow.Cells[0].Value));

            UpdateApplicationTypeForm.ShowDialog();

            ucList1.DataSource = clsApplicationType.GetApplicationTypesList();
        }
    }
}
