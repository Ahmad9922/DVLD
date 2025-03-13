namespace DVLD
{
    partial class frmManageTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageTestTypes));
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.gbManageTestTypes = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ucList1 = new DVLD.UCList();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.gbManageTestTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(104, 30);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmiEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEdit.Image")));
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(103, 26);
            this.tsmiEdit.Text = "Edit";
            this.tsmiEdit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // gbManageTestTypes
            // 
            this.gbManageTestTypes.Controls.Add(this.ucList1);
            this.gbManageTestTypes.CustomBorderThickness = new System.Windows.Forms.Padding(0, 90, 0, 0);
            this.gbManageTestTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbManageTestTypes.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gbManageTestTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbManageTestTypes.Location = new System.Drawing.Point(0, 0);
            this.gbManageTestTypes.Name = "gbManageTestTypes";
            this.gbManageTestTypes.Size = new System.Drawing.Size(1284, 661);
            this.gbManageTestTypes.TabIndex = 2;
            this.gbManageTestTypes.Text = "Manage Test FieldsMask";
            this.gbManageTestTypes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbManageTestTypes.TextOffset = new System.Drawing.Point(0, 25);
            // 
            // ucList1
            // 
            this.ucList1.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.ucList1.DataSource = null;
            this.ucList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucList1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ucList1.Location = new System.Drawing.Point(0, 90);
            this.ucList1.Margin = new System.Windows.Forms.Padding(6);
            this.ucList1.Name = "ucList1";
            this.ucList1.Size = new System.Drawing.Size(1284, 571);
            this.ucList1.TabIndex = 0;
            // 
            // frmManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.gbManageTestTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageTestTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Test FieldsMask";
            this.Load += new System.EventHandler(this.frmManageTestTypes_Load);
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.gbManageTestTypes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UCList ucList1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private Guna.UI2.WinForms.Guna2GroupBox gbManageTestTypes;
    }
}