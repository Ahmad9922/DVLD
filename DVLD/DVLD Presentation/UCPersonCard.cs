using DVLDBusiness;
using DVLDPresentation.Properties;
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
    public partial class UCPersonCard : UserControl
    {
        public clsPerson PersonInfo { get; private set; }

        public UCPersonCard()
        {
            InitializeComponent();
        }
     
        private void SetPersonInfo()
        {
            lblPersonIDValue.Text = PersonInfo.PersonID.ToString();
            lblNameValue.Text = PersonInfo.FullName;
            lblNationalNoValue.Text = PersonInfo.NationalNo;
            lblPhoneValue.Text = PersonInfo.Phone;
            lblEmailValue.Text = PersonInfo.Email;
            lblAddressValue.Text = PersonInfo.Address;
            lblGendorValue.Text = PersonInfo.Gendor.ToString();
            lblDateOfBirthValue.Text = PersonInfo.DateOfBirth.ToShortDateString();
            lblCountryValue.Text = PersonInfo.NationalityCountry;

            try
            {
                if (!string.IsNullOrEmpty(PersonInfo.ImagePath))
                {
                    FileStream fileStream = new FileStream(PersonInfo.ImagePath, FileMode.Open);
                    Image Img = Image.FromStream(fileStream);

                    btnPersonImage.Image = Img;
                    fileStream.Close();
                }
            }
            catch
            {
                MessageBox.Show("It Seems that the image path is incorrect." +
                    " You can select an image from the device if you wish.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                btnPersonImage.Image = ((Image)(new ComponentResourceManager(typeof(UCPersonCard)).GetObject("PersonImage.Image")));
            }
        }

        public bool SetPerson(int PersonID)
        {
            if ((PersonInfo = clsPerson.Find(PersonID)) != null)
            {
                SetPersonInfo();
                return true;
            }

            return false;
        }

        public bool SetPerson(string NationalNo)
        {
            if ((PersonInfo = clsPerson.Find(NationalNo)) != null)
            {
                SetPersonInfo();
                return true;
            }

            return false;
        }

        public void Clear()
        {
            PersonInfo = null;

            lblPersonIDValue.Text = "---";
            lblNameValue.Text = "---";
            lblNationalNoValue.Text = "---";
            lblPhoneValue.Text = "---";
            lblEmailValue.Text = "---";
            lblAddressValue.Text = "---";
            lblGendorValue.Text = "---";
            lblDateOfBirthValue.Text = "---";
            lblCountryValue.Text = "---";
            btnPersonImage.Image = ((Image)(new ComponentResourceManager(typeof(UCPersonCard)).GetObject("PersonImage.Image")));
        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            if (PersonInfo != null)
            {
                frmUpdateAndAddPerson AddNewPersonForm
                = new frmUpdateAndAddPerson(Convert.ToInt32(PersonInfo.PersonID));
                AddNewPersonForm.ShowDialog();

                SetPerson(PersonInfo.PersonID);
            }
        }
    }
}
