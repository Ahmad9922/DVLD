namespace DVLD
{
    partial class frmAddUpdateApplication
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
            this.ucAddUpdateApplication1 = new DVLD.UCAddUpdateApplication();
            this.SuspendLayout();
            // 
            // ucAddUpdateApplication1
            // 
            this.ucAddUpdateApplication1.BackColor = System.Drawing.Color.White;
            this.ucAddUpdateApplication1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddUpdateApplication1.Location = new System.Drawing.Point(0, 0);
            this.ucAddUpdateApplication1.Name = "ucAddUpdateApplication1";
            this.ucAddUpdateApplication1.Size = new System.Drawing.Size(570, 492);
            this.ucAddUpdateApplication1.TabIndex = 0;
            // 
            // frmAddUpdateApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 492);
            this.Controls.Add(this.ucAddUpdateApplication1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private UCAddUpdateApplication ucAddUpdateApplication1;
    }
}