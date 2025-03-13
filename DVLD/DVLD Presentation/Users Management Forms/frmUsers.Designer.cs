namespace DVLD
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.cmsUsersProperties = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsmiShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ucUsersList = new DVLD.UCListWithFilter();
            this.cmsUsersProperties.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddUser.FillColor = System.Drawing.Color.White;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddUser.Location = new System.Drawing.Point(1208, 97);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(45, 45);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // cmsUsersProperties
            // 
            this.cmsUsersProperties.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.cmsUsersProperties.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsUsersProperties.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowDetails,
            this.toolStripSeparator1,
            this.tsmiAddUser,
            this.tsmiEditUser,
            this.tsmiDeleteUser,
            this.tsmiChangePassword,
            this.toolStripSeparator2,
            this.phoneCallToolStripMenuItem,
            this.sendEmailToolStripMenuItem});
            this.cmsUsersProperties.Name = "guna2ContextMenuStrip1";
            this.cmsUsersProperties.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsUsersProperties.RenderStyle.BorderColor = System.Drawing.Color.GhostWhite;
            this.cmsUsersProperties.RenderStyle.ColorTable = null;
            this.cmsUsersProperties.RenderStyle.RoundedEdges = true;
            this.cmsUsersProperties.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsUsersProperties.RenderStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.cmsUsersProperties.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsUsersProperties.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsUsersProperties.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsUsersProperties.Size = new System.Drawing.Size(208, 198);
            // 
            // tsmiShowDetails
            // 
            this.tsmiShowDetails.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmiShowDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiShowDetails.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowDetails.Image")));
            this.tsmiShowDetails.Name = "tsmiShowDetails";
            this.tsmiShowDetails.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiShowDetails.ShowShortcutKeys = false;
            this.tsmiShowDetails.Size = new System.Drawing.Size(207, 26);
            this.tsmiShowDetails.Text = "Show Details";
            this.tsmiShowDetails.Click += new System.EventHandler(this.ShowDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // tsmiAddUser
            // 
            this.tsmiAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmiAddUser.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddUser.Image")));
            this.tsmiAddUser.Name = "tsmiAddUser";
            this.tsmiAddUser.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.tsmiAddUser.ShowShortcutKeys = false;
            this.tsmiAddUser.Size = new System.Drawing.Size(207, 26);
            this.tsmiAddUser.Text = "Add";
            this.tsmiAddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // tsmiEditUser
            // 
            this.tsmiEditUser.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEditUser.Image")));
            this.tsmiEditUser.Name = "tsmiEditUser";
            this.tsmiEditUser.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmiEditUser.ShowShortcutKeys = false;
            this.tsmiEditUser.Size = new System.Drawing.Size(207, 26);
            this.tsmiEditUser.Text = "Edit";
            this.tsmiEditUser.Click += new System.EventHandler(this.tsmiEditUser_Click);
            // 
            // tsmiDeleteUser
            // 
            this.tsmiDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDeleteUser.Image")));
            this.tsmiDeleteUser.Name = "tsmiDeleteUser";
            this.tsmiDeleteUser.ShowShortcutKeys = false;
            this.tsmiDeleteUser.Size = new System.Drawing.Size(207, 26);
            this.tsmiDeleteUser.Text = "Delete";
            this.tsmiDeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // tsmiChangePassword
            // 
            this.tsmiChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("tsmiChangePassword.Image")));
            this.tsmiChangePassword.Name = "tsmiChangePassword";
            this.tsmiChangePassword.Size = new System.Drawing.Size(207, 26);
            this.tsmiChangePassword.Text = "Change Password";
            this.tsmiChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneCallToolStripMenuItem.Image")));
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendEmailToolStripMenuItem.Image")));
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.btnAddUser);
            this.guna2GroupBox1.Controls.Add(this.ucUsersList);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 90, 0, 0);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1262, 622);
            this.guna2GroupBox1.TabIndex = 8;
            this.guna2GroupBox1.Text = "Users Management";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(0, 25);
            // 
            // ucUsersList
            // 
            this.ucUsersList.ContextMenuStrip = this.cmsUsersProperties;
            this.ucUsersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUsersList.FieldMask = new DVLD.UCFilter.enFieldMask[] {
        DVLD.UCFilter.enFieldMask.None,
        DVLD.UCFilter.enFieldMask.Number,
        DVLD.UCFilter.enFieldMask.Number,
        DVLD.UCFilter.enFieldMask.Letters,
        DVLD.UCFilter.enFieldMask.All,
        DVLD.UCFilter.enFieldMask.None};
            this.ucUsersList.FieldName = new string[] {
        "None",
        "UserID",
        "PersonID",
        "FullName",
        "UserName",
        "IsActive"};
            this.ucUsersList.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ucUsersList.Location = new System.Drawing.Point(0, 90);
            this.ucUsersList.Margin = new System.Windows.Forms.Padding(6);
            this.ucUsersList.Name = "ucUsersList";
            this.ucUsersList.SearchType = new DVLD.UCFilter.enSearchType[] {
        DVLD.UCFilter.enSearchType.None,
        DVLD.UCFilter.enSearchType.TextBox,
        DVLD.UCFilter.enSearchType.TextBox,
        DVLD.UCFilter.enSearchType.TextBox,
        DVLD.UCFilter.enSearchType.TextBox,
        DVLD.UCFilter.enSearchType.ComboBox};
            this.ucUsersList.Size = new System.Drawing.Size(1262, 532);
            this.ucUsersList.TabIndex = 7;
            this.ucUsersList.FilterResultChange += new System.Action<string, string>(this.ucUsersList_FilterResultChange);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 622);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.cmsUsersProperties.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsUsersProperties;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePassword;
        private UCListWithFilter ucUsersList;
    }
}