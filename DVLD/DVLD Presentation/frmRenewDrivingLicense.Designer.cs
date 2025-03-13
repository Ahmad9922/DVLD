namespace DVLD
{
    partial class frmRenewDrivingLicense
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
            this.ucRenewLicenseApplication1 = new DVLD.UCRenewLicenseApplication();
            this.SuspendLayout();
            // 
            // ucRenewLicenseApplication1
            // 
            this.ucRenewLicenseApplication1.BackColor = System.Drawing.Color.White;
            this.ucRenewLicenseApplication1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRenewLicenseApplication1.Location = new System.Drawing.Point(0, 0);
            this.ucRenewLicenseApplication1.Name = "ucRenewLicenseApplication1";
            this.ucRenewLicenseApplication1.Size = new System.Drawing.Size(1052, 930);
            this.ucRenewLicenseApplication1.TabIndex = 0;
            // 
            // frmRenewDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 930);
            this.Controls.Add(this.ucRenewLicenseApplication1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRenewDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renew Driving License";
            this.ResumeLayout(false);

        }

        #endregion

        private UCRenewLicenseApplication ucRenewLicenseApplication1;
    }
}