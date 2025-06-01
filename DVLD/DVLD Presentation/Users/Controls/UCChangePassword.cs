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

namespace DVLD
{
    public partial class UCChangePassword : UserControl
    {
        clsUser User;

        public UCChangePassword()
        {
            InitializeComponent();

            txtCurrentPassword.Select();
        }

        public void SetUserToChangePassword(clsUser User)
        {
            this.User = User;
        }

        private void txtCurruntPassword_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider.Clear();

            if (User.Password != txtCurrentPassword.Text)
            {
                ErrorProvider.SetError(txtCurrentPassword, "The password is incorrect.");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                txtNewPassword.Select();
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider.Clear();

            if (txtNewPassword.Text.Length < 6)
            {
                ErrorProvider.SetError(txtNewPassword, "The password must be at least 6 characters long.");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider.Clear();

            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                ErrorProvider.SetError(txtConfirmPassword, "Ensure that the password matches.");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        public bool Save()
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                return false;
            }
            else
            {
                User.Password = txtNewPassword.Text;
            }

            if (User.Save())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
