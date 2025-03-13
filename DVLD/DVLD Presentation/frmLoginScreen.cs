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
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLoginScreen : Form
    {
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

        private void SaveRegistrationInfo()
        {
            File.WriteAllText(clsGeneralProperties.RegisteredUserFile,
               (clsGeneralProperties.RegisteredUser.UserName + "," +
                clsGeneralProperties.RegisteredUser.Password));
        }

        private void RemoveRegistrationInfo()
        {
            if (File.Exists(clsGeneralProperties.RegisteredUserFile))
                File.Delete(clsGeneralProperties.RegisteredUserFile);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateTheUser())
            {
                if (cbRememberMeBox.Checked)
                    SaveRegistrationInfo();
                else
                    RemoveRegistrationInfo();

                frmMain Main = new frmMain();
                this.Hide();
                Main.ShowDialog();
                this.Close();
            }
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            if (File.Exists(clsGeneralProperties.RegisteredUserFile))
            {
                string[] Line = File.ReadAllText(clsGeneralProperties.RegisteredUserFile).Split(',');

                txtUserName.Text = Line[0];
                txtPassword.Text = Line[1];

                cbRememberMeBox.Checked = true;
            }
        }
    }
}
