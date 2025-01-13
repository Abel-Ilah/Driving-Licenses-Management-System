using BusinessLayer;
using System;

using System.Windows.Forms;
using UserInterface.Properties;

namespace UserInterface
{
    public partial class UC_PersonInfo : UserControl
    {
       
        clsPeople _Person;
       
        public UC_PersonInfo()
        {
            InitializeComponent();
        }
      
        private void SetDefaultPersonImage()
        {
            if (_Person.Gender == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

        }

        public void  ResetToInitialValues() 
        {
            btnEdit.Enabled = false;
            lbName.Text = "???????????";
            lbPersonID.Text = "???????????";
            lbNationalNo.Text = "???????????";
            lbCountry.Text = "???????????";
            lbAddress.Text = "???????????";
            lbEmail.Text = "???????????";
            lbBirthDate.Text = "???????????";
            lbPhone.Text = "???????????";
            lbGender.Text = "???????????";

            pbPersonImage.Image = Resources.Male_512;

            _Person = null;
        }
        public void LoadPersonInfo(int PersonID)
        {
            if (PersonID!=-1)
                _Person = clsPeople.Find(PersonID);
            
            if (_Person == null)
            {
                MessageBox.Show("The person was not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetToInitialValues();
                return;
            }
            btnEdit.Enabled = true;
            lbName.Text = _Person.FullName;
            lbPersonID.Text = _Person.ID.ToString();
            lbNationalNo.Text = _Person.NationalNo;
            lbCountry.Text = clsCountries.Find(_Person.CountryID).Name;
            lbAddress.Text = _Person.Address;
            lbEmail.Text = _Person.Email;
            lbBirthDate.Text = _Person.DateOfBirth.ToShortDateString();

            if (_Person.Gender == 0) { lbGender.Text = "Male"; pbGender.Image = Resources.Man_32; }
            else { lbGender.Text = "Female"; pbGender.Image = Resources.Woman_32; }

            lbPhone.Text = _Person.Phone;

            if (!string.IsNullOrEmpty(_Person.ImagePath))
            {
                try { pbPersonImage.ImageLocation=_Person.ImagePath; }
                catch (Exception ex)
                {
                    MessageBox.Show("The Person's image path was not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pbPersonImage.Image = Resources.MissedImage;
                    GlobalSettings.LoggingAnException("DVLD", ex.Message);
                }
            }
            else    SetDefaultPersonImage();
        }
      
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Add_EditePeopleForm frm1 = new Add_EditePeopleForm(_Person.ID);
            frm1.ShowDialog();
            LoadPersonInfo(_Person.ID);

        }

        
    }
}
