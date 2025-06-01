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
            CustomControls.UCFilter2.clsSearchProperties clsSearchProperties1 = new CustomControls.UCFilter2.clsSearchProperties();
            CustomControls.UCFilter2.clsSearchProperties clsSearchProperties2 = new CustomControls.UCFilter2.clsSearchProperties();
            this.btnAddPerson = new Guna.UI2.WinForms.Guna2Button();
            this.ucFilter1 = new CustomControls.UCFilter2();
            this.ucPersonCard1 = new DVLD.UCPersonCard();
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
            this.btnAddPerson.FocusedColor = System.Drawing.Color.Gray;
            this.btnAddPerson.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.Image")));
            this.btnAddPerson.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddPerson.Location = new System.Drawing.Point(676, 8);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(37, 37);
            this.btnAddPerson.TabIndex = 9;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // ucFilter1
            // 
            this.ucFilter1.BackColor = System.Drawing.Color.White;
            this.ucFilter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucFilter1.FieldName = "Field ApplicationTypeTitle";
            this.ucFilter1.Font = new System.Drawing.Font("Cairo SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.ucFilter1.Location = new System.Drawing.Point(0, 0);
            this.ucFilter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ucFilter1.MaximumSize = new System.Drawing.Size(0, 55);
            clsSearchProperties1.FieldName = "PersonID";
            clsSearchProperties1.SearchButtonVisible = true;
            clsSearchProperties1.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            clsSearchProperties1.TextBoxValue = "";
            clsSearchProperties2.FieldName = "NationalNo";
            clsSearchProperties2.SearchButtonVisible = true;
            clsSearchProperties2.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            clsSearchProperties2.TextBoxValue = "";
            this.ucFilter1.MultiSearch = new CustomControls.UCFilter2.clsSearchProperties[] {
        clsSearchProperties1,
        clsSearchProperties2};
            this.ucFilter1.Name = "ucFilter1";
            this.ucFilter1.SearchButtonVisible = true;
            this.ucFilter1.SearchStrategy = CustomControls.UCFilter2.enSearchOptions.Multiple;
            this.ucFilter1.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            this.ucFilter1.Size = new System.Drawing.Size(729, 55);
            this.ucFilter1.TabIndex = 10;
            this.ucFilter1.SearchButtonClick += new System.EventHandler<CustomControls.UCFilter2.ResultEventArgs>(this.ucFilter1_SearchButtonClick);
            // 
            // ucPersonCard1
            // 
            this.ucPersonCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPersonCard1.Location = new System.Drawing.Point(0, 55);
            this.ucPersonCard1.Name = "ucPersonCard1";
            this.ucPersonCard1.Size = new System.Drawing.Size(729, 339);
            this.ucPersonCard1.TabIndex = 0;
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
        private CustomControls.UCFilter2 ucFilter1;
    }
}
