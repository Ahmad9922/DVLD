namespace DVLD
{
    partial class frmReplacementLicense
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
            this.ucReForDamagedOrLostLicense1 = new DVLD.UCReForDamagedOrLostLicense();
            this.SuspendLayout();
            // 
            // ucReForDamagedOrLostLicense1
            // 
            this.ucReForDamagedOrLostLicense1.BackColor = System.Drawing.Color.White;
            this.ucReForDamagedOrLostLicense1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReForDamagedOrLostLicense1.Location = new System.Drawing.Point(0, 0);
            this.ucReForDamagedOrLostLicense1.Name = "ucReForDamagedOrLostLicense1";
            this.ucReForDamagedOrLostLicense1.Size = new System.Drawing.Size(1050, 776);
            this.ucReForDamagedOrLostLicense1.TabIndex = 0;
            // 
            // frmReplacementLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 776);
            this.Controls.Add(this.ucReForDamagedOrLostLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReplacementLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replacement for lost or damaged license";
            this.ResumeLayout(false);

        }

        #endregion

        private UCReForDamagedOrLostLicense ucReForDamagedOrLostLicense1;
    }
}