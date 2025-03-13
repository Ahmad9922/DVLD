namespace DVLD
{
    partial class frmUpdateAndAddPerson
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
            DVLDBusiness.clsPerson clsPerson1 = new DVLDBusiness.clsPerson();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.UCAddPerson1 = new DVLD.UCAddPerson();
            this.SuspendLayout();
            // 
            // lblMode
            // 
            this.lblMode.BackColor = System.Drawing.Color.Transparent;
            this.lblMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMode.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblMode.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblMode.Location = new System.Drawing.Point(0, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblMode.Size = new System.Drawing.Size(829, 76);
            this.lblMode.TabIndex = 4;
            this.lblMode.Text = "Add New Person";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.DarkGray;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(671, 652);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCancel.Location = new System.Drawing.Point(529, 652);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UCAddPerson1
            // 
            this.UCAddPerson1.Dock = System.Windows.Forms.DockStyle.Top;
            this.UCAddPerson1.Location = new System.Drawing.Point(0, 76);
            this.UCAddPerson1.Name = "UCAddPerson1";
            clsPerson1.Address = "";
            clsPerson1.DateOfBirth = new System.DateTime(((long)(0)));
            clsPerson1.Email = "";
            clsPerson1.FirstName = "";
            clsPerson1.Gendor = DVLDBusiness.clsPerson.enGendor.Male;
            clsPerson1.ImagePath = "";
            clsPerson1.LastName = "";
            clsPerson1.NationalityCountry = "";
            clsPerson1.NationalNo = "";
            clsPerson1.Phone = "";
            clsPerson1.SecondName = "";
            clsPerson1.ThirdName = "";
            this.UCAddPerson1.Person = clsPerson1;
            this.UCAddPerson1.Size = new System.Drawing.Size(829, 560);
            this.UCAddPerson1.TabIndex = 8;
            // 
            // frmUpdateAndAddPerson
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(829, 703);
            this.Controls.Add(this.UCAddPerson1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUpdateAndAddPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Person";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMode;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private UCAddPerson UCAddPerson1;
    }
}