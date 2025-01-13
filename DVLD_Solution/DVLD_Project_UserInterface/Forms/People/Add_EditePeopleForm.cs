using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;
using UserInterface.Properties;



namespace UserInterface
{
    public partial class Add_EditePeopleForm : Form
    {
        private enum enMode { eAddNew = 1, eUpdate = 2 }
        enMode _Mode;
        private int _PersonID;
        string _SelectedImagePath=string.Empty;
        clsPeople _Person;

        DataTable Countries;

        public Add_EditePeopleForm(int ID)
        {
            InitializeComponent();

            if (ID == -1) _Mode = enMode.eAddNew;
            else          _Mode = enMode.eUpdate;

            _PersonID = ID;
        }


        public delegate void DataBackEventHandler(int PersonID);

        public event DataBackEventHandler DataBack;

        private void MouseEnterBtn(object sender, EventArgs e)
        {
            ((PictureBox)sender).Height += 4;
            ((PictureBox)sender).Width += 4;
            ((PictureBox)sender).Top -= 2;
            ((PictureBox)sender).Left -= 2;
        }

        private void MouseLeaveBtn(object sender, EventArgs e)
        {
            ((PictureBox)sender).Height -= 4;
            ((PictureBox)sender).Width -= 4;
            ((PictureBox)sender).Top += 2;
            ((PictureBox)sender).Left += 2;
        }

        private int GetCountryID(String CountryName) 
        {
            int countryID = 1;
            DataRow[] rows = Countries.Select($"CountryName = '{CountryName}'");
            if (rows.Length > 0)
            {
                 countryID = (int)rows[0]["CountryID"];
            }
            return countryID;
        }
       
        private void FillComboBoxWithCountries()
        {
            Countries =clsCountries.GetCountriesList();
            cmbCountries.DataSource = Countries;
            cmbCountries.DisplayMember = "CountryName";
            cmbCountries.ValueMember = "CountryID";
            cmbCountries.SelectedValue= GetCountryID("Morocco");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void NameValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtbNationalNo_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-')
           {
               e.Handled = true;
           }
        }
        private bool IsNationalNoInCorrectForm()
        {

            if ((_Mode != enMode.eUpdate) || txtbNationalNo.Text.ToLower() != _Person.NationalNo.ToString().ToLower())
            {
                if (clsPeople.GetPersonID(txtbNationalNo.Text)!=-1)
                {
                    errorProvider1.SetError(txtbNationalNo, "This ID Card Number is Already Exists");
                    txtbNationalNo.Focus();
                    return false;
                }
            }
            errorProvider1.SetError(txtbNationalNo, string.Empty);
            return true;
        }

        private bool IsEmailInCorrectForm(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private bool IsValidEmail()
        {

            if (IsEmailInCorrectForm(txtbEmail.Text)|| string.IsNullOrEmpty(txtbEmail.Text))
            {
                errorProvider1.SetError(txtbEmail, string.Empty);
                return true;
            }
            else
            {
                errorProvider1.SetError(txtbEmail, "Email is not in the Correct Format!");
                return false;
            }
        }
        private void ShowFormInUpdateMode()
        {
            lbMode.Text = "Update Person";
           
            _Person = clsPeople.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("The person was not found in the system", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lbPersonID.Text = _Person.ID.ToString();
            txtbNationalNo.Text = _Person.NationalNo;
            txtbFirstName.Text = _Person.FirstName;
            txtbLastName.Text = _Person.LastName;
            txtbSecondName.Text = _Person.SecondName;
            txtbThirdName.Text = _Person.ThirdName;
            txtbEmail.Text = _Person.Email;
            txtbPhone.Text = _Person.Phone;
            dtDateOfBirth.Value = _Person.DateOfBirth;
            txtbAddress.Text = _Person.Address;

            if (_Person.Gender == 0)
                rbMale.Checked = true;
            if (_Person.Gender == 1)
                rbFemale.Checked = true;

            cmbCountries.SelectedValue = _Person.CountryID;

            _SelectedImagePath = _Person.ImagePath;

            if (_Person.ImagePath!=string.Empty)
            {
                try
                {
                    pbPersonImage.ImageLocation=_Person.ImagePath;
                }
                catch (Exception)
                {
                    MessageBox.Show("The Person's image path was not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pbPersonImage.Image = Resources.MissedImage;
                }
            }
            else
                SetDefaultPersonImage();
            
        }
        private void Add_EditeForm_Load(object sender, EventArgs e)
        {
            dtDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            rbMale.Checked = true;
            FillComboBoxWithCountries();
            OpenFileDialogSettings();
            lbMode.Text = "Add New Person";

            if (_Mode==enMode.eAddNew)
            {
                _Person=new clsPeople();
                return;
            }
            ShowFormInUpdateMode();
        }

        private bool EmptyTextBox(TextBox textbox)
        {
            if (string.IsNullOrEmpty(textbox.Text.Trim()))
            {
              
                errorProvider1.SetError(textbox, "This field can not be empty. Please enter a value.");
                return true;
            }
            else
            {
                errorProvider1.SetError(textbox, string.Empty);
                return false;
            }
        }
        private bool AllInputsAreNotEmpty()
        {
            return (!EmptyTextBox(txtbFirstName)) && (!EmptyTextBox(txtbSecondName)) && (!EmptyTextBox(txtbLastName)) &&
                 (!EmptyTextBox(txtbNationalNo)) && (!EmptyTextBox(txtbPhone)) && (!EmptyTextBox(txtbAddress));
        }

        private void txtbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtbNationalNo_TextChanged(object sender, EventArgs e)
        {
            IsNationalNoInCorrectForm();

        }

        private bool SavePersonData()
        {
            _Person.NationalNo= txtbNationalNo.Text;
            _Person.FirstName= txtbFirstName.Text;
            _Person.SecondName = txtbSecondName.Text;
            _Person.ThirdName = txtbThirdName.Text;
            _Person.LastName = txtbLastName.Text;
            _Person.Email = txtbEmail.Text;
            _Person.Phone= txtbPhone.Text;
            _Person.DateOfBirth=dtDateOfBirth.Value;

            if (rbMale.Checked) _Person.Gender = 0;
            else                _Person.Gender = 1;
           
            _Person.Address=txtbAddress.Text;


            _Person.CountryID = Convert.ToInt32(cmbCountries.SelectedValue);

            SavePersonImagePath();

            return _Person.Save();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (AllInputsAreNotEmpty() && IsNationalNoInCorrectForm() && IsValidEmail())
            {
                if (SavePersonData())
                {
                   
                    lbMode.Text = "Update Person";
                    _PersonID = _Person.ID;
                    lbPersonID.Text = _PersonID.ToString();
                   
                    // change current user Info in main screen after updating it's info : 
                    if (_Mode==enMode.eUpdate && _Person.ID==GlobalSettings.CurrentUser.PersonID)
                    {
                        if (MainForm.instance.lbCurrentUserFirstName.Text != txtbFirstName.Text)
                            MainForm.instance.lbCurrentUserFirstName.Text = txtbFirstName.Text;

                        if (MainForm.instance.pbCurrentUserImage.ImageLocation != _Person.ImagePath)
                        {
                            if (!string.IsNullOrEmpty(_Person.ImagePath))
                            {
                                try
                                {
                                    MainForm.instance.pbCurrentUserImage.ImageLocation = clsPeople.Find(GlobalSettings.CurrentUser.PersonID).ImagePath;
                                }
                                catch (Exception) { MainForm.instance.pbCurrentUserImage.Image = Resources.personLogo; }
                            }
                            else MainForm.instance.pbCurrentUserImage.Image = Resources.personLogo;
                        }
                          
                    }

                    MessageBox.Show("Data Saved Successfully.");
                    DataBack?.Invoke(Convert.ToInt32(_Person.ID));

                    _Mode = enMode.eUpdate;
                }
                else MessageBox.Show("Operation Failed,Data has not been Saved!", "Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }

        }

        private void txtbNationalNo_Leave(object sender, EventArgs e)
        {
            IsNationalNoInCorrectForm();
            EmptyTextBox(txtbNationalNo);
        }

        private void SetDefaultPersonImage()
        {
            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (_SelectedImagePath==string.Empty)
            {
                SetDefaultPersonImage();
            }
        }

        private void OpenFileDialogSettings()
        {
           // openFileDialog1.Title = "Person Image";
            openFileDialog1.InitialDirectory = @"C:\Users\hp\Desktop\Folders\Images";
            openFileDialog1.Filter = "PNG|*.PNG|JPG|*.JPG";
            openFileDialog1.FilterIndex= 0;
            openFileDialog1.FileName = "";
            openFileDialog1.Multiselect = false;
       
        }

        private void SavePersonImagePath()
        {
            if (_SelectedImagePath == _Person.ImagePath)
                return;

            
            if (!string.IsNullOrEmpty(_Person.ImagePath))
            {
                    if (File.Exists(_Person.ImagePath))
                    try
                    { // delete old Image form Folder: 
                        File.Delete(_Person.ImagePath);
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error (The Image has not been Deleted From the File): {ex.Message}", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }

            string NewPersonImagePath = string.Empty;

           
            if (!string.IsNullOrEmpty(_SelectedImagePath))
            {       // Add new Image to Folder: 
                do
                {
                   NewPersonImagePath = GetNewImagePath(@"C:\PeopleImages\");
                }
                while (File.Exists(NewPersonImagePath));

                File.Copy(_SelectedImagePath, NewPersonImagePath, true);
            }

            if (string.IsNullOrEmpty(_SelectedImagePath))
                NewPersonImagePath = "";
            

            _Person.ImagePath = NewPersonImagePath;

        }

        string GetNewImagePath(string FolderPath)
        {
            Guid guid = Guid.NewGuid();

            string FileType = ".PNG";
            if (openFileDialog1.FilterIndex == 2)
            {
                FileType = ".JPG";
            }

            return FolderPath + guid + FileType;
        }
        private void pbAddPersonImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbPersonImage.Image.Dispose();
                pbPersonImage.Image = null;
                pbPersonImage.ImageLocation= openFileDialog1.FileName;
                _SelectedImagePath = openFileDialog1.FileName;
            }
        }

        
        private void pbRemovePersonImage_Click(object sender, EventArgs e)
        {
            pbPersonImage.Image.Dispose();
            pbPersonImage.Image = null;
            _SelectedImagePath = string.Empty;
            SetDefaultPersonImage();
           
        }

        private void txtbFirstName_Leave(object sender, EventArgs e)
        {
            EmptyTextBox(txtbFirstName);
        }

        private void txtbSecondName_Leave(object sender, EventArgs e)
        {
            EmptyTextBox(txtbSecondName);
        }

        private void txtbLastName_Leave(object sender, EventArgs e)
        {
            EmptyTextBox(txtbLastName);
        }

     

        private void txtbPhone_Leave(object sender, EventArgs e)
        {
            EmptyTextBox(txtbPhone);
        }

        private void txtbAddress_Leave(object sender, EventArgs e)
        {
            EmptyTextBox(txtbAddress);
        }

        private void txtbEmail_Leave(object sender, EventArgs e)
        {
            IsValidEmail();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtbAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar == '\\')
            {
                e.Handled = true; 
            }
        }

        
    }
}
