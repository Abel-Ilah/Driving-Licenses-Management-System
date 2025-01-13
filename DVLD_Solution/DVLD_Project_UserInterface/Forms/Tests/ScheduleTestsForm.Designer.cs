namespace DataAccessLayer
{
    partial class ScheduleTestsForm
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
            this.uC_AddOrEditTestAppointment1 = new UserInterface.UC_AddOrEditTestAppointment();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uC_AddOrEditTestAppointment1
            // 
            this.uC_AddOrEditTestAppointment1.BackColor = System.Drawing.Color.White;
            this.uC_AddOrEditTestAppointment1.Location = new System.Drawing.Point(0, -1);
            this.uC_AddOrEditTestAppointment1.Name = "uC_AddOrEditTestAppointment1";
            this.uC_AddOrEditTestAppointment1.Size = new System.Drawing.Size(662, 619);
            this.uC_AddOrEditTestAppointment1.TabIndex = 0;
            this.uC_AddOrEditTestAppointment1.WhenAppointmentSaved += new System.Action<bool>(this.uC_AddOrEditTestAppointment1_WhenAppointmentSaved);
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
            this.btnClose.Location = new System.Drawing.Point(384, 576);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 36);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "   Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ScheduleTestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 616);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.uC_AddOrEditTestAppointment1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScheduleTestsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ScheduleTestsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserInterface.UC_AddOrEditTestAppointment uC_AddOrEditTestAppointment1;
        private System.Windows.Forms.Button btnClose;
    }
}