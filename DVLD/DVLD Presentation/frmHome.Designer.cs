namespace DVLDPresentation
{
    partial class frmHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tmsiManageApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiLocalDrivingLicenseApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalDrivingLiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicensesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLocalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInternationalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRenewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiReplacemecnt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiReleaseLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageDetainedLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDetainLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReleaseDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiManageApplication,
            this.drivingLicensesServicesToolStripMenuItem,
            this.detainLicensesToolStripMenuItem,
            this.tmsiManageApplicationTypes,
            this.tmsiManageTestTypes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 60, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(269, 670);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tmsiManageApplication
            // 
            this.tmsiManageApplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiLocalDrivingLicenseApplications,
            this.internationalDrivingLiToolStripMenuItem});
            this.tmsiManageApplication.Image = ((System.Drawing.Image)(resources.GetObject("tmsiManageApplication.Image")));
            this.tmsiManageApplication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tmsiManageApplication.Name = "tmsiManageApplication";
            this.tmsiManageApplication.Padding = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.tmsiManageApplication.Size = new System.Drawing.Size(262, 54);
            this.tmsiManageApplication.Text = "Manage Applications";
            this.tmsiManageApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmsiLocalDrivingLicenseApplications
            // 
            this.tmsiLocalDrivingLicenseApplications.Image = ((System.Drawing.Image)(resources.GetObject("tmsiLocalDrivingLicenseApplications.Image")));
            this.tmsiLocalDrivingLicenseApplications.Name = "tmsiLocalDrivingLicenseApplications";
            this.tmsiLocalDrivingLicenseApplications.Size = new System.Drawing.Size(448, 36);
            this.tmsiLocalDrivingLicenseApplications.Text = "Local Driving License Applications";
            this.tmsiLocalDrivingLicenseApplications.Click += new System.EventHandler(this.LocalDrivingLicenseApplications_Click);
            // 
            // internationalDrivingLiToolStripMenuItem
            // 
            this.internationalDrivingLiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("internationalDrivingLiToolStripMenuItem.Image")));
            this.internationalDrivingLiToolStripMenuItem.Name = "internationalDrivingLiToolStripMenuItem";
            this.internationalDrivingLiToolStripMenuItem.Size = new System.Drawing.Size(448, 36);
            this.internationalDrivingLiToolStripMenuItem.Text = "International Driving License Applications";
            this.internationalDrivingLiToolStripMenuItem.Click += new System.EventHandler(this.internationalDrivingLiToolStripMenuItem_Click);
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            this.drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.tsmiRenewDrivingLicense,
            this.toolStripSeparator1,
            this.tsmiReplacemecnt,
            this.toolStripSeparator2,
            this.tsmiReleaseLicense,
            this.tsmiRetakeTest});
            this.drivingLicensesServicesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("drivingLicensesServicesToolStripMenuItem.Image")));
            this.drivingLicensesServicesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            this.drivingLicensesServicesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.drivingLicensesServicesToolStripMenuItem.Size = new System.Drawing.Size(262, 54);
            this.drivingLicensesServicesToolStripMenuItem.Text = "Driving Licenses Services";
            this.drivingLicensesServicesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLocalLicense,
            this.tsmiInternationalLicense});
            this.newDrivingLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newDrivingLicenseToolStripMenuItem.Image")));
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(461, 36);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // tsmiLocalLicense
            // 
            this.tsmiLocalLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiLocalLicense.Image")));
            this.tsmiLocalLicense.Name = "tsmiLocalLicense";
            this.tsmiLocalLicense.Size = new System.Drawing.Size(273, 36);
            this.tsmiLocalLicense.Text = "Local License";
            this.tsmiLocalLicense.Click += new System.EventHandler(this.tsmiLocalLicense_Click);
            // 
            // tsmiInternationalLicense
            // 
            this.tsmiInternationalLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiInternationalLicense.Image")));
            this.tsmiInternationalLicense.Name = "tsmiInternationalLicense";
            this.tsmiInternationalLicense.Size = new System.Drawing.Size(273, 36);
            this.tsmiInternationalLicense.Text = "International License";
            this.tsmiInternationalLicense.Click += new System.EventHandler(this.tsmiInternationalLicense_Click);
            // 
            // tsmiRenewDrivingLicense
            // 
            this.tsmiRenewDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRenewDrivingLicense.Image")));
            this.tsmiRenewDrivingLicense.Name = "tsmiRenewDrivingLicense";
            this.tsmiRenewDrivingLicense.Size = new System.Drawing.Size(461, 36);
            this.tsmiRenewDrivingLicense.Text = "Renew Driving License";
            this.tsmiRenewDrivingLicense.Click += new System.EventHandler(this.tsmiRenewDrivingLicense_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(458, 6);
            // 
            // tsmiReplacemecnt
            // 
            this.tsmiReplacemecnt.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReplacemecnt.Image")));
            this.tsmiReplacemecnt.Name = "tsmiReplacemecnt";
            this.tsmiReplacemecnt.Size = new System.Drawing.Size(461, 36);
            this.tsmiReplacemecnt.Text = "Replacemecnt For Lost of Damaged License";
            this.tsmiReplacemecnt.Click += new System.EventHandler(this.tsmiReplacemecnt_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(458, 6);
            // 
            // tsmiReleaseLicense
            // 
            this.tsmiReleaseLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReleaseLicense.Image")));
            this.tsmiReleaseLicense.Name = "tsmiReleaseLicense";
            this.tsmiReleaseLicense.Size = new System.Drawing.Size(461, 36);
            this.tsmiReleaseLicense.Text = "Release Detained Driving License";
            this.tsmiReleaseLicense.Click += new System.EventHandler(this.tsmiReleaseDetainedLicense_Click);
            // 
            // tsmiRetakeTest
            // 
            this.tsmiRetakeTest.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRetakeTest.Image")));
            this.tsmiRetakeTest.Name = "tsmiRetakeTest";
            this.tsmiRetakeTest.Size = new System.Drawing.Size(461, 36);
            this.tsmiRetakeTest.Text = "Retake Test";
            this.tsmiRetakeTest.Click += new System.EventHandler(this.LocalDrivingLicenseApplications_Click);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManageDetainedLicenses,
            this.tsmiDetainLicense,
            this.tsmiReleaseDetainedLicense});
            this.detainLicensesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detainLicensesToolStripMenuItem.Image")));
            this.detainLicensesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(262, 54);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            this.detainLicensesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsmiManageDetainedLicenses
            // 
            this.tsmiManageDetainedLicenses.Image = ((System.Drawing.Image)(resources.GetObject("tsmiManageDetainedLicenses.Image")));
            this.tsmiManageDetainedLicenses.Name = "tsmiManageDetainedLicenses";
            this.tsmiManageDetainedLicenses.Size = new System.Drawing.Size(323, 36);
            this.tsmiManageDetainedLicenses.Text = "Manage Detained Licenses";
            this.tsmiManageDetainedLicenses.Click += new System.EventHandler(this.tsmiManageDetainedLicenses_Click);
            // 
            // tsmiDetainLicense
            // 
            this.tsmiDetainLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDetainLicense.Image")));
            this.tsmiDetainLicense.Name = "tsmiDetainLicense";
            this.tsmiDetainLicense.Size = new System.Drawing.Size(323, 36);
            this.tsmiDetainLicense.Text = "Detain License";
            this.tsmiDetainLicense.Click += new System.EventHandler(this.tsmiDetainLicense_Click);
            // 
            // tsmiReleaseDetainedLicense
            // 
            this.tsmiReleaseDetainedLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReleaseDetainedLicense.Image")));
            this.tsmiReleaseDetainedLicense.Name = "tsmiReleaseDetainedLicense";
            this.tsmiReleaseDetainedLicense.Size = new System.Drawing.Size(323, 36);
            this.tsmiReleaseDetainedLicense.Text = "Release Detained License";
            this.tsmiReleaseDetainedLicense.Click += new System.EventHandler(this.tsmiReleaseDetainedLicense_Click);
            // 
            // tmsiManageApplicationTypes
            // 
            this.tmsiManageApplicationTypes.Image = ((System.Drawing.Image)(resources.GetObject("tmsiManageApplicationTypes.Image")));
            this.tmsiManageApplicationTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tmsiManageApplicationTypes.Name = "tmsiManageApplicationTypes";
            this.tmsiManageApplicationTypes.Padding = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.tmsiManageApplicationTypes.Size = new System.Drawing.Size(262, 54);
            this.tmsiManageApplicationTypes.Text = "Manage Application Types";
            this.tmsiManageApplicationTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tmsiManageApplicationTypes.Click += new System.EventHandler(this.tmsiManageApplicationTypes_Click);
            // 
            // tmsiManageTestTypes
            // 
            this.tmsiManageTestTypes.Image = ((System.Drawing.Image)(resources.GetObject("tmsiManageTestTypes.Image")));
            this.tmsiManageTestTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tmsiManageTestTypes.Name = "tmsiManageTestTypes";
            this.tmsiManageTestTypes.Padding = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.tmsiManageTestTypes.Size = new System.Drawing.Size(262, 54);
            this.tmsiManageTestTypes.Text = "Manage Test Types";
            this.tmsiManageTestTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tmsiManageTestTypes.Click += new System.EventHandler(this.tmsiManageTestTypes_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(278, 670);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmsiManageApplication;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiRenewDrivingLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiReplacemecnt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiReleaseLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiRetakeTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiLocalLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem tmsiManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem tmsiManageTestTypes;
        private System.Windows.Forms.ToolStripMenuItem tmsiLocalDrivingLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem internationalDrivingLiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageDetainedLicenses;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetainLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiReleaseDetainedLicense;
    }
}