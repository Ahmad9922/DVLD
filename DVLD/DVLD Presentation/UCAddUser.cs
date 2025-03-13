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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD
{
    public partial class UCAddUser : UserControl
    {
        clsUser User;

        public UCAddUser()
        {
            InitializeComponent();

            User = new clsUser();
        }

        public event Action<int> SaveComplete;

        private void FillFieldsToUpdate()
        {
            lblUserIDValue.Text = User.UserID.ToString();
            txtUserName.Text = User.UserName;
            txtPassword.Text = User.Password;
            txtConfirmPassword.Text = User.Password;
            cbIsActive.Checked = User.IsActive;
        }

        public void SetUser(int UserID)
        {
            if ((User = clsUser.Find(UserID)) != null)
            {
                FillFieldsToUpdate();
            }
        }

        private bool FieldsValidation(int PersonID)
        {
            if (PersonID == -1)
                return false;

            if (string.IsNullOrEmpty(txtUserName.Text))
                return false;

            if (string.IsNullOrEmpty(txtPassword.Text))
                return false;

            if (txtPassword.Text != txtConfirmPassword.Text)
                return false;

            return true;
        }

        private void SetUserInfo(int PersonID)
        {
            User.Person = clsPerson.Find(PersonID);
            User.UserName = txtUserName.Text;
            User.Password = txtPassword.Text;
            User.IsActive = cbIsActive.Checked;
        }

        public bool SaveUser(int PersonID)
        {
            if (FieldsValidation(PersonID))
            {
                SetUserInfo(PersonID);

                if (User.Save())
                {
                    lblUserIDValue.Text = User.UserID.ToString();

                    MessageBox.Show("The User has been saved successfully .",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                else
                {
                    MessageBox.Show("Failed to save the User. If the problem persists," +
                        " please seek assistance from the Service and Maintenance Center",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                MessageBox.Show("Some fields are embty or invalid, please check all fields and try again .",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider.Clear();

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                ErrorProvider.SetError(txtConfirmPassword, "The password is different from the previous one.");
            }
        }
    }
}
