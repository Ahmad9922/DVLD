namespace DVLD
{
    partial class UCAddLocalDLA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAddLocalDLA));
            this.tcLevelsSave = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNextStep = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblCreatedByValue = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblApplicationFeesValue = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.cbCountries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblLicenseClass = new System.Windows.Forms.Label();
            this.lblApplicationDateValue = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.lblApplicationIDValue = new System.Windows.Forms.Label();
            this.ucPersonCardWithFilter1 = new DVLD.UCPersonCardWithFilter();
            this.tcLevelsSave.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcLevelsSave
            // 
            this.tcLevelsSave.Controls.Add(this.tabPage1);
            this.tcLevelsSave.Controls.Add(this.tabPage2);
            this.tcLevelsSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcLevelsSave.ItemSize = new System.Drawing.Size(180, 40);
            this.tcLevelsSave.Location = new System.Drawing.Point(0, 0);
            this.tcLevelsSave.Name = "tcLevelsSave";
            this.tcLevelsSave.SelectedIndex = 0;
            this.tcLevelsSave.Size = new System.Drawing.Size(809, 511);
            this.tcLevelsSave.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcLevelsSave.TabButtonHoverState.FillColor = System.Drawing.Color.Gray;
            this.tcLevelsSave.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcLevelsSave.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcLevelsSave.TabButtonHoverState.InnerColor = System.Drawing.Color.Gray;
            this.tcLevelsSave.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcLevelsSave.TabButtonIdleState.FillColor = System.Drawing.Color.Silver;
            this.tcLevelsSave.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcLevelsSave.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tcLevelsSave.TabButtonIdleState.InnerColor = System.Drawing.Color.Silver;
            this.tcLevelsSave.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcLevelsSave.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.tcLevelsSave.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcLevelsSave.TabButtonSelectedState.ForeColor = System.Drawing.Color.DarkGray;
            this.tcLevelsSave.TabButtonSelectedState.InnerColor = System.Drawing.Color.White;
            this.tcLevelsSave.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcLevelsSave.TabIndex = 3;
            this.tcLevelsSave.TabMenuBackColor = System.Drawing.Color.White;
            this.tcLevelsSave.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.tcLevelsSave.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcLevelsSave_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNextStep);
            this.tabPage1.Controls.Add(this.ucPersonCardWithFilter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(801, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNextStep
            // 
            this.btnNextStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextStep.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNextStep.BorderThickness = 1;
            this.btnNextStep.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNextStep.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNextStep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNextStep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNextStep.FillColor = System.Drawing.Color.Empty;
            this.btnNextStep.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNextStep.ForeColor = System.Drawing.Color.Gray;
            this.btnNextStep.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNextStep.Location = new System.Drawing.Point(628, 409);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(150, 45);
            this.btnNextStep.TabIndex = 1;
            this.btnNextStep.Text = "Next ▶";
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.lblCreatedByValue);
            this.tabPage2.Controls.Add(this.lblCreatedBy);
            this.tabPage2.Controls.Add(this.lblApplicationFeesValue);
            this.tabPage2.Controls.Add(this.lblApplicationFees);
            this.tabPage2.Controls.Add(this.cbCountries);
            this.tabPage2.Controls.Add(this.lblLicenseClass);
            this.tabPage2.Controls.Add(this.lblApplicationDateValue);
            this.tabPage2.Controls.Add(this.lblApplicationDate);
            this.tabPage2.Controls.Add(this.lblApplicationID);
            this.tabPage2.Controls.Add(this.lblApplicationIDValue);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(801, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Application Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnSave.Location = new System.Drawing.Point(628, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 45);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCreatedByValue
            // 
            this.lblCreatedByValue.AutoSize = true;
            this.lblCreatedByValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedByValue.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblCreatedByValue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCreatedByValue.Location = new System.Drawing.Point(224, 228);
            this.lblCreatedByValue.Name = "lblCreatedByValue";
            this.lblCreatedByValue.Size = new System.Drawing.Size(27, 19);
            this.lblCreatedByValue.TabIndex = 25;
            this.lblCreatedByValue.Text = "---";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedBy.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblCreatedBy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCreatedBy.Location = new System.Drawing.Point(53, 228);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(101, 19);
            this.lblCreatedBy.TabIndex = 24;
            this.lblCreatedBy.Text = "Created By : ";
            // 
            // lblApplicationFeesValue
            // 
            this.lblApplicationFeesValue.AutoSize = true;
            this.lblApplicationFeesValue.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationFeesValue.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblApplicationFeesValue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblApplicationFeesValue.Location = new System.Drawing.Point(224, 192);
            this.lblApplicationFeesValue.Name = "lblApplicationFeesValue";
            this.lblApplicationFeesValue.Size = new System.Drawing.Size(27, 19);
            this.lblApplicationFeesValue.TabIndex = 23;
            this.lblApplicationFeesValue.Text = "---";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationFees.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblApplicationFees.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblApplicationFees.Location = new System.Drawing.Point(53, 192);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(140, 19);
            this.lblApplicationFees.TabIndex = 22;
            this.lblApplicationFees.Text = "Application Fees : ";
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
            this.cbCountries.Location = new System.Drawing.Point(228, 137);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(265, 36);
            this.cbCountries.TabIndex = 21;
            // 
            // lblLicenseClass
            // 
            this.lblLicenseClass.AutoSize = true;
            this.lblLicenseClass.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenseClass.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblLicenseClass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLicenseClass.Location = new System.Drawing.Point(53, 143);
            this.lblLicenseClass.Name = "lblLicenseClass";
            this.lblLicenseClass.Size = new System.Drawing.Size(117, 19);
            this.lblLicenseClass.TabIndex = 15;
            this.lblLicenseClass.Text = "License Class : ";
            // 
            // lblApplicationDateValue
            // 
            this.lblApplicationDateValue.AutoSize = true;
            this.lblApplicationDateValue.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationDateValue.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblApplicationDateValue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblApplicationDateValue.Location = new System.Drawing.Point(224, 97);
            this.lblApplicationDateValue.Name = "lblApplicationDateValue";
            this.lblApplicationDateValue.Size = new System.Drawing.Size(27, 19);
            this.lblApplicationDateValue.TabIndex = 14;
            this.lblApplicationDateValue.Text = "---";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblApplicationDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblApplicationDate.Location = new System.Drawing.Point(53, 97);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(141, 19);
            this.lblApplicationDate.TabIndex = 13;
            this.lblApplicationDate.Text = "Application Date : ";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblApplicationID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblApplicationID.Location = new System.Drawing.Point(53, 61);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(121, 19);
            this.lblApplicationID.TabIndex = 11;
            this.lblApplicationID.Text = "ApplicationID : ";
            // 
            // lblApplicationIDValue
            // 
            this.lblApplicationIDValue.AutoSize = true;
            this.lblApplicationIDValue.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationIDValue.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblApplicationIDValue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblApplicationIDValue.Location = new System.Drawing.Point(224, 61);
            this.lblApplicationIDValue.Name = "lblApplicationIDValue";
            this.lblApplicationIDValue.Size = new System.Drawing.Size(27, 19);
            this.lblApplicationIDValue.TabIndex = 12;
            this.lblApplicationIDValue.Text = "---";
            // 
            // ucPersonCardWithFilter1
            // 
            this.ucPersonCardWithFilter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPersonCardWithFilter1.FilterBox = "";
            this.ucPersonCardWithFilter1.FilterEnabled = true;
            this.ucPersonCardWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ucPersonCardWithFilter1.Name = "ucPersonCardWithFilter1";
            this.ucPersonCardWithFilter1.Size = new System.Drawing.Size(795, 390);
            this.ucPersonCardWithFilter1.TabIndex = 0;
            // 
            // UCAddLocalDLA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcLevelsSave);
            this.Name = "UCAddLocalDLA";
            this.Size = new System.Drawing.Size(809, 511);
            this.tcLevelsSave.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tcLevelsSave;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2Button btnNextStep;
        private UCPersonCardWithFilter ucPersonCardWithFilter1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label lblApplicationIDValue;
        private System.Windows.Forms.Label lblApplicationDateValue;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblLicenseClass;
        private Guna.UI2.WinForms.Guna2ComboBox cbCountries;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblApplicationFeesValue;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblCreatedByValue;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}
