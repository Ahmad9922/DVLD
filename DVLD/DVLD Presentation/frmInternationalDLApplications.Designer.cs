namespace DVLD
{
    partial class frmInternationalDLApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInternationalDLApplications));
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAddApplication = new Guna.UI2.WinForms.Guna2Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowDriverLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.ucListWithFilter = new DVLD.UCListWithFilter();
            this.guna2GroupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2GroupBox1.Controls.Add(this.btnAddApplication);
            this.guna2GroupBox1.Controls.Add(this.ucListWithFilter);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 90, 0, 0);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1214, 560);
            this.guna2GroupBox1.TabIndex = 8;
            this.guna2GroupBox1.Text = "International Driving License Applications";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(0, 25);
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddApplication.BackColor = System.Drawing.Color.Transparent;
            this.btnAddApplication.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddApplication.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddApplication.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddApplication.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddApplication.FillColor = System.Drawing.Color.White;
            this.btnAddApplication.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddApplication.ForeColor = System.Drawing.Color.White;
            this.btnAddApplication.Image = ((System.Drawing.Image)(resources.GetObject("btnAddApplication.Image")));
            this.btnAddApplication.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddApplication.Location = new System.Drawing.Point(1157, 93);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(45, 45);
            this.btnAddApplication.TabIndex = 6;
            this.btnAddApplication.Click += new System.EventHandler(this.btnAddApplication_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.tsmiShowDriverLicenseHistory});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(291, 134);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(290, 36);
            this.toolStripMenuItem1.Text = "Show Person Details";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(290, 36);
            this.toolStripMenuItem2.Text = "Show License Details";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tsmiShowDriverLicenseHistory
            // 
            this.tsmiShowDriverLicenseHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowDriverLicenseHistory.Image")));
            this.tsmiShowDriverLicenseHistory.Name = "tsmiShowDriverLicenseHistory";
            this.tsmiShowDriverLicenseHistory.Size = new System.Drawing.Size(290, 36);
            this.tsmiShowDriverLicenseHistory.Text = "Show Driver License History";
            this.tsmiShowDriverLicenseHistory.Click += new System.EventHandler(this.tsmiShowDriverLicenseHistory_Click);
            // 
            // ucListWithFilter
            // 
            this.ucListWithFilter.BackColor = System.Drawing.Color.White;
            this.ucListWithFilter.ContextMenuStrip = this.contextMenuStrip1;
            this.ucListWithFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucListWithFilter.FieldMask = new DVLD.UCFilter.enFieldMask[] {
        DVLD.UCFilter.enFieldMask.None,
        DVLD.UCFilter.enFieldMask.Number};
            this.ucListWithFilter.FieldName = new string[] {
        "None",
        "DriverID",
        "IsActive"};
            this.ucListWithFilter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ucListWithFilter.Location = new System.Drawing.Point(0, 90);
            this.ucListWithFilter.Margin = new System.Windows.Forms.Padding(6);
            this.ucListWithFilter.Name = "ucListWithFilter";
            this.ucListWithFilter.SearchType = new DVLD.UCFilter.enSearchType[] {
        DVLD.UCFilter.enSearchType.None,
        DVLD.UCFilter.enSearchType.TextBox,
        DVLD.UCFilter.enSearchType.ComboBox};
            this.ucListWithFilter.Size = new System.Drawing.Size(1214, 470);
            this.ucListWithFilter.TabIndex = 0;
            this.ucListWithFilter.FilterResultChange += new System.Action<string, string>(this.ucListWithFilter_FilterResultChange);
            // 
            // frmInternationalDLApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 560);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInternationalDLApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International Driving License Applications";
            this.guna2GroupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnAddApplication;
        private UCListWithFilter ucListWithFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDriverLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}