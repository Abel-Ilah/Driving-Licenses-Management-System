namespace UserInterface
{
    partial class DetainLicenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetainLicenseForm));
            this.uC_LocalLicenseCardWithFilter1 = new UserInterface.UC_LocalLicenseCardWithFilter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbFineFees = new System.Windows.Forms.TextBox();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDetainID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.lbDetainDate = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowLicensesHistory = new System.Windows.Forms.Button();
            this.btnShowLicenseInfo = new System.Windows.Forms.Button();
            this.btnDetain = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // uC_LocalLicenseCardWithFilter1
            // 
            this.uC_LocalLicenseCardWithFilter1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.uC_LocalLicenseCardWithFilter1, "uC_LocalLicenseCardWithFilter1");
            this.uC_LocalLicenseCardWithFilter1.Name = "uC_LocalLicenseCardWithFilter1";
            this.uC_LocalLicenseCardWithFilter1.WhenLicenseIsFound += new System.Action<int>(this.uC_LocalLicenseCardWithFilter1_WhenLicenseIsFound);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbFineFees);
            this.groupBox1.Controls.Add(this.lbLicenseID);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbDetainID);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox11);
            this.groupBox1.Controls.Add(this.lbDetainDate);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.lbUserName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txtbFineFees
            // 
            resources.ApplyResources(this.txtbFineFees, "txtbFineFees");
            this.txtbFineFees.Name = "txtbFineFees";
            this.txtbFineFees.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbFineFees_KeyDown);
            this.txtbFineFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFineFees_KeyPress);
            // 
            // lbLicenseID
            // 
            resources.ApplyResources(this.lbLicenseID, "lbLicenseID");
            this.lbLicenseID.ForeColor = System.Drawing.Color.DimGray;
            this.lbLicenseID.Name = "lbLicenseID";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UserInterface.Properties.Resources.LocalDriving_License;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            // 
            // lbDetainID
            // 
            resources.ApplyResources(this.lbDetainID, "lbDetainID");
            this.lbDetainID.ForeColor = System.Drawing.Color.DimGray;
            this.lbDetainID.Name = "lbDetainID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserInterface.Properties.Resources.Number_32;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // pictureBox11
            // 
            resources.ApplyResources(this.pictureBox11, "pictureBox11");
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.TabStop = false;
            // 
            // lbDetainDate
            // 
            resources.ApplyResources(this.lbDetainDate, "lbDetainDate");
            this.lbDetainDate.ForeColor = System.Drawing.Color.DimGray;
            this.lbDetainDate.Name = "lbDetainDate";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Name = "label17";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::UserInterface.Properties.Resources.User_32__2;
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // lbUserName
            // 
            resources.ApplyResources(this.lbUserName, "lbUserName");
            this.lbUserName.ForeColor = System.Drawing.Color.DimGray;
            this.lbUserName.Name = "lbUserName";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Name = "label12";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::UserInterface.Properties.Resources.money_32;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // btnShowLicensesHistory
            // 
            this.btnShowLicensesHistory.BackColor = System.Drawing.Color.White;
            this.btnShowLicensesHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnShowLicensesHistory, "btnShowLicensesHistory");
            this.btnShowLicensesHistory.ForeColor = System.Drawing.Color.Olive;
            this.btnShowLicensesHistory.Image = global::UserInterface.Properties.Resources.PersonLicenseHistory_32;
            this.btnShowLicensesHistory.Name = "btnShowLicensesHistory";
            this.btnShowLicensesHistory.UseVisualStyleBackColor = false;
            this.btnShowLicensesHistory.Click += new System.EventHandler(this.btnShowLicensesHistory_Click);
            // 
            // btnShowLicenseInfo
            // 
            this.btnShowLicenseInfo.BackColor = System.Drawing.Color.White;
            this.btnShowLicenseInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnShowLicenseInfo, "btnShowLicenseInfo");
            this.btnShowLicenseInfo.ForeColor = System.Drawing.Color.Olive;
            this.btnShowLicenseInfo.Image = global::UserInterface.Properties.Resources.License_View_32;
            this.btnShowLicenseInfo.Name = "btnShowLicenseInfo";
            this.btnShowLicenseInfo.UseVisualStyleBackColor = false;
            this.btnShowLicenseInfo.Click += new System.EventHandler(this.btnShowLicenseInfo_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.BackColor = System.Drawing.Color.White;
            this.btnDetain.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnDetain, "btnDetain");
            this.btnDetain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDetain.Image = global::UserInterface.Properties.Resources.LocalDriving_License;
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.UseVisualStyleBackColor = false;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Image = global::UserInterface.Properties.Resources.Close_32;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DetainLicenseForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnShowLicensesHistory);
            this.Controls.Add(this.btnShowLicenseInfo);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uC_LocalLicenseCardWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetainLicenseForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.DetainLicenseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC_LocalLicenseCardWithFilter uC_LocalLicenseCardWithFilter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbFineFees;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDetainID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label lbDetainDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowLicensesHistory;
        private System.Windows.Forms.Button btnShowLicenseInfo;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.Button btnClose;
    }
}