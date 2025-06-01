namespace DVLD
{
    partial class UCAddUpdateApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAddUpdateApplication));
            this.cbApplicationType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudApplicationPaidFees = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblApplicantPersonID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.tcSubmissionSteps = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.tpLicenseClassInfo = new System.Windows.Forms.TabPage();
            this.nudClassPaidFees = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnBackToHome = new Guna.UI2.WinForms.Guna2Button();
            this.lblMinimumAllowedAge = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLicenseClasses = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudApplicationPaidFees)).BeginInit();
            this.tcSubmissionSteps.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tpLicenseClassInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClassPaidFees)).BeginInit();
            this.SuspendLayout();
            // 
            // cbApplicationType
            // 
            this.cbApplicationType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbApplicationType.BackColor = System.Drawing.Color.Transparent;
            this.cbApplicationType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbApplicationType.DropDownHeight = 200;
            this.cbApplicationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApplicationType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbApplicationType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbApplicationType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbApplicationType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbApplicationType.IntegralHeight = false;
            this.cbApplicationType.ItemHeight = 30;
            this.cbApplicationType.Location = new System.Drawing.Point(210, 14);
            this.cbApplicationType.Name = "cbApplicationType";
            this.cbApplicationType.Size = new System.Drawing.Size(328, 36);
            this.cbApplicationType.TabIndex = 22;
            this.cbApplicationType.SelectedIndexChanged += new System.EventHandler(this.cbApplicationType_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(568, 73);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Service Application";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(554, 56);
            this.label1.TabIndex = 24;
            this.label1.Text = "Application Type :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(554, 56);
            this.label2.TabIndex = 25;
            this.label2.Text = "Paid TestTypeFees :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(3, 115);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(554, 56);
            this.label3.TabIndex = 26;
            this.label3.Text = "Applicant Person ID :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudApplicationPaidFees
            // 
            this.nudApplicationPaidFees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudApplicationPaidFees.BackColor = System.Drawing.Color.Transparent;
            this.nudApplicationPaidFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudApplicationPaidFees.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudApplicationPaidFees.Location = new System.Drawing.Point(210, 71);
            this.nudApplicationPaidFees.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudApplicationPaidFees.Name = "nudApplicationPaidFees";
            this.nudApplicationPaidFees.Size = new System.Drawing.Size(328, 35);
            this.nudApplicationPaidFees.TabIndex = 67;
            this.nudApplicationPaidFees.UpDownButtonFillColor = System.Drawing.Color.Gray;
            this.nudApplicationPaidFees.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // lblApplicantPersonID
            // 
            this.lblApplicantPersonID.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicantPersonID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblApplicantPersonID.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblApplicantPersonID.Location = new System.Drawing.Point(206, 131);
            this.lblApplicantPersonID.Name = "lblApplicantPersonID";
            this.lblApplicantPersonID.Size = new System.Drawing.Size(217, 25);
            this.lblApplicantPersonID.TabIndex = 68;
            this.lblApplicantPersonID.Text = "Empty";
            this.lblApplicantPersonID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(3, 171);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(554, 56);
            this.label4.TabIndex = 86;
            this.label4.Text = "Application Date :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblApplicationDate.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblApplicationDate.Location = new System.Drawing.Point(206, 185);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(332, 28);
            this.lblApplicationDate.TabIndex = 87;
            this.lblApplicationDate.Text = "Empty";
            this.lblApplicationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcSubmissionSteps
            // 
            this.tcSubmissionSteps.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcSubmissionSteps.Controls.Add(this.tpHome);
            this.tcSubmissionSteps.Controls.Add(this.tpLicenseClassInfo);
            this.tcSubmissionSteps.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcSubmissionSteps.ItemSize = new System.Drawing.Size(180, 40);
            this.tcSubmissionSteps.Location = new System.Drawing.Point(0, 73);
            this.tcSubmissionSteps.Name = "tcSubmissionSteps";
            this.tcSubmissionSteps.SelectedIndex = 0;
            this.tcSubmissionSteps.Size = new System.Drawing.Size(568, 360);
            this.tcSubmissionSteps.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcSubmissionSteps.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcSubmissionSteps.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcSubmissionSteps.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcSubmissionSteps.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcSubmissionSteps.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcSubmissionSteps.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcSubmissionSteps.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcSubmissionSteps.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcSubmissionSteps.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcSubmissionSteps.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcSubmissionSteps.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcSubmissionSteps.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcSubmissionSteps.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcSubmissionSteps.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcSubmissionSteps.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcSubmissionSteps.TabIndex = 89;
            this.tcSubmissionSteps.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcSubmissionSteps.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalBottom;
            // 
            // tpHome
            // 
            this.tpHome.BackColor = System.Drawing.Color.White;
            this.tpHome.Controls.Add(this.btnNext);
            this.tpHome.Controls.Add(this.lblApplicationDate);
            this.tpHome.Controls.Add(this.lblApplicantPersonID);
            this.tpHome.Controls.Add(this.btnSearch);
            this.tpHome.Controls.Add(this.nudApplicationPaidFees);
            this.tpHome.Controls.Add(this.label4);
            this.tpHome.Controls.Add(this.label3);
            this.tpHome.Controls.Add(this.label2);
            this.tpHome.Controls.Add(this.cbApplicationType);
            this.tpHome.Controls.Add(this.label1);
            this.tpHome.Location = new System.Drawing.Point(4, 4);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(560, 312);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(429, 126);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 37);
            this.btnSearch.TabIndex = 85;
            this.btnSearch.Text = "Select Person";
            this.btnSearch.Click += new System.EventHandler(this.btnPersonSearch_Click);
            // 
            // tpLicenseClassInfo
            // 
            this.tpLicenseClassInfo.BackColor = System.Drawing.Color.White;
            this.tpLicenseClassInfo.Controls.Add(this.nudClassPaidFees);
            this.tpLicenseClassInfo.Controls.Add(this.btnBackToHome);
            this.tpLicenseClassInfo.Controls.Add(this.lblMinimumAllowedAge);
            this.tpLicenseClassInfo.Controls.Add(this.label7);
            this.tpLicenseClassInfo.Controls.Add(this.cbLicenseClasses);
            this.tpLicenseClassInfo.Controls.Add(this.label5);
            this.tpLicenseClassInfo.Controls.Add(this.label6);
            this.tpLicenseClassInfo.Location = new System.Drawing.Point(4, 4);
            this.tpLicenseClassInfo.Name = "tpLicenseClassInfo";
            this.tpLicenseClassInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLicenseClassInfo.Size = new System.Drawing.Size(560, 312);
            this.tpLicenseClassInfo.TabIndex = 1;
            this.tpLicenseClassInfo.Text = "License Class Info";
            // 
            // nudClassPaidFees
            // 
            this.nudClassPaidFees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudClassPaidFees.BackColor = System.Drawing.Color.Transparent;
            this.nudClassPaidFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudClassPaidFees.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudClassPaidFees.Location = new System.Drawing.Point(221, 70);
            this.nudClassPaidFees.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudClassPaidFees.Name = "nudClassPaidFees";
            this.nudClassPaidFees.Size = new System.Drawing.Size(317, 35);
            this.nudClassPaidFees.TabIndex = 91;
            this.nudClassPaidFees.UpDownButtonFillColor = System.Drawing.Color.Gray;
            // 
            // btnBackToHome
            // 
            this.btnBackToHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackToHome.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackToHome.BorderThickness = 1;
            this.btnBackToHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackToHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackToHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackToHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackToHome.FillColor = System.Drawing.Color.Empty;
            this.btnBackToHome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBackToHome.ForeColor = System.Drawing.Color.Gray;
            this.btnBackToHome.Image = global::DVLD.Properties.Resources.arrow_left;
            this.btnBackToHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBackToHome.Location = new System.Drawing.Point(20, 266);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(162, 40);
            this.btnBackToHome.TabIndex = 90;
            this.btnBackToHome.Text = "Back";
            this.btnBackToHome.Click += new System.EventHandler(this.btnBackToHome_Click);
            // 
            // lblMinimumAllowedAge
            // 
            this.lblMinimumAllowedAge.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimumAllowedAge.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblMinimumAllowedAge.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblMinimumAllowedAge.Location = new System.Drawing.Point(217, 131);
            this.lblMinimumAllowedAge.Name = "lblMinimumAllowedAge";
            this.lblMinimumAllowedAge.Size = new System.Drawing.Size(57, 25);
            this.lblMinimumAllowedAge.TabIndex = 73;
            this.lblMinimumAllowedAge.Text = "Empty";
            this.lblMinimumAllowedAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(3, 115);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(554, 56);
            this.label7.TabIndex = 72;
            this.label7.Text = "Minimum Allowed Age :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLicenseClasses.BackColor = System.Drawing.Color.Transparent;
            this.cbLicenseClasses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLicenseClasses.DropDownHeight = 200;
            this.cbLicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClasses.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLicenseClasses.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLicenseClasses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLicenseClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLicenseClasses.IntegralHeight = false;
            this.cbLicenseClasses.ItemHeight = 30;
            this.cbLicenseClasses.Location = new System.Drawing.Point(221, 14);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(317, 36);
            this.cbLicenseClasses.TabIndex = 68;
            this.cbLicenseClasses.SelectedIndexChanged += new System.EventHandler(this.cbLicenseClasses_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(3, 59);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(554, 56);
            this.label5.TabIndex = 70;
            this.label5.Text = "Class TestTypeFees :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(554, 56);
            this.label6.TabIndex = 69;
            this.label6.Text = "License Classes :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.BorderThickness = 1;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.Enabled = false;
            this.btnSubmit.FillColor = System.Drawing.Color.Empty;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSubmit.ForeColor = System.Drawing.Color.Gray;
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.ImageSize = new System.Drawing.Size(18, 18);
            this.btnSubmit.Location = new System.Drawing.Point(380, 439);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(162, 40);
            this.btnSubmit.TabIndex = 88;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.BorderThickness = 1;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.Enabled = false;
            this.btnNext.FillColor = System.Drawing.Color.Empty;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNext.ForeColor = System.Drawing.Color.Gray;
            this.btnNext.Image = global::DVLD.Properties.Resources.arrow_right;
            this.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNext.Location = new System.Drawing.Point(376, 266);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(162, 40);
            this.btnNext.TabIndex = 89;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // UCAddUpdateApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tcSubmissionSteps);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSubmit);
            this.Name = "UCAddUpdateApplication";
            this.Size = new System.Drawing.Size(568, 489);
            ((System.ComponentModel.ISupportInitialize)(this.nudApplicationPaidFees)).EndInit();
            this.tcSubmissionSteps.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpLicenseClassInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudClassPaidFees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbApplicationType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudApplicationPaidFees;
        private System.Windows.Forms.Label lblApplicantPersonID;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblApplicationDate;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2TabControl tcSubmissionSteps;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpLicenseClassInfo;
        private Guna.UI2.WinForms.Guna2ComboBox cbLicenseClasses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMinimumAllowedAge;
        private Guna.UI2.WinForms.Guna2Button btnBackToHome;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudClassPaidFees;
        private Guna.UI2.WinForms.Guna2Button btnNext;
    }
}
