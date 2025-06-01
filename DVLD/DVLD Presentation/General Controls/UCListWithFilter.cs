using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CustomControls.UCFilter2;

namespace DVLD
{
    public partial class UCListWithFilter : UserControl
    {
        public event EventHandler<ResultEventArgs> FilterValueChanged;
        public event EventHandler<ResultEventArgs> SearchButtonClick;

        public UCListWithFilter()
        {
            InitializeComponent();
        }

        public DataGridViewRow SelectedRow
        {
            get
            {
                return ucList.SelectedRow;
            }
        }

        [DefaultValue(null)]
        public clsSearchProperties[] FieldsProperties
        {
            get
            {
                return ucFilter.MultiSearch;
            }

            set
            {
                ucFilter.MultiSearch = value;
            }
        }

        public void SetList(DataTable List)
        {
            ucList.DataSource = List;
        }

        private void ucFilter_FilterValueChanged(object sender, ResultEventArgs e)
        {
            FilterValueChanged?.Invoke(sender, e);
        }

        private void ucFilter_SearchButtonClick(object sender, ResultEventArgs e)
        {
            SearchButtonClick?.Invoke(sender, e);
        }
    }
}
