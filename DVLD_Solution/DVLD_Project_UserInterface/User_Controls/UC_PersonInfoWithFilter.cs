using BusinessLayer;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class UC_PersonInfoWithFilter : UserControl
    {

        public event Action<int> WhenPersonIsFound;

        protected virtual void PersonIsFound(int personId)
        {
            Action<int> handler = WhenPersonIsFound;
            if (handler!=null)
            {
                handler(personId);
            }
        }


        int _PersonID;

        public UC_PersonInfoWithFilter()
        {
            InitializeComponent();
            _PersonID = -1;
            txtbFind.ContextMenu=new ContextMenu();
        }

        private void GetIDOfNewAddedPerson(int PersonID)
        {
            txtbFind.Text = PersonID.ToString();
            cmbFindBy.SelectedItem = "PersonID";
            UC_PersonCard.LoadPersonInfo(PersonID);

            PersonIsFound(PersonID);
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            Add_EditePeopleForm AddPersonForm = new Add_EditePeopleForm(-1);
            AddPersonForm.DataBack += GetIDOfNewAddedPerson;

            AddPersonForm.ShowDialog();
        }

        private void cmbFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbFind.Clear();
            txtbFind.Focus();
        }

        private void txtbFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtbFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFindBy.SelectedItem.ToString() == "PersonID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; return;
                }
            }
            if (cmbFindBy.SelectedItem.ToString() == "NationalNo")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
            }
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbFind.Text)) return;

            if (cmbFindBy.SelectedItem.ToString() == "PersonID")
            {
                int EnteredID = Convert.ToInt32(txtbFind.Text);
                if (clsPeople.IsPersonExist(EnteredID))
                {
                    _PersonID = EnteredID;
                }
            }

            else _PersonID = clsPeople.GetPersonID(txtbFind.Text);

            if (_PersonID != -1)
            {
                UC_PersonCard.LoadPersonInfo(_PersonID);

                PersonIsFound(_PersonID);
            }
            else
            {
                UC_PersonCard.ResetToInitialValues();
                MessageBox.Show($"There is no person with the entered {cmbFindBy.SelectedItem}. Please check the details and try again.", "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void DisableFilter()
        {
            gbFilter.Enabled = false;
        }
        public void ShowPersonInfoInCard(int PersonId)
        {
            UC_PersonCard.LoadPersonInfo(PersonId);

        }
        private void UC_PersonInfoWithFilter_Load(object sender, EventArgs e)
        {
            cmbFindBy.SelectedIndex = 0;
            txtbFind.Focus();
        }
    }
}
