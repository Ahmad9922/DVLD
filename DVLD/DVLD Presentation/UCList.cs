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
    public partial class UCList : UserControl
    {
        public UCList()
        {
            InitializeComponent();
        }

        public object DataSource
        { 
            get
            {
                return DGVList.DataSource;
            }
            set
            {
                DGVList.DataSource = value;
                lblRecordValue.Text = DGVList.Rows.Count.ToString();
            }
        }

        public DataGridViewRow SelectedRow
        {
            get
            {
                return DGVList.CurrentRow;
            }
        }
    }
}
