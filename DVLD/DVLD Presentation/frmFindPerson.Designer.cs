namespace DVLD
{
    partial class frmFindPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindPerson));
            this.btnOk = new Guna.UI2.WinForms.Guna2Button();
            this.ucPersonCardWithFilter1 = new DVLD.UCPersonCardWithFilter();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BorderColor = System.Drawing.Color.DimGray;
            this.btnOk.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnOk.BorderThickness = 1;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOk.FillColor = System.Drawing.Color.Empty;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOk.ForeColor = System.Drawing.Color.Gray;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(635, 410);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(151, 39);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ucPersonCardWithFilter1
            // 
            this.ucPersonCardWithFilter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPersonCardWithFilter1.FilterBox = "";
            this.ucPersonCardWithFilter1.FilterEnabled = true;
            this.ucPersonCardWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.ucPersonCardWithFilter1.Name = "ucPersonCardWithFilter1";
            this.ucPersonCardWithFilter1.Size = new System.Drawing.Size(806, 394);
            this.ucPersonCardWithFilter1.TabIndex = 0;
            // 
            // frmFindPerson
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 457);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.ucPersonCardWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFindPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Person";
            this.Activated += new System.EventHandler(this.frmFindPerson_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private UCPersonCardWithFilter ucPersonCardWithFilter1;
        private Guna.UI2.WinForms.Guna2Button btnOk;
    }
}