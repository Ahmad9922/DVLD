using DVLDBusiness;
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
    public partial class UCAddPerson : UserControl
    {
        public clsPerson Person {  get; set; }

        public event Action<int> OnPersonAdded;

        private bool IsImageChanged = false;

        private void SetInitialValues()
        {
            Person = new clsPerson();
            dtDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            btnMale.Checked = true;
        }

        public UCAddPerson()
        {
            InitializeComponent();

            SetInitialValues();
        }

        private bool FieldsValidation()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
                return false;

            if (string.IsNullOrEmpty(txtSecondName.Text))
                return false;

            if (string.IsNullOrEmpty(txtLastName.Text))
                return false;

            if (string.IsNullOrEmpty(txtNationalNo.Text)
                || (clsPerson.IsPersonExist(txtNationalNo.Text)
                && clsPerson.Find(txtNationalNo.Text).NationalNo != txtNationalNo.Text))
                return false;

            if (string.IsNullOrEmpty(txtPhone.Text))
                return false;

            if (!EmailValidation())
                return false;

            if (string.IsNullOrEmpty(txtAddress.Text))
                return false;

            return true;
        }

        public void LoadCountries()
        {
            cbCountries.Items.AddRange(clsCountry.CountriesList().ToArray());
            cbCountries.SelectedItem = "Libya";
        }

        private void SetGendorForUpdate()
        {
            if (Person.Gendor == clsPerson.enGendor.Male)
            {
                btnMale.Checked = true;
                btnFemale.Checked = false;
            }
            else
            {
                btnFemale.Checked = true;
                btnMale.Checked = false;
            }
        }

        public void SetPerson(int PersonID)
        {
            Person = clsPerson.Find(PersonID);

            lblPersonIDValue.Text = Person.PersonID.ToString();
            txtFirstName.Text = Person.FirstName;
            txtSecondName.Text = Person.SecondName;
            txtThirdName.Text = Person.ThirdName;
            txtLastName.Text = Person.LastName;
            txtNationalNo.Text = Person.NationalNo;
            txtPhone.Text = Person.Phone;
            txtEmail.Text = Person.Email;
            txtAddress.Text = Person.Address;
            SetGendorForUpdate();
            dtDateOfBirth.Value = Person.DateOfBirth;
            cbCountries.SelectedItem = Person.NationalityCountry;

            try
            {
                if (!string.IsNullOrEmpty(Person.ImagePath))
                {
                    FileStream fileStream = new FileStream(Person.ImagePath, FileMode.Open);
                    Image Img = Image.FromStream(fileStream);

                    btnPersonImage.Image = Img;
                    fileStream.Close();
                }
            }
            catch
            {
                MessageBox.Show("It Seems that the image path is incorrect." +
                    " You can select an image from the device if you wish.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPersonImage_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"C:\DVLD\Persons Images"))
            {
                Directory.CreateDirectory(@"C:\DVLD\Persons Images");
            }

            if (ofdImageDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(ofdImageDialog.FileName, FileMode.Open);

                btnPersonImage.Image = Image.FromStream(fileStream);
                fileStream.Close();

                btnPersonImage.Text = ofdImageDialog.FileName;
                IsImageChanged = true;
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            btnPersonImage.Text = string.Empty;
            IsImageChanged = true;

            SetDefaultGendorImage();
        }

        private void SetGendorForAdd()
        {
            if (btnMale.Checked)
                Person.Gendor = clsPerson.enGendor.Male;
            else
                Person.Gendor = clsPerson.enGendor.Female;
        }

        private void SetPersonInfo()
        {
            Person.NationalNo = txtNationalNo.Text;
            Person.FirstName = txtFirstName.Text;
            Person.SecondName = txtSecondName.Text;
            Person.ThirdName = txtThirdName.Text;
            Person.LastName = txtLastName.Text;
            Person.DateOfBirth = dtDateOfBirth.Value;
            Person.Email = txtEmail.Text;
            Person.Phone = txtPhone.Text;
            SetGendorForAdd();
            Person.Address = txtAddress.Text;
            Person.NationalityCountry = cbCountries.SelectedItem.ToString();

            if (IsImageChanged)
            {
                Person.ImagePath = btnPersonImage.Text;
            }
        }

        public bool SavePerson()
        {
            if (FieldsValidation())
            {
                SetPersonInfo();

                if (Person.Save())
                {
                    lblPersonIDValue.Text = Person.PersonID.ToString();

                    MessageBox.Show("The person has been saved successfully .",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    if (Person.Mode == clsPerson.enMode.AddNew)
                        if (OnPersonAdded != null)
                            OnPersonAdded.Invoke(Person.PersonID);

                    return true;
                }
                else
                {
                    MessageBox.Show("Failed to save the person. If the problem persists," +
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

        private bool EmailValidation()
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
                return true;

            if (txtEmail.Text.EndsWith("@gmail.com"))
                return true;

            if (txtEmail.Text.EndsWith("@outlook.com"))
                return true;

            if (txtEmail.Text.EndsWith("@hotmail.com"))
                return true;

            if (txtEmail.Text.EndsWith("@yahoo.com"))
                return true;

            return false;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            txtEmail.Text = txtEmail.Text.Trim();

            ErrorProvider1.Clear();

            if(EmailValidation())
                return;

            ErrorProvider1.SetError(txtEmail, "The email format is incorrect");
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider1.Clear();

            if (Person != null)
                if (Person.NationalNo == txtNationalNo.Text)
                    return;

            if (clsPerson.IsPersonExist(txtNationalNo.Text))
            {
                ErrorProvider1.SetError(txtNationalNo, "The nationalno you entered is already in use");
            }
        }

        private void SetDefaultGendorImage()
        {
            if (btnMale.Checked)
                btnPersonImage.Image = ilGendorImage.Images["Male"];
            else
                btnPersonImage.Image = ilGendorImage.Images["Female"];
        }

        private void Gendor_CheckedChanged(object sender, EventArgs e)
        {
            SetDefaultGendorImage();
        }
    }
}
