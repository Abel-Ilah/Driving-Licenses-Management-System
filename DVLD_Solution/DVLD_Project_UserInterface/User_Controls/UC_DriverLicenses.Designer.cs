namespace DataAccessLayer
{
    partial class UC_DriverLicenses
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDriverLicenses = new System.Windows.Forms.GroupBox();
            this.tbDriverLicenses = new System.Windows.Forms.TabControl();
            this.LocalPage = new System.Windows.Forms.TabPage();
            this.dgvlocalDriverLicenses = new System.Windows.Forms.DataGridView();
            this.contextMenuStripLocalDriverLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLocalLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLocalLicensesCount = new System.Windows.Forms.Label();
            this.InternationalPage = new System.Windows.Forms.TabPage();
            this.dgvInternationalDriverLicenses = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbInternationalLicensesCount = new System.Windows.Forms.Label();
            this.contextMenuStripInternationalDriverLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInternationalLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gbDriverLicenses.SuspendLayout();
            this.tbDriverLicenses.SuspendLayout();
            this.LocalPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlocalDriverLicenses)).BeginInit();
            this.contextMenuStripLocalDriverLicenses.SuspendLayout();
            this.InternationalPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalDriverLicenses)).BeginInit();
            this.contextMenuStripInternationalDriverLicenses.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDriverLicenses
            // 
            this.gbDriverLicenses.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbDriverLicenses.Controls.Add(this.tbDriverLicenses);
            this.gbDriverLicenses.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDriverLicenses.Location = new System.Drawing.Point(3, -2);
            this.gbDriverLicenses.Name = "gbDriverLicenses";
            this.gbDriverLicenses.Size = new System.Drawing.Size(958, 215);
            this.gbDriverLicenses.TabIndex = 0;
            this.gbDriverLicenses.TabStop = false;
            this.gbDriverLicenses.Text = "Driver Licenses";
            // 
            // tbDriverLicenses
            // 
            this.tbDriverLicenses.Controls.Add(this.LocalPage);
            this.tbDriverLicenses.Controls.Add(this.InternationalPage);
            this.tbDriverLicenses.Location = new System.Drawing.Point(6, 26);
            this.tbDriverLicenses.Name = "tbDriverLicenses";
            this.tbDriverLicenses.SelectedIndex = 0;
            this.tbDriverLicenses.Size = new System.Drawing.Size(944, 185);
            this.tbDriverLicenses.TabIndex = 0;
            // 
            // LocalPage
            // 
            this.LocalPage.Controls.Add(this.dgvlocalDriverLicenses);
            this.LocalPage.Controls.Add(this.label1);
            this.LocalPage.Controls.Add(this.label4);
            this.LocalPage.Controls.Add(this.lbLocalLicensesCount);
            this.LocalPage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LocalPage.Location = new System.Drawing.Point(4, 28);
            this.LocalPage.Name = "LocalPage";
            this.LocalPage.Padding = new System.Windows.Forms.Padding(3);
            this.LocalPage.Size = new System.Drawing.Size(936, 153);
            this.LocalPage.TabIndex = 0;
            this.LocalPage.Text = "Local";
            this.LocalPage.UseVisualStyleBackColor = true;
            // 
            // dgvlocalDriverLicenses
            // 
            this.dgvlocalDriverLicenses.AllowUserToAddRows = false;
            this.dgvlocalDriverLicenses.AllowUserToDeleteRows = false;
            this.dgvlocalDriverLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlocalDriverLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvlocalDriverLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlocalDriverLicenses.ContextMenuStrip = this.contextMenuStripLocalDriverLicenses;
            this.dgvlocalDriverLicenses.Location = new System.Drawing.Point(11, 26);
            this.dgvlocalDriverLicenses.Name = "dgvlocalDriverLicenses";
            this.dgvlocalDriverLicenses.ReadOnly = true;
            this.dgvlocalDriverLicenses.Size = new System.Drawing.Size(915, 104);
            this.dgvlocalDriverLicenses.TabIndex = 1;
            // 
            // contextMenuStripLocalDriverLicenses
            // 
            this.contextMenuStripLocalDriverLicenses.BackColor = System.Drawing.Color.White;
            this.contextMenuStripLocalDriverLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLocalLicenseDetailsToolStripMenuItem,
            this.toolStripSeparator1});
            this.contextMenuStripLocalDriverLicenses.Name = "contextMenuStripPeople";
            this.contextMenuStripLocalDriverLicenses.Size = new System.Drawing.Size(264, 48);
            this.contextMenuStripLocalDriverLicenses.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripLocalDriverLicenses_Opening);
            // 
            // showLocalLicenseDetailsToolStripMenuItem
            // 
            this.showLocalLicenseDetailsToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLocalLicenseDetailsToolStripMenuItem.Image = global::UserInterface.Properties.Resources.License_View_32;
            this.showLocalLicenseDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLocalLicenseDetailsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.showLocalLicenseDetailsToolStripMenuItem.Name = "showLocalLicenseDetailsToolStripMenuItem";
            this.showLocalLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(263, 38);
            this.showLocalLicenseDetailsToolStripMenuItem.Text = "Show License  Details";
            this.showLocalLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLocalLicenseDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(260, 6);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local Licenses History:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(9, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "# Records : ";
            // 
            // lbLocalLicensesCount
            // 
            this.lbLocalLicensesCount.AutoSize = true;
            this.lbLocalLicensesCount.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalLicensesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbLocalLicensesCount.Location = new System.Drawing.Point(144, 127);
            this.lbLocalLicensesCount.Name = "lbLocalLicensesCount";
            this.lbLocalLicensesCount.Size = new System.Drawing.Size(24, 25);
            this.lbLocalLicensesCount.TabIndex = 30;
            this.lbLocalLicensesCount.Text = "0";
            // 
            // InternationalPage
            // 
            this.InternationalPage.BackColor = System.Drawing.Color.White;
            this.InternationalPage.Controls.Add(this.dgvInternationalDriverLicenses);
            this.InternationalPage.Controls.Add(this.label5);
            this.InternationalPage.Controls.Add(this.label3);
            this.InternationalPage.Controls.Add(this.lbInternationalLicensesCount);
            this.InternationalPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InternationalPage.Location = new System.Drawing.Point(4, 28);
            this.InternationalPage.Name = "InternationalPage";
            this.InternationalPage.Padding = new System.Windows.Forms.Padding(3);
            this.InternationalPage.Size = new System.Drawing.Size(936, 153);
            this.InternationalPage.TabIndex = 1;
            this.InternationalPage.Text = "International";
            // 
            // dgvInternationalDriverLicenses
            // 
            this.dgvInternationalDriverLicenses.AllowUserToAddRows = false;
            this.dgvInternationalDriverLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalDriverLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInternationalDriverLicenses.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalDriverLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInternationalDriverLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalDriverLicenses.ContextMenuStrip = this.contextMenuStripInternationalDriverLicenses;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternationalDriverLicenses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInternationalDriverLicenses.Location = new System.Drawing.Point(11, 26);
            this.dgvInternationalDriverLicenses.Name = "dgvInternationalDriverLicenses";
            this.dgvInternationalDriverLicenses.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalDriverLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInternationalDriverLicenses.Size = new System.Drawing.Size(915, 104);
            this.dgvInternationalDriverLicenses.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(11, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "International Licenses History:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "# Records : ";
            // 
            // lbInternationalLicensesCount
            // 
            this.lbInternationalLicensesCount.AutoSize = true;
            this.lbInternationalLicensesCount.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInternationalLicensesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbInternationalLicensesCount.Location = new System.Drawing.Point(145, 127);
            this.lbInternationalLicensesCount.Name = "lbInternationalLicensesCount";
            this.lbInternationalLicensesCount.Size = new System.Drawing.Size(24, 25);
            this.lbInternationalLicensesCount.TabIndex = 34;
            this.lbInternationalLicensesCount.Text = "0";
            // 
            // contextMenuStripInternationalDriverLicenses
            // 
            this.contextMenuStripInternationalDriverLicenses.BackColor = System.Drawing.Color.White;
            this.contextMenuStripInternationalDriverLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInternationalLicenseDetailsToolStripMenuItem,
            this.toolStripSeparator2});
            this.contextMenuStripInternationalDriverLicenses.Name = "contextMenuStripPeople";
            this.contextMenuStripInternationalDriverLicenses.Size = new System.Drawing.Size(260, 48);
            this.contextMenuStripInternationalDriverLicenses.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripInternationalDriverLicenses_Opening);
            // 
            // showInternationalLicenseDetailsToolStripMenuItem
            // 
            this.showInternationalLicenseDetailsToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showInternationalLicenseDetailsToolStripMenuItem.Image = global::UserInterface.Properties.Resources.License_View_32;
            this.showInternationalLicenseDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showInternationalLicenseDetailsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.showInternationalLicenseDetailsToolStripMenuItem.Name = "showInternationalLicenseDetailsToolStripMenuItem";
            this.showInternationalLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(259, 38);
            this.showInternationalLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showInternationalLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showInternationalLicenseDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(256, 6);
            // 
            // UC_DriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbDriverLicenses);
            this.Name = "UC_DriverLicenses";
            this.Size = new System.Drawing.Size(968, 210);
            this.gbDriverLicenses.ResumeLayout(false);
            this.tbDriverLicenses.ResumeLayout(false);
            this.LocalPage.ResumeLayout(false);
            this.LocalPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlocalDriverLicenses)).EndInit();
            this.contextMenuStripLocalDriverLicenses.ResumeLayout(false);
            this.InternationalPage.ResumeLayout(false);
            this.InternationalPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalDriverLicenses)).EndInit();
            this.contextMenuStripInternationalDriverLicenses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDriverLicenses;
        private System.Windows.Forms.TabControl tbDriverLicenses;
        private System.Windows.Forms.TabPage LocalPage;
        private System.Windows.Forms.TabPage InternationalPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvlocalDriverLicenses;
        private System.Windows.Forms.Label lbLocalLicensesCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbInternationalLicensesCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvInternationalDriverLicenses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLocalDriverLicenses;
        private System.Windows.Forms.ToolStripMenuItem showLocalLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripInternationalDriverLicenses;
        private System.Windows.Forms.ToolStripMenuItem showInternationalLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
