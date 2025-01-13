using BusinessLayer;
using System;
using System.Windows.Forms;


namespace UserInterface
{
    public partial class TestTypesForm : Form
    {
        public TestTypesForm()
        {
            InitializeComponent();
        }
        private void LoadTestTypesToDataGridView()
        {
            dgvTestTypes.DataSource = clsTestTypes.GetAllTestTypes().DefaultView;
           
            dgvTestTypes.Columns["Title"].Width = 210;
            dgvTestTypes.Columns["Description"].Width = 470;

            lbNumberOfRecords.Text = dgvTestTypes.Rows.Count.ToString();
        }

        private void TestTypesForm_Load(object sender, System.EventArgs e)
        {
            LoadTestTypesToDataGridView();
        }

        private void updateToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
         UpdateTestTypeInfoForm frm = new UpdateTestTypeInfoForm(Convert.ToByte(dgvTestTypes.CurrentRow.Cells[0].Value));
         frm.ShowDialog();
         dgvTestTypes.DataSource = clsTestTypes.GetAllTestTypes().DefaultView;
        }
    }
}
