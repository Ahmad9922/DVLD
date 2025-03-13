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
    public partial class UCUserCard : UserControl
    {
        public clsUser User { get; set; }

        public UCUserCard()
        {
            InitializeComponent();
        }

        private void SetUserInfo()
        {
            lblUserIDValue.Text = User.UserID.ToString();
            lblUserNameValue.Text = User.UserName.ToString();
            lblIsActiveValue.Text = User.IsActive ? "Yes" : "No";
            ucPersonCard1.SetPerson(User.Person.PersonID);
        }

        public void SetUser(int UserID)
        {
            if ((User = clsUser.Find(UserID)) != null)
            {
                SetUserInfo();
            }
        }

        public void SetUser(string UserName)
        {
            if ((User = clsUser.Find(UserName)) != null)
            {
                SetUserInfo();
            }
        }

        public void Clear()
        {
            User = null;

            lblUserIDValue.Text = "???";
            lblUserNameValue.Text = "???";
            lblIsActiveValue.Text = "???";
            ucPersonCard1.Clear();
        }
    }
}
