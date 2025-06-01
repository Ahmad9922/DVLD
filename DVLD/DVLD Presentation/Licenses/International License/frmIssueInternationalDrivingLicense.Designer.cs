namespace DVLD
{
    partial class frmIssueInternationalDrivingLicense
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
            this.ucLicenseCardWithFilter1 = new DVLD.UCAddInternationalLicense();
            this.SuspendLayout();
            // 
            // ucLicenseCardWithFilter1
            // 
            this.ucLicenseCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ucLicenseCardWithFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLicenseCardWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.ucLicenseCardWithFilter1.Name = "ucLicenseCardWithFilter1";
            this.ucLicenseCardWithFilter1.Size = new System.Drawing.Size(1050, 795);
            this.ucLicenseCardWithFilter1.TabIndex = 49;
            // 
            // frmIssueInternationalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 795);
            this.Controls.Add(this.ucLicenseCardWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIssueInternationalDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue International Driving License";
            this.ResumeLayout(false);

        }

        #endregion
        private UCAddInternationalLicense ucLicenseCardWithFilter1;
    }
}