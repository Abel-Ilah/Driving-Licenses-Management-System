namespace UserInterface
{
    partial class LicensesHistoryForm
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
            this.lbMode = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.uC_DriverLicenses1 = new DataAccessLayer.UC_DriverLicenses();
            this.uC_PersonInfoWithFilter1 = new UserInterface.UC_PersonInfoWithFilter();
            this.SuspendLayout();
            // 
            // lbMode
            // 
            this.lbMode.Font = new System.Drawing.Font("Rockwell Extra Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMode.ForeColor = System.Drawing.Color.Red;
            this.lbMode.Location = new System.Drawing.Point(287, -6);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(388, 39);
            this.lbMode.TabIndex = 57;
            this.lbMode.Text = "License History";
            this.lbMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnClose.Location = new System.Drawing.Point(855, 643);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 36);
            this.btnClose.TabIndex = 153;
            this.btnClose.Text = "   Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // uC_DriverLicenses1
            // 
            this.uC_DriverLicenses1.BackColor = System.Drawing.Color.White;
            this.uC_DriverLicenses1.Location = new System.Drawing.Point(12, 425);
            this.uC_DriverLicenses1.Name = "uC_DriverLicenses1";
            this.uC_DriverLicenses1.Size = new System.Drawing.Size(968, 212);
            this.uC_DriverLicenses1.TabIndex = 58;
            // 
            // uC_PersonInfoWithFilter1
            // 
            this.uC_PersonInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.uC_PersonInfoWithFilter1.Location = new System.Drawing.Point(53, 26);
            this.uC_PersonInfoWithFilter1.Name = "uC_PersonInfoWithFilter1";
            this.uC_PersonInfoWithFilter1.Size = new System.Drawing.Size(894, 403);
            this.uC_PersonInfoWithFilter1.TabIndex = 0;
            // 
            // ShowDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 681);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.uC_DriverLicenses1);
            this.Controls.Add(this.lbMode);
            this.Controls.Add(this.uC_PersonInfoWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowDriverLicenses";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ShowDriverLicenses_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_PersonInfoWithFilter uC_PersonInfoWithFilter1;
        private System.Windows.Forms.Label lbMode;
        private DataAccessLayer.UC_DriverLicenses uC_DriverLicenses1;
        private System.Windows.Forms.Button btnClose;
    }
}