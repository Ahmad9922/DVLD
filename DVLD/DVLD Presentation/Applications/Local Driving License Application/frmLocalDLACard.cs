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
    public partial class frmLocalDLACard : Form
    {
        public frmLocalDLACard(int LocalDLAID)
        {
            InitializeComponent();
            ucLocalDLACard1.FillApplicatoin(LocalDLAID);
        }
    }
}
