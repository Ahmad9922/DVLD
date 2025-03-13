namespace DVLD
{
    partial class UCUserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUserCard));
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserIDValue = new System.Windows.Forms.Label();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserNameValue = new System.Windows.Forms.Label();
            this.guna2VSeparator3 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblIsActiveValue = new System.Windows.Forms.Label();
            this.gbUserInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ucPersonCard1 = new DVLD.UCPersonCard();
            this.gbUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblUserID.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserID.Image = ((System.Drawing.Image)(resources.GetObject("lblUserID.Image")));
            this.lblUserID.Location = new System.Drawing.Point(94, 71);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(74, 19);
            this.lblUserID.TabIndex = 28;
            this.lblUserID.Text = "UserID : ";
            // 
            // lblUserIDValue
            // 
            this.lblUserIDValue.AutoSize = true;
            this.lblUserIDValue.BackColor = System.Drawing.Color.Transparent;
            this.lblUserIDValue.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblUserIDValue.Location = new System.Drawing.Point(166, 71);
            this.lblUserIDValue.Name = "lblApplicationTypeIDValue";
            this.lblUserIDValue.Size = new System.Drawing.Size(27, 19);
            this.lblUserIDValue.TabIndex = 29;
            this.lblUserIDValue.Text = "---";
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.guna2VSeparator2.Location = new System.Drawing.Point(309, 63);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(20, 32);
            this.guna2VSeparator2.TabIndex = 33;
            this.guna2VSeparator2.UseTransparentBackground = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblUserName.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserName.Image = ((System.Drawing.Image)(resources.GetObject("lblUserName.Image")));
            this.lblUserName.Location = new System.Drawing.Point(335, 71);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(98, 19);
            this.lblUserName.TabIndex = 34;
            this.lblUserName.Text = "UserName : ";
            // 
            // lblUserNameValue
            // 
            this.lblUserNameValue.AutoSize = true;
            this.lblUserNameValue.BackColor = System.Drawing.Color.Transparent;
            this.lblUserNameValue.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblUserNameValue.Location = new System.Drawing.Point(439, 71);
            this.lblUserNameValue.Name = "lblUserNameValue";
            this.lblUserNameValue.Size = new System.Drawing.Size(27, 19);
            this.lblUserNameValue.TabIndex = 35;
            this.lblUserNameValue.Text = "---";
            // 
            // guna2VSeparator3
            // 
            this.guna2VSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.guna2VSeparator3.Location = new System.Drawing.Point(581, 63);
            this.guna2VSeparator3.Name = "guna2VSeparator3";
            this.guna2VSeparator3.Size = new System.Drawing.Size(20, 32);
            this.guna2VSeparator3.TabIndex = 36;
            this.guna2VSeparator3.UseTransparentBackground = true;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.BackColor = System.Drawing.Color.Transparent;
            this.lblIsActive.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblIsActive.ForeColor = System.Drawing.Color.DimGray;
            this.lblIsActive.Image = ((System.Drawing.Image)(resources.GetObject("lblIsActive.Image")));
            this.lblIsActive.Location = new System.Drawing.Point(607, 71);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(86, 19);
            this.lblIsActive.TabIndex = 37;
            this.lblIsActive.Text = "Is Active : ";
            // 
            // lblIsActiveValue
            // 
            this.lblIsActiveValue.AutoSize = true;
            this.lblIsActiveValue.BackColor = System.Drawing.Color.Transparent;
            this.lblIsActiveValue.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblIsActiveValue.Location = new System.Drawing.Point(699, 71);
            this.lblIsActiveValue.Name = "lblIsActiveValue";
            this.lblIsActiveValue.Size = new System.Drawing.Size(27, 19);
            this.lblIsActiveValue.TabIndex = 38;
            this.lblIsActiveValue.Text = "---";
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.lblIsActiveValue);
            this.gbUserInfo.Controls.Add(this.lblIsActive);
            this.gbUserInfo.Controls.Add(this.guna2VSeparator3);
            this.gbUserInfo.Controls.Add(this.lblUserNameValue);
            this.gbUserInfo.Controls.Add(this.lblUserName);
            this.gbUserInfo.Controls.Add(this.guna2VSeparator2);
            this.gbUserInfo.Controls.Add(this.lblUserIDValue);
            this.gbUserInfo.Controls.Add(this.lblUserID);
            this.gbUserInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbUserInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbUserInfo.Location = new System.Drawing.Point(0, 339);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(809, 123);
            this.gbUserInfo.TabIndex = 0;
            this.gbUserInfo.Text = "User Information";
            // 
            // ucPersonCard1
            // 
            this.ucPersonCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPersonCard1.Location = new System.Drawing.Point(0, 0);
            this.ucPersonCard1.Name = "ucPersonCard1";
            this.ucPersonCard1.Size = new System.Drawing.Size(809, 339);
            this.ucPersonCard1.TabIndex = 1;
            // 
            // UCUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucPersonCard1);
            this.Controls.Add(this.gbUserInfo);
            this.Name = "UCUserCard";
            this.Size = new System.Drawing.Size(809, 462);
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserIDValue;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserNameValue;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator3;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblIsActiveValue;
        private Guna.UI2.WinForms.Guna2GroupBox gbUserInfo;
        private UCPersonCard ucPersonCard1;
    }
}
