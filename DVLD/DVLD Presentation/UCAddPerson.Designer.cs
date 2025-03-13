namespace DVLD
{
    partial class UCAddPerson
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAddPerson));
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbPersonInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblPersonID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPersonIDValue = new System.Windows.Forms.Label();
            this.txtNationalNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRemoveImage = new Guna.UI2.WinForms.Guna2Button();
            this.btnPersonImage = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbCountries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtDateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnFemale = new Guna.UI2.WinForms.Guna2Button();
            this.lblGendor = new System.Windows.Forms.Label();
            this.btnMale = new Guna.UI2.WinForms.Guna2Button();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtThirdName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSecondName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ilGendorImage = new System.Windows.Forms.ImageList(this.components);
            this.ofdImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtFirstName.IconLeft")));
            this.txtFirstName.Location = new System.Drawing.Point(19, 136);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(223, 36);
            this.txtFirstName.TabIndex = 0;
            // 
            // gbPersonInfo
            // 
            this.gbPersonInfo.Controls.Add(this.lblPersonID);
            this.gbPersonInfo.Controls.Add(this.lblPersonIDValue);
            this.gbPersonInfo.Controls.Add(this.txtNationalNo);
            this.gbPersonInfo.Controls.Add(this.btnRemoveImage);
            this.gbPersonInfo.Controls.Add(this.btnPersonImage);
            this.gbPersonInfo.Controls.Add(this.txtAddress);
            this.gbPersonInfo.Controls.Add(this.cbCountries);
            this.gbPersonInfo.Controls.Add(this.lblCountry);
            this.gbPersonInfo.Controls.Add(this.lblDateOfBirth);
            this.gbPersonInfo.Controls.Add(this.dtDateOfBirth);
            this.gbPersonInfo.Controls.Add(this.btnFemale);
            this.gbPersonInfo.Controls.Add(this.lblGendor);
            this.gbPersonInfo.Controls.Add(this.btnMale);
            this.gbPersonInfo.Controls.Add(this.txtEmail);
            this.gbPersonInfo.Controls.Add(this.txtPhone);
            this.gbPersonInfo.Controls.Add(this.txtLastName);
            this.gbPersonInfo.Controls.Add(this.txtThirdName);
            this.gbPersonInfo.Controls.Add(this.txtSecondName);
            this.gbPersonInfo.Controls.Add(this.lblName);
            this.gbPersonInfo.Controls.Add(this.txtFirstName);
            this.gbPersonInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPersonInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbPersonInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbPersonInfo.Location = new System.Drawing.Point(0, 0);
            this.gbPersonInfo.MinimumSize = new System.Drawing.Size(638, 390);
            this.gbPersonInfo.Name = "gbPersonInfo";
            this.gbPersonInfo.Size = new System.Drawing.Size(705, 555);
            this.gbPersonInfo.TabIndex = 2;
            this.gbPersonInfo.Text = "Person Information";
            this.gbPersonInfo.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // lblPersonID
            // 
            this.lblPersonID.BorderThickness = 0;
            this.lblPersonID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPersonID.DefaultText = "Person : ";
            this.lblPersonID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblPersonID.DisabledState.FillColor = System.Drawing.Color.White;
            this.lblPersonID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblPersonID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblPersonID.Enabled = false;
            this.lblPersonID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblPersonID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblPersonID.IconLeft = ((System.Drawing.Image)(resources.GetObject("lblPersonID.IconLeft")));
            this.lblPersonID.Location = new System.Drawing.Point(19, 52);
            this.lblPersonID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.PasswordChar = '\0';
            this.lblPersonID.PlaceholderText = "";
            this.lblPersonID.SelectedText = "";
            this.lblPersonID.Size = new System.Drawing.Size(117, 34);
            this.lblPersonID.TabIndex = 27;
            // 
            // lblPersonIDValue
            // 
            this.lblPersonIDValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonIDValue.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblPersonIDValue.Location = new System.Drawing.Point(136, 57);
            this.lblPersonIDValue.Name = "lblPersonIDValue";
            this.lblPersonIDValue.Size = new System.Drawing.Size(159, 25);
            this.lblPersonIDValue.TabIndex = 26;
            this.lblPersonIDValue.Text = "N/A";
            this.lblPersonIDValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNationalNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalNo.DefaultText = "";
            this.txtNationalNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNationalNo.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtNationalNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationalNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationalNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationalNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNationalNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationalNo.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtNationalNo.IconLeft")));
            this.txtNationalNo.Location = new System.Drawing.Point(271, 136);
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.PasswordChar = '\0';
            this.txtNationalNo.PlaceholderText = "NationalNo";
            this.txtNationalNo.SelectedText = "";
            this.txtNationalNo.Size = new System.Drawing.Size(223, 36);
            this.txtNationalNo.TabIndex = 9;
            this.txtNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalNo_Validating);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveImage.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btnRemoveImage.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnRemoveImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveImage.FillColor = System.Drawing.Color.Empty;
            this.btnRemoveImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnRemoveImage.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveImage.Image")));
            this.btnRemoveImage.Location = new System.Drawing.Point(562, 304);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(76, 25);
            this.btnRemoveImage.TabIndex = 24;
            this.btnRemoveImage.Text = "Remove";
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // btnPersonImage
            // 
            this.btnPersonImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonImage.AnimatedGIF = true;
            this.btnPersonImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersonImage.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPersonImage.HoverState.ImageSize = new System.Drawing.Size(150, 150);
            this.btnPersonImage.Image = ((System.Drawing.Image)(resources.GetObject("PersonImage.Image")));
            this.btnPersonImage.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPersonImage.ImageRotate = 0F;
            this.btnPersonImage.ImageSize = new System.Drawing.Size(140, 140);
            this.btnPersonImage.IndicateFocus = true;
            this.btnPersonImage.Location = new System.Drawing.Point(519, 136);
            this.btnPersonImage.Name = "PersonImage";
            this.btnPersonImage.PressedState.ImageSize = new System.Drawing.Size(140, 140);
            this.btnPersonImage.Size = new System.Drawing.Size(162, 162);
            this.btnPersonImage.TabIndex = 23;
            this.btnPersonImage.Click += new System.EventHandler(this.btnPersonImage_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.AutoSize = true;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtAddress.IconLeft")));
            this.txtAddress.IconLeftOffset = new System.Drawing.Point(0, -50);
            this.txtAddress.Location = new System.Drawing.Point(19, 404);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "Address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(662, 137);
            this.txtAddress.TabIndex = 22;
            // 
            // cbCountries
            // 
            this.cbCountries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCountries.BackColor = System.Drawing.Color.Transparent;
            this.cbCountries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCountries.DropDownHeight = 200;
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountries.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountries.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCountries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCountries.IntegralHeight = false;
            this.cbCountries.ItemHeight = 30;
            this.cbCountries.Location = new System.Drawing.Point(271, 346);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(410, 36);
            this.cbCountries.TabIndex = 20;
            // 
            // lblCountry
            // 
            this.lblCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblCountry.Location = new System.Drawing.Point(267, 319);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(81, 19);
            this.lblCountry.TabIndex = 19;
            this.lblCountry.Text = "Country : ";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblDateOfBirth.Location = new System.Drawing.Point(15, 319);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(117, 19);
            this.lblDateOfBirth.TabIndex = 18;
            this.lblDateOfBirth.Text = "Date Of Birth : ";
            // 
            // dtDateOfBirth
            // 
            this.dtDateOfBirth.Checked = true;
            this.dtDateOfBirth.FillColor = System.Drawing.Color.Silver;
            this.dtDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.dtDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtDateOfBirth.Location = new System.Drawing.Point(19, 346);
            this.dtDateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDateOfBirth.Name = "dtDateOfBirth";
            this.dtDateOfBirth.Size = new System.Drawing.Size(223, 36);
            this.dtDateOfBirth.TabIndex = 17;
            this.dtDateOfBirth.Value = new System.DateTime(2005, 1, 22, 0, 0, 0, 0);
            // 
            // btnFemale
            // 
            this.btnFemale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFemale.BackColor = System.Drawing.Color.Transparent;
            this.btnFemale.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btnFemale.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnFemale.BorderThickness = 1;
            this.btnFemale.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFemale.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFemale.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFemale.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFemale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFemale.FillColor = System.Drawing.Color.Empty;
            this.btnFemale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnFemale.Image = ((System.Drawing.Image)(resources.GetObject("btnFemale.Image")));
            this.btnFemale.Location = new System.Drawing.Point(458, 262);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(36, 36);
            this.btnFemale.TabIndex = 16;
            this.btnFemale.CheckedChanged += new System.EventHandler(this.Gendor_CheckedChanged);
            // 
            // lblGendor
            // 
            this.lblGendor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGendor.AutoSize = true;
            this.lblGendor.BackColor = System.Drawing.Color.Transparent;
            this.lblGendor.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblGendor.Location = new System.Drawing.Point(267, 270);
            this.lblGendor.Name = "lblGendor";
            this.lblGendor.Size = new System.Drawing.Size(77, 19);
            this.lblGendor.TabIndex = 15;
            this.lblGendor.Text = "Gendor : ";
            // 
            // btnMale
            // 
            this.btnMale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMale.BackColor = System.Drawing.Color.Transparent;
            this.btnMale.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btnMale.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnMale.BorderThickness = 1;
            this.btnMale.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMale.Checked = true;
            this.btnMale.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMale.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMale.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMale.FillColor = System.Drawing.Color.Empty;
            this.btnMale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnMale.Image = ((System.Drawing.Image)(resources.GetObject("btnMale.Image")));
            this.btnMale.Location = new System.Drawing.Point(416, 262);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(36, 36);
            this.btnMale.TabIndex = 14;
            this.btnMale.CheckedChanged += new System.EventHandler(this.Gendor_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtEmail.IconLeft")));
            this.txtEmail.Location = new System.Drawing.Point(271, 220);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Email (Optional)";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(223, 36);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPhone.IconLeft")));
            this.txtPhone.Location = new System.Drawing.Point(271, 178);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "Phone";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(223, 36);
            this.txtPhone.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtLastName.IconLeft")));
            this.txtLastName.Location = new System.Drawing.Point(19, 262);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(223, 36);
            this.txtLastName.TabIndex = 6;
            // 
            // txtThirdName
            // 
            this.txtThirdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThirdName.DefaultText = "";
            this.txtThirdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThirdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThirdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThirdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThirdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThirdName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtThirdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThirdName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtThirdName.IconLeft")));
            this.txtThirdName.Location = new System.Drawing.Point(19, 220);
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.PasswordChar = '\0';
            this.txtThirdName.PlaceholderText = "Third Name (Optional)";
            this.txtThirdName.SelectedText = "";
            this.txtThirdName.Size = new System.Drawing.Size(223, 36);
            this.txtThirdName.TabIndex = 5;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSecondName.DefaultText = "";
            this.txtSecondName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSecondName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSecondName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecondName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecondName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecondName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSecondName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecondName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSecondName.IconLeft")));
            this.txtSecondName.Location = new System.Drawing.Point(19, 178);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.PasswordChar = '\0';
            this.txtSecondName.PlaceholderText = "Second Name";
            this.txtSecondName.SelectedText = "";
            this.txtSecondName.Size = new System.Drawing.Size(223, 36);
            this.txtSecondName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblName.Location = new System.Drawing.Point(15, 108);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 19);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name : ";
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.ContainerControl = this;
            // 
            // ilGendorImage
            // 
            this.ilGendorImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilGendorImage.ImageStream")));
            this.ilGendorImage.TransparentColor = System.Drawing.Color.Transparent;
            this.ilGendorImage.Images.SetKeyName(0, "Male");
            this.ilGendorImage.Images.SetKeyName(1, "Female");
            // 
            // ofdImageDialog
            // 
            this.ofdImageDialog.Filter = "All Images | *.png; *.jpg; *.jpeg; *.bmp | PNG (*.png)|*.png; | JPG (*.jpg) | *.j" +
    "pg; | JPEG (*.jpeg) | *.jpeg; | BMP (*.bmp) | *.bmp;";
            // 
            // UCAddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbPersonInfo);
            this.Name = "UCAddPerson";
            this.Size = new System.Drawing.Size(705, 555);
            this.gbPersonInfo.ResumeLayout(false);
            this.gbPersonInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2GroupBox gbPersonInfo;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtThirdName;
        private Guna.UI2.WinForms.Guna2TextBox txtSecondName;
        private Guna.UI2.WinForms.Guna2TextBox txtNationalNo;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2Button btnFemale;
        private System.Windows.Forms.Label lblGendor;
        private Guna.UI2.WinForms.Guna2Button btnMale;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblCountry;
        private Guna.UI2.WinForms.Guna2ComboBox cbCountries;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2ImageButton btnPersonImage;
        private Guna.UI2.WinForms.Guna2Button btnRemoveImage;
        private System.Windows.Forms.ErrorProvider ErrorProvider1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtDateOfBirth;
        private System.Windows.Forms.Label lblPersonIDValue;
        private System.Windows.Forms.ImageList ilGendorImage;
        private Guna.UI2.WinForms.Guna2TextBox lblPersonID;
        private System.Windows.Forms.OpenFileDialog ofdImageDialog;
    }
}
