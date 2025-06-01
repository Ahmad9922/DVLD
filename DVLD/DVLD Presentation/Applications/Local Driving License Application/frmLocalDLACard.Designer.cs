namespace DVLD
{
    partial class frmLocalDLACard
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
            this.ucLocalDLACard1 = new DVLD.UCLocalDLACard();
            this.SuspendLayout();
            // 
            // ucLocalDLACard1
            // 
            this.ucLocalDLACard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLocalDLACard1.LocalDLA = null;
            this.ucLocalDLACard1.Location = new System.Drawing.Point(0, 0);
            this.ucLocalDLACard1.Name = "ucLocalDLACard1";
            this.ucLocalDLACard1.Size = new System.Drawing.Size(857, 448);
            this.ucLocalDLACard1.TabIndex = 0;
            // 
            // frmLocalDLACard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 448);
            this.Controls.Add(this.ucLocalDLACard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLocalDLACard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving License Application Card";
            this.ResumeLayout(false);

        }

        #endregion

        private UCLocalDLACard ucLocalDLACard1;
    }
}