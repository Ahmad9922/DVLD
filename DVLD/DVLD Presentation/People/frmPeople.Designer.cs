namespace DVLD
{
    partial class frmPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeople));
            CustomControls.UCFilter2.clsSearchProperties clsSearchProperties1 = new CustomControls.UCFilter2.clsSearchProperties();
            CustomControls.UCFilter2.clsSearchProperties clsSearchProperties2 = new CustomControls.UCFilter2.clsSearchProperties();
            CustomControls.UCFilter2.clsSearchProperties clsSearchProperties3 = new CustomControls.UCFilter2.clsSearchProperties();
            CustomControls.UCFilter2.clsSearchProperties clsSearchProperties4 = new CustomControls.UCFilter2.clsSearchProperties();
            CustomControls.UCFilter2.clsSearchProperties clsSearchProperties5 = new CustomControls.UCFilter2.clsSearchProperties();
            CustomControls.UCFilter2.clsSearchProperties clsSearchProperties6 = new CustomControls.UCFilter2.clsSearchProperties();
            CustomControls.UCFilter2.clsSearchProperties clsSearchProperties7 = new CustomControls.UCFilter2.clsSearchProperties();
            CustomControls.UCFilter2.clsComboBoxStyleProperties clsComboBoxStyleProperties1 = new CustomControls.UCFilter2.clsComboBoxStyleProperties();
            CustomControls.UCFilter2.clsComboBoxStyleProperties clsComboBoxStyleProperties2 = new CustomControls.UCFilter2.clsComboBoxStyleProperties();
            CustomControls.UCFilter2.clsComboBoxStyleProperties clsComboBoxStyleProperties3 = new CustomControls.UCFilter2.clsComboBoxStyleProperties();
            CustomControls.UCFilter2.clsSearchProperties clsSearchProperties8 = new CustomControls.UCFilter2.clsSearchProperties();
            CustomControls.UCFilter2.clsSearchProperties clsSearchProperties9 = new CustomControls.UCFilter2.clsSearchProperties();
            this.btnAddPerson = new Guna.UI2.WinForms.Guna2Button();
            this.cmsPeopleProperties = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsmiShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeletePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ucPeopleList = new DVLD.UCListWithFilter();
            this.cmsPeopleProperties.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPerson.FillColor = System.Drawing.Color.White;
            this.btnAddPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.Image")));
            this.btnAddPerson.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddPerson.Location = new System.Drawing.Point(1208, 97);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(45, 45);
            this.btnAddPerson.TabIndex = 5;
            this.btnAddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // cmsPeopleProperties
            // 
            this.cmsPeopleProperties.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.cmsPeopleProperties.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPeopleProperties.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowDetails,
            this.toolStripSeparator1,
            this.tsmiAddPerson,
            this.tsmiEditPerson,
            this.tsmiDeletePerson,
            this.toolStripSeparator2,
            this.phoneCallToolStripMenuItem,
            this.sendEmailToolStripMenuItem});
            this.cmsPeopleProperties.Name = "guna2ContextMenuStrip1";
            this.cmsPeopleProperties.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsPeopleProperties.RenderStyle.BorderColor = System.Drawing.Color.GhostWhite;
            this.cmsPeopleProperties.RenderStyle.ColorTable = null;
            this.cmsPeopleProperties.RenderStyle.RoundedEdges = true;
            this.cmsPeopleProperties.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsPeopleProperties.RenderStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.cmsPeopleProperties.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsPeopleProperties.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsPeopleProperties.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsPeopleProperties.Size = new System.Drawing.Size(256, 172);
            // 
            // tsmiShowDetails
            // 
            this.tsmiShowDetails.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmiShowDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiShowDetails.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowDetails.Image")));
            this.tsmiShowDetails.Name = "tsmiShowDetails";
            this.tsmiShowDetails.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiShowDetails.ShowShortcutKeys = false;
            this.tsmiShowDetails.Size = new System.Drawing.Size(255, 26);
            this.tsmiShowDetails.Text = "Show Details";
            this.tsmiShowDetails.Click += new System.EventHandler(this.ShowDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(252, 6);
            // 
            // tsmiAddPerson
            // 
            this.tsmiAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmiAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddPerson.Image")));
            this.tsmiAddPerson.Name = "tsmiAddPerson";
            this.tsmiAddPerson.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.tsmiAddPerson.ShowShortcutKeys = false;
            this.tsmiAddPerson.Size = new System.Drawing.Size(255, 26);
            this.tsmiAddPerson.Text = "FirstTimeSchedule Person";
            this.tsmiAddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // tsmiEditPerson
            // 
            this.tsmiEditPerson.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEditPerson.Image")));
            this.tsmiEditPerson.Name = "tsmiEditPerson";
            this.tsmiEditPerson.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmiEditPerson.ShowShortcutKeys = false;
            this.tsmiEditPerson.Size = new System.Drawing.Size(255, 26);
            this.tsmiEditPerson.Text = "Edit Person";
            this.tsmiEditPerson.Click += new System.EventHandler(this.EditPerson_Click);
            // 
            // tsmiDeletePerson
            // 
            this.tsmiDeletePerson.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDeletePerson.Image")));
            this.tsmiDeletePerson.Name = "tsmiDeletePerson";
            this.tsmiDeletePerson.ShowShortcutKeys = false;
            this.tsmiDeletePerson.Size = new System.Drawing.Size(255, 26);
            this.tsmiDeletePerson.Text = "Delete Person";
            this.tsmiDeletePerson.Click += new System.EventHandler(this.DeletePerson_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(252, 6);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneCallToolStripMenuItem.Image")));
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendEmailToolStripMenuItem.Image")));
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2GroupBox1.Controls.Add(this.btnAddPerson);
            this.guna2GroupBox1.Controls.Add(this.ucPeopleList);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 90, 0, 0);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1262, 622);
            this.guna2GroupBox1.TabIndex = 6;
            this.guna2GroupBox1.Text = "People Management";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(0, 25);
            // 
            // ucPeopleList
            // 
            this.ucPeopleList.ContextMenuStrip = this.cmsPeopleProperties;
            this.ucPeopleList.Dock = System.Windows.Forms.DockStyle.Fill;
            clsSearchProperties1.FieldName = "Person ID";
            clsSearchProperties1.SearchButtonVisible = false;
            clsSearchProperties1.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            clsSearchProperties1.TextBoxValue = "";
            clsSearchProperties2.FieldName = "National No";
            clsSearchProperties2.SearchButtonVisible = false;
            clsSearchProperties2.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            clsSearchProperties2.TextBoxValue = "";
            clsSearchProperties3.FieldName = "First Name";
            clsSearchProperties3.SearchButtonVisible = false;
            clsSearchProperties3.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            clsSearchProperties3.TextBoxValue = "";
            clsSearchProperties4.FieldName = "Second Name";
            clsSearchProperties4.SearchButtonVisible = false;
            clsSearchProperties4.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            clsSearchProperties4.TextBoxValue = "";
            clsSearchProperties5.FieldName = "Third Name";
            clsSearchProperties5.SearchButtonVisible = false;
            clsSearchProperties5.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            clsSearchProperties5.TextBoxValue = "";
            clsSearchProperties6.FieldName = "Last Name";
            clsSearchProperties6.SearchButtonVisible = false;
            clsSearchProperties6.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            clsSearchProperties6.TextBoxValue = "";
            clsComboBoxStyleProperties1.Name = "All";
            clsComboBoxStyleProperties2.Name = "Male";
            clsComboBoxStyleProperties2.Value = "Male";
            clsComboBoxStyleProperties3.Name = "Female";
            clsComboBoxStyleProperties3.Value = "Female";
            clsSearchProperties7.ComboBoxStyleProperties = new CustomControls.UCFilter2.clsComboBoxStyleProperties[] {
        clsComboBoxStyleProperties1,
        clsComboBoxStyleProperties2,
        clsComboBoxStyleProperties3};
            clsSearchProperties7.FieldName = "Gendor";
            clsSearchProperties7.SearchButtonVisible = false;
            clsSearchProperties7.SearchStyle = CustomControls.UCFilter2.enSearchStyle.ComboBox;
            clsSearchProperties7.TextBoxValue = "";
            clsSearchProperties8.FieldName = "Phone";
            clsSearchProperties8.SearchButtonVisible = false;
            clsSearchProperties8.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            clsSearchProperties8.TextBoxValue = "";
            clsSearchProperties9.FieldName = "Email";
            clsSearchProperties9.SearchButtonVisible = false;
            clsSearchProperties9.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            clsSearchProperties9.TextBoxValue = "";
            this.ucPeopleList.FieldsProperties = new CustomControls.UCFilter2.clsSearchProperties[] {
        clsSearchProperties1,
        clsSearchProperties2,
        clsSearchProperties3,
        clsSearchProperties4,
        clsSearchProperties5,
        clsSearchProperties6,
        clsSearchProperties7,
        clsSearchProperties8,
        clsSearchProperties9};
            this.ucPeopleList.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ucPeopleList.Location = new System.Drawing.Point(0, 90);
            this.ucPeopleList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ucPeopleList.Name = "ucPeopleList";
            this.ucPeopleList.Size = new System.Drawing.Size(1262, 532);
            this.ucPeopleList.TabIndex = 6;
            this.ucPeopleList.FilterValueChanged += new System.EventHandler<CustomControls.UCFilter2.ResultEventArgs>(this.ucPeopleList_FilterValueChanged);
            // 
            // frmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 622);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPeople";
            this.Text = "frmPeople";
            this.Load += new System.EventHandler(this.Form_Load);
            this.cmsPeopleProperties.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAddPerson;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsPeopleProperties;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddPerson;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditPerson;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeletePerson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private UCListWithFilter ucPeopleList;
    }
}