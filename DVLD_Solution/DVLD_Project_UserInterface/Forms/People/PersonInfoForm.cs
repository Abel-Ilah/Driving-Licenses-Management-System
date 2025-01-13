using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class PersonInfoForm : Form
    {
       int _PersonID=-1;
        public PersonInfoForm(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void PersonInfoForm_Load(object sender, EventArgs e)
        {
            UC_personInfo.LoadPersonInfo(_PersonID);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

    
    }
}
