using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FormSelectTypeOfLicenseToAdd : Form
    {
        public FormSelectTypeOfLicenseToAdd()
        {
            InitializeComponent();
        }


        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Width += 8;
            ((PictureBox)sender).Height += 8;
            ((PictureBox)sender).Top -= 4;
            ((PictureBox)sender).Left -= 4;
        }
        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Width -= 8;
            ((PictureBox)sender).Height -= 8;
            ((PictureBox)sender).Top += 4;
            ((PictureBox)sender).Left += 4;
        }

     
        private void pbLocalDrivingLicense_Click(object sender, EventArgs e)
        {
            AddOrEditLocalDrivingLicenseApplicationsForm frm = new AddOrEditLocalDrivingLicenseApplicationsForm(-1);
            frm.ShowDialog();
        }

        private void pbInternationalDrivingLicense_Click(object sender, EventArgs e)
        {
            IssueInternationalLicenseForm form = new IssueInternationalLicenseForm();
            form.ShowDialog();
        }
    }
}
