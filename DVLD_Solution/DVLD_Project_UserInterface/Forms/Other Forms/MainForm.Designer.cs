namespace UserInterface
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panelManagePeople = new System.Windows.Forms.Panel();
            this.btnListOfpeople = new System.Windows.Forms.Button();
            this.btnManagePeople = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnDeletePerson = new System.Windows.Forms.Button();
            this.btnUpdatePerson = new System.Windows.Forms.Button();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.PanelApplications = new System.Windows.Forms.Panel();
            this.panelDetainLicenses = new System.Windows.Forms.Panel();
            this.DetainedLicenses = new System.Windows.Forms.Button();
            this.btnDetainLicense = new System.Windows.Forms.Button();
            this.btnReleaseLicense = new System.Windows.Forms.Button();
            this.btnDetainLicenses = new System.Windows.Forms.Button();
            this.btnTestTypes = new System.Windows.Forms.Button();
            this.btnApplicationsTypes = new System.Windows.Forms.Button();
            this.PanelMangeApplications = new System.Windows.Forms.Panel();
            this.btnManageApplications = new System.Windows.Forms.Button();
            this.btnLocalDrivingLicense = new System.Windows.Forms.Button();
            this.btnInternationalDrivingLicense = new System.Windows.Forms.Button();
            this.btnApplications = new System.Windows.Forms.Button();
            this.panelDrivingLicensesServices = new System.Windows.Forms.Panel();
            this.btnReplaceDrivingLicense = new System.Windows.Forms.Button();
            this.btnReleaseDrivingLicense = new System.Windows.Forms.Button();
            this.btnDrivingLicensesServices = new System.Windows.Forms.Button();
            this.BtnNewDrivingLicense = new System.Windows.Forms.Button();
            this.BtnRenewDrivingLicense = new System.Windows.Forms.Button();
            this.panelManageUsers = new System.Windows.Forms.Panel();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnListOfUsers = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnProfileDetails = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lbCurrentUserName = new System.Windows.Forms.Label();
            this.lbCurrentUserFirstName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMinimizeForm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDetainedLicensesCount = new System.Windows.Forms.Label();
            this.lbInternationalLicensesCount = new System.Windows.Forms.Label();
            this.lbLocalLicensesCount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbDriversCount = new System.Windows.Forms.Label();
            this.lbUsersCount = new System.Windows.Forms.Label();
            this.lbPeopleCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbCurrentUserImage = new UserInterface.RoundedPictureBox();
            this.MainPanel.SuspendLayout();
            this.panelManagePeople.SuspendLayout();
            this.PanelApplications.SuspendLayout();
            this.panelDetainLicenses.SuspendLayout();
            this.PanelMangeApplications.SuspendLayout();
            this.panelDrivingLicensesServices.SuspendLayout();
            this.panelManageUsers.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1063, 45);
            this.label1.TabIndex = 1;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveTheFormWithMouse);
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainPanel.Controls.Add(this.btnLogOut);
            this.MainPanel.Controls.Add(this.panelManagePeople);
            this.MainPanel.Controls.Add(this.btnDrivers);
            this.MainPanel.Controls.Add(this.PanelApplications);
            this.MainPanel.Controls.Add(this.panelManageUsers);
            this.MainPanel.Controls.Add(this.panelProfile);
            this.MainPanel.Location = new System.Drawing.Point(-1, -6);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(250, 665);
            this.MainPanel.TabIndex = 2;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::UserInterface.Properties.Resources.logOut30;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 365);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(250, 50);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "       Log out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panelManagePeople
            // 
            this.panelManagePeople.Controls.Add(this.btnListOfpeople);
            this.panelManagePeople.Controls.Add(this.btnManagePeople);
            this.panelManagePeople.Controls.Add(this.btnAddPerson);
            this.panelManagePeople.Controls.Add(this.btnDeletePerson);
            this.panelManagePeople.Controls.Add(this.btnUpdatePerson);
            this.panelManagePeople.Controls.Add(this.btnFindPerson);
            this.panelManagePeople.Location = new System.Drawing.Point(-1, 116);
            this.panelManagePeople.Name = "panelManagePeople";
            this.panelManagePeople.Size = new System.Drawing.Size(250, 50);
            this.panelManagePeople.TabIndex = 6;
            // 
            // btnListOfpeople
            // 
            this.btnListOfpeople.BackColor = System.Drawing.Color.Teal;
            this.btnListOfpeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListOfpeople.FlatAppearance.BorderSize = 0;
            this.btnListOfpeople.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnListOfpeople.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnListOfpeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListOfpeople.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnListOfpeople.ForeColor = System.Drawing.Color.White;
            this.btnListOfpeople.Image = global::UserInterface.Properties.Resources.ApplicationsIcon30;
            this.btnListOfpeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListOfpeople.Location = new System.Drawing.Point(1, 250);
            this.btnListOfpeople.Name = "btnListOfpeople";
            this.btnListOfpeople.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnListOfpeople.Size = new System.Drawing.Size(250, 50);
            this.btnListOfpeople.TabIndex = 7;
            this.btnListOfpeople.Text = "        List Of People";
            this.btnListOfpeople.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListOfpeople.UseVisualStyleBackColor = false;
            this.btnListOfpeople.Click += new System.EventHandler(this.btnListOfPeople_Click);
            // 
            // btnManagePeople
            // 
            this.btnManagePeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManagePeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManagePeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManagePeople.FlatAppearance.BorderSize = 0;
            this.btnManagePeople.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnManagePeople.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnManagePeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagePeople.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.btnManagePeople.ForeColor = System.Drawing.Color.White;
            this.btnManagePeople.Image = global::UserInterface.Properties.Resources.managepeople25;
            this.btnManagePeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagePeople.Location = new System.Drawing.Point(1, 0);
            this.btnManagePeople.Name = "btnManagePeople";
            this.btnManagePeople.Size = new System.Drawing.Size(250, 50);
            this.btnManagePeople.TabIndex = 5;
            this.btnManagePeople.Tag = "SlideIsHided";
            this.btnManagePeople.Text = "       Manage People";
            this.btnManagePeople.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagePeople.UseVisualStyleBackColor = false;
            this.btnManagePeople.Click += new System.EventHandler(this.btnManagePeople_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.Color.Teal;
            this.btnAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPerson.FlatAppearance.BorderSize = 0;
            this.btnAddPerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnAddPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnAddPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddPerson.Image = global::UserInterface.Properties.Resources.addnewPerson30;
            this.btnAddPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPerson.Location = new System.Drawing.Point(1, 50);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddPerson.Size = new System.Drawing.Size(250, 50);
            this.btnAddPerson.TabIndex = 8;
            this.btnAddPerson.Text = "        Add Person";
            this.btnAddPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.BackColor = System.Drawing.Color.Teal;
            this.btnDeletePerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePerson.FlatAppearance.BorderSize = 0;
            this.btnDeletePerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnDeletePerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnDeletePerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePerson.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnDeletePerson.ForeColor = System.Drawing.Color.White;
            this.btnDeletePerson.Image = global::UserInterface.Properties.Resources.deleteperosn30;
            this.btnDeletePerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePerson.Location = new System.Drawing.Point(1, 200);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDeletePerson.Size = new System.Drawing.Size(250, 50);
            this.btnDeletePerson.TabIndex = 9;
            this.btnDeletePerson.Text = "        Delete Person";
            this.btnDeletePerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePerson.UseVisualStyleBackColor = false;
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // btnUpdatePerson
            // 
            this.btnUpdatePerson.BackColor = System.Drawing.Color.Teal;
            this.btnUpdatePerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePerson.FlatAppearance.BorderSize = 0;
            this.btnUpdatePerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnUpdatePerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnUpdatePerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePerson.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePerson.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePerson.Image = global::UserInterface.Properties.Resources.updateperson30;
            this.btnUpdatePerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatePerson.Location = new System.Drawing.Point(1, 150);
            this.btnUpdatePerson.Name = "btnUpdatePerson";
            this.btnUpdatePerson.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpdatePerson.Size = new System.Drawing.Size(250, 50);
            this.btnUpdatePerson.TabIndex = 11;
            this.btnUpdatePerson.Text = "        Update Person";
            this.btnUpdatePerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatePerson.UseVisualStyleBackColor = false;
            this.btnUpdatePerson.Click += new System.EventHandler(this.btnUpdatePerson_Click);
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.BackColor = System.Drawing.Color.Teal;
            this.btnFindPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindPerson.FlatAppearance.BorderSize = 0;
            this.btnFindPerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnFindPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnFindPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindPerson.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnFindPerson.ForeColor = System.Drawing.Color.White;
            this.btnFindPerson.Image = global::UserInterface.Properties.Resources.findperson30;
            this.btnFindPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindPerson.Location = new System.Drawing.Point(1, 100);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFindPerson.Size = new System.Drawing.Size(250, 50);
            this.btnFindPerson.TabIndex = 10;
            this.btnFindPerson.Text = "        Find Person";
            this.btnFindPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindPerson.UseVisualStyleBackColor = false;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDrivers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDrivers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDrivers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.btnDrivers.ForeColor = System.Drawing.Color.White;
            this.btnDrivers.Image = global::UserInterface.Properties.Resources.Driver35;
            this.btnDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivers.Location = new System.Drawing.Point(0, 265);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnDrivers.Size = new System.Drawing.Size(250, 50);
            this.btnDrivers.TabIndex = 6;
            this.btnDrivers.Tag = "SlideIsHided";
            this.btnDrivers.Text = "       Drivers";
            this.btnDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivers.UseVisualStyleBackColor = false;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // PanelApplications
            // 
            this.PanelApplications.Controls.Add(this.panelDetainLicenses);
            this.PanelApplications.Controls.Add(this.btnTestTypes);
            this.PanelApplications.Controls.Add(this.btnApplicationsTypes);
            this.PanelApplications.Controls.Add(this.PanelMangeApplications);
            this.PanelApplications.Controls.Add(this.btnApplications);
            this.PanelApplications.Controls.Add(this.panelDrivingLicensesServices);
            this.PanelApplications.Location = new System.Drawing.Point(-1, 215);
            this.PanelApplications.Name = "PanelApplications";
            this.PanelApplications.Size = new System.Drawing.Size(250, 50);
            this.PanelApplications.TabIndex = 7;
            // 
            // panelDetainLicenses
            // 
            this.panelDetainLicenses.Controls.Add(this.DetainedLicenses);
            this.panelDetainLicenses.Controls.Add(this.btnDetainLicense);
            this.panelDetainLicenses.Controls.Add(this.btnReleaseLicense);
            this.panelDetainLicenses.Controls.Add(this.btnDetainLicenses);
            this.panelDetainLicenses.Location = new System.Drawing.Point(0, 150);
            this.panelDetainLicenses.Name = "panelDetainLicenses";
            this.panelDetainLicenses.Size = new System.Drawing.Size(250, 50);
            this.panelDetainLicenses.TabIndex = 22;
            // 
            // DetainedLicenses
            // 
            this.DetainedLicenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DetainedLicenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DetainedLicenses.FlatAppearance.BorderSize = 0;
            this.DetainedLicenses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.DetainedLicenses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.DetainedLicenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetainedLicenses.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.DetainedLicenses.ForeColor = System.Drawing.Color.White;
            this.DetainedLicenses.Image = global::UserInterface.Properties.Resources.arrowToRight;
            this.DetainedLicenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DetainedLicenses.Location = new System.Drawing.Point(0, 150);
            this.DetainedLicenses.Name = "DetainedLicenses";
            this.DetainedLicenses.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.DetainedLicenses.Size = new System.Drawing.Size(250, 50);
            this.DetainedLicenses.TabIndex = 7;
            this.DetainedLicenses.Text = "         Detained Licenses";
            this.DetainedLicenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DetainedLicenses.UseVisualStyleBackColor = false;
            this.DetainedLicenses.Click += new System.EventHandler(this.DetainedLicenses_Click);
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDetainLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetainLicense.FlatAppearance.BorderSize = 0;
            this.btnDetainLicense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnDetainLicense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetainLicense.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnDetainLicense.ForeColor = System.Drawing.Color.White;
            this.btnDetainLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnDetainLicense.Image")));
            this.btnDetainLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetainLicense.Location = new System.Drawing.Point(0, 50);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDetainLicense.Size = new System.Drawing.Size(250, 50);
            this.btnDetainLicense.TabIndex = 5;
            this.btnDetainLicense.Text = "         Detain License";
            this.btnDetainLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetainLicense.UseVisualStyleBackColor = false;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
            // 
            // btnReleaseLicense
            // 
            this.btnReleaseLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReleaseLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReleaseLicense.FlatAppearance.BorderSize = 0;
            this.btnReleaseLicense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnReleaseLicense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnReleaseLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReleaseLicense.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnReleaseLicense.ForeColor = System.Drawing.Color.White;
            this.btnReleaseLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnReleaseLicense.Image")));
            this.btnReleaseLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReleaseLicense.Location = new System.Drawing.Point(0, 100);
            this.btnReleaseLicense.Name = "btnReleaseLicense";
            this.btnReleaseLicense.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReleaseLicense.Size = new System.Drawing.Size(250, 50);
            this.btnReleaseLicense.TabIndex = 5;
            this.btnReleaseLicense.Text = "         Release License";
            this.btnReleaseLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReleaseLicense.UseVisualStyleBackColor = false;
            this.btnReleaseLicense.Click += new System.EventHandler(this.btnReleaseLicense_Click);
            // 
            // btnDetainLicenses
            // 
            this.btnDetainLicenses.BackColor = System.Drawing.Color.Teal;
            this.btnDetainLicenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetainLicenses.FlatAppearance.BorderSize = 0;
            this.btnDetainLicenses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnDetainLicenses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnDetainLicenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetainLicenses.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnDetainLicenses.ForeColor = System.Drawing.Color.White;
            this.btnDetainLicenses.Image = global::UserInterface.Properties.Resources.stop30;
            this.btnDetainLicenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetainLicenses.Location = new System.Drawing.Point(0, 0);
            this.btnDetainLicenses.Name = "btnDetainLicenses";
            this.btnDetainLicenses.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDetainLicenses.Size = new System.Drawing.Size(250, 50);
            this.btnDetainLicenses.TabIndex = 6;
            this.btnDetainLicenses.Tag = "SlideIsHided";
            this.btnDetainLicenses.Text = "         Detain Licenses";
            this.btnDetainLicenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetainLicenses.UseVisualStyleBackColor = false;
            this.btnDetainLicenses.Click += new System.EventHandler(this.btnDetainLicenses_Click);
            // 
            // btnTestTypes
            // 
            this.btnTestTypes.BackColor = System.Drawing.Color.Teal;
            this.btnTestTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestTypes.FlatAppearance.BorderSize = 0;
            this.btnTestTypes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnTestTypes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnTestTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestTypes.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnTestTypes.ForeColor = System.Drawing.Color.White;
            this.btnTestTypes.Image = global::UserInterface.Properties.Resources.testtypes30;
            this.btnTestTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestTypes.Location = new System.Drawing.Point(0, 250);
            this.btnTestTypes.Name = "btnTestTypes";
            this.btnTestTypes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTestTypes.Size = new System.Drawing.Size(250, 50);
            this.btnTestTypes.TabIndex = 8;
            this.btnTestTypes.Text = "         Test Types";
            this.btnTestTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestTypes.UseVisualStyleBackColor = false;
            this.btnTestTypes.Click += new System.EventHandler(this.btnTestTypes_Click);
            // 
            // btnApplicationsTypes
            // 
            this.btnApplicationsTypes.BackColor = System.Drawing.Color.Teal;
            this.btnApplicationsTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplicationsTypes.FlatAppearance.BorderSize = 0;
            this.btnApplicationsTypes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnApplicationsTypes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnApplicationsTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplicationsTypes.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnApplicationsTypes.ForeColor = System.Drawing.Color.White;
            this.btnApplicationsTypes.Image = global::UserInterface.Properties.Resources.ApplicationsIcon30;
            this.btnApplicationsTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplicationsTypes.Location = new System.Drawing.Point(0, 200);
            this.btnApplicationsTypes.Name = "btnApplicationsTypes";
            this.btnApplicationsTypes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnApplicationsTypes.Size = new System.Drawing.Size(250, 50);
            this.btnApplicationsTypes.TabIndex = 7;
            this.btnApplicationsTypes.Text = "         Applications Types";
            this.btnApplicationsTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplicationsTypes.UseVisualStyleBackColor = false;
            this.btnApplicationsTypes.Click += new System.EventHandler(this.btnApplicationsTypes_Click);
            // 
            // PanelMangeApplications
            // 
            this.PanelMangeApplications.Controls.Add(this.btnManageApplications);
            this.PanelMangeApplications.Controls.Add(this.btnLocalDrivingLicense);
            this.PanelMangeApplications.Controls.Add(this.btnInternationalDrivingLicense);
            this.PanelMangeApplications.Location = new System.Drawing.Point(0, 100);
            this.PanelMangeApplications.Name = "PanelMangeApplications";
            this.PanelMangeApplications.Size = new System.Drawing.Size(250, 50);
            this.PanelMangeApplications.TabIndex = 21;
            // 
            // btnManageApplications
            // 
            this.btnManageApplications.BackColor = System.Drawing.Color.Teal;
            this.btnManageApplications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageApplications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageApplications.FlatAppearance.BorderSize = 0;
            this.btnManageApplications.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnManageApplications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnManageApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageApplications.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnManageApplications.ForeColor = System.Drawing.Color.White;
            this.btnManageApplications.Image = global::UserInterface.Properties.Resources.manageapplications30;
            this.btnManageApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageApplications.Location = new System.Drawing.Point(0, 0);
            this.btnManageApplications.Name = "btnManageApplications";
            this.btnManageApplications.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnManageApplications.Size = new System.Drawing.Size(250, 50);
            this.btnManageApplications.TabIndex = 5;
            this.btnManageApplications.Tag = "SlideIsHided";
            this.btnManageApplications.Text = "         Manage Applications";
            this.btnManageApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageApplications.UseVisualStyleBackColor = false;
            this.btnManageApplications.Click += new System.EventHandler(this.btnManageApplications_Click);
            // 
            // btnLocalDrivingLicense
            // 
            this.btnLocalDrivingLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLocalDrivingLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalDrivingLicense.FlatAppearance.BorderSize = 0;
            this.btnLocalDrivingLicense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnLocalDrivingLicense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnLocalDrivingLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalDrivingLicense.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnLocalDrivingLicense.ForeColor = System.Drawing.Color.White;
            this.btnLocalDrivingLicense.Image = global::UserInterface.Properties.Resources.arrowToRight;
            this.btnLocalDrivingLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalDrivingLicense.Location = new System.Drawing.Point(0, 50);
            this.btnLocalDrivingLicense.Name = "btnLocalDrivingLicense";
            this.btnLocalDrivingLicense.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLocalDrivingLicense.Size = new System.Drawing.Size(250, 50);
            this.btnLocalDrivingLicense.TabIndex = 5;
            this.btnLocalDrivingLicense.Text = "         Local D.Lecense";
            this.btnLocalDrivingLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalDrivingLicense.UseVisualStyleBackColor = false;
            this.btnLocalDrivingLicense.Click += new System.EventHandler(this.btnLocalDrivingLicense_Click);
            // 
            // btnInternationalDrivingLicense
            // 
            this.btnInternationalDrivingLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInternationalDrivingLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInternationalDrivingLicense.FlatAppearance.BorderSize = 0;
            this.btnInternationalDrivingLicense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnInternationalDrivingLicense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnInternationalDrivingLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInternationalDrivingLicense.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnInternationalDrivingLicense.ForeColor = System.Drawing.Color.White;
            this.btnInternationalDrivingLicense.Image = global::UserInterface.Properties.Resources.arrowToRight;
            this.btnInternationalDrivingLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInternationalDrivingLicense.Location = new System.Drawing.Point(0, 100);
            this.btnInternationalDrivingLicense.Name = "btnInternationalDrivingLicense";
            this.btnInternationalDrivingLicense.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInternationalDrivingLicense.Size = new System.Drawing.Size(250, 50);
            this.btnInternationalDrivingLicense.TabIndex = 5;
            this.btnInternationalDrivingLicense.Text = "         International D.L";
            this.btnInternationalDrivingLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInternationalDrivingLicense.UseVisualStyleBackColor = false;
            this.btnInternationalDrivingLicense.Click += new System.EventHandler(this.btnInternationalDrivingLicense_Click);
            // 
            // btnApplications
            // 
            this.btnApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnApplications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApplications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplications.FlatAppearance.BorderSize = 0;
            this.btnApplications.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnApplications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplications.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.btnApplications.ForeColor = System.Drawing.Color.White;
            this.btnApplications.Image = global::UserInterface.Properties.Resources.ApplicationsIcon30;
            this.btnApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplications.Location = new System.Drawing.Point(-1, 0);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.Size = new System.Drawing.Size(250, 50);
            this.btnApplications.TabIndex = 5;
            this.btnApplications.Tag = "SlideIsHided";
            this.btnApplications.Text = "       Applications";
            this.btnApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplications.UseVisualStyleBackColor = false;
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);
            // 
            // panelDrivingLicensesServices
            // 
            this.panelDrivingLicensesServices.Controls.Add(this.btnReplaceDrivingLicense);
            this.panelDrivingLicensesServices.Controls.Add(this.btnReleaseDrivingLicense);
            this.panelDrivingLicensesServices.Controls.Add(this.btnDrivingLicensesServices);
            this.panelDrivingLicensesServices.Controls.Add(this.BtnNewDrivingLicense);
            this.panelDrivingLicensesServices.Controls.Add(this.BtnRenewDrivingLicense);
            this.panelDrivingLicensesServices.Location = new System.Drawing.Point(0, 50);
            this.panelDrivingLicensesServices.Name = "panelDrivingLicensesServices";
            this.panelDrivingLicensesServices.Size = new System.Drawing.Size(250, 50);
            this.panelDrivingLicensesServices.TabIndex = 9;
            // 
            // btnReplaceDrivingLicense
            // 
            this.btnReplaceDrivingLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReplaceDrivingLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplaceDrivingLicense.FlatAppearance.BorderSize = 0;
            this.btnReplaceDrivingLicense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnReplaceDrivingLicense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnReplaceDrivingLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplaceDrivingLicense.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnReplaceDrivingLicense.ForeColor = System.Drawing.Color.White;
            this.btnReplaceDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnReplaceDrivingLicense.Image")));
            this.btnReplaceDrivingLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplaceDrivingLicense.Location = new System.Drawing.Point(0, 150);
            this.btnReplaceDrivingLicense.Name = "btnReplaceDrivingLicense";
            this.btnReplaceDrivingLicense.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReplaceDrivingLicense.Size = new System.Drawing.Size(250, 50);
            this.btnReplaceDrivingLicense.TabIndex = 6;
            this.btnReplaceDrivingLicense.Text = "          Replace D.License";
            this.btnReplaceDrivingLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplaceDrivingLicense.UseVisualStyleBackColor = false;
            this.btnReplaceDrivingLicense.Click += new System.EventHandler(this.btnReplaceDrivingLicense_Click);
            // 
            // btnReleaseDrivingLicense
            // 
            this.btnReleaseDrivingLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReleaseDrivingLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReleaseDrivingLicense.FlatAppearance.BorderSize = 0;
            this.btnReleaseDrivingLicense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnReleaseDrivingLicense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnReleaseDrivingLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReleaseDrivingLicense.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnReleaseDrivingLicense.ForeColor = System.Drawing.Color.White;
            this.btnReleaseDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnReleaseDrivingLicense.Image")));
            this.btnReleaseDrivingLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReleaseDrivingLicense.Location = new System.Drawing.Point(0, 200);
            this.btnReleaseDrivingLicense.Name = "btnReleaseDrivingLicense";
            this.btnReleaseDrivingLicense.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReleaseDrivingLicense.Size = new System.Drawing.Size(250, 50);
            this.btnReleaseDrivingLicense.TabIndex = 7;
            this.btnReleaseDrivingLicense.Text = "          Release D.License";
            this.btnReleaseDrivingLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReleaseDrivingLicense.UseVisualStyleBackColor = false;
            this.btnReleaseDrivingLicense.Click += new System.EventHandler(this.btnReleaseDrivingLicense_Click);
            // 
            // btnDrivingLicensesServices
            // 
            this.btnDrivingLicensesServices.BackColor = System.Drawing.Color.Teal;
            this.btnDrivingLicensesServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDrivingLicensesServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrivingLicensesServices.FlatAppearance.BorderSize = 0;
            this.btnDrivingLicensesServices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnDrivingLicensesServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnDrivingLicensesServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivingLicensesServices.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnDrivingLicensesServices.ForeColor = System.Drawing.Color.White;
            this.btnDrivingLicensesServices.Image = ((System.Drawing.Image)(resources.GetObject("btnDrivingLicensesServices.Image")));
            this.btnDrivingLicensesServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivingLicensesServices.Location = new System.Drawing.Point(0, 0);
            this.btnDrivingLicensesServices.Name = "btnDrivingLicensesServices";
            this.btnDrivingLicensesServices.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDrivingLicensesServices.Size = new System.Drawing.Size(250, 50);
            this.btnDrivingLicensesServices.TabIndex = 5;
            this.btnDrivingLicensesServices.Tag = "SlideIsHided";
            this.btnDrivingLicensesServices.Text = "         D.Licenses Servises";
            this.btnDrivingLicensesServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivingLicensesServices.UseVisualStyleBackColor = false;
            this.btnDrivingLicensesServices.Click += new System.EventHandler(this.btnDrivingLicensesServices_Click);
            // 
            // BtnNewDrivingLicense
            // 
            this.BtnNewDrivingLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnNewDrivingLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewDrivingLicense.FlatAppearance.BorderSize = 0;
            this.BtnNewDrivingLicense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.BtnNewDrivingLicense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.BtnNewDrivingLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewDrivingLicense.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.BtnNewDrivingLicense.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnNewDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("BtnNewDrivingLicense.Image")));
            this.BtnNewDrivingLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewDrivingLicense.Location = new System.Drawing.Point(0, 50);
            this.BtnNewDrivingLicense.Name = "BtnNewDrivingLicense";
            this.BtnNewDrivingLicense.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnNewDrivingLicense.Size = new System.Drawing.Size(250, 50);
            this.BtnNewDrivingLicense.TabIndex = 5;
            this.BtnNewDrivingLicense.Text = "          New D.Lecense";
            this.BtnNewDrivingLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewDrivingLicense.UseVisualStyleBackColor = false;
            this.BtnNewDrivingLicense.Click += new System.EventHandler(this.BtnNewDrivingLicense_Click);
            // 
            // BtnRenewDrivingLicense
            // 
            this.BtnRenewDrivingLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnRenewDrivingLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRenewDrivingLicense.FlatAppearance.BorderSize = 0;
            this.BtnRenewDrivingLicense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.BtnRenewDrivingLicense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.BtnRenewDrivingLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRenewDrivingLicense.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.BtnRenewDrivingLicense.ForeColor = System.Drawing.Color.White;
            this.BtnRenewDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("BtnRenewDrivingLicense.Image")));
            this.BtnRenewDrivingLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRenewDrivingLicense.Location = new System.Drawing.Point(0, 100);
            this.BtnRenewDrivingLicense.Name = "BtnRenewDrivingLicense";
            this.BtnRenewDrivingLicense.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnRenewDrivingLicense.Size = new System.Drawing.Size(250, 50);
            this.BtnRenewDrivingLicense.TabIndex = 5;
            this.BtnRenewDrivingLicense.Text = "          Renew D.License";
            this.BtnRenewDrivingLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRenewDrivingLicense.UseVisualStyleBackColor = false;
            this.BtnRenewDrivingLicense.Click += new System.EventHandler(this.BtnRenewDrivingLicense_Click);
            // 
            // panelManageUsers
            // 
            this.panelManageUsers.Controls.Add(this.btnManageUsers);
            this.panelManageUsers.Controls.Add(this.btnListOfUsers);
            this.panelManageUsers.Controls.Add(this.btnAddUser);
            this.panelManageUsers.Controls.Add(this.btnDeleteUser);
            this.panelManageUsers.Controls.Add(this.btnFindUser);
            this.panelManageUsers.Controls.Add(this.btnUpdateUser);
            this.panelManageUsers.Location = new System.Drawing.Point(-1, 166);
            this.panelManageUsers.Name = "panelManageUsers";
            this.panelManageUsers.Size = new System.Drawing.Size(250, 50);
            this.panelManageUsers.TabIndex = 6;
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManageUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnManageUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.Image = global::UserInterface.Properties.Resources.ManageUsers25;
            this.btnManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUsers.Location = new System.Drawing.Point(0, 0);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(250, 50);
            this.btnManageUsers.TabIndex = 6;
            this.btnManageUsers.Tag = "SlideIsHided";
            this.btnManageUsers.Text = "       Manage Users";
            this.btnManageUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnListOfUsers
            // 
            this.btnListOfUsers.BackColor = System.Drawing.Color.Teal;
            this.btnListOfUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListOfUsers.FlatAppearance.BorderSize = 0;
            this.btnListOfUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnListOfUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnListOfUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListOfUsers.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnListOfUsers.ForeColor = System.Drawing.Color.White;
            this.btnListOfUsers.Image = global::UserInterface.Properties.Resources.ApplicationsIcon30;
            this.btnListOfUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListOfUsers.Location = new System.Drawing.Point(0, 250);
            this.btnListOfUsers.Name = "btnListOfUsers";
            this.btnListOfUsers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnListOfUsers.Size = new System.Drawing.Size(250, 50);
            this.btnListOfUsers.TabIndex = 5;
            this.btnListOfUsers.Text = "        List Of Users";
            this.btnListOfUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListOfUsers.UseVisualStyleBackColor = false;
            this.btnListOfUsers.Click += new System.EventHandler(this.btnListOfUsers_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Teal;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = global::UserInterface.Properties.Resources.addnewPerson30;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(0, 50);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddUser.Size = new System.Drawing.Size(250, 50);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "        Add User";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Image = global::UserInterface.Properties.Resources.deleteperosn30;
            this.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.Location = new System.Drawing.Point(0, 200);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDeleteUser.Size = new System.Drawing.Size(250, 50);
            this.btnDeleteUser.TabIndex = 5;
            this.btnDeleteUser.Text = "        Delete User";
            this.btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnFindUser
            // 
            this.btnFindUser.BackColor = System.Drawing.Color.Teal;
            this.btnFindUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindUser.FlatAppearance.BorderSize = 0;
            this.btnFindUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnFindUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnFindUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindUser.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnFindUser.ForeColor = System.Drawing.Color.White;
            this.btnFindUser.Image = global::UserInterface.Properties.Resources.findperson30;
            this.btnFindUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindUser.Location = new System.Drawing.Point(0, 100);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFindUser.Size = new System.Drawing.Size(250, 50);
            this.btnFindUser.TabIndex = 5;
            this.btnFindUser.Text = "        Find User";
            this.btnFindUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindUser.UseVisualStyleBackColor = false;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnUpdateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Image = global::UserInterface.Properties.Resources.updateperson30;
            this.btnUpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUser.Location = new System.Drawing.Point(0, 150);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpdateUser.Size = new System.Drawing.Size(250, 50);
            this.btnUpdateUser.TabIndex = 5;
            this.btnUpdateUser.Text = "        Update User";
            this.btnUpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // panelProfile
            // 
            this.panelProfile.Controls.Add(this.btnProfile);
            this.panelProfile.Controls.Add(this.btnProfileDetails);
            this.panelProfile.Controls.Add(this.btnChangePassword);
            this.panelProfile.Location = new System.Drawing.Point(0, 315);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(250, 50);
            this.panelProfile.TabIndex = 6;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = global::UserInterface.Properties.Resources.profile30;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnProfile.Size = new System.Drawing.Size(250, 50);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Tag = "SlideIsHided";
            this.btnProfile.Text = "       Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnProfileDetails
            // 
            this.btnProfileDetails.BackColor = System.Drawing.Color.Teal;
            this.btnProfileDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfileDetails.FlatAppearance.BorderSize = 0;
            this.btnProfileDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnProfileDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnProfileDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileDetails.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnProfileDetails.ForeColor = System.Drawing.Color.White;
            this.btnProfileDetails.Image = global::UserInterface.Properties.Resources.profiledetails30;
            this.btnProfileDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfileDetails.Location = new System.Drawing.Point(0, 50);
            this.btnProfileDetails.Name = "btnProfileDetails";
            this.btnProfileDetails.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProfileDetails.Size = new System.Drawing.Size(250, 50);
            this.btnProfileDetails.TabIndex = 5;
            this.btnProfileDetails.Text = "        Profile Details";
            this.btnProfileDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfileDetails.UseVisualStyleBackColor = false;
            this.btnProfileDetails.Click += new System.EventHandler(this.btnProfileDetails_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Teal;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Image = global::UserInterface.Properties.Resources.changepassword30;
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 100);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnChangePassword.Size = new System.Drawing.Size(250, 50);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "        Change PassWord";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lbCurrentUserName
            // 
            this.lbCurrentUserName.AutoSize = true;
            this.lbCurrentUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCurrentUserName.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.lbCurrentUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbCurrentUserName.Location = new System.Drawing.Point(67, 45);
            this.lbCurrentUserName.Name = "lbCurrentUserName";
            this.lbCurrentUserName.Size = new System.Drawing.Size(36, 16);
            this.lbCurrentUserName.TabIndex = 16;
            this.lbCurrentUserName.Text = "User";
            this.lbCurrentUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCurrentUserFirstName
            // 
            this.lbCurrentUserFirstName.AutoSize = true;
            this.lbCurrentUserFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCurrentUserFirstName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentUserFirstName.ForeColor = System.Drawing.Color.White;
            this.lbCurrentUserFirstName.Location = new System.Drawing.Point(65, 18);
            this.lbCurrentUserFirstName.Name = "lbCurrentUserFirstName";
            this.lbCurrentUserFirstName.Size = new System.Drawing.Size(92, 19);
            this.lbCurrentUserFirstName.TabIndex = 17;
            this.lbCurrentUserFirstName.Text = "FirstName";
            this.lbCurrentUserFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "__________________________________";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(-1, -6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 81);
            this.label2.TabIndex = 20;
            // 
            // btnMinimizeForm
            // 
            this.btnMinimizeForm.BackColor = System.Drawing.Color.White;
            this.btnMinimizeForm.BackgroundImage = global::UserInterface.Properties.Resources.Minimize;
            this.btnMinimizeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizeForm.FlatAppearance.BorderSize = 0;
            this.btnMinimizeForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMinimizeForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMinimizeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeForm.Location = new System.Drawing.Point(987, 5);
            this.btnMinimizeForm.Name = "btnMinimizeForm";
            this.btnMinimizeForm.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizeForm.TabIndex = 4;
            this.btnMinimizeForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMinimizeForm.UseVisualStyleBackColor = false;
            this.btnMinimizeForm.Click += new System.EventHandler(this.btnMinimizeForm_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = global::UserInterface.Properties.Resources.closeIcon;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1027, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(334, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(665, 171);
            this.label6.TabIndex = 23;
            this.label6.Text = "Driver  &&  Vehicle License Department";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbDetainedLicensesCount);
            this.panel1.Controls.Add(this.lbInternationalLicensesCount);
            this.panel1.Controls.Add(this.lbLocalLicensesCount);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.lbDriversCount);
            this.panel1.Controls.Add(this.lbUsersCount);
            this.panel1.Controls.Add(this.lbPeopleCount);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(253, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 256);
            this.panel1.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label13.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(215, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(363, 33);
            this.label13.TabIndex = 26;
            this.label13.Text = "General Statistics";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(1, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(798, 45);
            this.label12.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(531, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(5, 209);
            this.label9.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(255, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(5, 216);
            this.label7.TabIndex = 2;
            // 
            // lbDetainedLicensesCount
            // 
            this.lbDetainedLicensesCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbDetainedLicensesCount.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainedLicensesCount.ForeColor = System.Drawing.Color.White;
            this.lbDetainedLicensesCount.Location = new System.Drawing.Point(550, 210);
            this.lbDetainedLicensesCount.Name = "lbDetainedLicensesCount";
            this.lbDetainedLicensesCount.Size = new System.Drawing.Size(246, 33);
            this.lbDetainedLicensesCount.TabIndex = 37;
            this.lbDetainedLicensesCount.Text = "1000000000";
            this.lbDetainedLicensesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbInternationalLicensesCount
            // 
            this.lbInternationalLicensesCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbInternationalLicensesCount.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInternationalLicensesCount.ForeColor = System.Drawing.Color.White;
            this.lbInternationalLicensesCount.Location = new System.Drawing.Point(271, 210);
            this.lbInternationalLicensesCount.Name = "lbInternationalLicensesCount";
            this.lbInternationalLicensesCount.Size = new System.Drawing.Size(255, 33);
            this.lbInternationalLicensesCount.TabIndex = 36;
            this.lbInternationalLicensesCount.Text = "1000000000";
            this.lbInternationalLicensesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLocalLicensesCount
            // 
            this.lbLocalLicensesCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbLocalLicensesCount.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalLicensesCount.ForeColor = System.Drawing.Color.White;
            this.lbLocalLicensesCount.Location = new System.Drawing.Point(2, 210);
            this.lbLocalLicensesCount.Name = "lbLocalLicensesCount";
            this.lbLocalLicensesCount.Size = new System.Drawing.Size(255, 33);
            this.lbLocalLicensesCount.TabIndex = 35;
            this.lbLocalLicensesCount.Text = "1000000000";
            this.lbLocalLicensesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Teal;
            this.label15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(550, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(228, 29);
            this.label15.TabIndex = 34;
            this.label15.Text = "Detained Licenses";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Teal;
            this.label16.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(268, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(260, 27);
            this.label16.TabIndex = 33;
            this.label16.Text = "International Licenses";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label19.Location = new System.Drawing.Point(1, 204);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(798, 45);
            this.label19.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Teal;
            this.label20.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(35, 162);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(184, 29);
            this.label20.TabIndex = 29;
            this.label20.Text = "Local Licenses";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Teal;
            this.label21.Location = new System.Drawing.Point(1, 155);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(798, 45);
            this.label21.TabIndex = 28;
            // 
            // lbDriversCount
            // 
            this.lbDriversCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbDriversCount.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDriversCount.ForeColor = System.Drawing.Color.White;
            this.lbDriversCount.Location = new System.Drawing.Point(545, 105);
            this.lbDriversCount.Name = "lbDriversCount";
            this.lbDriversCount.Size = new System.Drawing.Size(251, 33);
            this.lbDriversCount.TabIndex = 27;
            this.lbDriversCount.Text = "1000000000";
            this.lbDriversCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUsersCount
            // 
            this.lbUsersCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbUsersCount.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsersCount.ForeColor = System.Drawing.Color.White;
            this.lbUsersCount.Location = new System.Drawing.Point(271, 105);
            this.lbUsersCount.Name = "lbUsersCount";
            this.lbUsersCount.Size = new System.Drawing.Size(255, 33);
            this.lbUsersCount.TabIndex = 26;
            this.lbUsersCount.Text = "1000000000";
            this.lbUsersCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPeopleCount
            // 
            this.lbPeopleCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbPeopleCount.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeopleCount.ForeColor = System.Drawing.Color.White;
            this.lbPeopleCount.Location = new System.Drawing.Point(2, 105);
            this.lbPeopleCount.Name = "lbPeopleCount";
            this.lbPeopleCount.Size = new System.Drawing.Size(255, 33);
            this.lbPeopleCount.TabIndex = 25;
            this.lbPeopleCount.Text = "1000000000";
            this.lbPeopleCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Teal;
            this.label11.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(617, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 33);
            this.label11.TabIndex = 6;
            this.label11.Text = "Drivers";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Teal;
            this.label10.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(358, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 33);
            this.label10.TabIndex = 5;
            this.label10.Text = "Users";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(1, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(798, 45);
            this.label8.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(76, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "People";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(1, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(798, 45);
            this.label4.TabIndex = 0;
            // 
            // pbCurrentUserImage
            // 
            this.pbCurrentUserImage.BackColor = System.Drawing.Color.White;
            this.pbCurrentUserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCurrentUserImage.Image = global::UserInterface.Properties.Resources.personLogo;
            this.pbCurrentUserImage.Location = new System.Drawing.Point(3, 13);
            this.pbCurrentUserImage.Name = "pbCurrentUserImage";
            this.pbCurrentUserImage.Size = new System.Drawing.Size(55, 55);
            this.pbCurrentUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrentUserImage.TabIndex = 18;
            this.pbCurrentUserImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 642);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbCurrentUserImage);
            this.Controls.Add(this.lbCurrentUserName);
            this.Controls.Add(this.lbCurrentUserFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.btnMinimizeForm);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.panelManagePeople.ResumeLayout(false);
            this.PanelApplications.ResumeLayout(false);
            this.panelDetainLicenses.ResumeLayout(false);
            this.PanelMangeApplications.ResumeLayout(false);
            this.panelDrivingLicensesServices.ResumeLayout(false);
            this.panelManageUsers.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimizeForm;
        private System.Windows.Forms.Panel panelManageUsers;
        private System.Windows.Forms.Button btnListOfUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnFindUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnProfileDetails;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnManagePeople;
        private System.Windows.Forms.Panel panelManagePeople;
        private System.Windows.Forms.Button btnListOfpeople;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnDeletePerson;
        private System.Windows.Forms.Button btnUpdatePerson;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Panel PanelApplications;
        private System.Windows.Forms.Button btnApplications;
        private System.Windows.Forms.Button btnTestTypes;
        private System.Windows.Forms.Button btnDetainLicenses;
        private System.Windows.Forms.Button btnApplicationsTypes;
        public RoundedPictureBox pbCurrentUserImage;
        public System.Windows.Forms.Label lbCurrentUserName;
        public System.Windows.Forms.Label lbCurrentUserFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDrivingLicensesServices;
        private System.Windows.Forms.Button btnReplaceDrivingLicense;
        private System.Windows.Forms.Button btnReleaseDrivingLicense;
        private System.Windows.Forms.Button btnDrivingLicensesServices;
        private System.Windows.Forms.Button BtnNewDrivingLicense;
        private System.Windows.Forms.Button BtnRenewDrivingLicense;
        private System.Windows.Forms.Panel PanelMangeApplications;
        private System.Windows.Forms.Button btnManageApplications;
        private System.Windows.Forms.Button btnLocalDrivingLicense;
        private System.Windows.Forms.Button btnInternationalDrivingLicense;
        private System.Windows.Forms.Panel panelDetainLicenses;
        private System.Windows.Forms.Button btnDetainLicense;
        private System.Windows.Forms.Button btnReleaseLicense;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button DetainedLicenses;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDriversCount;
        private System.Windows.Forms.Label lbUsersCount;
        private System.Windows.Forms.Label lbPeopleCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbDetainedLicensesCount;
        private System.Windows.Forms.Label lbInternationalLicensesCount;
        private System.Windows.Forms.Label lbLocalLicensesCount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}