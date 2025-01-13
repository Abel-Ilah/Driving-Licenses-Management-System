using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace UserInterface
{
    public partial class TakeTestForm : Form
    {
     
        int _testAppointmentId=-1;
        clsTestsAppointments _Appointment;
        clsTests _test;
        public TakeTestForm(int TestAppointmentID)
        {
            InitializeComponent();
            _testAppointmentId = TestAppointmentID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TakeTestForm_Load(object sender, EventArgs e)
        {
            _Appointment = clsTestsAppointments.Find(_testAppointmentId);
            if (_Appointment==null)
            {
                MessageBox.Show("Appointment does not exist in the system!","Appointment not found.",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            _test = new clsTests();
            uC_ScheduledTest1.LoadTestAppointmentInfo(_testAppointmentId);
            rbPass.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save the Test With this Result?\n You won't be able to change it later.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {

                _test.TestAppointmentID = _testAppointmentId;
                _test.Result = (rbPass.Checked == true);
                _test.Notes = txtbNotes.Text;
                _test.CreatedByUserID = GlobalSettings.CurrentUser.UserID;
                if (_test.Save())
                {
                    _Appointment.IsLocked = true;
                    if (_Appointment.Save())
                    {
                        MessageBox.Show("Data Saved Successfully.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        uC_ScheduledTest1.TestID = _test.TestID;
                        panelSaveResults.Enabled = false;
                        //Close();
                    }
                }
                else MessageBox.Show("Operation Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Operation Canceled", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
