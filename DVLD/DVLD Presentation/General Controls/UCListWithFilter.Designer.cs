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
            CustomControls.UCFilter2.clsRadioButtonStyleProperties clsRadioButtonStyleProperties1 = new CustomControls.UCFilter2.clsRadioButtonStyleProperties();
            CustomControls.UCFilter2.clsRadioButtonStyleProperties clsRadioButtonStyleProperties2 = new CustomControls.UCFilter2.clsRadioButtonStyleProperties();
            this.ucFilter = new CustomControls.UCFilter2();
            this.ucList = new DVLD.UCList();
            this.SuspendLayout();
            // 
            // ucFilter
            // 
            this.ucFilter.BackColor = System.Drawing.Color.White;
            this.ucFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucFilter.FieldName = "Field ApplicationTypeTitle";
            this.ucFilter.Font = new System.Drawing.Font("Cairo SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.ucFilter.Location = new System.Drawing.Point(0, 0);
            this.ucFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ucFilter.MaximumSize = new System.Drawing.Size(0, 55);
            this.ucFilter.Name = "ucFilter";
            this.ucFilter.RadioButtonOneChecked = clsRadioButtonStyleProperties1;
            this.ucFilter.RadioButtonTowChecked = clsRadioButtonStyleProperties2;
            this.ucFilter.SearchStrategy = CustomControls.UCFilter2.enSearchOptions.Multiple;
            this.ucFilter.SearchStyle = CustomControls.UCFilter2.enSearchStyle.TextBox;
            this.ucFilter.Size = new System.Drawing.Size(1112, 55);
            this.ucFilter.TabIndex = 2;
            this.ucFilter.FilterValueChanged += new System.EventHandler<CustomControls.UCFilter2.ResultEventArgs>(this.ucFilter_FilterValueChanged);
            this.ucFilter.SearchButtonClick += new System.EventHandler<CustomControls.UCFilter2.ResultEventArgs>(this.ucFilter_SearchButtonClick);
            // 
            // ucList
            // 
            this.ucList.BackColor = System.Drawing.Color.White;
            this.ucList.DataSource = null;
            this.ucList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucList.Location = new System.Drawing.Point(0, 55);
            this.ucList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ucList.Name = "ucList";
            this.ucList.Size = new System.Drawing.Size(1112, 541);
            this.ucList.TabIndex = 0;
            // 
            // UCListWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucList);
            this.Controls.Add(this.ucFilter);
            this.Font = new System.Drawing.Font("Cairo SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UCListWithFilter";
            this.Size = new System.Drawing.Size(1112, 596);
            this.ResumeLayout(false);

        }

        #endregion

        private UCList ucList;
        private CustomControls.UCFilter2 ucFilter;
    }
}
