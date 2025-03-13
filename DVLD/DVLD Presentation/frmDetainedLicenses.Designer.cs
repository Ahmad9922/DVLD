namespace DVLD
{
    partial class frmDetainedLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainedLicenses));
            this.btnDetainLicense = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnReleaseDetainedLicense = new Guna.UI2.WinForms.Guna2Button();
            this.ucListWithFilter = new DVLD.UCListWithFilter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowDriverLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReleaseDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2GroupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetainLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnDetainLicense.BorderColor = System.Drawing.Color.Silver;
            this.btnDetainLicense.BorderThickness = 1;
            this.btnDetainLicense.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetainLicense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetainLicense.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetainLicense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetainLicense.FillColor = System.Drawing.Color.White;
            this.btnDetainLicense.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetainLicense.ForeColor = System.Drawing.Color.White;
            this.btnDetainLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnDetainLicense.Image")));
            this.btnDetainLicense.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDetainLicense.Location = new System.Drawing.Point(1126, 103);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.Size = new System.Drawing.Size(60, 60);
            this.btnDetainLicense.TabIndex = 6;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2GroupBox1.Controls.Add(this.btnReleaseDetainedLicense);
            this.guna2GroupBox1.Controls.Add(this.btnDetainLicense);
            this.guna2GroupBox1.Controls.Add(this.ucListWithFilter);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 90, 0, 0);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1205, 715);
            this.guna2GroupBox1.TabIndex = 8;
            this.guna2GroupBox1.Text = "Detained Licenses";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(0, 25);
            // 
            // btnReleaseDetainedLicense
            // 
            this.btnReleaseDetainedLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReleaseDetainedLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnReleaseDetainedLicense.BorderColor = System.Drawing.Color.Silver;
            this.btnReleaseDetainedLicense.BorderThickness = 1;
            this.btnReleaseDetainedLicense.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReleaseDetainedLicense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReleaseDetainedLicense.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReleaseDetainedLicense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReleaseDetainedLicense.FillColor = System.Drawing.Color.White;
            this.btnReleaseDetainedLicense.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReleaseDetainedLicense.ForeColor = System.Drawing.Color.White;
            this.btnReleaseDetainedLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnReleaseDetainedLicense.Image")));
            this.btnReleaseDetainedLicense.ImageSize = new System.Drawing.Size(40, 40);
            this.btnReleaseDetainedLicense.Location = new System.Drawing.Point(1060, 103);
            this.btnReleaseDetainedLicense.Name = "btnReleaseDetainedLicense";
            this.btnReleaseDetainedLicense.Size = new System.Drawing.Size(60, 60);
            this.btnReleaseDetainedLicense.TabIndex = 7;
            this.btnReleaseDetainedLicense.Click += new System.EventHandler(this.btnReleaseDetainedLicense_Click);
            // 
            // ucListWithFilter
            // 
            this.ucListWithFilter.BackColor = System.Drawing.Color.White;
            this.ucListWithFilter.ContextMenuStrip = this.contextMenuStrip1;
            this.ucListWithFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucListWithFilter.FieldMask = new DVLD.UCFilter.enFieldMask[] {
        DVLD.UCFilter.enFieldMask.None,
        DVLD.UCFilter.enFieldMask.Number,
        DVLD.UCFilter.enFieldMask.Number,
        DVLD.UCFilter.enFieldMask.LettersAndNumbers,
        DVLD.UCFilter.enFieldMask.Letters,
        DVLD.UCFilter.enFieldMask.None,
        DVLD.UCFilter.enFieldMask.Number};
            this.ucListWithFilter.FieldName = new string[] {
        "None",
        "Detain ID",
        "License ID",
        "National No",
        "Full Name",
        "Is Release",
        "Release Application ID"};
            this.ucListWithFilter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ucListWithFilter.Location = new System.Drawing.Point(0, 90);
            this.ucListWithFilter.Margin = new System.Windows.Forms.Padding(6);
            this.ucListWithFilter.Name = "ucListWithFilter";
            this.ucListWithFilter.SearchType = new DVLD.UCFilter.enSearchType[] {
        DVLD.UCFilter.enSearchType.None,
        DVLD.UCFilter.enSearchType.TextBox,
        DVLD.UCFilter.enSearchType.TextBox,
        DVLD.UCFilter.enSearchType.TextBox,
        DVLD.UCFilter.enSearchType.TextBox,
        DVLD.UCFilter.enSearchType.ComboBox,
        DVLD.UCFilter.enSearchType.TextBox};
            this.ucListWithFilter.Size = new System.Drawing.Size(1205, 625);
            this.ucListWithFilter.TabIndex = 0;
            this.ucListWithFilter.FilterResultChange += new System.Action<string, string>(this.ucListWithFilter_FilterResultChange);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItem1,
            this.toolStripMenuItem2,
            this.tsmiShowDriverLicenseHistory,
            this.tsmiReleaseDetainedLicense});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(291, 170);
            // 
            // StripMenuItem1
            // 
            this.StripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("StripMenuItem1.Image")));
            this.StripMenuItem1.Name = "StripMenuItem1";
            this.StripMenuItem1.Size = new System.Drawing.Size(290, 36);
            this.StripMenuItem1.Text = "Show Person Details";
            this.StripMenuItem1.Click += new System.EventHandler(this.ShowPersonDetails_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(290, 36);
            this.toolStripMenuItem2.Text = "Show License Details";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ShowLicenseDetails_Click);
            // 
            // tsmiShowDriverLicenseHistory
            // 
            this.tsmiShowDriverLicenseHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowDriverLicenseHistory.Image")));
            this.tsmiShowDriverLicenseHistory.Name = "tsmiShowDriverLicenseHistory";
            this.tsmiShowDriverLicenseHistory.Size = new System.Drawing.Size(290, 36);
            this.tsmiShowDriverLicenseHistory.Text = "Show Driver License History";
            this.tsmiShowDriverLicenseHistory.Click += new System.EventHandler(this.tsmiShowDriverLicenseHistory_Click);
            // 
            // tsmiReleaseDetainedLicense
            // 
            this.tsmiReleaseDetainedLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReleaseDetainedLicense.Image")));
            this.tsmiReleaseDetainedLicense.Name = "tsmiReleaseDetainedLicense";
            this.tsmiReleaseDetainedLicense.Size = new System.Drawing.Size(290, 36);
            this.tsmiReleaseDetainedLicense.Text = "Release Detained License";
            this.tsmiReleaseDetainedLicense.Click += new System.EventHandler(this.tsmiReleaseDetainedLicense_Click);
            // 
            // frmDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 715);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDetainedLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detained Licenses";
            this.guna2GroupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDetainLicense;
        private UCListWithFilter ucListWithFilter;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnReleaseDetainedLicense;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDriverLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem tsmiReleaseDetainedLicense;
    }
}