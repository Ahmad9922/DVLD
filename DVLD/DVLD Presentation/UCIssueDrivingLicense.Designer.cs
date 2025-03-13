namespace DVLD
{
    partial class UCIssueDrivingLicense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbLicenseInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gbLicenseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNotes
            // 
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Location = new System.Drawing.Point(0, 40);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderText = "Notes";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(608, 147);
            this.txtNotes.TabIndex = 0;
            this.txtNotes.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // gbLicenseInfo
            // 
            this.gbLicenseInfo.Controls.Add(this.txtNotes);
            this.gbLicenseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbLicenseInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbLicenseInfo.Location = new System.Drawing.Point(0, 0);
            this.gbLicenseInfo.Name = "gbLicenseInfo";
            this.gbLicenseInfo.Size = new System.Drawing.Size(608, 187);
            this.gbLicenseInfo.TabIndex = 72;
            this.gbLicenseInfo.Text = "License Info";
            this.gbLicenseInfo.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // UCIssueDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbLicenseInfo);
            this.Name = "UCIssueDrivingLicense";
            this.Size = new System.Drawing.Size(608, 187);
            this.gbLicenseInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private Guna.UI2.WinForms.Guna2GroupBox gbLicenseInfo;
    }
}
