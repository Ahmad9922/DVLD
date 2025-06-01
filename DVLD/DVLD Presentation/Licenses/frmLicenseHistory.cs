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
    public partial class frmLicenseHistory : Form
    {
        public frmLicenseHistory(int DriverID)
        {
            InitializeComponent();
            ucPersonCard1.SetPerson(clsDriver.Find(DriverID).Person.PersonID.Value);
            ucDriverLicenses1.FillLicenses(DriverID);
        }
    }
}
