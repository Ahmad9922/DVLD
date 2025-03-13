namespace DVLD
{
    partial class UCAddTestAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAddTestAppointment));
            this.gbAppointmentInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtAppointmentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblLockEditingMessage = new System.Windows.Forms.Label();
            this.lblTrial = new System.Windows.Forms.Label();
            this.guna2TextBox8 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFees = new System.Windows.Forms.Label();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXT = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblApplicantPersonName = new System.Windows.Forms.Label();
            this.lblILocalDLAID = new System.Windows.Forms.Label();
            this.lblLicenseClass = new System.Windows.Forms.Label();
            this.gbRetakeTestInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox7 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblRTApplicationID = new System.Windows.Forms.Label();
            this.lblRTAFees = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.gbAppointmentInfo.SuspendLayout();
            this.gbRetakeTestInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAppointmentInfo
            // 
            this.gbAppointmentInfo.Controls.Add(this.dtAppointmentDate);
            this.gbAppointmentInfo.Controls.Add(this.lblLockEditingMessage);
            this.gbAppointmentInfo.Controls.Add(this.lblTrial);
            this.gbAppointmentInfo.Controls.Add(this.guna2TextBox8);
            this.gbAppointmentInfo.Controls.Add(this.lblFees);
            this.gbAppointmentInfo.Controls.Add(this.guna2TextBox4);
            this.gbAppointmentInfo.Controls.Add(this.guna2TextBox2);
            this.gbAppointmentInfo.Controls.Add(this.TXT);
            this.gbAppointmentInfo.Controls.Add(this.guna2TextBox1);
            this.gbAppointmentInfo.Controls.Add(this.guna2TextBox3);
            this.gbAppointmentInfo.Controls.Add(this.lblApplicantPersonName);
            this.gbAppointmentInfo.Controls.Add(this.lblILocalDLAID);
            this.gbAppointmentInfo.Controls.Add(this.lblLicenseClass);
            this.gbAppointmentInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.gbAppointmentInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAppointmentInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbAppointmentInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbAppointmentInfo.Location = new System.Drawing.Point(0, 0);
            this.gbAppointmentInfo.Name = "gbAppointmentInfo";
            this.gbAppointmentInfo.Size = new System.Drawing.Size(706, 324);
            this.gbAppointmentInfo.TabIndex = 48;
            this.gbAppointmentInfo.Text = "Test Appointment";
            this.gbAppointmentInfo.TextOffset = new System.Drawing.Point(7, 11);
            // 
            // dtAppointmentDate
            // 
            this.dtAppointmentDate.Checked = true;
            this.dtAppointmentDate.FillColor = System.Drawing.Color.White;
            this.dtAppointmentDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtAppointmentDate.ForeColor = System.Drawing.Color.DimGray;
            this.dtAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtAppointmentDate.Location = new System.Drawing.Point(110, 239);
            this.dtAppointmentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtAppointmentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtAppointmentDate.Name = "dtAppointmentDate";
            this.dtAppointmentDate.Size = new System.Drawing.Size(200, 36);
            this.dtAppointmentDate.TabIndex = 55;
            this.dtAppointmentDate.Value = new System.DateTime(2025, 2, 13, 22, 3, 52, 77);
            // 
            // lblLockEditingMessage
            // 
            this.lblLockEditingMessage.AutoSize = true;
            this.lblLockEditingMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblLockEditingMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLockEditingMessage.ForeColor = System.Drawing.Color.Red;
            this.lblLockEditingMessage.Location = new System.Drawing.Point(267, 21);
            this.lblLockEditingMessage.Name = "lblLockEditingMessage";
            this.lblLockEditingMessage.Size = new System.Drawing.Size(321, 19);
            this.lblLockEditingMessage.TabIndex = 60;
            this.lblLockEditingMessage.Text = "Person already sat for the test, appointment locked";
            this.lblLockEditingMessage.Visible = false;
            // 
            // lblTrial
            // 
            this.lblTrial.AutoSize = true;
            this.lblTrial.BackColor = System.Drawing.Color.Transparent;
            this.lblTrial.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTrial.Location = new System.Drawing.Point(267, 204);
            this.lblTrial.Name = "lblTrial";
            this.lblTrial.Size = new System.Drawing.Size(18, 19);
            this.lblTrial.TabIndex = 59;
            this.lblTrial.Text = "0";
            // 
            // guna2TextBox8
            // 
            this.guna2TextBox8.BorderThickness = 0;
            this.guna2TextBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox8.DefaultText = "Trial : ";
            this.guna2TextBox8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox8.DisabledState.FillColor = System.Drawing.Color.White;
            this.guna2TextBox8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox8.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox8.Enabled = false;
            this.guna2TextBox8.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox8.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox8.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox8.IconLeft")));
            this.guna2TextBox8.Location = new System.Drawing.Point(19, 197);
            this.guna2TextBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox8.Name = "guna2TextBox8";
            this.guna2TextBox8.PasswordChar = '\0';
            this.guna2TextBox8.PlaceholderText = "";
            this.guna2TextBox8.SelectedText = "";
            this.guna2TextBox8.Size = new System.Drawing.Size(215, 34);
            this.guna2TextBox8.TabIndex = 58;
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.BackColor = System.Drawing.Color.Transparent;
            this.lblFees.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblFees.Location = new System.Drawing.Point(267, 289);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(18, 19);
            this.lblFees.TabIndex = 57;
            this.lblFees.Text = "0";
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.BorderThickness = 0;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "Fees :  ";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.White;
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.Enabled = false;
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox4.IconLeft")));
            this.guna2TextBox4.Location = new System.Drawing.Point(19, 281);
            this.guna2TextBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.Size = new System.Drawing.Size(84, 34);
            this.guna2TextBox4.TabIndex = 56;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderThickness = 0;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "Date : ";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.White;
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.Enabled = false;
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox2.IconLeft")));
            this.guna2TextBox2.Location = new System.Drawing.Point(19, 239);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(84, 34);
            this.guna2TextBox2.TabIndex = 54;
            // 
            // TXT
            // 
            this.TXT.BorderThickness = 0;
            this.TXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT.DefaultText = "License Class : ";
            this.TXT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXT.DisabledState.FillColor = System.Drawing.Color.White;
            this.TXT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXT.Enabled = false;
            this.TXT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXT.IconLeft = ((System.Drawing.Image)(resources.GetObject("TXT.IconLeft")));
            this.TXT.Location = new System.Drawing.Point(19, 113);
            this.TXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT.Name = "TXT";
            this.TXT.PasswordChar = '\0';
            this.TXT.PlaceholderText = "";
            this.TXT.SelectedText = "";
            this.TXT.Size = new System.Drawing.Size(190, 34);
            this.TXT.TabIndex = 45;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderThickness = 0;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "Applicant Person Name : ";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.White;
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.Enabled = false;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.Location = new System.Drawing.Point(19, 155);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(215, 34);
            this.guna2TextBox1.TabIndex = 44;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.BorderThickness = 0;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "L.D.L Application ID : ";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.White;
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.Enabled = false;
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox3.IconLeft")));
            this.guna2TextBox3.Location = new System.Drawing.Point(19, 71);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(190, 34);
            this.guna2TextBox3.TabIndex = 43;
            // 
            // lblApplicantPersonName
            // 
            this.lblApplicantPersonName.AutoSize = true;
            this.lblApplicantPersonName.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicantPersonName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblApplicantPersonName.Location = new System.Drawing.Point(267, 162);
            this.lblApplicantPersonName.Name = "lblApplicantPersonName";
            this.lblApplicantPersonName.Size = new System.Drawing.Size(27, 19);
            this.lblApplicantPersonName.TabIndex = 35;
            this.lblApplicantPersonName.Text = "---";
            // 
            // lblILocalDLAID
            // 
            this.lblILocalDLAID.AutoSize = true;
            this.lblILocalDLAID.BackColor = System.Drawing.Color.Transparent;
            this.lblILocalDLAID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblILocalDLAID.Location = new System.Drawing.Point(267, 79);
            this.lblILocalDLAID.Name = "lblILocalDLAID";
            this.lblILocalDLAID.Size = new System.Drawing.Size(18, 19);
            this.lblILocalDLAID.TabIndex = 29;
            this.lblILocalDLAID.Text = "0";
            // 
            // lblLicenseClass
            // 
            this.lblLicenseClass.AutoSize = true;
            this.lblLicenseClass.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenseClass.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblLicenseClass.Location = new System.Drawing.Point(267, 120);
            this.lblLicenseClass.Name = "lblLicenseClass";
            this.lblLicenseClass.Size = new System.Drawing.Size(27, 19);
            this.lblLicenseClass.TabIndex = 27;
            this.lblLicenseClass.Text = "---";
            // 
            // gbRetakeTestInfo
            // 
            this.gbRetakeTestInfo.BackColor = System.Drawing.Color.White;
            this.gbRetakeTestInfo.Controls.Add(this.guna2TextBox5);
            this.gbRetakeTestInfo.Controls.Add(this.guna2TextBox6);
            this.gbRetakeTestInfo.Controls.Add(this.guna2TextBox7);
            this.gbRetakeTestInfo.Controls.Add(this.lblTotalFees);
            this.gbRetakeTestInfo.Controls.Add(this.lblRTApplicationID);
            this.gbRetakeTestInfo.Controls.Add(this.lblRTAFees);
            this.gbRetakeTestInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbRetakeTestInfo.Enabled = false;
            this.gbRetakeTestInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbRetakeTestInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbRetakeTestInfo.Location = new System.Drawing.Point(0, 324);
            this.gbRetakeTestInfo.Name = "gbRetakeTestInfo";
            this.gbRetakeTestInfo.Size = new System.Drawing.Size(706, 174);
            this.gbRetakeTestInfo.TabIndex = 58;
            this.gbRetakeTestInfo.Text = "Retake Test Info";
            this.gbRetakeTestInfo.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // guna2TextBox5
            // 
            this.guna2TextBox5.BorderThickness = 0;
            this.guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox5.DefaultText = "R.T Application ID : ";
            this.guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.White;
            this.guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.Enabled = false;
            this.guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox5.IconLeft")));
            this.guna2TextBox5.Location = new System.Drawing.Point(19, 48);
            this.guna2TextBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox5.Name = "guna2TextBox5";
            this.guna2TextBox5.PasswordChar = '\0';
            this.guna2TextBox5.PlaceholderText = "";
            this.guna2TextBox5.SelectedText = "";
            this.guna2TextBox5.Size = new System.Drawing.Size(190, 34);
            this.guna2TextBox5.TabIndex = 45;
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.BorderThickness = 0;
            this.guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox6.DefaultText = "Total Fees : ";
            this.guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.White;
            this.guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.Enabled = false;
            this.guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox6.IconLeft")));
            this.guna2TextBox6.Location = new System.Drawing.Point(19, 132);
            this.guna2TextBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.PasswordChar = '\0';
            this.guna2TextBox6.PlaceholderText = "";
            this.guna2TextBox6.SelectedText = "";
            this.guna2TextBox6.Size = new System.Drawing.Size(170, 34);
            this.guna2TextBox6.TabIndex = 44;
            // 
            // guna2TextBox7
            // 
            this.guna2TextBox7.BorderThickness = 0;
            this.guna2TextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox7.DefaultText = "Retake Test Application Fees : ";
            this.guna2TextBox7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox7.DisabledState.FillColor = System.Drawing.Color.White;
            this.guna2TextBox7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox7.Enabled = false;
            this.guna2TextBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox7.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox7.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox7.IconLeft")));
            this.guna2TextBox7.Location = new System.Drawing.Point(19, 90);
            this.guna2TextBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox7.Name = "guna2TextBox7";
            this.guna2TextBox7.PasswordChar = '\0';
            this.guna2TextBox7.PlaceholderText = "";
            this.guna2TextBox7.SelectedText = "";
            this.guna2TextBox7.Size = new System.Drawing.Size(250, 34);
            this.guna2TextBox7.TabIndex = 43;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFees.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTotalFees.Location = new System.Drawing.Point(289, 142);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(17, 19);
            this.lblTotalFees.TabIndex = 35;
            this.lblTotalFees.Text = "?";
            // 
            // lblRTApplicationID
            // 
            this.lblRTApplicationID.AutoSize = true;
            this.lblRTApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.lblRTApplicationID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRTApplicationID.Location = new System.Drawing.Point(289, 58);
            this.lblRTApplicationID.Name = "lblRTApplicationID";
            this.lblRTApplicationID.Size = new System.Drawing.Size(17, 19);
            this.lblRTApplicationID.TabIndex = 29;
            this.lblRTApplicationID.Text = "?";
            // 
            // lblRTAFees
            // 
            this.lblRTAFees.AutoSize = true;
            this.lblRTAFees.BackColor = System.Drawing.Color.Transparent;
            this.lblRTAFees.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRTAFees.Location = new System.Drawing.Point(289, 99);
            this.lblRTAFees.Name = "lblRTAFees";
            this.lblRTAFees.Size = new System.Drawing.Size(17, 19);
            this.lblRTAFees.TabIndex = 27;
            this.lblRTAFees.Text = "?";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.BorderThickness = 1;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.Gray;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(566, 510);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 37);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UCAddTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbRetakeTestInfo);
            this.Controls.Add(this.gbAppointmentInfo);
            this.Name = "UCAddTestAppointment";
            this.Size = new System.Drawing.Size(706, 557);
            this.Load += new System.EventHandler(this.UCAddTestAppointment_Load);
            this.gbAppointmentInfo.ResumeLayout(false);
            this.gbAppointmentInfo.PerformLayout();
            this.gbRetakeTestInfo.ResumeLayout(false);
            this.gbRetakeTestInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbAppointmentInfo;
        private Guna.UI2.WinForms.Guna2TextBox TXT;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private System.Windows.Forms.Label lblApplicantPersonName;
        private System.Windows.Forms.Label lblILocalDLAID;
        private System.Windows.Forms.Label lblLicenseClass;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtAppointmentDate;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private System.Windows.Forms.Label lblFees;
        private Guna.UI2.WinForms.Guna2GroupBox gbRetakeTestInfo;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox7;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblRTApplicationID;
        private System.Windows.Forms.Label lblRTAFees;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblTrial;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox8;
        private System.Windows.Forms.Label lblLockEditingMessage;
    }
}
