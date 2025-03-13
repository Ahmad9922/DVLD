using System;
using DVLDBusiness;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using DVLD;
using System.IO;

namespace DVLDPresentation
{
    public partial class frmMain : Form
    {
        frmHome HomeForm;
        frmPeople PeopleForm;
        frmDrivers DriversForm;
        frmUsers UsersForm;

        public frmMain()
        {
            InitializeComponent();

            HomeForm = new frmHome();
            PeopleForm = new frmPeople();
            DriversForm = new frmDrivers();
            UsersForm = new frmUsers();
        }

        private void SetRegisteredUserInfo()
        {
            btnRegisteredUserAccount.Text = clsGeneralProperties.RegisteredUser.UserName;

            try
            {
                FileStream fileStream = new FileStream(clsGeneralProperties.RegisteredUser.Person.ImagePath, FileMode.Open);
                btnRegisteredUserAccount.Image = Bitmap.FromStream(fileStream);
                fileStream.Close();
            }
            catch
            {
                btnRegisteredUserAccount.Image = null;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HomeForm.MdiParent = this;
            HomeForm.Dock = DockStyle.Fill;
            HomeForm.Show();

            SetRegisteredUserInfo();
        }

        private void SetForm(Form frm)
        {
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnHomeTab_Click(object sender, EventArgs e)
        {
            PeopleForm.Close();
            DriversForm.Close();
            UsersForm.Close();

            if (HomeForm.IsDisposed)
                HomeForm = new frmHome();

            SetForm(HomeForm);
        }

        private void btnPeopleTab_Click(object sender, EventArgs e)
        {
            HomeForm.Close();
            DriversForm.Close();
            UsersForm.Close();

            if (PeopleForm.IsDisposed)
                PeopleForm = new frmPeople();

            SetForm(PeopleForm);
        }

        private void btnDriversTab_Click(object sender, EventArgs e)
        {
            HomeForm.Close();
            PeopleForm.Close();
            UsersForm.Close();

            if (DriversForm.IsDisposed)
                DriversForm = new frmDrivers();

            SetForm(DriversForm);
        }

        private void UsersTab_Click(object sender, EventArgs e)
        {
            PeopleForm.Close();
            DriversForm.Close();
            HomeForm.Close();

            if (UsersForm.IsDisposed)
                UsersForm = new frmUsers();

            SetForm(UsersForm);
        }

        private void btnRegisteredUserAccount_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Visible)
                flowLayoutPanel1.Visible = false;
            else
                flowLayoutPanel1.Visible = true;
        }

        private void btnAccountInfo_Click(object sender, EventArgs e)
        {
            frmUserCard UserCardForm = new frmUserCard(clsGeneralProperties.RegisteredUser.UserID);
            UserCardForm.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword ChangePasswordForm = new frmChangePassword(clsGeneralProperties.RegisteredUser.UserID);
            ChangePasswordForm.ShowDialog();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            clsGeneralProperties.RegisteredUser = null;
            frmLoginScreen LoginForm = new frmLoginScreen();
            this.Hide();
            LoginForm.ShowDialog();
            this.Close();
        }
    }
}
