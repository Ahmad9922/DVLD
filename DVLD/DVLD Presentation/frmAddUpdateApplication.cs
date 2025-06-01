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
    public partial class frmAddUpdateApplication : Form
    {
        public frmAddUpdateApplication()
        {
            InitializeComponent();

            Text = "Add Application";
        }

        public frmAddUpdateApplication(int ID, clsApplicationType.enApplicationTypeID ApplicationTypeID)
        {
            InitializeComponent();

            switch (ApplicationTypeID)
            {
                case clsApplicationType.enApplicationTypeID.NewLocalDrivingLicenseService:
                    ucAddUpdateApplication1.UpdateLocalDrivingLicenseApplication(ID);
                    break;

                default:
                    ucAddUpdateApplication1.UpdateApplication(ID);
                    break;
            }

            Text = "Update Application";
        }
    }
}
