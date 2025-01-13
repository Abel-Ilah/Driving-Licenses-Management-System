namespace UserInterface
{
    partial class ReplaceLicenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceLicenseForm));
            this.uC_LocalLicenseCardWithFilter1 = new UserInterface.UC_LocalLicenseCardWithFilter();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
            this.gbReplaceLicenseReasons = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbOldLicenseID = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbRenewedlLicenseID = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbLicenseFees = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnShowLicensesHistory = new System.Windows.Forms.Button();
            this.btnShowLicenseInfo = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbReplaceLicenseReasons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // uC_LocalLicenseCardWithFilter1
            // 
            this.uC_LocalLicenseCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.uC_LocalLicenseCardWithFilter1.Location = new System.Drawing.Point(10, 1);
            this.uC_LocalLicenseCardWithFilter1.Name = "uC_LocalLicenseCardWithFilter1";
            this.uC_LocalLicenseCardWithFilter1.Size = new System.Drawing.Size(754, 362);
            this.uC_LocalLicenseCardWithFilter1.TabIndex = 0;
            this.uC_LocalLicenseCardWithFilter1.WhenLicenseIsFound += new System.Action<int>(this.uC_LocalLicenseCardWithFilter1_WhenLicenseIsFound);
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbLostLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbLostLicense.Location = new System.Drawing.Point(548, 12);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(146, 27);
            this.rbLostLicense.TabIndex = 2;
            this.rbLostLicense.TabStop = true;
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.UseVisualStyleBackColor = true;
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.AutoSize = true;
            this.rbDamagedLicense.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbDamagedLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbDamagedLicense.Location = new System.Drawing.Point(159, 12);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(194, 27);
            this.rbDamagedLicense.TabIndex = 3;
            this.rbDamagedLicense.TabStop = true;
            this.rbDamagedLicense.Text = "Damaged License";
            this.rbDamagedLicense.UseVisualStyleBackColor = true;
            this.rbDamagedLicense.CheckedChanged += new System.EventHandler(this.rbDamagedLicense_CheckedChanged);
            // 
            // gbReplaceLicenseReasons
            // 
            this.gbReplaceLicenseReasons.Controls.Add(this.rbLostLicense);
            this.gbReplaceLicenseReasons.Controls.Add(this.rbDamagedLicense);
            this.gbReplaceLicenseReasons.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gbReplaceLicenseReasons.ForeColor = System.Drawing.Color.Olive;
            this.gbReplaceLicenseReasons.Location = new System.Drawing.Point(13, 364);
            this.gbReplaceLicenseReasons.Name = "gbReplaceLicenseReasons";
            this.gbReplaceLicenseReasons.Size = new System.Drawing.Size(746, 46);
            this.gbReplaceLicenseReasons.TabIndex = 4;
            this.gbReplaceLicenseReasons.TabStop = false;
            this.gbReplaceLicenseReasons.Text = "Replacement For";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbOldLicenseID);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbRenewedlLicenseID);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbApplicationID);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox11);
            this.groupBox1.Controls.Add(this.lbApplicationDate);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.lbUserName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.lbLicenseFees);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.lbApplicationFees);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbTotalFees);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 168);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info";
            // 
            // lbOldLicenseID
            // 
            this.lbOldLicenseID.AutoSize = true;
            this.lbOldLicenseID.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.lbOldLicenseID.ForeColor = System.Drawing.Color.DimGray;
            this.lbOldLicenseID.Location = new System.Drawing.Point(627, 68);
            this.lbOldLicenseID.Name = "lbOldLicenseID";
            this.lbOldLicenseID.Size = new System.Drawing.Size(77, 19);
            this.lbOldLicenseID.TabIndex = 165;
            this.lbOldLicenseID.Text = "[??????]";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::UserInterface.Properties.Resources.LocalDriving_License;
            this.pictureBox6.Location = new System.Drawing.Point(581, 61);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 164;
            this.pictureBox6.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(400, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 19);
            this.label9.TabIndex = 163;
            this.label9.Text = "Old License ID";
            // 
            // lbRenewedlLicenseID
            // 
            this.lbRenewedlLicenseID.AutoSize = true;
            this.lbRenewedlLicenseID.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.lbRenewedlLicenseID.ForeColor = System.Drawing.Color.DimGray;
            this.lbRenewedlLicenseID.Location = new System.Drawing.Point(627, 34);
            this.lbRenewedlLicenseID.Name = "lbRenewedlLicenseID";
            this.lbRenewedlLicenseID.Size = new System.Drawing.Size(77, 19);
            this.lbRenewedlLicenseID.TabIndex = 162;
            this.lbRenewedlLicenseID.Text = "[??????]";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UserInterface.Properties.Resources.LocalDriving_License;
            this.pictureBox3.Location = new System.Drawing.Point(580, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 161;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(400, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 19);
            this.label6.TabIndex = 160;
            this.label6.Text = "Replaced License ID";
            // 
            // lbApplicationID
            // 
            this.lbApplicationID.AutoSize = true;
            this.lbApplicationID.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.lbApplicationID.ForeColor = System.Drawing.Color.DimGray;
            this.lbApplicationID.Location = new System.Drawing.Point(198, 34);
            this.lbApplicationID.Name = "lbApplicationID";
            this.lbApplicationID.Size = new System.Drawing.Size(77, 19);
            this.lbApplicationID.TabIndex = 156;
            this.lbApplicationID.Text = "[??????]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserInterface.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(152, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 155;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 154;
            this.label4.Text = "Application ID";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(152, 61);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(32, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 136;
            this.pictureBox11.TabStop = false;
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.lbApplicationDate.ForeColor = System.Drawing.Color.DimGray;
            this.lbApplicationDate.Location = new System.Drawing.Point(198, 68);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(77, 19);
            this.lbApplicationDate.TabIndex = 137;
            this.lbApplicationDate.Text = "[??????]";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(6, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(142, 19);
            this.label17.TabIndex = 135;
            this.label17.Text = "Application Date";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::UserInterface.Properties.Resources.User_32__2;
            this.pictureBox7.Location = new System.Drawing.Point(581, 129);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 133;
            this.pictureBox7.TabStop = false;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.lbUserName.ForeColor = System.Drawing.Color.DimGray;
            this.lbUserName.Location = new System.Drawing.Point(627, 136);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(77, 19);
            this.lbUserName.TabIndex = 134;
            this.lbUserName.Text = "[??????]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(400, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 19);
            this.label12.TabIndex = 132;
            this.label12.Text = "Created By";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::UserInterface.Properties.Resources.money_32;
            this.pictureBox9.Location = new System.Drawing.Point(152, 129);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 130;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::UserInterface.Properties.Resources.money_32;
            this.pictureBox5.Location = new System.Drawing.Point(152, 95);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 130;
            this.pictureBox5.TabStop = false;
            // 
            // lbLicenseFees
            // 
            this.lbLicenseFees.AutoSize = true;
            this.lbLicenseFees.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.lbLicenseFees.ForeColor = System.Drawing.Color.DimGray;
            this.lbLicenseFees.Location = new System.Drawing.Point(198, 136);
            this.lbLicenseFees.Name = "lbLicenseFees";
            this.lbLicenseFees.Size = new System.Drawing.Size(77, 19);
            this.lbLicenseFees.TabIndex = 131;
            this.lbLicenseFees.Text = "[??????]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::UserInterface.Properties.Resources.money_32;
            this.pictureBox4.Location = new System.Drawing.Point(581, 95);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 130;
            this.pictureBox4.TabStop = false;
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.lbApplicationFees.ForeColor = System.Drawing.Color.DimGray;
            this.lbApplicationFees.Location = new System.Drawing.Point(198, 102);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(77, 19);
            this.lbApplicationFees.TabIndex = 131;
            this.lbApplicationFees.Text = "[??????]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 19);
            this.label7.TabIndex = 129;
            this.label7.Text = "License Fees";
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotalFees.ForeColor = System.Drawing.Color.DimGray;
            this.lbTotalFees.Location = new System.Drawing.Point(627, 102);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(77, 19);
            this.lbTotalFees.TabIndex = 131;
            this.lbTotalFees.Text = "[??????]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 129;
            this.label1.Text = "Application Fees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(400, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 129;
            this.label5.Text = "Total Fees";
            // 
            // btnShowLicensesHistory
            // 
            this.btnShowLicensesHistory.BackColor = System.Drawing.Color.White;
            this.btnShowLicensesHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowLicensesHistory.Enabled = false;
            this.btnShowLicensesHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowLicensesHistory.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.btnShowLicensesHistory.ForeColor = System.Drawing.Color.Olive;
            this.btnShowLicensesHistory.Image = global::UserInterface.Properties.Resources.PersonLicenseHistory_32;
            this.btnShowLicensesHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowLicensesHistory.Location = new System.Drawing.Point(12, 581);
            this.btnShowLicensesHistory.Name = "btnShowLicensesHistory";
            this.btnShowLicensesHistory.Size = new System.Drawing.Size(231, 36);
            this.btnShowLicensesHistory.TabIndex = 123;
            this.btnShowLicensesHistory.Text = "         Show Licenses History";
            this.btnShowLicensesHistory.UseVisualStyleBackColor = false;
            this.btnShowLicensesHistory.Click += new System.EventHandler(this.btnShowLicensesHistory_Click);
            // 
            // btnShowLicenseInfo
            // 
            this.btnShowLicenseInfo.BackColor = System.Drawing.Color.White;
            this.btnShowLicenseInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowLicenseInfo.Enabled = false;
            this.btnShowLicenseInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowLicenseInfo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.btnShowLicenseInfo.ForeColor = System.Drawing.Color.Olive;
            this.btnShowLicenseInfo.Image = global::UserInterface.Properties.Resources.License_View_32;
            this.btnShowLicenseInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowLicenseInfo.Location = new System.Drawing.Point(271, 581);
            this.btnShowLicenseInfo.Name = "btnShowLicenseInfo";
            this.btnShowLicenseInfo.Size = new System.Drawing.Size(231, 36);
            this.btnShowLicenseInfo.TabIndex = 122;
            this.btnShowLicenseInfo.Text = "         Show License Info";
            this.btnShowLicenseInfo.UseVisualStyleBackColor = false;
            this.btnShowLicenseInfo.Click += new System.EventHandler(this.btnShowLicenseInfo_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.White;
            this.btnIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssue.Enabled = false;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIssue.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIssue.Image = global::UserInterface.Properties.Resources.LocalDriving_License;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(657, 581);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(99, 36);
            this.btnIssue.TabIndex = 121;
            this.btnIssue.Text = "       Issue";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Image = global::UserInterface.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(530, 581);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 36);
            this.btnClose.TabIndex = 120;
            this.btnClose.Text = "       Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ReplaceLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 620);
            this.Controls.Add(this.btnShowLicensesHistory);
            this.Controls.Add(this.btnShowLicenseInfo);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbReplaceLicenseReasons);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uC_LocalLicenseCardWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplaceLicenseForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ReplaceLicenseForm_Load);
            this.gbReplaceLicenseReasons.ResumeLayout(false);
            this.gbReplaceLicenseReasons.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC_LocalLicenseCardWithFilter uC_LocalLicenseCardWithFilter1;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.RadioButton rbDamagedLicense;
        private System.Windows.Forms.GroupBox gbReplaceLicenseReasons;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbOldLicenseID;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbRenewedlLicenseID;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbApplicationID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lbLicenseFees;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnShowLicensesHistory;
        private System.Windows.Forms.Button btnShowLicenseInfo;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnClose;
    }
}