namespace DVLD
{
    partial class frmReleaseDetainedLicense
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
            this.ucReleaseDetainedLicense1 = new DVLD.UCReleaseDetainedLicense();
            this.SuspendLayout();
            // 
            // ucReleaseDetainedLicense1
            // 
            this.ucReleaseDetainedLicense1.BackColor = System.Drawing.Color.White;
            this.ucReleaseDetainedLicense1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReleaseDetainedLicense1.Location = new System.Drawing.Point(0, 0);
            this.ucReleaseDetainedLicense1.Name = "ucReleaseDetainedLicense1";
            this.ucReleaseDetainedLicense1.Size = new System.Drawing.Size(1050, 824);
            this.ucReleaseDetainedLicense1.TabIndex = 0;
            // 
            // frmReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 824);
            this.Controls.Add(this.ucReleaseDetainedLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReleaseDetainedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Release Detained License";
            this.ResumeLayout(false);

        }

        #endregion

        private UCReleaseDetainedLicense ucReleaseDetainedLicense1;
    }
}