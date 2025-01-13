using BusinessLayer;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UserInterface
{
    public partial class AddOrEditLocalDrivingLicenseApplicationsForm : Form
    {
        private enum enMode { eAddNew = 1, eUpdate = 2 }
        enMode _Mode;

        int _DrivingLicenseApplicationID;
        clsLocalDrivingLicenseApplications _DrivingLicenseApplication;

        DataTable _LicenseClassesTable;

        bool IsFirstClickOnNextButton;
        public AddOrEditLocalDrivingLicenseApplicationsForm(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            if (LocalDrivingLicenseApplicationID == -1)
                _Mode = enMode.eAddNew;
            else _Mode = enMode.eUpdate;

            _DrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            IsFirstClickOnNextButton = true;
        }

        private void ShowSaveButton()
        {
            btnNext.Visible = false;
            btnSave.Visible = true;
        }
        private void HideSaveButton()
        {
            btnNext.Visible = true;
            btnSave.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (IsFirstClickOnNextButton)
            {
                if (_Mode == enMode.eAddNew && _DrivingLicenseApplication.ApplicantPersonID == -1)
                {
                    MessageBox.Show("Please link a person to this Application  before proceeding.", "Link Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                IsFirstClickOnNextButton = false;
            }

            btnPrev.Enabled = true;
            ShowSaveButton();
            tabcontrolApplication.SelectedTab = tabcontrolApplication.TabPages["ApplicationInfoPage"];
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            btnPrev.Enabled = false;
            HideSaveButton();
            tabcontrolApplication.SelectedTab = tabcontrolApplication.TabPages["PersonalInfoPage"];
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        void FillComboBoxWithLicenseClassesNames()
        {
            _LicenseClassesTable = clsLicenseClasses.GetLicenseClassesList();
            cmbLicenseClasses.DisplayMember = "ClassName";
            cmbLicenseClasses.ValueMember = "LicenseClassID";
            cmbLicenseClasses.DataSource = _LicenseClassesTable;
            cmbLicenseClasses.SelectedIndex = 2;
        }
        void ShowFormInUpdateMode()
        {
            _DrivingLicenseApplication = clsLocalDrivingLicenseApplications.Find(_DrivingLicenseApplicationID);

            if (_DrivingLicenseApplication == null)
            {
                MessageBox.Show("The Application was not found in the system", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            lbFormMode.Text = "Update Local Driving License Application";

            uC_PersonInfoWithFilter1.ShowPersonInfoInCard(_DrivingLicenseApplication.ApplicantPersonID);
            uC_PersonInfoWithFilter1.DisableFilter();

            lbDrivingLicenseApplicationId.Text = _DrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lbDrivingLicenseApplicationDate.Text = _DrivingLicenseApplication.ApplicationDate.ToShortDateString();
            cmbLicenseClasses.SelectedValue = _DrivingLicenseApplication.LicenseClassID;
            lbApplicationFees.Text = _DrivingLicenseApplication.PaidFees.ToString();
            lbUserName.Text = clsUsers.FindByUserID(_DrivingLicenseApplication.CreatedByUserID).UserName;
        }
        private void AddOrEditApplicationsForm_Load(object sender, EventArgs e)
        {
            FillComboBoxWithLicenseClassesNames();

            btnPrev.Enabled = false;

            if (_Mode == enMode.eAddNew)
            {
                lbFormMode.Text = "Add New Local Driving License Application";

                _DrivingLicenseApplication = new clsLocalDrivingLicenseApplications();

                lbDrivingLicenseApplicationDate.Text = DateTime.Now.ToShortDateString();
                lbApplicationFees.Text = clsApplicationTypes.Find(1).ApplicationFees.ToString();
                lbUserName.Text = GlobalSettings.CurrentUser.UserName;

                return;
            }
            ShowFormInUpdateMode();
        }

        private void uC_PersonInfoWithFilter1_WhenPersonIsFound(int obj)
        {
            if (_Mode == enMode.eAddNew && obj > -1)
            {
                _DrivingLicenseApplication.ApplicantPersonID = obj;
            }
        }

        byte GetMinimumAllowedAge()
        {
            byte age = 18;
            foreach (DataRow row in _LicenseClassesTable.Rows)
            {
                if ((int)row["LicenseClassID"] == (int)cmbLicenseClasses.SelectedValue)
                {
                    age =Convert.ToByte( row["MinimumAllowedAge"]);
                    break;
                }
            }
            return age;
        }
        byte GetApplicantPersonAge()
        {
           return Convert.ToByte(DateTime.Now.Year - clsPeople.Find(_DrivingLicenseApplication.ApplicantPersonID).DateOfBirth.Year);
            
        }

        bool PersonHasActiveOrCompletedDrivingLicenseApplication()
        {
            int ActiveLocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplications.GetActiveLocalDrivingLicenseApplicationID(_DrivingLicenseApplication.ApplicantPersonID, Convert.ToInt32(cmbLicenseClasses.SelectedValue));
            int CompletedLocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplications.GetCompletedLocalDrivingLicenseApplicationID(_DrivingLicenseApplication.ApplicantPersonID, Convert.ToInt32(cmbLicenseClasses.SelectedValue));

                if (CompletedLocalDrivingLicenseApplicationID != -1)
                {
                    MessageBox.Show($"This Person Already have a License with the same applied License Class!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return true;
                }
                if (ActiveLocalDrivingLicenseApplicationID != -1)
                {
                    MessageBox.Show($"This Person is Already have an Active Application For this License Class with ID={ActiveLocalDrivingLicenseApplicationID}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return true;
                }
            
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte ApplicantPersonAge = GetApplicantPersonAge();
            int MinimumAllowedAge = GetMinimumAllowedAge();

            if (ApplicantPersonAge < MinimumAllowedAge)
            {
                MessageBox.Show($"The Age of this Person ({ApplicantPersonAge}) does not meet the minimum allowed age of {MinimumAllowedAge}.", "Age Restriction", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

           
            switch (_Mode)
            {
             case enMode.eAddNew:

                    if (PersonHasActiveOrCompletedDrivingLicenseApplication()) return;

                    _DrivingLicenseApplication.ApplicationDate = DateTime.Now;
                    _DrivingLicenseApplication.ApplicationTypeID = 1;
                    _DrivingLicenseApplication.ApplicationStatus = 1;
                    _DrivingLicenseApplication.LastStatusDate = DateTime.Now;
                    _DrivingLicenseApplication.PaidFees = Convert.ToDecimal(lbApplicationFees.Text);
                    _DrivingLicenseApplication.CreatedByUserID = GlobalSettings.CurrentUser.UserID;
                    _DrivingLicenseApplication.LicenseClassID = (int)cmbLicenseClasses.SelectedValue;

                    if (_DrivingLicenseApplication.Save())
                    {
                       MessageBox.Show("New Application has been added successfully.", " Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       _Mode = enMode.eUpdate;
                       lbFormMode.Text = "Update Local Driving License Application";
                       lbDrivingLicenseApplicationId.Text = _DrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                    }
                    else
                     MessageBox.Show("Operation Failed,Something Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;

             case enMode.eUpdate:

                    if (_DrivingLicenseApplication.LicenseClassID == Convert.ToInt32(cmbLicenseClasses.SelectedValue)) return;

                    if (PersonHasActiveOrCompletedDrivingLicenseApplication()) return;

                    _DrivingLicenseApplication.LicenseClassID = Convert.ToInt32(cmbLicenseClasses.SelectedValue);

                    if (_DrivingLicenseApplication.Save())
                        MessageBox.Show("Application has been Updated successfully.", " Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Operation Failed,Something Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
               
            }




           

            
        }
    }
}