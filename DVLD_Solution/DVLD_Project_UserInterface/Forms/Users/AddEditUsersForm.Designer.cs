namespace UserInterface
{
    partial class AddEditUsersForm
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
            this.components = new System.ComponentModel.Container();
            this.tabcontrolUser = new System.Windows.Forms.TabControl();
            this.PersonalInfoPage = new System.Windows.Forms.TabPage();
            this.uC_PersonInfoWithFilter1 = new UserInterface.UC_PersonInfoWithFilter();
            this.UserLoginInfoPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbConfirmPassword = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtbNewPassword = new System.Windows.Forms.TextBox();
            this.txtbUserName = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbFormMode = new System.Windows.Forms.Label();
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabcontrolUser.SuspendLayout();
            this.PersonalInfoPage.SuspendLayout();
            this.UserLoginInfoPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcontrolUser
            // 
            this.tabcontrolUser.Controls.Add(this.PersonalInfoPage);
            this.tabcontrolUser.Controls.Add(this.UserLoginInfoPage);
            this.tabcontrolUser.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcontrolUser.Location = new System.Drawing.Point(1, 25);
            this.tabcontrolUser.Multiline = true;
            this.tabcontrolUser.Name = "tabcontrolUser";
            this.tabcontrolUser.SelectedIndex = 0;
            this.tabcontrolUser.Size = new System.Drawing.Size(914, 447);
            this.tabcontrolUser.TabIndex = 0;
            this.tabcontrolUser.TabStop = false;
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
            this.uC_PersonInfoWithFilter1.Location = new System.Drawing.Point(8, 10);
            this.uC_PersonInfoWithFilter1.Name = "uC_PersonInfoWithFilter1";
            this.uC_PersonInfoWithFilter1.Size = new System.Drawing.Size(894, 403);
            this.uC_PersonInfoWithFilter1.TabIndex = 0;
            this.uC_PersonInfoWithFilter1.WhenPersonIsFound += new System.Action<int>(this.uC_PersonInfoWithFilter1_WhenPersonIsFound);
            // 
            // UserLoginInfoPage
            // 
            this.UserLoginInfoPage.BackColor = System.Drawing.Color.White;
            this.UserLoginInfoPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UserLoginInfoPage.Controls.Add(this.groupBox3);
            this.UserLoginInfoPage.Controls.Add(this.label8);
            this.UserLoginInfoPage.Controls.Add(this.label7);
            this.UserLoginInfoPage.Controls.Add(this.label6);
            this.UserLoginInfoPage.Controls.Add(this.lbUserID);
            this.UserLoginInfoPage.Controls.Add(this.label13);
            this.UserLoginInfoPage.Controls.Add(this.txtbConfirmPassword);
            this.UserLoginInfoPage.Controls.Add(this.txtbNewPassword);
            this.UserLoginInfoPage.Controls.Add(this.txtbUserName);
            this.UserLoginInfoPage.Controls.Add(this.pictureBox3);
            this.UserLoginInfoPage.Controls.Add(this.pictureBox10);
            this.UserLoginInfoPage.Controls.Add(this.pictureBox1);
            this.UserLoginInfoPage.Controls.Add(this.pictureBox2);
            this.UserLoginInfoPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.UserLoginInfoPage.Location = new System.Drawing.Point(4, 28);
            this.UserLoginInfoPage.Name = "UserLoginInfoPage";
            this.UserLoginInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserLoginInfoPage.Size = new System.Drawing.Size(906, 415);
            this.UserLoginInfoPage.TabIndex = 1;
            this.UserLoginInfoPage.Text = "LogIn Info";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbInactive);
            this.groupBox3.Controls.Add(this.rbActive);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(189, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(549, 60);
            this.groupBox3.TabIndex = 70;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Status";
            // 
            // rbInactive
            // 
            this.rbInactive.AutoSize = true;
            this.rbInactive.Font = new System.Drawing.Font("Rockwell", 16.25F, System.Drawing.FontStyle.Bold);
            this.rbInactive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbInactive.Location = new System.Drawing.Point(425, 22);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(118, 31);
            this.rbInactive.TabIndex = 14;
            this.rbInactive.TabStop = true;
            this.rbInactive.Text = "Inactive";
            this.rbInactive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Font = new System.Drawing.Font("Rockwell", 16.25F, System.Drawing.FontStyle.Bold);
            this.rbActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbActive.Location = new System.Drawing.Point(235, 22);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(97, 31);
            this.rbActive.TabIndex = 13;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(195, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 24);
            this.label8.TabIndex = 68;
            this.label8.Text = "Confirm PassWord";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(195, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 24);
            this.label7.TabIndex = 68;
            this.label7.Text = "New PassWord";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(195, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 67;
            this.label6.Text = "UserName";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold);
            this.lbUserID.Location = new System.Drawing.Point(457, 68);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(61, 29);
            this.lbUserID.TabIndex = 66;
            this.lbUserID.Text = "N/A";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(195, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 24);
            this.label13.TabIndex = 64;
            this.label13.Text = "User ID";
            // 
            // txtbConfirmPassword
            // 
            this.txtbConfirmPassword.ContextMenuStrip = this.contextMenuStrip1;
            this.txtbConfirmPassword.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.txtbConfirmPassword.Location = new System.Drawing.Point(460, 265);
            this.txtbConfirmPassword.MaxLength = 20;
            this.txtbConfirmPassword.Name = "txtbConfirmPassword";
            this.txtbConfirmPassword.Size = new System.Drawing.Size(278, 31);
            this.txtbConfirmPassword.TabIndex = 10;
            this.txtbConfirmPassword.TextChanged += new System.EventHandler(this.txtbConfirmPassword_TextChanged);
            this.txtbConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PreventPasteTextOnTextBoxes);
            this.txtbConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbConfirmPassword_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtbPassword
            // 
            this.txtbNewPassword.ContextMenuStrip = this.contextMenuStrip1;
            this.txtbNewPassword.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.txtbNewPassword.Location = new System.Drawing.Point(460, 199);
            this.txtbNewPassword.MaxLength = 20;
            this.txtbNewPassword.Name = "txtbPassword";
            this.txtbNewPassword.Size = new System.Drawing.Size(278, 31);
            this.txtbNewPassword.TabIndex = 11;
            this.txtbNewPassword.TextChanged += new System.EventHandler(this.txtbPassword_TextChanged);
            this.txtbNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PreventPasteTextOnTextBoxes);
            this.txtbNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbPassword_KeyPress);
            // 
            // txtbUserName
            // 
            this.txtbUserName.ContextMenuStrip = this.contextMenuStrip1;
            this.txtbUserName.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.txtbUserName.Location = new System.Drawing.Point(460, 133);
            this.txtbUserName.MaxLength = 20;
            this.txtbUserName.Name = "txtbUserName";
            this.txtbUserName.Size = new System.Drawing.Size(278, 31);
            this.txtbUserName.TabIndex = 10;
            this.txtbUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PreventPasteTextOnTextBoxes);
            this.txtbUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbUserName_KeyPress);
            this.txtbUserName.Leave += new System.EventHandler(this.txtbUserName_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UserInterface.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(399, 199);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 69;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::UserInterface.Properties.Resources.Number_32;
            this.pictureBox10.Location = new System.Drawing.Point(399, 67);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(31, 31);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 65;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserInterface.Properties.Resources.Person_32;
            this.pictureBox1.Location = new System.Drawing.Point(399, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UserInterface.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(399, 265);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            // 
            // lbFormMode
            // 
            this.lbFormMode.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Bold);
            this.lbFormMode.ForeColor = System.Drawing.Color.Red;
            this.lbFormMode.Location = new System.Drawing.Point(2, -20);
            this.lbFormMode.Name = "lbFormMode";
            this.lbFormMode.Size = new System.Drawing.Size(910, 72);
            this.lbFormMode.TabIndex = 35;
            this.lbFormMode.Text = "Add New User";
            this.lbFormMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.ContainerControl = this;
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
            this.btnSave.Location = new System.Drawing.Point(815, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 36);
            this.btnSave.TabIndex = 15;
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
            this.btnClose.Location = new System.Drawing.Point(607, 480);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 36);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "       Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrev.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrev.Image = global::UserInterface.Properties.Resources.Prev_32;
            this.btnPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.Location = new System.Drawing.Point(711, 480);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(99, 36);
            this.btnPrev.TabIndex = 7;
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
            this.btnNext.Location = new System.Drawing.Point(815, 480);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(99, 36);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "  Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // AddEditUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 518);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbFormMode);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tabcontrolUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditUsersForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddEditUsersForm_Load);
            this.tabcontrolUser.ResumeLayout(false);
            this.PersonalInfoPage.ResumeLayout(false);
            this.UserLoginInfoPage.ResumeLayout(false);
            this.UserLoginInfoPage.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabControl tabcontrolUser;
        private System.Windows.Forms.TabPage UserLoginInfoPage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtbConfirmPassword;
        private System.Windows.Forms.TextBox txtbNewPassword;
        private System.Windows.Forms.TextBox txtbUserName;
        private System.Windows.Forms.TabPage PersonalInfoPage;
        private System.Windows.Forms.Label lbFormMode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider ErrorProvider1;
        private UC_PersonInfoWithFilter uC_PersonInfoWithFilter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}