namespace DVLD
{
    partial class frmApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApplications));
            CustomControls.UCFilter2.clsSearchProperties clsSearchProperties1 = new CustomControls.UCFilter2.clsSearchProperties();
            CustomControls.UCFilter2.clsSearchProperties clsSearchProperties2 = new CustomControls.UCFilter2.clsSearchProperties();
            CustomControls.UCFilter2.clsSearchProperties clsSearchProperties3 = new CustomControls.UCFilter2.clsSearchProperties();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAddApplication = new Guna.UI2.WinForms.Guna2Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.ucApplicationsList = new DVLD.UCListWithFilter();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2GroupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2GroupBox1.Controls.Add(this.btnAddApplication);
            this.guna2GroupBox1.Controls.Add(this.ucApplicationsList);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 90, 0, 0);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1100, 580);
            this.guna2GroupBox1.TabIndex = 7;
            this.guna2GroupBox1.Text = "Applications Management";
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
            this.btnAddApplication.Image = global::DVLD.Properties.Resources.icons8_plus_1080;
            this.btnAddApplication.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddApplication.Location = new System.Drawing.Point(1046, 97);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(45, 45);
            this.btnAddApplication.TabIndex = 5;
            this.btnAddApplication.Click += new System.EventHandler(this.btnAddApplication_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator3,
            this.addToolStripMenuItem,
            this.tsmiEdit,
            this.tsmiDelete,
            this.tsmiCancelApplication,
            this.manageToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 226);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem.Image")));
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(183, 36);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem.Image")));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(183, 36);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.btnAddApplication_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEdit.Image")));
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(183, 36);
            this.tsmiEdit.Text = "Edit";
            this.tsmiEdit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDelete.Image")));
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(183, 36);
            this.tsmiDelete.Text = "Delete";
            // 
            // tsmiCancelApplication
            // 
            this.tsmiCancelApplication.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCancelApplication.Image")));
            this.tsmiCancelApplication.Name = "tsmiCancelApplication";
            this.tsmiCancelApplication.Size = new System.Drawing.Size(183, 36);
            this.tsmiCancelApplication.Text = "Cancel";
            // 
            // ucApplicationsList
            // 
            this.ucApplicationsList.ContextMenuStrip = this.contextMenuStrip1;
            this.ucApplicationsList.Dock = System.Windows.Forms.DockStyle.Fill;
            clsSearchProperties1.FieldName = "Application ID";
            clsSearchProperties1.SearchButtonVisible = false;
            clsSearchProperties1.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            clsSearchProperties1.TextBoxValue = "";
            clsSearchProperties2.FieldName = "Application Type ApplicationTypeTitle";
            clsSearchProperties2.SearchButtonVisible = false;
            clsSearchProperties2.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            clsSearchProperties2.TextBoxValue = "";
            clsSearchProperties3.FieldName = "Paid ApplicationFees";
            clsSearchProperties3.SearchButtonVisible = false;
            clsSearchProperties3.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            clsSearchProperties3.TextBoxValue = "";
            this.ucApplicationsList.FieldsProperties = new CustomControls.UCFilter2.clsSearchProperties[] {
        clsSearchProperties1,
        clsSearchProperties2,
        clsSearchProperties3};
            this.ucApplicationsList.Font = new System.Drawing.Font("Cairo SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.ucApplicationsList.Location = new System.Drawing.Point(0, 90);
            this.ucApplicationsList.Margin = new System.Windows.Forms.Padding(6);
            this.ucApplicationsList.Name = "ucApplicationsList";
            this.ucApplicationsList.Size = new System.Drawing.Size(1100, 490);
            this.ucApplicationsList.TabIndex = 6;
            this.ucApplicationsList.FilterValueChanged += new System.EventHandler<CustomControls.UCFilter2.ResultEventArgs>(this.ucApplicationsList_FilterValueChanged);
            this.ucApplicationsList.Load += new System.EventHandler(this.ucApplicationsList_Load);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Image = global::DVLD.Properties.Resources.icons8_resume_100__3_;
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(183, 36);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // frmApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 580);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmApplications";
            this.Text = "frmApplications";
            this.guna2GroupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnAddApplication;
        private UCListWithFilter ucApplicationsList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelApplication;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
    }
}