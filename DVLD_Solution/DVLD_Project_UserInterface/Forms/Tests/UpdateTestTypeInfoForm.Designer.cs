﻿namespace UserInterface
{
    partial class UpdateTestTypeInfoForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMode = new System.Windows.Forms.Label();
            this.txtbFees = new System.Windows.Forms.TextBox();
            this.txtbTitle = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 83;
            this.label3.Text = "Fees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 82;
            this.label2.Text = "Title";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(188, 41);
            this.lbID.Name = "lbID";
            this.lbID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbID.Size = new System.Drawing.Size(55, 25);
            this.lbID.TabIndex = 81;
            this.lbID.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 80;
            this.label1.Text = "ID ";
            // 
            // lbMode
            // 
            this.lbMode.AutoSize = true;
            this.lbMode.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold);
            this.lbMode.ForeColor = System.Drawing.Color.Red;
            this.lbMode.Location = new System.Drawing.Point(83, -3);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(290, 32);
            this.lbMode.TabIndex = 79;
            this.lbMode.Text = "Update Test Type";
            this.lbMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbFees
            // 
            this.txtbFees.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFees.Location = new System.Drawing.Point(188, 236);
            this.txtbFees.MaxLength = 20;
            this.txtbFees.Name = "txtbFees";
            this.txtbFees.Size = new System.Drawing.Size(272, 25);
            this.txtbFees.TabIndex = 3;
            this.txtbFees.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.txtbFees.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbFees_KeyDown);
            this.txtbFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFees_KeyPress);
            // 
            // txtbTitle
            // 
            this.txtbTitle.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTitle.Location = new System.Drawing.Point(188, 75);
            this.txtbTitle.MaxLength = 99;
            this.txtbTitle.Name = "txtbTitle";
            this.txtbTitle.Size = new System.Drawing.Size(272, 25);
            this.txtbTitle.TabIndex = 1;
            this.txtbTitle.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
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
            this.btnClose.Location = new System.Drawing.Point(188, 268);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 36);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "   Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Image = global::UserInterface.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(341, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UserInterface.Properties.Resources.money_32;
            this.pictureBox2.Location = new System.Drawing.Point(148, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 84;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserInterface.Properties.Resources.ApplicationTitle;
            this.pictureBox1.Location = new System.Drawing.Point(148, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::UserInterface.Properties.Resources.Number_32;
            this.pictureBox10.Location = new System.Drawing.Point(148, 42);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(25, 25);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 86;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UserInterface.Properties.Resources.ApplicationTitle;
            this.pictureBox3.Location = new System.Drawing.Point(148, 108);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 89;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 88;
            this.label4.Text = "Description";
            // 
            // txtbDescription
            // 
            this.txtbDescription.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDescription.Location = new System.Drawing.Point(188, 108);
            this.txtbDescription.MaxLength = 499;
            this.txtbDescription.Multiline = true;
            this.txtbDescription.Name = "txtbDescription";
            this.txtbDescription.Size = new System.Drawing.Size(272, 120);
            this.txtbDescription.TabIndex = 2;
            this.txtbDescription.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // UpdateTestTypeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 307);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbDescription);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMode);
            this.Controls.Add(this.txtbFees);
            this.Controls.Add(this.txtbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateTestTypeInfoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UpdateTestTypeInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.TextBox txtbFees;
        private System.Windows.Forms.TextBox txtbTitle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbDescription;
    }
}