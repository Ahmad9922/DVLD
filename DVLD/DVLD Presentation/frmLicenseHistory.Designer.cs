namespace DVLD
{
    partial class frmLicenseHistory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicenseHistory));
            this.gbDrivingLicenses = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tcLicenseType = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.ucLocalLicenseList = new DVLD.UCList();
            this.ucInternationalLicenseList = new DVLD.UCList();
            this.ucPersonCard1 = new DVLD.UCPersonCard();
            this.gbDrivingLicenses.SuspendLayout();
            this.tcLicenseType.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDrivingLicenses
            // 
            this.gbDrivingLicenses.Controls.Add(this.tcLicenseType);
            this.gbDrivingLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDrivingLicenses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbDrivingLicenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbDrivingLicenses.Location = new System.Drawing.Point(0, 311);
            this.gbDrivingLicenses.Name = "gbDrivingLicenses";
            this.gbDrivingLicenses.Size = new System.Drawing.Size(824, 490);
            this.gbDrivingLicenses.TabIndex = 2;
            this.gbDrivingLicenses.Text = "Driving Licenses";
            // 
            // tcLicenseType
            // 
            this.tcLicenseType.Controls.Add(this.tabPage1);
            this.tcLicenseType.Controls.Add(this.tabPage2);
            this.tcLicenseType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcLicenseType.ItemSize = new System.Drawing.Size(180, 40);
            this.tcLicenseType.Location = new System.Drawing.Point(0, 40);
            this.tcLicenseType.Name = "tcLicenseType";
            this.tcLicenseType.SelectedIndex = 0;
            this.tcLicenseType.Size = new System.Drawing.Size(824, 450);
            this.tcLicenseType.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcLicenseType.TabButtonHoverState.FillColor = System.Drawing.Color.Gray;
            this.tcLicenseType.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcLicenseType.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcLicenseType.TabButtonHoverState.InnerColor = System.Drawing.Color.Gray;
            this.tcLicenseType.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcLicenseType.TabButtonIdleState.FillColor = System.Drawing.Color.Silver;
            this.tcLicenseType.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcLicenseType.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tcLicenseType.TabButtonIdleState.InnerColor = System.Drawing.Color.Silver;
            this.tcLicenseType.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcLicenseType.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.tcLicenseType.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcLicenseType.TabButtonSelectedState.ForeColor = System.Drawing.Color.DarkGray;
            this.tcLicenseType.TabButtonSelectedState.InnerColor = System.Drawing.Color.White;
            this.tcLicenseType.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcLicenseType.TabIndex = 4;
            this.tcLicenseType.TabMenuBackColor = System.Drawing.Color.White;
            this.tcLicenseType.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucLocalLicenseList);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(816, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Local License";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucInternationalLicenseList);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(816, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "International License";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowLicense});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(188, 40);
            // 
            // tsmiShowLicense
            // 
            this.tsmiShowLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowLicense.Image")));
            this.tsmiShowLicense.Name = "tsmiShowLicense";
            this.tsmiShowLicense.Size = new System.Drawing.Size(187, 36);
            this.tsmiShowLicense.Text = "Show License";
            this.tsmiShowLicense.Click += new System.EventHandler(this.tsmiShowLicense_Click);
            // 
            // ucLocalLicenseList
            // 
            this.ucLocalLicenseList.ContextMenuStrip = this.contextMenuStrip1;
            this.ucLocalLicenseList.DataSource = null;
            this.ucLocalLicenseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLocalLicenseList.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ucLocalLicenseList.Location = new System.Drawing.Point(3, 3);
            this.ucLocalLicenseList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ucLocalLicenseList.Name = "ucLocalLicenseList";
            this.ucLocalLicenseList.Size = new System.Drawing.Size(810, 396);
            this.ucLocalLicenseList.TabIndex = 1;
            // 
            // ucInternationalLicenseList
            // 
            this.ucInternationalLicenseList.DataSource = null;
            this.ucInternationalLicenseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInternationalLicenseList.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ucInternationalLicenseList.Location = new System.Drawing.Point(3, 3);
            this.ucInternationalLicenseList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ucInternationalLicenseList.Name = "ucInternationalLicenseList";
            this.ucInternationalLicenseList.Size = new System.Drawing.Size(810, 396);
            this.ucInternationalLicenseList.TabIndex = 2;
            // 
            // ucPersonCard1
            // 
            this.ucPersonCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPersonCard1.Location = new System.Drawing.Point(0, 0);
            this.ucPersonCard1.Name = "ucPersonCard1";
            this.ucPersonCard1.Size = new System.Drawing.Size(824, 311);
            this.ucPersonCard1.TabIndex = 0;
            // 
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 801);
            this.Controls.Add(this.gbDrivingLicenses);
            this.Controls.Add(this.ucPersonCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLicenseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License History";
            this.gbDrivingLicenses.ResumeLayout(false);
            this.tcLicenseType.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UCPersonCard ucPersonCard1;
        private UCList ucLocalLicenseList;
        private Guna.UI2.WinForms.Guna2GroupBox gbDrivingLicenses;
        private Guna.UI2.WinForms.Guna2TabControl tcLicenseType;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UCList ucInternationalLicenseList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowLicense;
    }
}