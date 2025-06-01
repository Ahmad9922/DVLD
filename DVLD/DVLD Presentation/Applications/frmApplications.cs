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
    public partial class frmApplications : Form
    {
        private int SelectedApplicationID
        {
            get
            {
                return Convert.ToInt32(ucApplicationsList.SelectedRow.Cells[0].Value);
            }
        }

        private clsApplicationType.enApplicationTypeID SelectedApplicationTypeID
        {
            get
            {
                return clsApplication.Find(SelectedApplicationID).ApplicationType.ApplicationTypeID;
            }
        }

        public frmApplications()
        {
            InitializeComponent();
        }

        private void RefreshList()
        {
            ucApplicationsList.SetList(clsApplication.GetApplications());
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            frmAddUpdateApplication AddUpdateApplicationForm = new frmAddUpdateApplication();
            AddUpdateApplicationForm.ShowDialog();

            RefreshList();
        }

        private void ucApplicationsList_FilterValueChanged(object sender, CustomControls.UCFilter2.ResultEventArgs e)
        {
            ucApplicationsList.SetList(clsApplication.GetApplications(e.Value, e.FieldName));
        }

        private void ucApplicationsList_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            frmAddUpdateApplication AddUpdateApplicationForm = new frmAddUpdateApplication(SelectedApplicationID, SelectedApplicationTypeID);
            AddUpdateApplicationForm.ShowDialog();

            RefreshList();
        }
    }
}
