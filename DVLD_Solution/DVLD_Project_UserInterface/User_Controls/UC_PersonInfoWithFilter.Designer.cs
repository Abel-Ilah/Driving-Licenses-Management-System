
namespace UserInterface
{
    partial class UC_PersonInfoWithFilter
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
            this.UC_PersonCard = new UserInterface.UC_PersonInfo();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.txtbFind = new System.Windows.Forms.TextBox();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.cmbFindBy = new System.Windows.Forms.ComboBox();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // UC_PersonCard
            // 
            this.UC_PersonCard.BackColor = System.Drawing.Color.White;
            this.UC_PersonCard.Location = new System.Drawing.Point(-2, 61);
            this.UC_PersonCard.Name = "UC_PersonCard";
            this.UC_PersonCard.Size = new System.Drawing.Size(894, 342);
            this.UC_PersonCard.TabIndex = 74;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.txtbFind);
            this.gbFilter.Controls.Add(this.btnAddNewPerson);
            this.gbFilter.Controls.Add(this.cmbFindBy);
            this.gbFilter.Controls.Add(this.btnFindPerson);
            this.gbFilter.Controls.Add(this.label3);
            this.gbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbFilter.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(3, -2);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbFilter.Size = new System.Drawing.Size(886, 60);
            this.gbFilter.TabIndex = 75;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Find Person";
            // 
            // txtbFind
            // 
            this.txtbFind.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFind.Location = new System.Drawing.Point(271, 24);
            this.txtbFind.MaxLength = 50;
            this.txtbFind.Name = "txtbFind";
            this.txtbFind.Size = new System.Drawing.Size(218, 26);
            this.txtbFind.TabIndex = 2;
            this.txtbFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbFind_KeyDown);
            this.txtbFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFind_KeyPress);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BackColor = System.Drawing.Color.White;
            this.btnAddNewPerson.BackgroundImage = global::UserInterface.Properties.Resources.Add_Person_40;
            this.btnAddNewPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNewPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewPerson.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnAddNewPerson.FlatAppearance.BorderSize = 2;
            this.btnAddNewPerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewPerson.Location = new System.Drawing.Point(845, 19);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(35, 35);
            this.btnAddNewPerson.TabIndex = 4;
            this.btnAddNewPerson.UseVisualStyleBackColor = false;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // cmbFindBy
            // 
            this.cmbFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFindBy.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFindBy.FormattingEnabled = true;
            this.cmbFindBy.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo"});
            this.cmbFindBy.Location = new System.Drawing.Point(115, 23);
            this.cmbFindBy.Name = "cmbFindBy";
            this.cmbFindBy.Size = new System.Drawing.Size(152, 27);
            this.cmbFindBy.TabIndex = 1;
            this.cmbFindBy.SelectedIndexChanged += new System.EventHandler(this.cmbFindBy_SelectedIndexChanged);
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.BackColor = System.Drawing.Color.White;
            this.btnFindPerson.BackgroundImage = global::UserInterface.Properties.Resources.search;
            this.btnFindPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindPerson.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnFindPerson.FlatAppearance.BorderSize = 2;
            this.btnFindPerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFindPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindPerson.Location = new System.Drawing.Point(493, 23);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(27, 27);
            this.btnFindPerson.TabIndex = 3;
            this.btnFindPerson.UseVisualStyleBackColor = false;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(19, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Find By";
            // 
            // UC_PersonInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UC_PersonCard);
            this.Controls.Add(this.gbFilter);
            this.Name = "UC_PersonInfoWithFilter";
            this.Size = new System.Drawing.Size(894, 403);
            this.Load += new System.EventHandler(this.UC_PersonInfoWithFilter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.TextBox txtbFind;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.ComboBox cmbFindBy;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.Label label3;
        public UC_PersonInfo UC_PersonCard;
    }
}
