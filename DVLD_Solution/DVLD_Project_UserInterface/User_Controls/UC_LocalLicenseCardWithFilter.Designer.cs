namespace UserInterface
{
    partial class UC_LocalLicenseCardWithFilter
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.txtbFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.uC_LicenseCard1 = new UserInterface.UC_LicenseCard();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.txtbFind);
            this.gbFilter.Controls.Add(this.btnFind);
            this.gbFilter.Controls.Add(this.label3);
            this.gbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbFilter.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(3, -2);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbFilter.Size = new System.Drawing.Size(746, 60);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Find License";
            // 
            // txtbFind
            // 
            this.txtbFind.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.txtbFind.Location = new System.Drawing.Point(161, 21);
            this.txtbFind.MaxLength = 50;
            this.txtbFind.Name = "txtbFind";
            this.txtbFind.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtbFind.Size = new System.Drawing.Size(218, 29);
            this.txtbFind.TabIndex = 1;
            this.txtbFind.Tag = "";
            this.txtbFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbFind_KeyDown);
            this.txtbFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFind_KeyPress);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.BackgroundImage = global::UserInterface.Properties.Resources.search;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnFind.FlatAppearance.BorderSize = 2;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFind.Location = new System.Drawing.Point(385, 21);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(30, 29);
            this.btnFind.TabIndex = 2;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(42, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "License ID:";
            // 
            // uC_LicenseCard1
            // 
            this.uC_LicenseCard1.BackColor = System.Drawing.Color.White;
            this.uC_LicenseCard1.Location = new System.Drawing.Point(0, 57);
            this.uC_LicenseCard1.Name = "uC_LicenseCard1";
            this.uC_LicenseCard1.Size = new System.Drawing.Size(753, 308);
            this.uC_LicenseCard1.TabIndex = 3;
            // 
            // UC_LocalLicenseCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.uC_LicenseCard1);
            this.Name = "UC_LocalLicenseCardWithFilter";
            this.Size = new System.Drawing.Size(754, 362);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UC_LicenseCard uC_LicenseCard1;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.TextBox txtbFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label3;
    }
}
