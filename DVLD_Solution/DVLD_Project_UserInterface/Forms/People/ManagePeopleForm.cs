using BusinessLayer;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class ManagePeopleForm : Form
    {
        DataTable _PeopleTable;
       
        public ManagePeopleForm()
        {
            InitializeComponent();
            _PeopleTable=clsPeople.GetPeopleList();
            txtbFilter.ContextMenu=new ContextMenu();
        }

        private void RefreshPeopleList()
        {
            _PeopleTable = clsPeople.GetPeopleList();
            dgvPeople.DataSource = _PeopleTable.DefaultView;
            lbNumberOfPeople.Text = dgvPeople.RowCount.ToString();
        }

        private void ManagePeopleForm_Load(object sender, EventArgs e)
        {
            RefreshPeopleList();
            cmbFilterBy.SelectedIndex = 0;
        }

        void FilterDataGridView(string Filter)
        {
            _PeopleTable.DefaultView.RowFilter = Filter;
            dgvPeople.DataSource= _PeopleTable.DefaultView;
            lbNumberOfPeople.Text = dgvPeople.Rows.Count.ToString();
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDataGridView("");

            if (cmbFilterBy.SelectedItem.ToString() == "None")
            {
                txtbFilter.Visible = false;
            }
            else
            {
                txtbFilter.Visible = true;
                txtbFilter.Clear();
                txtbFilter.Focus();
            }

        }

        private void txtbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterBy.SelectedItem.ToString() == "PersonID" || cmbFilterBy.SelectedItem.ToString() == "Phone")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;return;
                }
            }
            if (cmbFilterBy.SelectedItem.ToString() == "NationalNo")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
            }
           
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Add_EditePeopleForm AddNewPersonForm = new Add_EditePeopleForm(-1);
            AddNewPersonForm.ShowDialog();
            RefreshPeopleList();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_EditePeopleForm UpdatePersonForm = new Add_EditePeopleForm(Convert.ToInt32(dgvPeople.CurrentRow.Cells[0].Value));
            UpdatePersonForm.ShowDialog();
            RefreshPeopleList();
        }


        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonInfoForm frm = new PersonInfoForm(Convert.ToInt32(dgvPeople.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            RefreshPeopleList();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this person from the system ? ", "Confirm the operation",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
    
                int PersonIDToDelete = Convert.ToInt32(dgvPeople.CurrentRow.Cells[0].Value);
                string PersonImagePath = "";

                if (!string.IsNullOrEmpty(clsPeople.Find(PersonIDToDelete).ImagePath))
                         PersonImagePath = clsPeople.Find(PersonIDToDelete).ImagePath; 

                if (clsPeople.Delete(PersonIDToDelete))
                {
                    MessageBox.Show("This person has been deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshPeopleList();
                    if (File.Exists(PersonImagePath)) { File.Delete(PersonImagePath); }

                }
                else
                    MessageBox.Show("This person can't be deleted because it is linked to other data on the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
           
        }

        private void txtbFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtbFilter_TextChanged(object sender, EventArgs e)
        {
            string Filter = $"CONVERT({cmbFilterBy.SelectedItem},'System.String') like'%{txtbFilter.Text}%'"; ;
            FilterDataGridView(Filter);
        }
    }
}
