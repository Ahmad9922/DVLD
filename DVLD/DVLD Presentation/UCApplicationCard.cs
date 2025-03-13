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
    public partial class UCApplicationCard : UserControl
    {
        public clsApplication Application { get; set; }

        public UCApplicationCard()
        {
            InitializeComponent();
        }

        public void FillApplication(int ApplicationID)
        {
            if ((Application = clsApplication.Find(ApplicationID)) != null)
            {
                lblApplicationID.Text = ApplicationID.ToString();
                lblApplicantPerson.Text = Application.ApplicantPerson.FullName;
                lblApplicationDate.Text = Application.ApplicationDate.ToShortDateString();
                lblApplicationStatus.Text = Application.ApplicationStatus.ToString();
                lblLastStatusDate.Text = Application.LastStatusDate.ToShortDateString();
                lblApplicationType.Text = Application.ApplicationType.Title;
                lblCreatedByUser.Text = Application.CreatedByUser.UserName;
            }
        }

        private void ViewPersonInfo_Click(object sender, EventArgs e)
        {
            frmPersonCard PersonCardForm = new frmPersonCard(Application.ApplicantPerson.PersonID);
            PersonCardForm.ShowDialog();
        }
    }
}
