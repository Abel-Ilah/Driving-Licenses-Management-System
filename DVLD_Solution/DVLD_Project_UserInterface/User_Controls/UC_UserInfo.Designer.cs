namespace UserInterface
{
    partial class UC_UserInfo
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
            this.gbUserLoginInfo = new System.Windows.Forms.GroupBox();
            this.lbAccountStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.uC_PersonInfo1 = new UserInterface.UC_PersonInfo();
            this.gbUserLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUserLoginInfo
            // 
            this.gbUserLoginInfo.Controls.Add(this.lbAccountStatus);
            this.gbUserLoginInfo.Controls.Add(this.label3);
            this.gbUserLoginInfo.Controls.Add(this.lbUserName);
            this.gbUserLoginInfo.Controls.Add(this.label2);
            this.gbUserLoginInfo.Controls.Add(this.lbUserID);
            this.gbUserLoginInfo.Controls.Add(this.label13);
            this.gbUserLoginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.gbUserLoginInfo.Location = new System.Drawing.Point(3, 332);
            this.gbUserLoginInfo.Name = "gbUserLoginInfo";
            this.gbUserLoginInfo.Size = new System.Drawing.Size(886, 72);
            this.gbUserLoginInfo.TabIndex = 1;
            this.gbUserLoginInfo.TabStop = false;
            this.gbUserLoginInfo.Text = "Login Information";
            // 
            // lbAccountStatus
            // 
            this.lbAccountStatus.AutoSize = true;
            this.lbAccountStatus.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.lbAccountStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbAccountStatus.Location = new System.Drawing.Point(750, 35);
            this.lbAccountStatus.Name = "lbAccountStatus";
            this.lbAccountStatus.Size = new System.Drawing.Size(108, 19);
            this.lbAccountStatus.TabIndex = 110;
            this.lbAccountStatus.Text = "???????????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(617, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 109;
            this.label3.Text = "Account Status :";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.lbUserName.ForeColor = System.Drawing.Color.Red;
            this.lbUserName.Location = new System.Drawing.Point(392, 35);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(108, 19);
            this.lbUserName.TabIndex = 108;
            this.lbUserName.Text = "???????????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(292, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 107;
            this.label2.Text = "User Name :";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.lbUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbUserID.Location = new System.Drawing.Point(104, 35);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(108, 19);
            this.lbUserID.TabIndex = 106;
            this.lbUserID.Text = "???????????";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(28, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 19);
            this.label13.TabIndex = 99;
            this.label13.Text = "User ID :";
            // 
            // uC_PersonInfo1
            // 
            this.uC_PersonInfo1.BackColor = System.Drawing.Color.White;
            this.uC_PersonInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uC_PersonInfo1.Location = new System.Drawing.Point(-1, -5);
            this.uC_PersonInfo1.Name = "uC_PersonInfo1";
            this.uC_PersonInfo1.Size = new System.Drawing.Size(894, 342);
            this.uC_PersonInfo1.TabIndex = 2;
            // 
            // UC_UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbUserLoginInfo);
            this.Controls.Add(this.uC_PersonInfo1);
            this.Name = "UC_UserInfo";
            this.Size = new System.Drawing.Size(892, 410);
            this.gbUserLoginInfo.ResumeLayout(false);
            this.gbUserLoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbUserLoginInfo;
        private UC_PersonInfo uC_PersonInfo1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbAccountStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUserID;
    }
}
