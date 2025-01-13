namespace UserInterface
{
    partial class ShowLocalDrivingLicenseApplicationInfoForm
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
            this.uC_LocalDrivingLicenseApplicationInfo1 = new UserInterface.UC_LocalDrivingLicenseApplicationInfo();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uC_LocalDrivingLicenseApplicationInfo1
            // 
            this.uC_LocalDrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.uC_LocalDrivingLicenseApplicationInfo1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_LocalDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(-1, -4);
            this.uC_LocalDrivingLicenseApplicationInfo1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uC_LocalDrivingLicenseApplicationInfo1.Name = "uC_LocalDrivingLicenseApplicationInfo1";
            this.uC_LocalDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(909, 339);
            this.uC_LocalDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.White;
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseForm.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCloseForm.Image = global::UserInterface.Properties.Resources.Close_32;
            this.btnCloseForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseForm.Location = new System.Drawing.Point(784, 334);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(119, 36);
            this.btnCloseForm.TabIndex = 18;
            this.btnCloseForm.Text = "   Close";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // ShowLocalDrivingLicenseApplicationInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 372);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.uC_LocalDrivingLicenseApplicationInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowLocalDrivingLicenseApplicationInfoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ShowLocalDrivingLicenseApplicationInfoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_LocalDrivingLicenseApplicationInfo uC_LocalDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.Button btnCloseForm;
    }
}