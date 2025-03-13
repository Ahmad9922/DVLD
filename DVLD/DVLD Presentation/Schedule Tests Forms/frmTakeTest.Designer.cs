namespace DVLD
{
    partial class frmTakeTest
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
            this.ucTakeTest1 = new DVLD.UCTakeTest();
            this.ucTestAppointmentCard1 = new DVLD.UCTestAppointmentCard();
            this.SuspendLayout();
            // 
            // ucTakeTest1
            // 
            this.ucTakeTest1.BackColor = System.Drawing.Color.White;
            this.ucTakeTest1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucTakeTest1.Location = new System.Drawing.Point(0, 317);
            this.ucTakeTest1.Name = "ucTakeTest1";
            this.ucTakeTest1.Size = new System.Drawing.Size(568, 181);
            this.ucTakeTest1.TabIndex = 0;
            this.ucTakeTest1.ONSaveCompleted += new System.Action(this.ucTakeTest1_ONSaveCompleted);
            // 
            // ucTestAppointmentCard1
            // 
            this.ucTestAppointmentCard1.BackColor = System.Drawing.Color.White;
            this.ucTestAppointmentCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTestAppointmentCard1.Location = new System.Drawing.Point(0, 0);
            this.ucTestAppointmentCard1.Name = "ucTestAppointmentCard1";
            this.ucTestAppointmentCard1.Size = new System.Drawing.Size(568, 317);
            this.ucTestAppointmentCard1.TabIndex = 1;
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 498);
            this.Controls.Add(this.ucTestAppointmentCard1);
            this.Controls.Add(this.ucTakeTest1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Take Test";
            this.ResumeLayout(false);

        }

        #endregion

        private UCTakeTest ucTakeTest1;
        private UCTestAppointmentCard ucTestAppointmentCard1;
    }
}