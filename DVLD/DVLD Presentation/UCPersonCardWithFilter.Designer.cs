namespace DVLD
{
    partial class UCPersonCardWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPersonCardWithFilter));
            this.btnAddPerson = new Guna.UI2.WinForms.Guna2Button();
            this.ucPersonCard1 = new DVLD.UCPersonCard();
            this.ucFilter1 = new DVLD.UCFilter();
            this.SuspendLayout();
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPerson.FillColor = System.Drawing.Color.Silver;
            this.btnAddPerson.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.Image")));
            this.btnAddPerson.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddPerson.Location = new System.Drawing.Point(674, 41);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(37, 37);
            this.btnAddPerson.TabIndex = 9;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // ucPersonCard1
            // 
            this.ucPersonCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPersonCard1.Location = new System.Drawing.Point(0, 88);
            this.ucPersonCard1.Name = "ucPersonCard1";
            this.ucPersonCard1.Size = new System.Drawing.Size(729, 306);
            this.ucPersonCard1.TabIndex = 0;
            // 
            // ucFilter1
            // 
            this.ucFilter1.BackColor = System.Drawing.Color.White;
            this.ucFilter1.ComboBoxValue = "PersonID";
            this.ucFilter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucFilter1.FieldMask = new DVLD.UCFilter.enFieldMask[] {
        DVLD.UCFilter.enFieldMask.Number,
        DVLD.UCFilter.enFieldMask.LettersAndNumbers};
            this.ucFilter1.FieldName = new string[] {
        "PersonID",
        "NationalNo"};
            this.ucFilter1.Location = new System.Drawing.Point(0, 0);
            this.ucFilter1.Name = "ucFilter1";
            this.ucFilter1.SearchBoxValue = "";
            this.ucFilter1.SearchType = new DVLD.UCFilter.enSearchType[] {
        DVLD.UCFilter.enSearchType.TextBox,
        DVLD.UCFilter.enSearchType.TextBox};
            this.ucFilter1.Size = new System.Drawing.Size(729, 88);
            this.ucFilter1.TabIndex = 10;
            this.ucFilter1.Title = "Filter By :";
            this.ucFilter1.FilterResultChange += new System.Action<string, string>(this.ucFilter1_FilterResultChange);
            // 
            // UCPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.ucPersonCard1);
            this.Controls.Add(this.ucFilter1);
            this.Name = "UCPersonCardWithFilter";
            this.Size = new System.Drawing.Size(729, 394);
            this.ResumeLayout(false);

        }

        #endregion

        private UCPersonCard ucPersonCard1;
        private Guna.UI2.WinForms.Guna2Button btnAddPerson;
        private UCFilter ucFilter1;
    }
}
