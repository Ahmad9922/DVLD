namespace DVLD
{
    partial class frmAddAndUpdateTestAppointment
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
            this.ucAddTestAppointment1 = new DVLD.UCAddTestAppointment();
            this.SuspendLayout();
            // 
            // ucAddTestAppointment1
            // 
            this.ucAddTestAppointment1.BackColor = System.Drawing.Color.White;
            this.ucAddTestAppointment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddTestAppointment1.Location = new System.Drawing.Point(0, 0);
            this.ucAddTestAppointment1.Name = "ucAddTestAppointment1";
            this.ucAddTestAppointment1.Size = new System.Drawing.Size(788, 565);
            this.ucAddTestAppointment1.TabIndex = 0;
            this.ucAddTestAppointment1.TestAppointment = null;
            this.ucAddTestAppointment1.ONSaveCompleted += new System.Action(this.AddTestAppointment_ONSaveCompleted);
            // 
            // frmAddAndUpdateTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 565);
            this.Controls.Add(this.ucAddTestAppointment1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddAndUpdateTestAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private UCAddTestAppointment ucAddTestAppointment1;
    }
}