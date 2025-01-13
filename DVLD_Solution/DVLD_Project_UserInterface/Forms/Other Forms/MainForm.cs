using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UserInterface.Properties;
namespace UserInterface
{
    public partial class MainForm : Form
    {
        public static MainForm instance;

        LogInForm _LoginFrm;

        DataTable Appointments;

        public MainForm(LogInForm frm)
        {
            InitializeComponent();
            instance=this;
            _LoginFrm = frm;

        }

        //we need this code to move the form when we click on the header of the form: 
        //----------------------------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void MoveTheFormWithMouse(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_LoginFrm!=null)
            {
                _LoginFrm.Close();
            }
            this.Close();
        }
        private void btnMinimizeForm_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //----------------------------------------------------------------------------------------



        // Show and hide the buttons in the sidebar:
        //----------------------------------------------------------------------------------------
      
        private void ShowSlidesWhenButtonClicked(Button button, Panel panel, Size size)
        {
            if (button.Tag.ToString() == "SlideIsHided")
            {
                panel.Size = size;
                button.Tag = "SlideIsShown";
                return;
            }
            if (button.Tag.ToString() == "SlideIsShown")
            {
                panel.Size = button.Size;
                button.Tag = "SlideIsHided";
                if (button == btnApplications)
                {
                    panelDrivingLicensesServices.Height = btnDrivingLicensesServices.Height;
                    btnDrivingLicensesServices.Tag = "SlideIsHided";

                    PanelMangeApplications.Height = btnManageApplications.Height;
                    btnManageApplications.Tag = "SlideIsHided";

                    panelDetainLicenses.Height = btnDetainLicenses.Height;
                    btnDetainLicenses.Tag = "SlideIsHided";

                    PanelMangeApplications.Location = new Point(panelDrivingLicensesServices.Left, panelDrivingLicensesServices.Top + panelDrivingLicensesServices.Height);
                    panelDetainLicenses.Location = new Point(PanelMangeApplications.Left, PanelMangeApplications.Top + PanelMangeApplications.Height);
                    btnApplicationsTypes.Location = new Point(panelDetainLicenses.Left, panelDetainLicenses.Top + panelDetainLicenses.Height);
                    btnTestTypes.Location = new Point(btnApplicationsTypes.Left, btnApplicationsTypes.Top + btnApplicationsTypes.Height);

                }
            }
        }

        private void UpdateLocationsOfButtons(Button btnClicked)
        {
            if (btnClicked == btnManagePeople)
            {
                panelManageUsers.Location = new Point(panelManagePeople.Left, panelManagePeople.Top + panelManagePeople.Height);

                PanelApplications.Location = new Point(panelManageUsers.Left, panelManageUsers.Top + panelManageUsers.Height);

                btnDrivers.Location= new Point(PanelApplications.Left, PanelApplications.Top + PanelApplications.Height);

                panelProfile.Location = new Point(btnDrivers.Left, btnDrivers.Top + btnDrivers.Height);

                btnLogOut.Location = new Point(panelProfile.Left, panelProfile.Top + panelProfile.Height);

                return;
            }
            if (btnClicked == btnManageUsers)
            {
                PanelApplications.Location = new Point(panelManageUsers.Left, panelManageUsers.Top + panelManageUsers.Height);


                btnDrivers.Location = new Point(PanelApplications.Left, PanelApplications.Top + PanelApplications.Height);

                panelProfile.Location = new Point(btnDrivers.Left, btnDrivers.Top + btnDrivers.Height);

                btnLogOut.Location = new Point(panelProfile.Left, panelProfile.Top + panelProfile.Height);

                return;
            }

            if (btnClicked == btnApplications)
            {

                btnDrivers.Location = new Point(PanelApplications.Left, PanelApplications.Top + PanelApplications.Height);

                panelProfile.Location = new Point(btnDrivers.Left, btnDrivers.Top + btnDrivers.Height);

                btnLogOut.Location = new Point(panelProfile.Left, panelProfile.Top + panelProfile.Height);

                return;
            }
            if (btnClicked == btnDrivers)
            {
                panelProfile.Location = new Point(btnDrivers.Left, btnDrivers.Top + btnDrivers.Height);

                btnLogOut.Location = new Point(panelProfile.Left, panelProfile.Top + panelProfile.Height);
                return;
            }

            if (btnClicked == btnProfile)
            {
                btnLogOut.Location = new Point(panelProfile.Left, panelProfile.Top + panelProfile.Height);
                return;
            }

        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            Size PanelSize = new Size(250, 300);
            ShowSlidesWhenButtonClicked(btnManageUsers, panelManageUsers, PanelSize);
            UpdateLocationsOfButtons(btnManageUsers);
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            Size PanelSize = new Size(250, 300);
            ShowSlidesWhenButtonClicked(btnApplications, PanelApplications, PanelSize);
            UpdateLocationsOfButtons(btnApplications);
        }

        private void btnDrivingLicensesServices_Click(object sender, EventArgs e)
        {
            Size PanelSize = new Size(250, 250);
            ShowSlidesWhenButtonClicked(btnDrivingLicensesServices, panelDrivingLicensesServices, PanelSize);

            PanelMangeApplications.Location = new Point(panelDrivingLicensesServices.Left, panelDrivingLicensesServices.Top + panelDrivingLicensesServices.Height);
            panelDetainLicenses.Location = new Point(PanelMangeApplications.Left, PanelMangeApplications.Top + PanelMangeApplications.Height);
            btnApplicationsTypes.Location = new Point(panelDetainLicenses.Left, panelDetainLicenses.Top + panelDetainLicenses.Height);
            btnTestTypes.Location = new Point(btnApplicationsTypes.Left, btnApplicationsTypes.Top + btnApplicationsTypes.Height);

            PanelApplications.Height = btnApplications.Height + panelDrivingLicensesServices.Height + PanelMangeApplications.Height + panelDetainLicenses.Height + btnApplicationsTypes.Height + btnTestTypes.Height;


            UpdateLocationsOfButtons(btnApplications);
        }

        private void btnManageApplications_Click(object sender, EventArgs e)
        {
           Size PanelSize = new Size(250, 150);
            ShowSlidesWhenButtonClicked(btnManageApplications, PanelMangeApplications, PanelSize);

            panelDetainLicenses.Location = new Point(PanelMangeApplications.Left, PanelMangeApplications.Top + PanelMangeApplications.Height);
            btnApplicationsTypes.Location = new Point(panelDetainLicenses.Left, panelDetainLicenses.Top + panelDetainLicenses.Height);
            btnTestTypes.Location = new Point(btnApplicationsTypes.Left, btnApplicationsTypes.Top + btnApplicationsTypes.Height);

            PanelApplications.Height = btnApplications.Height + panelDrivingLicensesServices.Height + PanelMangeApplications.Height + panelDetainLicenses.Height + btnApplicationsTypes.Height + btnTestTypes.Height;


            UpdateLocationsOfButtons(btnApplications);
        }

        private void btnDetainLicenses_Click(object sender, EventArgs e)
        {
            Size PanelSize = new Size(250, 200);
            ShowSlidesWhenButtonClicked(btnDetainLicenses, panelDetainLicenses, PanelSize);

            btnApplicationsTypes.Location = new Point(panelDetainLicenses.Left, panelDetainLicenses.Top + panelDetainLicenses.Height);
            btnTestTypes.Location = new Point(btnApplicationsTypes.Left, btnApplicationsTypes.Top + btnApplicationsTypes.Height);

            PanelApplications.Height = btnApplications.Height + panelDrivingLicensesServices.Height + PanelMangeApplications.Height + panelDetainLicenses.Height + btnApplicationsTypes.Height + btnTestTypes.Height;

            UpdateLocationsOfButtons(btnApplications);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Size PanelSize = new Size(250, 150);
            ShowSlidesWhenButtonClicked(btnProfile, panelProfile, PanelSize);
            UpdateLocationsOfButtons(btnProfile);
        }

  
        //----------------------------------------------------------------------------------------

        private void RefreshUserInfoOnScreen()
        {
            lbCurrentUserName.Text = GlobalSettings.CurrentUser.UserName;
           
            lbCurrentUserFirstName.Text = GlobalSettings.CurrentUser.PersonInfo.FirstName;
            try
            {
                pbCurrentUserImage.ImageLocation = GlobalSettings.CurrentUser.PersonInfo.ImagePath;
            }
            catch (Exception ex) { pbCurrentUserImage.Image = Resources.personLogo; GlobalSettings.LoggingAnException("DVLD", ex.Message); }
        }


        void FillStatisticTables()
        {
            Dictionary<string, int> Statistics = clsSharedMethods.GetGeneralStatistics();
            if (Statistics!=null && Statistics.Count>0)
            {
                lbPeopleCount.Text = Statistics["PeopleCount"].ToString();
                lbUsersCount.Text = Statistics["UsersCount"].ToString();
                lbDriversCount.Text = Statistics["DriversCount"].ToString();
                lbLocalLicensesCount.Text = Statistics["LocalLicensesCount"].ToString();
                lbInternationalLicensesCount.Text = Statistics["InternationalLicensesCount"].ToString();
                lbDetainedLicensesCount.Text = Statistics["DetainedLicensesCount"].ToString();

            }
        }
        
    private void MainForm_Load(object sender, EventArgs e)
        {
          if (GlobalSettings.CurrentUser!=null)
          {
              RefreshUserInfoOnScreen();
          }
           FillStatisticTables();
        }

        private void btnManagePeople_Click(object sender, EventArgs e)
        {
            Size PanelSize = new Size(250, 300);
            ShowSlidesWhenButtonClicked(btnManagePeople, panelManagePeople, PanelSize);
            UpdateLocationsOfButtons(btnManagePeople);

        }

        private void LogOut()
        {
            GlobalSettings.CurrentUser = null;
            pbCurrentUserImage.Image = Resources.personLogo;
            _LoginFrm.Show();
            this.Close();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void btnListOfPeople_Click(object sender, EventArgs e)
        {
            ManagePeopleForm frm = new ManagePeopleForm();
            
            frm.ShowDialog();

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Add_EditePeopleForm AddPersonForm = new Add_EditePeopleForm(-1);
            AddPersonForm.Location = new Point(320,120);
            AddPersonForm.ShowDialog();
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            SearchForm frm = new SearchForm(SearchForm.enSearchFor.SearchForPerson, SearchForm.enSearchReason.ToShowInfo);
            frm.ShowDialog();


        }

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            SearchForm frm = new SearchForm(SearchForm.enSearchFor.SearchForPerson, SearchForm.enSearchReason.ToUpdateInfo);
            frm.ShowDialog();
           
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            SearchForm frm = new SearchForm(SearchForm.enSearchFor.SearchForPerson, SearchForm.enSearchReason.ToDelete);
            frm.ShowDialog();
        }

        private void btnListOfUsers_Click(object sender, EventArgs e)
        {
            ManageUsersForm frm = new ManageUsersForm();
            frm.ShowDialog();

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            SearchForm SearchToDeleteForm = new SearchForm(SearchForm.enSearchFor.SearchForUser, SearchForm.enSearchReason.ToDelete);
            SearchToDeleteForm.ShowDialog();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {

         SearchForm searchfrm = new SearchForm(SearchForm.enSearchFor.SearchForUser, SearchForm.enSearchReason.ToUpdateInfo);
         searchfrm.ShowDialog();

        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            SearchForm frm = new SearchForm(SearchForm.enSearchFor.SearchForUser, SearchForm.enSearchReason.ToShowInfo);
            frm.ShowDialog();
            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddEditUsersForm AddNewUserForm = new AddEditUsersForm(-1);
            AddNewUserForm.ShowDialog();
        }

        private void btnProfileDetails_Click(object sender, EventArgs e)
        {
            UserInfoForm frm = new UserInfoForm(GlobalSettings.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangeUserPasswordForm frm = new ChangeUserPasswordForm(GlobalSettings.CurrentUser.UserID);
            frm.ShowDialog();
        }


        private void BtnNewDrivingLicense_Click(object sender, EventArgs e)
        {
           FormSelectTypeOfLicenseToAdd form = new FormSelectTypeOfLicenseToAdd();
            form.ShowDialog();
        }

        private void BtnRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            RenewLocalLicenseForm form = new RenewLocalLicenseForm();
            form.ShowDialog();
        }

        private void btnReleaseDrivingLicense_Click(object sender, EventArgs e)
        {
            ReleaseLicenseForm form = new ReleaseLicenseForm();
            form.ShowDialog();
        }

   
        private void btnReplaceDrivingLicense_Click(object sender, EventArgs e)
        {
            ReplaceLicenseForm frm = new ReplaceLicenseForm();
            frm.ShowDialog();
        }
        private void btnApplicationsTypes_Click(object sender, EventArgs e)
        {
            ApplicationTypesForm frm = new ApplicationTypesForm();
            frm.ShowDialog();

        }

        private void btnTestTypes_Click(object sender, EventArgs e)
        {
            TestTypesForm frm = new TestTypesForm();
            frm.ShowDialog();
        }

        private void btnLocalDrivingLicense_Click(object sender, EventArgs e)
        {
            ManageLocalDrivingLicenseApplications frm = new ManageLocalDrivingLicenseApplications();
            frm.ShowDialog();
        }

        private void btnInternationalDrivingLicense_Click(object sender, EventArgs e)
        {
            ManageInternationalLicensesApplicationsForm form =new ManageInternationalLicensesApplicationsForm();
            form.ShowDialog();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            ManageDriversForm form = new ManageDriversForm();
            form.ShowDialog();
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            DetainLicenseForm frm = new DetainLicenseForm();
            frm.ShowDialog();
        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            ReleaseLicenseForm frm = new ReleaseLicenseForm();
            frm.ShowDialog();
        }

        private void DetainedLicenses_Click(object sender, EventArgs e)
        {
            ManageDetainedLicensesForm form = new ManageDetainedLicensesForm();
            form.ShowDialog();
        }

      
    }
}
