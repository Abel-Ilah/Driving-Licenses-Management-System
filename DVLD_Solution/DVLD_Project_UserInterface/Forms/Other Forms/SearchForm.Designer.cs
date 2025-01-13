namespace UserInterface
{
    partial class SearchForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtbSearchBy = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.lbSearchFor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Fuchsia;
            this.label4.Location = new System.Drawing.Point(70, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 1);
            this.label4.TabIndex = 8;
            // 
            // txtbSearchBy
            // 
            this.txtbSearchBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbSearchBy.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearchBy.ForeColor = System.Drawing.Color.Gray;
            this.txtbSearchBy.HideSelection = false;
            this.txtbSearchBy.Location = new System.Drawing.Point(72, 116);
            this.txtbSearchBy.MaxLength = 30;
            this.txtbSearchBy.Name = "txtbSearchBy";
            this.txtbSearchBy.Size = new System.Drawing.Size(340, 29);
            this.txtbSearchBy.TabIndex = 7;
            this.txtbSearchBy.TextChanged += new System.EventHandler(this.txtbSearchBy_TextChanged);
            this.txtbSearchBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbSearchBy_KeyDown);
            this.txtbSearchBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbUserName_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = global::UserInterface.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(375, 114);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 33);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(69, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 36);
            this.label1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(67, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Search  By";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Location = new System.Drawing.Point(191, 48);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(217, 33);
            this.cmbSearchBy.TabIndex = 12;
            this.cmbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cmbSearchBy_SelectedIndexChanged);
            // 
            // lbSearchFor
            // 
            this.lbSearchFor.Font = new System.Drawing.Font("Rockwell Extra Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchFor.ForeColor = System.Drawing.Color.Red;
            this.lbSearchFor.Location = new System.Drawing.Point(49, -6);
            this.lbSearchFor.Name = "lbSearchFor";
            this.lbSearchFor.Size = new System.Drawing.Size(365, 36);
            this.lbSearchFor.TabIndex = 14;
            this.lbSearchFor.Text = "Search For a User";
            this.lbSearchFor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSearchFor.Click += new System.EventHandler(this.lbSearchFor_Click);
            // 
            // SearchForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(490, 206);
            this.Controls.Add(this.lbSearchFor);
            this.Controls.Add(this.cmbSearchBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbSearchBy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbSearchBy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label lbSearchFor;
    }
}