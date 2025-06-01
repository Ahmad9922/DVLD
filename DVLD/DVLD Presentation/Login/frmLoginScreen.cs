using DVLDBusiness;
using DVLDPresentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLoginScreen : Form
    {
        frmMain MainForm;

        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private bool ValidateTheUser()
        {
            clsUser RegisteredUser = clsUser.Find(txtUserName.Text.Trim(), txtPassword.Text.Trim());

            if (RegisteredUser != null)
            {
                if (RegisteredUser.IsActive)
                {
                    clsGeneralProperties.RegisteredUser = RegisteredUser;
                    return true;
                }
                else
                {
                    MessageBox.Show("Your account is not activated. Please contact your Admin to activate it.", "Stop",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("The username or password is invalid. Please try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void RememberTheUser()
        {
            try
            {
                using (RegistryKey Key = Registry.CurrentUser.CreateSubKey(clsGeneralProperties.DVLDRegistryKey))
                {
                    Key.SetValue(txtUserName.PlaceholderText, txtUserName.Text, RegistryValueKind.String);
                    Key.SetValue(txtPassword.PlaceholderText, txtPassword.Text, RegistryValueKind.String);
                }
            }
            catch
            {

            }
        }

        private void DontRememberTheUser()
        {
            try
            {
                using (RegistryKey Key = Registry.CurrentUser.OpenSubKey(clsGeneralProperties.DVLDRegistryKey, true))
                {
                    Key.DeleteValue(txtPassword.PlaceholderText);
                    Key.DeleteValue(txtUserName.PlaceholderText);
                }
            }
            catch 
            {

            }
        }

        private void GetRegisteredUserInfo()
        {
            try
            {
                using (RegistryKey Key = Registry.CurrentUser.OpenSubKey(clsGeneralProperties.DVLDRegistryKey))
                {
                    txtUserName.Text = Convert.ToString(Key.GetValue(txtUserName.PlaceholderText, null));
                    txtPassword.Text = Convert.ToString(Key.GetValue(txtPassword.PlaceholderText, null));
        
                    if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                        cbRememberMeBox.Checked = true;
                }
            }
            catch
            {

            }
        }

        private void _ShowMainForm()
        {
            MainForm = new frmMain();
            MainForm.OnSignOutClick += MainForm_OnSignOutClick;
            this.Hide();

            if (MainForm.ShowDialog() == DialogResult.Cancel)
                this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateTheUser())
            {
                if (cbRememberMeBox.Checked)
                    RememberTheUser();
                else
                    DontRememberTheUser();

                _ShowMainForm();
            }
        }

        private void MainForm_OnSignOutClick()
        {
            clsGeneralProperties.RegisteredUser = null;
            MainForm.Close();
            MainForm.DialogResult = DialogResult.No;
            this.Show();
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            GetRegisteredUserInfo();
        }
    }
}
