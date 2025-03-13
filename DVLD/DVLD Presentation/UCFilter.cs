using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class UCFilter : UserControl
    {
        public enum enFieldMask { None = 0, Letters = 1, Number = 2, LettersAndNumbers = 3, Char = 4, Boolean = 5, All = 6 }
        public enum enSearchType { None = 0, TextBox = 1, ComboBox = 2 }

        public string[] FieldName
        {
            get
            {
                string[] Items = new string[cbFilterOptions.Items.Count];

                for (int i = 0; i < cbFilterOptions.Items.Count; i++)
                {
                    Items.SetValue(cbFilterOptions.Items[i], i);
                }

                return Items;
            }

            set
            {
                cbFilterOptions.Items.Clear();
                cbFilterOptions.Items.AddRange(value.ToArray());
            }
        }
        public enFieldMask[] FieldMask { get; set; }
        public enSearchType[] SearchType { get; set; }

        public event Action<string, string> FilterResultChange;

        public event Action<string, string> SearchButtonClick;

        public UCFilter()
        {
            InitializeComponent();

            ComboBoxItems = new Dictionary<string, List<object>>();
        }

        public string Title 
        {
            get
            {
                return label1.Text;
            }

            set
            {
                label1.Text = value;
            }
        }

        public string SearchBoxValue
        { get { return txtSearchBox.Text; } set { txtSearchBox.Text = value; } }

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

        private bool CheckType()
        {
            switch (FieldMask[cbFilterOptions.SelectedIndex])
            {
                case enFieldMask.Letters:
                    maskedTextBox1.Mask = "??????????????????????????????";
                    break;

                case enFieldMask.Number:
                    maskedTextBox1.Mask = "999999999999999999999999999999";
                    break;

                case enFieldMask.LettersAndNumbers:
                    maskedTextBox1.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
                    break;

                case enFieldMask.Char:
                    maskedTextBox1.Mask = "L";
                    break;

                case enFieldMask.All:
                    maskedTextBox1.Mask = "";
                    break;
            }

            maskedTextBox1.Text = txtSearchBox.Text;
            txtSearchBox.Text = maskedTextBox1.Text;

            if (txtSearchBox.Text != maskedTextBox1.Text)
                return false;
            else
                return true;
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (!CheckType()) return;

            if (FilterResultChange != null)
                FilterResultChange.Invoke(txtSearchBox.Text, Convert.ToString(cbFilterOptions.SelectedItem));
        }

        private void ShowComboBox()
        {
            cbSearchList.Items.Clear();
            cbSearchList.Visible = true;
            txtSearchBox.Visible = false;

            cbSearchList.Items.AddRange(ComboBoxItems[Convert.ToString(cbFilterOptions.SelectedItem)].ToArray());
            cbSearchList.SelectedIndex = 0;
        }

        private void cbFilterOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchBox.Text = string.Empty;

            if (SearchType[cbFilterOptions.SelectedIndex] != enSearchType.None)
            {
                if (SearchType[cbFilterOptions.SelectedIndex] == enSearchType.TextBox)
                {
                    txtSearchBox.Visible = true;
                    cbSearchList.Visible = false;
                }
                else
                {
                    ShowComboBox();
                }
            }
            else
            {
                txtSearchBox.Visible = false;
                cbSearchList.Visible = false;
            }
        }

        private void cbSearchList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterResultChange != null)
                FilterResultChange.Invoke(Convert.ToString(cbSearchList.SelectedItem),
                    Convert.ToString(cbFilterOptions.SelectedItem));
        }

        private void UCFilter_Load(object sender, EventArgs e)
        {
            if (cbFilterOptions.Items.Count != 0)
            {
                cbFilterOptions.SelectedIndex = 0;
            }
        }
    }
}
