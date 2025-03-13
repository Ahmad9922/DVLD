namespace DVLD
{
    partial class frmUpdateAndAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateAndAddUser));
            this.tcLevelsSave = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNextStep = new Guna.UI2.WinForms.Guna2Button();
            this.ucPersonCardWithFilter1 = new DVLD.UCPersonCardWithFilter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucAddUser = new DVLD.UCAddUser();
            this.btnSaveUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.tcLevelsSave.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcLevelsSave
            // 
            this.tcLevelsSave.Controls.Add(this.tabPage1);
            this.tcLevelsSave.Controls.Add(this.tabPage2);
            this.tcLevelsSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcLevelsSave.ItemSize = new System.Drawing.Size(180, 40);
            this.tcLevelsSave.Location = new System.Drawing.Point(0, 0);
            this.tcLevelsSave.Name = "tcLevelsSave";
            this.tcLevelsSave.SelectedIndex = 0;
            this.tcLevelsSave.Size = new System.Drawing.Size(788, 475);
            this.tcLevelsSave.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcLevelsSave.TabButtonHoverState.FillColor = System.Drawing.Color.Gray;
            this.tcLevelsSave.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcLevelsSave.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcLevelsSave.TabButtonHoverState.InnerColor = System.Drawing.Color.Gray;
            this.tcLevelsSave.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcLevelsSave.TabButtonIdleState.FillColor = System.Drawing.Color.Silver;
            this.tcLevelsSave.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcLevelsSave.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tcLevelsSave.TabButtonIdleState.InnerColor = System.Drawing.Color.Silver;
            this.tcLevelsSave.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcLevelsSave.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.tcLevelsSave.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcLevelsSave.TabButtonSelectedState.ForeColor = System.Drawing.Color.DarkGray;
            this.tcLevelsSave.TabButtonSelectedState.InnerColor = System.Drawing.Color.White;
            this.tcLevelsSave.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcLevelsSave.TabIndex = 1;
            this.tcLevelsSave.TabMenuBackColor = System.Drawing.Color.White;
            this.tcLevelsSave.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.tcLevelsSave.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcLevelsSave_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNextStep);
            this.tabPage1.Controls.Add(this.ucPersonCardWithFilter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNextStep
            // 
            this.btnNextStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextStep.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNextStep.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNextStep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNextStep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNextStep.FillColor = System.Drawing.Color.Silver;
            this.btnNextStep.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNextStep.ForeColor = System.Drawing.Color.White;
            this.btnNextStep.Image = ((System.Drawing.Image)(resources.GetObject("btnNextStep.Image")));
            this.btnNextStep.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNextStep.Location = new System.Drawing.Point(607, 374);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(150, 45);
            this.btnNextStep.TabIndex = 1;
            this.btnNextStep.Text = "Next";
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // ucPersonCardWithFilter1
            // 
            this.ucPersonCardWithFilter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPersonCardWithFilter1.FilterBox = "";
            this.ucPersonCardWithFilter1.FilterEnabled = true;
            this.ucPersonCardWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ucPersonCardWithFilter1.Name = "ucPersonCardWithFilter1";
            this.ucPersonCardWithFilter1.Size = new System.Drawing.Size(774, 365);
            this.ucPersonCardWithFilter1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucAddUser);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Login Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucAddUser
            // 
            this.ucAddUser.BackColor = System.Drawing.Color.White;
            this.ucAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddUser.Location = new System.Drawing.Point(3, 3);
            this.ucAddUser.Name = "ucAddUser";
            this.ucAddUser.Size = new System.Drawing.Size(774, 421);
            this.ucAddUser.TabIndex = 0;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveUser.FillColor = System.Drawing.Color.Silver;
            this.btnSaveUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSaveUser.ForeColor = System.Drawing.Color.White;
            this.btnSaveUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSaveUser.Location = new System.Drawing.Point(611, 488);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(150, 40);
            this.btnSaveUser.TabIndex = 2;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnCancel.BorderThickness = 2;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCancel.Location = new System.Drawing.Point(455, 488);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmUpdateAndAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 540);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.tcLevelsSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUpdateAndAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tcLevelsSave.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UCPersonCardWithFilter ucPersonCardWithFilter1;
        private Guna.UI2.WinForms.Guna2TabControl tcLevelsSave;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2Button btnNextStep;
        private Guna.UI2.WinForms.Guna2Button btnSaveUser;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private UCAddUser ucAddUser;
    }
}