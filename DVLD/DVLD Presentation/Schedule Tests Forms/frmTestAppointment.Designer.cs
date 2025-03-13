namespace DVLD
{
    partial class frmTestAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestAppointment));
            this.btnAddAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.gbTestAppointment = new Guna.UI2.WinForms.Guna2GroupBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.ImagesTestTypes = new System.Windows.Forms.ImageList(this.components);
            this.LocalDLACard = new DVLD.UCLocalDLACard();
            this.ucList1 = new DVLD.UCList();
            this.contextMenuStrip1.SuspendLayout();
            this.gbTestAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAppointment.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddAppointment.FillColor = System.Drawing.Color.White;
            this.btnAddAppointment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAddAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAppointment.Image")));
            this.btnAddAppointment.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddAppointment.Location = new System.Drawing.Point(933, 623);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(45, 45);
            this.btnAddAppointment.TabIndex = 7;
            this.btnAddAppointment.Click += new System.EventHandler(this.AddAppointment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(10, 645);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Appointment : ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.tsmiTakeTest});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(161, 36);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.Edit_Click);
            // 
            // tsmiTakeTest
            // 
            this.tsmiTakeTest.Image = ((System.Drawing.Image)(resources.GetObject("tsmiTakeTest.Image")));
            this.tsmiTakeTest.Name = "tsmiTakeTest";
            this.tsmiTakeTest.Size = new System.Drawing.Size(161, 36);
            this.tsmiTakeTest.Text = "Take Test";
            this.tsmiTakeTest.Click += new System.EventHandler(this.TakeTest_Click);
            // 
            // gbTestAppointment
            // 
            this.gbTestAppointment.Controls.Add(this.PictureBox);
            this.gbTestAppointment.Controls.Add(this.LocalDLACard);
            this.gbTestAppointment.Controls.Add(this.btnAddAppointment);
            this.gbTestAppointment.Controls.Add(this.ucList1);
            this.gbTestAppointment.Controls.Add(this.label1);
            this.gbTestAppointment.CustomBorderThickness = new System.Windows.Forms.Padding(0, 90, 0, 0);
            this.gbTestAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTestAppointment.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gbTestAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbTestAppointment.Location = new System.Drawing.Point(0, 0);
            this.gbTestAppointment.Name = "gbTestAppointment";
            this.gbTestAppointment.Size = new System.Drawing.Size(990, 953);
            this.gbTestAppointment.TabIndex = 9;
            this.gbTestAppointment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbTestAppointment.TextOffset = new System.Drawing.Point(0, 25);
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox.Location = new System.Drawing.Point(307, 8);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(70, 70);
            this.PictureBox.TabIndex = 9;
            this.PictureBox.TabStop = false;
            // 
            // ImagesTestTypes
            // 
            this.ImagesTestTypes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImagesTestTypes.ImageStream")));
            this.ImagesTestTypes.TransparentColor = System.Drawing.Color.Transparent;
            this.ImagesTestTypes.Images.SetKeyName(0, "Vision");
            this.ImagesTestTypes.Images.SetKeyName(1, "Written");
            this.ImagesTestTypes.Images.SetKeyName(2, "Street");
            // 
            // LocalDLACard
            // 
            this.LocalDLACard.Dock = System.Windows.Forms.DockStyle.Top;
            this.LocalDLACard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LocalDLACard.LocalDLA = null;
            this.LocalDLACard.Location = new System.Drawing.Point(0, 90);
            this.LocalDLACard.Margin = new System.Windows.Forms.Padding(6);
            this.LocalDLACard.Name = "LocalDLACard";
            this.LocalDLACard.Size = new System.Drawing.Size(990, 524);
            this.LocalDLACard.TabIndex = 0;
            // 
            // ucList1
            // 
            this.ucList1.ContextMenuStrip = this.contextMenuStrip1;
            this.ucList1.DataSource = null;
            this.ucList1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucList1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ucList1.Location = new System.Drawing.Point(0, 674);
            this.ucList1.Margin = new System.Windows.Forms.Padding(6);
            this.ucList1.Name = "ucList1";
            this.ucList1.Size = new System.Drawing.Size(990, 279);
            this.ucList1.TabIndex = 1;
            // 
            // frmTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(990, 953);
            this.Controls.Add(this.gbTestAppointment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTestAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Appointment";
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbTestAppointment.ResumeLayout(false);
            this.gbTestAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UCLocalDLACard LocalDLACard;
        private UCList ucList1;
        private Guna.UI2.WinForms.Guna2Button btnAddAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiTakeTest;
        private Guna.UI2.WinForms.Guna2GroupBox gbTestAppointment;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ImageList ImagesTestTypes;
    }
}