namespace DVLD
{
    partial class UCLicenseCardWithFilter
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
            this.ucFilter = new DVLD.UCFilter();
            this.ucLicenseCard1 = new DVLD.UCLicenseCard();
            this.SuspendLayout();
            // 
            // ucFilter
            // 
            this.ucFilter.BackColor = System.Drawing.Color.White;
            this.ucFilter.ComboBoxValue = null;
            this.ucFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFilter.FilterEnabled = true;
            this.ucFilter.Location = new System.Drawing.Point(0, 0);
            this.ucFilter.Name = "ucFilter";
            this.ucFilter.SearchBoxValue = "";
            this.ucFilter.Size = new System.Drawing.Size(871, 99);
            this.ucFilter.TabIndex = 1;
            this.ucFilter.Title = "Filter By :";
            this.ucFilter.UsingButtonSearch = true;
            // 
            // ucLicenseCard1
            // 
            this.ucLicenseCard1.BackColor = System.Drawing.Color.White;
            this.ucLicenseCard1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucLicenseCard1.InternationalLicense = null;
            this.ucLicenseCard1.License = null;
            this.ucLicenseCard1.Location = new System.Drawing.Point(0, 99);
            this.ucLicenseCard1.Name = "ucLicenseCard1";
            this.ucLicenseCard1.Size = new System.Drawing.Size(871, 423);
            this.ucLicenseCard1.TabIndex = 0;
            // 
            // UCLicenseCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucFilter);
            this.Controls.Add(this.ucLicenseCard1);
            this.Name = "UCLicenseCardWithFilter";
            this.Size = new System.Drawing.Size(871, 522);
            this.ResumeLayout(false);

        }

        #endregion

        private UCLicenseCard ucLicenseCard1;
        private UCFilter ucFilter;
    }
}
