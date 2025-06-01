namespace DVLD
{
    partial class frmDrivers
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
            CustomControls.UCFilter2.clsSearchProperties clsSearchProperties1 = new CustomControls.UCFilter2.clsSearchProperties();
            CustomControls.UCFilter2.clsSearchProperties clsSearchProperties2 = new CustomControls.UCFilter2.clsSearchProperties();
            CustomControls.UCFilter2.clsSearchProperties clsSearchProperties3 = new CustomControls.UCFilter2.clsSearchProperties();
            CustomControls.UCFilter2.clsSearchProperties clsSearchProperties4 = new CustomControls.UCFilter2.clsSearchProperties();
            CustomControls.UCFilter2.clsSearchProperties clsSearchProperties5 = new CustomControls.UCFilter2.clsSearchProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrivers));
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ucDriversList = new DVLD.UCListWithFilter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowDriverLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2GroupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.ucDriversList);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 90, 0, 0);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(800, 450);
            this.guna2GroupBox1.TabIndex = 9;
            this.guna2GroupBox1.Text = "Drivers";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(0, 25);
            // 
            // ucDriversList
            // 
            this.ucDriversList.ContextMenuStrip = this.contextMenuStrip1;
            this.ucDriversList.Dock = System.Windows.Forms.DockStyle.Fill;
            clsSearchProperties1.FieldName = "Driver ID";
            clsSearchProperties1.SearchButtonVisible = false;
            clsSearchProperties1.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            clsSearchProperties1.TextBoxValue = "";
            clsSearchProperties2.FieldName = "Person ID";
            clsSearchProperties2.SearchButtonVisible = false;
            clsSearchProperties2.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            clsSearchProperties2.TextBoxValue = "";
            clsSearchProperties3.FieldName = "National No";
            clsSearchProperties3.SearchButtonVisible = false;
            clsSearchProperties3.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            clsSearchProperties3.TextBoxValue = "";
            clsSearchProperties4.FieldName = "Full Name";
            clsSearchProperties4.SearchButtonVisible = false;
            clsSearchProperties4.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            clsSearchProperties4.TextBoxValue = "";
            clsSearchProperties5.FieldName = "Number Of Active Licenses";
            clsSearchProperties5.SearchButtonVisible = false;
            clsSearchProperties5.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            clsSearchProperties5.TextBoxValue = "";
            this.ucDriversList.FieldsProperties = new CustomControls.UCFilter2.clsSearchProperties[] {
        clsSearchProperties1,
        clsSearchProperties2,
        clsSearchProperties3,
        clsSearchProperties4,
        clsSearchProperties5};
            this.ucDriversList.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ucDriversList.Location = new System.Drawing.Point(0, 90);
            this.ucDriversList.Margin = new System.Windows.Forms.Padding(6);
            this.ucDriversList.Name = "ucDriversList";
            this.ucDriversList.Size = new System.Drawing.Size(800, 360);
            this.ucDriversList.TabIndex = 7;
            this.ucDriversList.FilterValueChanged += new System.EventHandler<CustomControls.UCFilter2.ResultEventArgs>(this.ucDriversList_FilterValueChanged);
            this.ucDriversList.Load += new System.EventHandler(this.ucDriversList_Load);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowDriverLicenseHistory});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(291, 40);
            // 
            // tsmiShowDriverLicenseHistory
            // 
            this.tsmiShowDriverLicenseHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowDriverLicenseHistory.Image")));
            this.tsmiShowDriverLicenseHistory.Name = "tsmiShowDriverLicenseHistory";
            this.tsmiShowDriverLicenseHistory.Size = new System.Drawing.Size(290, 36);
            this.tsmiShowDriverLicenseHistory.Text = "Show Driver License History";
            this.tsmiShowDriverLicenseHistory.Click += new System.EventHandler(this.tsmiShowDriverLicenseHistory_Click);
            // 
            // frmDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDrivers";
            this.Text = "frmDrivers";
            this.guna2GroupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private UCListWithFilter ucDriversList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDriverLicenseHistory;
    }
}