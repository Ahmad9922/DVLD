namespace DVLD
{
    partial class UCFilter
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.cbSearchList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(789, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFilterOptions
            // 
            this.cbFilterOptions.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbFilterOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterOptions.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterOptions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterOptions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterOptions.ItemHeight = 30;
            this.cbFilterOptions.Location = new System.Drawing.Point(0, 42);
            this.cbFilterOptions.Name = "cbFilterOptions";
            this.cbFilterOptions.Size = new System.Drawing.Size(199, 36);
            this.cbFilterOptions.TabIndex = 1;
            this.cbFilterOptions.SelectedIndexChanged += new System.EventHandler(this.cbFilterOptions_SelectedIndexChanged);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBox.DefaultText = "";
            this.txtSearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBox.Location = new System.Drawing.Point(205, 42);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.PasswordChar = '\0';
            this.txtSearchBox.PlaceholderText = "";
            this.txtSearchBox.SelectedText = "";
            this.txtSearchBox.Size = new System.Drawing.Size(293, 36);
            this.txtSearchBox.TabIndex = 2;
            this.txtSearchBox.Visible = false;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(489, 14);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ResetOnSpace = false;
            this.maskedTextBox1.Size = new System.Drawing.Size(9, 20);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.Visible = false;
            // 
            // cbSearchList
            // 
            this.cbSearchList.BackColor = System.Drawing.Color.Transparent;
            this.cbSearchList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearchList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSearchList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSearchList.ItemHeight = 30;
            this.cbSearchList.Location = new System.Drawing.Point(205, 42);
            this.cbSearchList.Name = "cbSearchList";
            this.cbSearchList.Size = new System.Drawing.Size(293, 36);
            this.cbSearchList.TabIndex = 4;
            this.cbSearchList.Visible = false;
            this.cbSearchList.SelectedIndexChanged += new System.EventHandler(this.cbSearchList_SelectedIndexChanged);
            // 
            // UCFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.cbSearchList);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.cbFilterOptions);
            this.Controls.Add(this.label1);
            this.Name = "UCFilter";
            this.Size = new System.Drawing.Size(789, 88);
            this.Load += new System.EventHandler(this.UCFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchList;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterOptions;
    }
}
