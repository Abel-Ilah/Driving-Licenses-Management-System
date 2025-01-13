using System;
using System.Data;
using System.Windows.Forms;
using BusinessLayer;

namespace UserInterface
{
    public partial class ApplicationTypesForm : Form
    {
        public ApplicationTypesForm()
        {
            InitializeComponent();
            
        }

        private void LoadApplicationTypesToDataGridView()
        {
            dgvApplicationTypes.DataSource = clsApplicationTypes.GetAllApplicationsTypes().DefaultView;
            dgvApplicationTypes.Columns[0].Width = 100;
            dgvApplicationTypes.Columns[1].Width = 500;
            dgvApplicationTypes.Columns[2].Width = 180;

            lbNumberOfRecords.Text = dgvApplicationTypes.Rows.Count.ToString();
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplicationTypesForm_Load(object sender, EventArgs e)
        {
            LoadApplicationTypesToDataGridView();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateApplicationTypeInfoForm frm =new UpdateApplicationTypeInfoForm(Convert.ToInt32(dgvApplicationTypes.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            dgvApplicationTypes.DataSource = clsApplicationTypes.GetAllApplicationsTypes().DefaultView;
        }
    }
}
