namespace DVLD
{
    partial class UCLocalDLACard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLocalDLACard));
            this.gbApplicationInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnViewLicenseInfo = new Guna.UI2.WinForms.Guna2Button();
            this.TXT = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPassedTests = new System.Windows.Forms.Label();
            this.lblILocalDLAD = new System.Windows.Forms.Label();
            this.lblApplaidForLicense = new System.Windows.Forms.Label();
            this.ucApplicationCard = new DVLD.UCApplicationCard();
            this.gbApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbApplicationInfo
            // 
            this.gbApplicationInfo.Controls.Add(this.btnViewLicenseInfo);
            this.gbApplicationInfo.Controls.Add(this.TXT);
            this.gbApplicationInfo.Controls.Add(this.guna2TextBox1);
            this.gbApplicationInfo.Controls.Add(this.guna2TextBox2);
            this.gbApplicationInfo.Controls.Add(this.lblPassedTests);
            this.gbApplicationInfo.Controls.Add(this.lblILocalDLAD);
            this.gbApplicationInfo.Controls.Add(this.lblApplaidForLicense);
            this.gbApplicationInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbApplicationInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbApplicationInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbApplicationInfo.Location = new System.Drawing.Point(0, 0);
            this.gbApplicationInfo.Name = "gbApplicationInfo";
            this.gbApplicationInfo.Size = new System.Drawing.Size(888, 226);
            this.gbApplicationInfo.TabIndex = 47;
            this.gbApplicationInfo.Text = "Local Driving License Application Info";
            this.gbApplicationInfo.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // btnViewLicenseInfo
            // 
            this.btnViewLicenseInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnViewLicenseInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btnViewLicenseInfo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnViewLicenseInfo.BorderThickness = 2;
            this.btnViewLicenseInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewLicenseInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewLicenseInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewLicenseInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewLicenseInfo.Enabled = false;
            this.btnViewLicenseInfo.FillColor = System.Drawing.Color.Empty;
            this.btnViewLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewLicenseInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnViewLicenseInfo.Location = new System.Drawing.Point(19, 173);
            this.btnViewLicenseInfo.Name = "btnViewLicenseInfo";
            this.btnViewLicenseInfo.Size = new System.Drawing.Size(170, 35);
            this.btnViewLicenseInfo.TabIndex = 53;
            this.btnViewLicenseInfo.Text = "View License Info";
            this.btnViewLicenseInfo.Click += new System.EventHandler(this.btnViewLicenseInfo_Click);
            // 
            // TXT
            // 
            this.TXT.BorderThickness = 0;
            this.TXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT.DefaultText = "Applaid For License : ";
            this.TXT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXT.DisabledState.FillColor = System.Drawing.Color.White;
            this.TXT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXT.Enabled = false;
            this.TXT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXT.IconLeft = ((System.Drawing.Image)(resources.GetObject("TXT.IconLeft")));
            this.TXT.Location = new System.Drawing.Point(19, 90);
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
            this.guna2TextBox1.DefaultText = "Passed Tests : ";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.White;
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.Enabled = false;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.Location = new System.Drawing.Point(19, 132);
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
            this.guna2TextBox2.DefaultText = "L.D.L Application ID : ";
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
            this.guna2TextBox2.Size = new System.Drawing.Size(190, 34);
            this.guna2TextBox2.TabIndex = 43;
            // 
            // lblPassedTests
            // 
            this.lblPassedTests.AutoSize = true;
            this.lblPassedTests.BackColor = System.Drawing.Color.Transparent;
            this.lblPassedTests.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblPassedTests.Location = new System.Drawing.Point(267, 142);
            this.lblPassedTests.Name = "lblPassedTests";
            this.lblPassedTests.Size = new System.Drawing.Size(27, 19);
            this.lblPassedTests.TabIndex = 35;
            this.lblPassedTests.Text = "---";
            // 
            // lblILocalDLAD
            // 
            this.lblILocalDLAD.AutoSize = true;
            this.lblILocalDLAD.BackColor = System.Drawing.Color.Transparent;
            this.lblILocalDLAD.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblILocalDLAD.Location = new System.Drawing.Point(267, 58);
            this.lblILocalDLAD.Name = "lblILocalDLAID";
            this.lblILocalDLAD.Size = new System.Drawing.Size(27, 19);
            this.lblILocalDLAD.TabIndex = 29;
            this.lblILocalDLAD.Text = "---";
            // 
            // lblApplaidForLicense
            // 
            this.lblApplaidForLicense.AutoSize = true;
            this.lblApplaidForLicense.BackColor = System.Drawing.Color.Transparent;
            this.lblApplaidForLicense.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblApplaidForLicense.Location = new System.Drawing.Point(267, 99);
            this.lblApplaidForLicense.Name = "lblApplaidForLicense";
            this.lblApplaidForLicense.Size = new System.Drawing.Size(27, 19);
            this.lblApplaidForLicense.TabIndex = 27;
            this.lblApplaidForLicense.Text = "---";
            // 
            // ucApplicationCard
            // 
            this.ucApplicationCard.Application = null;
            this.ucApplicationCard.BackColor = System.Drawing.Color.White;
            this.ucApplicationCard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucApplicationCard.Location = new System.Drawing.Point(0, 226);
            this.ucApplicationCard.Name = "ucApplicationCard";
            this.ucApplicationCard.Size = new System.Drawing.Size(888, 227);
            this.ucApplicationCard.TabIndex = 0;
            // 
            // UCLocalDLACard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbApplicationInfo);
            this.Controls.Add(this.ucApplicationCard);
            this.Name = "UCLocalDLACard";
            this.Size = new System.Drawing.Size(888, 453);
            this.gbApplicationInfo.ResumeLayout(false);
            this.gbApplicationInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UCApplicationCard ucApplicationCard;
        private Guna.UI2.WinForms.Guna2GroupBox gbApplicationInfo;
        private Guna.UI2.WinForms.Guna2Button btnViewLicenseInfo;
        private Guna.UI2.WinForms.Guna2TextBox TXT;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label lblPassedTests;
        private System.Windows.Forms.Label lblILocalDLAD;
        private System.Windows.Forms.Label lblApplaidForLicense;
    }
}
