using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD.UCFilter;

namespace DVLD
{
    public partial class UCListWithFilter : UserControl
    {
        public UCListWithFilter()
        {
            InitializeComponent();
        }

        public event Action<string, string> FilterResultChange;

        public DataGridViewRow SelectedRow
        {
            get
            {
                return ucList.SelectedRow;
            }
        }

        public string[] FieldName
        {
            get
            {
               return ucFilter.FieldName;
            }

            set
            {
                ucFilter.FieldName = value;
            }
        }

        public enFieldMask[] FieldMask
        { 
            get
            {
                return ucFilter.FieldMask;
            }

            set
            {
                ucFilter.FieldMask = value;
            }
        }

        public enSearchType[] SearchType
        {
            get
            {
                return ucFilter.SearchType;
            }

            set
            {
                ucFilter.SearchType = value;
            }
        }

        public void SetComboBoxItems(string FieldName, List<object> Items)
        {
            ucFilter.SetComboBoxItem(FieldName, Items);
        }

        public void SetList(DataTable List)
        {
            ucList.DataSource = List;

            
        }

        private void Filter_FilterResultChange(string obj, string obj2)
        {
            if (FilterResultChange != null)
                FilterResultChange.Invoke(obj, obj2);
        }
    }
}
