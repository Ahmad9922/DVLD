namespace DVLD
{
    partial class UCApplicationCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCApplicationCard));
            this.gbApplicationInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnViewPersonInfo = new Guna.UI2.WinForms.Guna2Button();
            this.lblApplicationType = new System.Windows.Forms.Label();
            this.lblGendor = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNationalNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.lblApplicantPerson = new System.Windows.Forms.Label();
            this.lblLastStatusDate = new System.Windows.Forms.Label();
            this.lblApplicationStatus = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.gbApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbApplicationInfo
            // 
            this.gbApplicationInfo.Controls.Add(this.btnViewPersonInfo);
            this.gbApplicationInfo.Controls.Add(this.lblApplicationType);
            this.gbApplicationInfo.Controls.Add(this.lblGendor);
            this.gbApplicationInfo.Controls.Add(this.lblAddress);
            this.gbApplicationInfo.Controls.Add(this.lblEmail);
            this.gbApplicationInfo.Controls.Add(this.lblPhone);
            this.gbApplicationInfo.Controls.Add(this.lblNationalNo);
            this.gbApplicationInfo.Controls.Add(this.guna2TextBox1);
            this.gbApplicationInfo.Controls.Add(this.guna2TextBox2);
            this.gbApplicationInfo.Controls.Add(this.lblCreatedByUser);
            this.gbApplicationInfo.Controls.Add(this.lblApplicantPerson);
            this.gbApplicationInfo.Controls.Add(this.lblLastStatusDate);
            this.gbApplicationInfo.Controls.Add(this.lblApplicationStatus);
            this.gbApplicationInfo.Controls.Add(this.lblApplicationID);
            this.gbApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.gbApplicationInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbApplicationInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbApplicationInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbApplicationInfo.Location = new System.Drawing.Point(0, 0);
            this.gbApplicationInfo.Name = "gbApplicationInfo";
            this.gbApplicationInfo.Size = new System.Drawing.Size(849, 227);
            this.gbApplicationInfo.TabIndex = 46;
            this.gbApplicationInfo.Text = "Application Info";
            this.gbApplicationInfo.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // btnViewPersonInfo
            // 
            this.btnViewPersonInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnViewPersonInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btnViewPersonInfo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnViewPersonInfo.BorderThickness = 2;
            this.btnViewPersonInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewPersonInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewPersonInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewPersonInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewPersonInfo.FillColor = System.Drawing.Color.Empty;
            this.btnViewPersonInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewPersonInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnViewPersonInfo.Location = new System.Drawing.Point(327, 89);
            this.btnViewPersonInfo.Name = "btnViewPersonInfo";
            this.btnViewPersonInfo.Size = new System.Drawing.Size(170, 35);
            this.btnViewPersonInfo.TabIndex = 53;
            this.btnViewPersonInfo.Text = "View Person Info";
            this.btnViewPersonInfo.Click += new System.EventHandler(this.ViewPersonInfo_Click);
            // 
            // lblApplicationType
            // 
            this.lblApplicationType.AutoSize = true;
            this.lblApplicationType.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationType.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblApplicationType.Location = new System.Drawing.Point(533, 140);
            this.lblApplicationType.Name = "lblApplicationType";
            this.lblApplicationType.Size = new System.Drawing.Size(27, 19);
            this.lblApplicationType.TabIndex = 52;
            this.lblApplicationType.Text = "---";
            // 
            // lblGendor
            // 
            this.lblGendor.BorderThickness = 0;
            this.lblGendor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblGendor.DefaultText = "Created By User : ";
            this.lblGendor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblGendor.DisabledState.FillColor = System.Drawing.Color.White;
            this.lblGendor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblGendor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblGendor.Enabled = false;
            this.lblGendor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblGendor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGendor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblGendor.IconLeft = ((System.Drawing.Image)(resources.GetObject("lblGendor.IconLeft")));
            this.lblGendor.Location = new System.Drawing.Point(327, 174);
            this.lblGendor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblGendor.Name = "lblGendor";
            this.lblGendor.PasswordChar = '\0';
            this.lblGendor.PlaceholderText = "";
            this.lblGendor.SelectedText = "";
            this.lblGendor.Size = new System.Drawing.Size(163, 34);
            this.lblGendor.TabIndex = 49;
            // 
            // lblAddress
            // 
            this.lblAddress.BorderThickness = 0;
            this.lblAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblAddress.DefaultText = "Last Status Date :";
            this.lblAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblAddress.DisabledState.FillColor = System.Drawing.Color.White;
            this.lblAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblAddress.Enabled = false;
            this.lblAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblAddress.IconLeft = ((System.Drawing.Image)(resources.GetObject("lblAddress.IconLeft")));
            this.lblAddress.Location = new System.Drawing.Point(19, 174);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.PasswordChar = '\0';
            this.lblAddress.PlaceholderText = "";
            this.lblAddress.SelectedText = "";
            this.lblAddress.Size = new System.Drawing.Size(170, 34);
            this.lblAddress.TabIndex = 48;
            // 
            // lblEmail
            // 
            this.lblEmail.BorderThickness = 0;
            this.lblEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblEmail.DefaultText = "Application Status : ";
            this.lblEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblEmail.DisabledState.FillColor = System.Drawing.Color.White;
            this.lblEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblEmail.Enabled = false;
            this.lblEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblEmail.IconLeft = ((System.Drawing.Image)(resources.GetObject("lblEmail.IconLeft")));
            this.lblEmail.Location = new System.Drawing.Point(19, 132);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.PasswordChar = '\0';
            this.lblEmail.PlaceholderText = "";
            this.lblEmail.SelectedText = "";
            this.lblEmail.Size = new System.Drawing.Size(188, 34);
            this.lblEmail.TabIndex = 47;
            // 
            // lblPhone
            // 
            this.lblPhone.BorderThickness = 0;
            this.lblPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPhone.DefaultText = "Application Type : ";
            this.lblPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblPhone.DisabledState.FillColor = System.Drawing.Color.White;
            this.lblPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblPhone.Enabled = false;
            this.lblPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblPhone.IconLeft = ((System.Drawing.Image)(resources.GetObject("lblPhone.IconLeft")));
            this.lblPhone.Location = new System.Drawing.Point(327, 132);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.PasswordChar = '\0';
            this.lblPhone.PlaceholderText = "";
            this.lblPhone.SelectedText = "";
            this.lblPhone.Size = new System.Drawing.Size(170, 34);
            this.lblPhone.TabIndex = 46;
            // 
            // lblNationalNo
            // 
            this.lblNationalNo.BorderThickness = 0;
            this.lblNationalNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblNationalNo.DefaultText = "Application Date : ";
            this.lblNationalNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblNationalNo.DisabledState.FillColor = System.Drawing.Color.White;
            this.lblNationalNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblNationalNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblNationalNo.Enabled = false;
            this.lblNationalNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblNationalNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblNationalNo.IconLeft = ((System.Drawing.Image)(resources.GetObject("lblNationalNo.IconLeft")));
            this.lblNationalNo.Location = new System.Drawing.Point(19, 90);
            this.lblNationalNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblNationalNo.Name = "lblNationalNo";
            this.lblNationalNo.PasswordChar = '\0';
            this.lblNationalNo.PlaceholderText = "";
            this.lblNationalNo.SelectedText = "";
            this.lblNationalNo.Size = new System.Drawing.Size(170, 34);
            this.lblNationalNo.TabIndex = 45;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderThickness = 0;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "Applicant Person : ";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.White;
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.Enabled = false;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.Location = new System.Drawing.Point(327, 48);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(170, 34);
            this.guna2TextBox1.TabIndex = 44;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderThickness = 0;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "ApplicationID : ";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.White;
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.Enabled = false;
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox2.IconLeft")));
            this.guna2TextBox2.Location = new System.Drawing.Point(19, 48);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(148, 34);
            this.guna2TextBox2.TabIndex = 43;
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblCreatedByUser.Location = new System.Drawing.Point(533, 181);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(27, 19);
            this.lblCreatedByUser.TabIndex = 37;
            this.lblCreatedByUser.Text = "---";
            // 
            // lblApplicantPerson
            // 
            this.lblApplicantPerson.AutoSize = true;
            this.lblApplicantPerson.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicantPerson.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblApplicantPerson.Location = new System.Drawing.Point(533, 58);
            this.lblApplicantPerson.Name = "lblApplicantPerson";
            this.lblApplicantPerson.Size = new System.Drawing.Size(27, 19);
            this.lblApplicantPerson.TabIndex = 35;
            this.lblApplicantPerson.Text = "---";
            // 
            // lblLastStatusDate
            // 
            this.lblLastStatusDate.AutoSize = true;
            this.lblLastStatusDate.BackColor = System.Drawing.Color.Transparent;
            this.lblLastStatusDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblLastStatusDate.Location = new System.Drawing.Point(216, 181);
            this.lblLastStatusDate.Name = "lblLastStatusDate";
            this.lblLastStatusDate.Size = new System.Drawing.Size(27, 19);
            this.lblLastStatusDate.TabIndex = 33;
            this.lblLastStatusDate.Text = "---";
            // 
            // lblApplicationStatus
            // 
            this.lblApplicationStatus.AutoSize = true;
            this.lblApplicationStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationStatus.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblApplicationStatus.Location = new System.Drawing.Point(216, 140);
            this.lblApplicationStatus.Name = "lblApplicationStatus";
            this.lblApplicationStatus.Size = new System.Drawing.Size(27, 19);
            this.lblApplicationStatus.TabIndex = 31;
            this.lblApplicationStatus.Text = "---";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblApplicationID.Location = new System.Drawing.Point(216, 58);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(27, 19);
            this.lblApplicationID.TabIndex = 29;
            this.lblApplicationID.Text = "---";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblApplicationDate.Location = new System.Drawing.Point(216, 99);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(27, 19);
            this.lblApplicationDate.TabIndex = 27;
            this.lblApplicationDate.Text = "---";
            // 
            // UCApplicationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbApplicationInfo);
            this.Name = "UCApplicationCard";
            this.Size = new System.Drawing.Size(849, 227);
            this.gbApplicationInfo.ResumeLayout(false);
            this.gbApplicationInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox gbApplicationInfo;
        private Guna.UI2.WinForms.Guna2TextBox lblGendor;
        private Guna.UI2.WinForms.Guna2TextBox lblAddress;
        private Guna.UI2.WinForms.Guna2TextBox lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox lblPhone;
        private Guna.UI2.WinForms.Guna2TextBox lblNationalNo;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label lblApplicantPerson;
        private System.Windows.Forms.Label lblLastStatusDate;
        private System.Windows.Forms.Label lblApplicationStatus;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblApplicationType;
        private Guna.UI2.WinForms.Guna2Button btnViewPersonInfo;
    }
}
