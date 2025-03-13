namespace DVLD
{
    partial class frmIssueDrivingLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueDrivingLicense));
            this.btnIssue = new Guna.UI2.WinForms.Guna2Button();
            this.ucIssueDrivingLicense1 = new DVLD.UCIssueDrivingLicense();
            this.ucLocalDLACard1 = new DVLD.UCLocalDLACard();
            this.SuspendLayout();
            // 
            // btnIssue
            // 
            this.btnIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIssue.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIssue.BorderThickness = 1;
            this.btnIssue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIssue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIssue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIssue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIssue.FillColor = System.Drawing.Color.Empty;
            this.btnIssue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnIssue.ForeColor = System.Drawing.Color.Gray;
            this.btnIssue.Image = ((System.Drawing.Image)(resources.GetObject("btnIssue.Image")));
            this.btnIssue.Location = new System.Drawing.Point(717, 610);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(128, 37);
            this.btnIssue.TabIndex = 47;
            this.btnIssue.Text = "Issue";
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // ucIssueDrivingLicense1
            // 
            this.ucIssueDrivingLicense1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucIssueDrivingLicense1.Location = new System.Drawing.Point(0, 453);
            this.ucIssueDrivingLicense1.Name = "ucIssueDrivingLicense1";
            this.ucIssueDrivingLicense1.Size = new System.Drawing.Size(857, 139);
            this.ucIssueDrivingLicense1.TabIndex = 1;
            // 
            // ucLocalDLACard1
            // 
            this.ucLocalDLACard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucLocalDLACard1.LocalDLA = null;
            this.ucLocalDLACard1.Location = new System.Drawing.Point(0, 0);
            this.ucLocalDLACard1.Name = "ucLocalDLACard1";
            this.ucLocalDLACard1.Size = new System.Drawing.Size(857, 453);
            this.ucLocalDLACard1.TabIndex = 0;
            // 
            // frmIssueDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 659);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.ucIssueDrivingLicense1);
            this.Controls.Add(this.ucLocalDLACard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIssueDrivingLicense";
            this.Text = "Issue Driving License";
            this.ResumeLayout(false);

        }

        #endregion

        private UCLocalDLACard ucLocalDLACard1;
        private UCIssueDrivingLicense ucIssueDrivingLicense1;
        private Guna.UI2.WinForms.Guna2Button btnIssue;
    }
}