namespace UserInterface
{
    partial class TestsAppointmentsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTestType = new System.Windows.Forms.Label();
            this.dgvTestAppointments = new System.Windows.Forms.DataGridView();
            this.contextMenuStripAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label9 = new System.Windows.Forms.Label();
            this.lbNumberOfAppointments = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uC_LocalDrivingLicenseApplicationCard = new UserInterface.UC_LocalDrivingLicenseApplicationInfo();
            this.xxxx = new UserInterface.UC_LocalDrivingLicenseApplicationInfo();
            this.pbTestType = new System.Windows.Forms.PictureBox();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).BeginInit();
            this.contextMenuStripAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestType)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTestType
            // 
            this.lbTestType.AutoSize = true;
            this.lbTestType.Font = new System.Drawing.Font("Rockwell Extra Bold", 22F, System.Drawing.FontStyle.Bold);
            this.lbTestType.ForeColor = System.Drawing.Color.Red;
            this.lbTestType.Location = new System.Drawing.Point(219, 116);
            this.lbTestType.Name = "lbTestType";
            this.lbTestType.Size = new System.Drawing.Size(458, 35);
            this.lbTestType.TabIndex = 27;
            this.lbTestType.Text = "Vision Test Appointment";
            // 
            // dgvTestAppointments
            // 
            this.dgvTestAppointments.AllowUserToAddRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvTestAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTestAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestAppointments.ContextMenuStrip = this.contextMenuStripAppointments;
            this.dgvTestAppointments.GridColor = System.Drawing.Color.Black;
            this.dgvTestAppointments.Location = new System.Drawing.Point(5, 526);
            this.dgvTestAppointments.MultiSelect = false;
            this.dgvTestAppointments.Name = "dgvTestAppointments";
            this.dgvTestAppointments.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvTestAppointments.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTestAppointments.Size = new System.Drawing.Size(904, 122);
            this.dgvTestAppointments.TabIndex = 28;
            // 
            // contextMenuStripAppointments
            // 
            this.contextMenuStripAppointments.BackColor = System.Drawing.Color.White;
            this.contextMenuStripAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditAppointmentToolStripMenuItem,
            this.TakeTestToolStripMenuItem,
            this.toolStripSeparator1});
            this.contextMenuStripAppointments.Name = "contextMenuStripPeople";
            this.contextMenuStripAppointments.Size = new System.Drawing.Size(233, 108);
            this.contextMenuStripAppointments.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripAppointments_Opening);
            // 
            // EditAppointmentToolStripMenuItem
            // 
            this.EditAppointmentToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditAppointmentToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAppointmentToolStripMenuItem.Image = global::UserInterface.Properties.Resources.edit_32;
            this.EditAppointmentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditAppointmentToolStripMenuItem.Name = "EditAppointmentToolStripMenuItem";
            this.EditAppointmentToolStripMenuItem.Size = new System.Drawing.Size(232, 38);
            this.EditAppointmentToolStripMenuItem.Text = "Edit Appointment";
            this.EditAppointmentToolStripMenuItem.Click += new System.EventHandler(this.EditAppointmentToolStripMenuItem_Click);
            // 
            // TakeTestToolStripMenuItem
            // 
            this.TakeTestToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.TakeTestToolStripMenuItem.Image = global::UserInterface.Properties.Resources.Test_32;
            this.TakeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TakeTestToolStripMenuItem.Name = "TakeTestToolStripMenuItem";
            this.TakeTestToolStripMenuItem.Size = new System.Drawing.Size(232, 38);
            this.TakeTestToolStripMenuItem.Text = "Take Test";
            this.TakeTestToolStripMenuItem.Click += new System.EventHandler(this.TakeTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Olive;
            this.label9.Location = new System.Drawing.Point(3, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 22);
            this.label9.TabIndex = 110;
            this.label9.Text = "Appointments :";
            // 
            // lbNumberOfAppointments
            // 
            this.lbNumberOfAppointments.AutoSize = true;
            this.lbNumberOfAppointments.Font = new System.Drawing.Font("Rockwell Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfAppointments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbNumberOfAppointments.Location = new System.Drawing.Point(141, 658);
            this.lbNumberOfAppointments.Name = "lbNumberOfAppointments";
            this.lbNumberOfAppointments.Size = new System.Drawing.Size(62, 22);
            this.lbNumberOfAppointments.TabIndex = 112;
            this.lbNumberOfAppointments.Text = "0000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(6, 658);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 22);
            this.label4.TabIndex = 111;
            this.label4.Text = "# Records : ";
            // 
            // uC_LocalDrivingLicenseApplicationInfo2
            // 
            this.uC_LocalDrivingLicenseApplicationCard.BackColor = System.Drawing.Color.White;
            this.uC_LocalDrivingLicenseApplicationCard.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_LocalDrivingLicenseApplicationCard.Location = new System.Drawing.Point(0, 145);
            this.uC_LocalDrivingLicenseApplicationCard.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uC_LocalDrivingLicenseApplicationCard.Name = "uC_LocalDrivingLicenseApplicationInfo2";
            this.uC_LocalDrivingLicenseApplicationCard.Size = new System.Drawing.Size(909, 339);
            this.uC_LocalDrivingLicenseApplicationCard.TabIndex = 115;
            // 
            // uC_LocalDrivingLicenseApplicationInfo1
            // 
            this.xxxx.BackColor = System.Drawing.Color.White;
            this.xxxx.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xxxx.Location = new System.Drawing.Point(2, 146);
            this.xxxx.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.xxxx.Name = "uC_LocalDrivingLicenseApplicationInfo1";
            this.xxxx.Size = new System.Drawing.Size(909, 339);
            this.xxxx.TabIndex = 115;
            // 
            // pbTestType
            // 
            this.pbTestType.Image = global::UserInterface.Properties.Resources.driving_test_512;
            this.pbTestType.Location = new System.Drawing.Point(374, -1);
            this.pbTestType.Name = "pbTestType";
            this.pbTestType.Size = new System.Drawing.Size(148, 126);
            this.pbTestType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTestType.TabIndex = 1;
            this.pbTestType.TabStop = false;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.Color.White;
            this.btnAddAppointment.BackgroundImage = global::UserInterface.Properties.Resources.AddAppointment_32;
            this.btnAddAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAppointment.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnAddAppointment.FlatAppearance.BorderSize = 2;
            this.btnAddAppointment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddAppointment.Location = new System.Drawing.Point(856, 483);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(53, 40);
            this.btnAddAppointment.TabIndex = 114;
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
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
            this.btnCloseForm.Location = new System.Drawing.Point(790, 651);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(119, 36);
            this.btnCloseForm.TabIndex = 113;
            this.btnCloseForm.Text = "   Close";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // TestsAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 688);
            this.Controls.Add(this.pbTestType);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.uC_LocalDrivingLicenseApplicationCard);
            this.Controls.Add(this.lbTestType);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.lbNumberOfAppointments);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvTestAppointments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestsAppointmentsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TestsAppointmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).EndInit();
            this.contextMenuStripAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbTestType;
        private System.Windows.Forms.Label lbTestType;
        private System.Windows.Forms.DataGridView dgvTestAppointments;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbNumberOfAppointments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnAddAppointment;
        private UC_LocalDrivingLicenseApplicationInfo xxxx;
        private UC_LocalDrivingLicenseApplicationInfo uC_LocalDrivingLicenseApplicationCard;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAppointments;
        private System.Windows.Forms.ToolStripMenuItem EditAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}