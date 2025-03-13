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
    public partial class frmUserCard : Form
    {
        public frmUserCard(int UserID)
        {
            InitializeComponent();

            ucUserCard1.SetUser(UserID);
        }
    }
}
