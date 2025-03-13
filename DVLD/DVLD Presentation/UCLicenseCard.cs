using DVLDBusiness;
using DVLDPresentation.Properties;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class UCLicenseCard : UserControl
    {
        public clsLocalLicense License {  get; set; }

        public clsInternationalLicense InternationalLicense { get; set; }

        public UCLicenseCard()
        {
            InitializeComponent();
        }

        private void SetColor(Color color)
        {
            lblClassName.BackColor = color;
            guna2Panel1.BorderColor = color;
            guna2Panel2.BorderColor = color;
        }

        private void LicenseStyle()
        {
            switch (License.LicenseClass.LicenseClassID)
            {
                case 1:
                    SetColor(Color.MediumPurple);
                    break;
                case 2:
                    SetColor(Color.MediumSeaGreen);
                    break;
                case 3:
                    SetColor(Color.DarkRed);
                    break;
                case 4:
                    SetColor(Color.DarkOrange);
                    break;
                case 5:
                    SetColor(Color.DarkSlateBlue);
                    break;
                case 6:
                    SetColor(Color.DarkMagenta);
                    break;
                case 7:
                    SetColor(Color.DarkKhaki);
                    break;
            }
        }

        public void FillLocalLicenseInfo(int LicenseID)
        {
            if ((License = clsLocalLicense.Find(LicenseID)) != null)
            {
                lblClassName.Text = License.LicenseClass.ClassName;
                lblName.Text = License.Application.ApplicantPerson.FullName;
                lblLicenseID.Text = License.LicenseID.ToString();
                lblDateOfBirth.Text = License.Application.ApplicantPerson.DateOfBirth.ToShortDateString();
                lblIssueDate.Text = License.IssueDate.ToShortDateString();
                lblDriverID.Text = License.Driver.DriverID.ToString();
                lblNationality.Text = License.Application.ApplicantPerson.NationalityCountry;
                lblNationalNo.Text = License.Application.ApplicantPerson.NationalNo;
                lblIssueReason.Text = License.IssueReason.ToString();
                lblNotes.Text = License.Notes;
                lblExpirationDate.Text = License.ExpirationDate.ToShortDateString();
                lblIsActive.Text = License.IsActive ? "Yes" : "No";
                lblIsDetained.Text = License.IsDetain ? "Yes" : "No";
                lblApplicationID.Text = License.Application.ApplicationID.ToString();

                LicenseStyle();

                try
                {
                    FileStream fileStream = new FileStream(License.Application.ApplicantPerson.ImagePath,
                        FileMode.Open);
                    PersonImage.Image = Image.FromStream(fileStream);
                    fileStream.Close();
                }
                catch
                {
                    MessageBox.Show("It seems that the image path is incorrect." +
                    " You can select an image from the device if you wish.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void FillInternationalLicenseInfo(int InternationalLicenseID)
        {
            if ((InternationalLicense = clsInternationalLicense.Find(InternationalLicenseID)) != null)
            {
                lblClassName.Text = "International License";
                lblName.Text = InternationalLicense.Application.ApplicantPerson.FullName;
                lblLicenseID.Text = InternationalLicense.LicenseID.ToString();
                lblDateOfBirth.Text = InternationalLicense.Application.ApplicantPerson.DateOfBirth.ToShortDateString();
                lblIssueDate.Text = InternationalLicense.IssueDate.ToShortDateString();
                lblDriverID.Text = InternationalLicense.Driver.DriverID.ToString();
                lblNationality.Text = InternationalLicense.Application.ApplicantPerson.NationalityCountry;
                lblNationalNo.Text = InternationalLicense.Application.ApplicantPerson.NationalNo;
                lblIssueReason.Text = "";
                lblNotes.Text = InternationalLicense.LocalLicense.Notes;
                lblExpirationDate.Text = InternationalLicense.ExpirationDate.ToShortDateString();
                lblIsActive.Text = InternationalLicense.IsActive ? "Yes" : "No";
                lblIsDetained.Text = InternationalLicense.IsActive ? "No" : "Yes";
                lblApplicationID.Text = InternationalLicense.Application.ApplicationID.ToString();

                lblClassName.BackColor = Color.Teal;
                guna2Panel1.BorderColor = Color.Teal;
                guna2Panel2.BorderColor = Color.Teal;

                try
                {
                    FileStream fileStream = new FileStream(InternationalLicense.Application.ApplicantPerson.ImagePath,
                        FileMode.Open);
                    PersonImage.Image = Image.FromStream(fileStream);
                    fileStream.Close();
                }
                catch
                {
                    MessageBox.Show("It seems that the image path is incorrect." +
                    " You can select an image from the device if you wish.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void Clear()
        {
            License = null;
            InternationalLicense = null;

            lblClassName.Text = "???";
            lblName.Text = "???";
            lblLicenseID.Text = "???";
            lblDateOfBirth.Text = "???";
            lblIssueDate.Text = "???";
            lblDriverID.Text = "???";
            lblNationality.Text = "???";
            lblNationalNo.Text = "???";
            lblIssueReason.Text = "???";
            lblNotes.Text = "???";
            lblExpirationDate.Text = "???";
            lblIsActive.Text = "???";
            lblIsDetained.Text = "???";
            lblApplicationID.Text = "???";

            lblClassName.BackColor = Color.Silver;
            guna2Panel1.BorderColor = Color.Silver;
            guna2Panel2.BorderColor = Color.Silver;

            PersonImage.Image = ((System.Drawing.Image)(new 
                System.ComponentModel.ComponentResourceManager(typeof(UCLicenseCard))
                .GetObject("PersonImage.Image")));
        }
    }
}
