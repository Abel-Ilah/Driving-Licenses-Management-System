namespace UserInterface
{
    partial class FormSelectTypeOfLicenseToAdd
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
            this.pbInternationalDrivingLicense = new System.Windows.Forms.PictureBox();
            this.pbLocalDrivingLicense = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbInternationalDrivingLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalDrivingLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // pbInternationalDrivingLicense
            // 
            this.pbInternationalDrivingLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInternationalDrivingLicense.Image = global::UserInterface.Properties.Resources.InternationalDrivingLicenseLogo;
            this.pbInternationalDrivingLicense.Location = new System.Drawing.Point(386, 15);
            this.pbInternationalDrivingLicense.Name = "pbInternationalDrivingLicense";
            this.pbInternationalDrivingLicense.Size = new System.Drawing.Size(330, 208);
            this.pbInternationalDrivingLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInternationalDrivingLicense.TabIndex = 1;
            this.pbInternationalDrivingLicense.TabStop = false;
            this.pbInternationalDrivingLicense.Click += new System.EventHandler(this.pbInternationalDrivingLicense_Click);
            this.pbInternationalDrivingLicense.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pbInternationalDrivingLicense.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // pbLocalDrivingLicense
            // 
            this.pbLocalDrivingLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLocalDrivingLicense.Image = global::UserInterface.Properties.Resources.LocalDrivingLicenseLogo;
            this.pbLocalDrivingLicense.Location = new System.Drawing.Point(20, 15);
            this.pbLocalDrivingLicense.Name = "pbLocalDrivingLicense";
            this.pbLocalDrivingLicense.Size = new System.Drawing.Size(330, 208);
            this.pbLocalDrivingLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLocalDrivingLicense.TabIndex = 0;
            this.pbLocalDrivingLicense.TabStop = false;
            this.pbLocalDrivingLicense.Click += new System.EventHandler(this.pbLocalDrivingLicense_Click);
            this.pbLocalDrivingLicense.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pbLocalDrivingLicense.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // FormSelectTypeOfLicenseToAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(734, 240);
            this.Controls.Add(this.pbInternationalDrivingLicense);
            this.Controls.Add(this.pbLocalDrivingLicense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectTypeOfLicenseToAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbInternationalDrivingLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalDrivingLicense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLocalDrivingLicense;
        private System.Windows.Forms.PictureBox pbInternationalDrivingLicense;
    }
}