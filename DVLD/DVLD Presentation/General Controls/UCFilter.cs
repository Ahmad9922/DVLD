using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD.UCFilter.clsFilterProperty;

namespace DVLD
{
    public partial class UCFilter : UserControl
    {
        public class clsFilterProperty
        {
            public enum enFieldMask { None = 0, Letters = 1, Number = 2, LettersAndNumbers = 3, Char = 4, Boolean = 5, All = 6 }
            public enum enSearchType { None = 0, TextBox = 1, ComboBox = 2 }

            public string FieldName { get; set; }
            public enFieldMask FieldMask { get; set; }
            public enSearchType SearchType { get; set; }

            public string[] ComboBoxFields { get; set; }

            public clsFilterProperty()
            {
                FieldName = "None";
                FieldMask = enFieldMask.None;
                SearchType = enSearchType.TextBox;
            }
        }

        public class FilterEventArgs : EventArgs
        {
            public string Value { get; }
            public string FieldName { get; }
            public enFieldMask Mask { get; }
            public enSearchType SearchType { get; }

            public FilterEventArgs(string value, string fieldName, enFieldMask mask, enSearchType searchType)
            {
                Mask = mask;
                SearchType = searchType;
                Value = value;
                FieldName = fieldName;
            }
        }

        public clsFilterProperty[] FilterProperties { get; set; }

        public bool UsingButtonSearch
        { 
            get
            {
                return btnSearch.Visible;
            }

            set
            {
                btnSearch.Visible = value;
            }
        }

        public bool FilterEnabled
        {
            get
            {
                return guna2GroupBox1.Enabled;
            }
            set
            {
                guna2GroupBox1.Enabled = value;
            }
        }

        public event EventHandler<FilterEventArgs> OnFilterChanged;

        public event EventHandler<FilterEventArgs> SearchButtonClick;

        public UCFilter()
        {
            InitializeComponent();

            ComboBoxItems = new Dictionary<string, List<object>>();
        }

        public string Title 
        {
            get
            {
                return guna2GroupBox1.Text;
            }

            set
            {
                guna2GroupBox1.Text = value;
            }
        }

        public string SearchBoxValue
        { 
            get
            {
                return txtSearchBox.Text; 
            } 

            set
            { 
                txtSearchBox.Text = value;
            }
        }

        public string ComboBoxValue
        { 
            get
            {
                if (cbFilterOptions.SelectedItem != null)
                    return Convert.ToString(cbFilterOptions.SelectedItem);
                else
                    return null;
            }

          set { cbFilterOptions.SelectedItem = value; }
        }

        private Dictionary<string, List<object>> ComboBoxItems { get; set; }

        public void SetComboBoxItem(string FieldName, List<object> Items)
        {
            Items.Insert(0, "All");

            ComboBoxItems.Add(FieldName, Items);
        }

    

        private void ShowComboBox()
        {
            cbSearchList.Items.Clear();
            cbSearchList.Visible = true;
            txtSearchBox.Visible = false;
            cbSearchList.Items.AddRange(FilterProperties[cbFilterOptions.SelectedIndex].ComboBoxFields);
            cbSearchList.SelectedIndex = 0;
        }

        private void cbFilterOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchBox.Text = string.Empty;

            switch (FilterProperties[cbFilterOptions.SelectedIndex].SearchType)
            {
                case clsFilterProperty.enSearchType.None:
                    txtSearchBox.Visible = false;
                    cbSearchList.Visible = false;
                    break;

                case clsFilterProperty.enSearchType.TextBox:
                    txtSearchBox.Visible = true;
                    cbSearchList.Visible = false;
                    break;

                case clsFilterProperty.enSearchType.ComboBox:
                    ShowComboBox();
                    break;
            }
        }

        private FilterEventArgs GetFilterArguments(string Value, string FieldName, enFieldMask Mask, enSearchType SearchType)
        {
            return new FilterEventArgs(Value, FieldName, Mask, SearchType);
        }

        private void FilterChanged(FilterEventArgs e)
        {
            OnFilterChanged?.Invoke(this, e);
        }

        private void SearchButton_Click(FilterEventArgs e)
        {
            SearchButtonClick?.Invoke(this, e);
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            FilterChanged(GetFilterArguments(txtSearchBox.Text, cbFilterOptions.Text,
                    FilterProperties[cbFilterOptions.SelectedIndex].FieldMask,
                    FilterProperties[cbFilterOptions.SelectedIndex].SearchType));
        }

        private void cbSearchList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterChanged(GetFilterArguments(cbSearchList.Text, cbFilterOptions.Text,
                    FilterProperties[cbFilterOptions.SelectedIndex].FieldMask,
                    FilterProperties[cbFilterOptions.SelectedIndex].SearchType));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchButton_Click(GetFilterArguments(cbSearchList.Text, cbFilterOptions.Text,
                    FilterProperties[cbFilterOptions.SelectedIndex].FieldMask,
                    FilterProperties[cbFilterOptions.SelectedIndex].SearchType));
        }

        public void TextBoxFocus()
        {
            txtSearchBox.Focus();
        }

        private void txtSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)13 && btnSearch.Visible)
                    btnSearch.PerformClick();
                else
                    e.Handled = false;

                txtSearchBox.Focus();
                return;
            }

            switch (FilterProperties[cbFilterOptions.SelectedIndex].FieldMask)
            {
                case enFieldMask.Letters:
                    e.Handled = !char.IsLetter(e.KeyChar);
                    break;

                case enFieldMask.Number:
                    e.Handled = !char.IsDigit(e.KeyChar);
                    break;

                case enFieldMask.LettersAndNumbers:
                    e.Handled = !char.IsLetterOrDigit(e.KeyChar);
                    break;

                case enFieldMask.Char:
                    e.Handled = txtSearchBox.Text.Length > 1;
                    break;

                case enFieldMask.All:
                    e.Handled = false;
                    break;
            }
        }

        private void UCFilter_Load(object sender, EventArgs e)
        {
            if (FilterProperties == null)
                return;

            if (FilterProperties.Length != 0)
            {
                foreach (clsFilterProperty FilterProperty in FilterProperties)
                {
                    cbFilterOptions.Items.Add(FilterProperty.FieldName?? "None");
                }

                cbFilterOptions.SelectedIndex = 0;
            }
        }
    }
}
