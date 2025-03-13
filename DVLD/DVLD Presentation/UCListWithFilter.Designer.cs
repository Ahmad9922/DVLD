namespace DVLD
{
    partial class UCListWithFilter
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
            this.ucList = new DVLD.UCList();
            this.ucFilter = new DVLD.UCFilter();
            this.SuspendLayout();
            // 
            // ucList
            // 
            this.ucList.BackColor = System.Drawing.Color.White;
            this.ucList.DataSource = null;
            this.ucList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucList.Location = new System.Drawing.Point(0, 91);
            this.ucList.Name = "ucList";
            this.ucList.Size = new System.Drawing.Size(953, 505);
            this.ucList.TabIndex = 0;
            // 
            // ucFilter
            // 
            this.ucFilter.BackColor = System.Drawing.Color.White;
            this.ucFilter.ComboBoxValue = null;
            this.ucFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucFilter.FieldMask = null;
            this.ucFilter.FieldName = new string[0];
            this.ucFilter.Location = new System.Drawing.Point(0, 0);
            this.ucFilter.Name = "ucFilter";
            this.ucFilter.SearchBoxValue = "";
            this.ucFilter.SearchType = null;
            this.ucFilter.Size = new System.Drawing.Size(953, 91);
            this.ucFilter.TabIndex = 1;
            this.ucFilter.Title = "Filter By :";
            this.ucFilter.FilterResultChange += new System.Action<string, string>(this.Filter_FilterResultChange);
            // 
            // UCListWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucList);
            this.Controls.Add(this.ucFilter);
            this.Name = "UCListWithFilter";
            this.Size = new System.Drawing.Size(953, 596);
            this.ResumeLayout(false);

        }

        #endregion

        private UCList ucList;
        private UCFilter ucFilter;
    }
}
