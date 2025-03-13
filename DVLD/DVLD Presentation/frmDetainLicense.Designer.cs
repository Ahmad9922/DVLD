namespace DVLD
{
    partial class frmDetainLicense
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
            this.ucDetainLicense1 = new DVLD.UCDetainLicense();
            this.SuspendLayout();
            // 
            // ucDetainLicense1
            // 
            this.ucDetainLicense1.BackColor = System.Drawing.Color.White;
            this.ucDetainLicense1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDetainLicense1.Location = new System.Drawing.Point(0, 0);
            this.ucDetainLicense1.Name = "ucDetainLicense1";
            this.ucDetainLicense1.Size = new System.Drawing.Size(1049, 773);
            this.ucDetainLicense1.TabIndex = 0;
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 773);
            this.Controls.Add(this.ucDetainLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDetainLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detain License";
            this.ResumeLayout(false);

        }

        #endregion

        private UCDetainLicense ucDetainLicense1;
    }
}