namespace UserInterface
{
    partial class AddOrEditLocalDrivingLicenseApplicationsForm
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
            this.tabcontrolApplication = new System.Windows.Forms.TabControl();
            this.PersonalInfoPage = new System.Windows.Forms.TabPage();
            this.uC_PersonInfoWithFilter1 = new UserInterface.UC_PersonInfoWithFilter();
            this.ApplicationInfoPage = new System.Windows.Forms.TabPage();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.cmbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.lbDrivingLicenseApplicationDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDrivingLicenseApplicationId = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbFormMode = new System.Windows.Forms.Label();
            this.tabcontrolApplication.SuspendLayout();
            this.PersonalInfoPage.SuspendLayout();
            this.ApplicationInfoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcontrolApplication
            // 
            this.tabcontrolApplication.Controls.Add(this.PersonalInfoPage);
            this.tabcontrolApplication.Controls.Add(this.ApplicationInfoPage);
            this.tabcontrolApplication.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcontrolApplication.Location = new System.Drawing.Point(6, 32);
            this.tabcontrolApplication.Multiline = true;
            this.tabcontrolApplication.Name = "tabcontrolApplication";
            this.tabcontrolApplication.SelectedIndex = 0;
            this.tabcontrolApplication.Size = new System.Drawing.Size(914, 447);
            this.tabcontrolApplication.TabIndex = 1;
            this.tabcontrolApplication.TabStop = false;
            // 
            // PersonalInfoPage
            // 
            this.PersonalInfoPage.BackColor = System.Drawing.Color.White;
            this.PersonalInfoPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PersonalInfoPage.Controls.Add(this.uC_PersonInfoWithFilter1);
            this.PersonalInfoPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PersonalInfoPage.Location = new System.Drawing.Point(4, 28);
            this.PersonalInfoPage.Name = "PersonalInfoPage";
            this.PersonalInfoPage.Size = new System.Drawing.Size(906, 415);
            this.PersonalInfoPage.TabIndex = 2;
            this.PersonalInfoPage.Text = "Personal Info";
            // 
            // uC_PersonInfoWithFilter1
            // 
            this.uC_PersonInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.uC_PersonInfoWithFilter1.Location = new System.Drawing.Point(5, 8);
            this.uC_PersonInfoWithFilter1.Name = "uC_PersonInfoWithFilter1";
            this.uC_PersonInfoWithFilter1.Size = new System.Drawing.Size(894, 403);
            this.uC_PersonInfoWithFilter1.TabIndex = 0;
            this.uC_PersonInfoWithFilter1.WhenPersonIsFound += new System.Action<int>(this.uC_PersonInfoWithFilter1_WhenPersonIsFound);
            // 
            // ApplicationInfoPage
            // 
            this.ApplicationInfoPage.BackColor = System.Drawing.Color.White;
            this.ApplicationInfoPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ApplicationInfoPage.Controls.Add(this.lbUserName);
            this.ApplicationInfoPage.Controls.Add(this.lbApplicationFees);
            this.ApplicationInfoPage.Controls.Add(this.cmbLicenseClasses);
            this.ApplicationInfoPage.Controls.Add(this.lbDrivingLicenseApplicationDate);
            this.ApplicationInfoPage.Controls.Add(this.label1);
            this.ApplicationInfoPage.Controls.Add(this.pictureBox4);
            this.ApplicationInfoPage.Controls.Add(this.label8);
            this.ApplicationInfoPage.Controls.Add(this.label7);
            this.ApplicationInfoPage.Controls.Add(this.label6);
            this.ApplicationInfoPage.Controls.Add(this.lbDrivingLicenseApplicationId);
            this.ApplicationInfoPage.Controls.Add(this.label13);
            this.ApplicationInfoPage.Controls.Add(this.pictureBox3);
            this.ApplicationInfoPage.Controls.Add(this.pictureBox10);
            this.ApplicationInfoPage.Controls.Add(this.pictureBox1);
            this.ApplicationInfoPage.Controls.Add(this.pictureBox2);
            this.ApplicationInfoPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ApplicationInfoPage.Location = new System.Drawing.Point(4, 28);
            this.ApplicationInfoPage.Name = "ApplicationInfoPage";
            this.ApplicationInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.ApplicationInfoPage.Size = new System.Drawing.Size(906, 415);
            this.ApplicationInfoPage.TabIndex = 1;
            this.ApplicationInfoPage.Text = "Application Info";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold);
            this.lbUserName.Location = new System.Drawing.Point(457, 331);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(94, 29);
            this.lbUserName.TabIndex = 75;
            this.lbUserName.Text = "UserID";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold);
            this.lbApplicationFees.Location = new System.Drawing.Point(457, 266);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(69, 29);
            this.lbApplicationFees.TabIndex = 74;
            this.lbApplicationFees.Text = "Fees";
            // 
            // cmbLicenseClasses
            // 
            this.cmbLicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLicenseClasses.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLicenseClasses.FormattingEnabled = true;
            this.cmbLicenseClasses.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo",
            "FirstName",
            "LastName",
            "Gender",
            "Country",
            "Phone",
            "Email",
            "DateOfBirth"});
            this.cmbLicenseClasses.Location = new System.Drawing.Point(453, 201);
            this.cmbLicenseClasses.Name = "cmbLicenseClasses";
            this.cmbLicenseClasses.Size = new System.Drawing.Size(338, 27);
            this.cmbLicenseClasses.TabIndex = 73;
            // 
            // lbDrivingLicenseApplicationDate
            // 
            this.lbDrivingLicenseApplicationDate.AutoSize = true;
            this.lbDrivingLicenseApplicationDate.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold);
            this.lbDrivingLicenseApplicationDate.Location = new System.Drawing.Point(457, 134);
            this.lbDrivingLicenseApplicationDate.Name = "lbDrivingLicenseApplicationDate";
            this.lbDrivingLicenseApplicationDate.Size = new System.Drawing.Size(68, 29);
            this.lbDrivingLicenseApplicationDate.TabIndex = 72;
            this.lbDrivingLicenseApplicationDate.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(195, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 71;
            this.label1.Text = "Created By";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::UserInterface.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(399, 332);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 70;
            this.pictureBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(195, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 24);
            this.label8.TabIndex = 68;
            this.label8.Text = "Application Fees";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(195, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 24);
            this.label7.TabIndex = 68;
            this.label7.Text = "License Class";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(195, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 24);
            this.label6.TabIndex = 67;
            this.label6.Text = "Application Date";
            // 
            // lbDrivingLicenseApplicationId
            // 
            this.lbDrivingLicenseApplicationId.AutoSize = true;
            this.lbDrivingLicenseApplicationId.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold);
            this.lbDrivingLicenseApplicationId.Location = new System.Drawing.Point(457, 68);
            this.lbDrivingLicenseApplicationId.Name = "lbDrivingLicenseApplicationId";
            this.lbDrivingLicenseApplicationId.Size = new System.Drawing.Size(89, 29);
            this.lbDrivingLicenseApplicationId.TabIndex = 66;
            this.lbDrivingLicenseApplicationId.Text = "[????]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(195, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 24);
            this.label13.TabIndex = 64;
            this.label13.Text = "D.L Application ID";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UserInterface.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(399, 201);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 69;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::UserInterface.Properties.Resources.Number_32;
            this.pictureBox10.Location = new System.Drawing.Point(399, 69);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(27, 27);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 65;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserInterface.Properties.Resources.Person_32;
            this.pictureBox1.Location = new System.Drawing.Point(399, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UserInterface.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(399, 267);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Image = global::UserInterface.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(820, 483);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 36);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "       Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Image = global::UserInterface.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(612, 483);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 36);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "       Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.Enabled = false;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrev.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrev.Image = global::UserInterface.Properties.Resources.Prev_32;
            this.btnPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.Location = new System.Drawing.Point(716, 483);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(99, 36);
            this.btnPrev.TabIndex = 10;
            this.btnPrev.Text = "        Prev";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.Image = global::UserInterface.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(820, 483);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(99, 36);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "  Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbFormMode
            // 
            this.lbFormMode.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Bold);
            this.lbFormMode.ForeColor = System.Drawing.Color.Red;
            this.lbFormMode.Location = new System.Drawing.Point(-1, -13);
            this.lbFormMode.Name = "lbFormMode";
            this.lbFormMode.Size = new System.Drawing.Size(920, 72);
            this.lbFormMode.TabIndex = 36;
            this.lbFormMode.Text = "Add New Local Driving License Application";
            this.lbFormMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddOrEditLocalDrivingLicenseApplicationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 522);
            this.Controls.Add(this.lbFormMode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tabcontrolApplication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrEditLocalDrivingLicenseApplicationsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddOrEditApplicationsForm_Load);
            this.tabcontrolApplication.ResumeLayout(false);
            this.PersonalInfoPage.ResumeLayout(false);
            this.ApplicationInfoPage.ResumeLayout(false);
            this.ApplicationInfoPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrolApplication;
        private System.Windows.Forms.TabPage PersonalInfoPage;
        private UC_PersonInfoWithFilter uC_PersonInfoWithFilter1;
        private System.Windows.Forms.TabPage ApplicationInfoPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDrivingLicenseApplicationId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbFormMode;
        private System.Windows.Forms.Label lbDrivingLicenseApplicationDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.ComboBox cmbLicenseClasses;
    }
}