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

namespace DVLD
{
    public partial class frmUsers : Form
    {
        private int SelectedUserID { get { return Convert.ToInt32(ucUsersList.SelectedRow.Cells[0].Value); } }
        private int SelectedPersonID { get { return Convert.ToInt32(ucUsersList.SelectedRow.Cells[1].Value); } }

        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            ucUsersList.SetList(clsUser.UsersList());
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            frmUpdateAndAddUser AddUserForm = new frmUpdateAndAddUser();
            AddUserForm.ShowDialog();

            ucUsersList.SetList(clsUser.UsersList());
        }

        private void ShowDetails_Click(object sender, EventArgs e)
        {
            frmUserCard UserCardForm = new frmUserCard(SelectedUserID);
            UserCardForm.ShowDialog();

            ucUsersList.SetList(clsUser.UsersList());
        }

        private void tsmiEditUser_Click(object sender, EventArgs e)
        {
            frmUpdateAndAddUser AddUserForm = new frmUpdateAndAddUser(SelectedUserID);
            AddUserForm.ShowDialog();

            ucUsersList.SetList(clsUser.UsersList());
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this User with the ID : "
                + SelectedUserID.ToString(),
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (clsUser.Delete(SelectedUserID))
                {
                    MessageBox.Show("The User has been successfully deleted.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
                else
                {
                    MessageBox.Show("This User cannot be deleted because they are linked to " +
                        "other entities in the system.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ucUsersList.SetList(clsUser.UsersList());
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword ChangePasswordForm = new frmChangePassword(SelectedUserID);
            ChangePasswordForm.ShowDialog();
        }

        private void ucUsersList_FilterValueChanged(object sender, CustomControls.UCFilter2.ResultEventArgs e)
        {
            ucUsersList.SetList(clsUser.UsersList(e.Value, e.FieldName));
        }
    }
}
