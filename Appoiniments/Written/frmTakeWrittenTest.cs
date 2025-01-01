using LogicLayerDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDtest.Appoiniments.Written
{
    public partial class frmTakeWrittenTest : Form
    {
        int _TestAppointment;
        int _CreatedBy;
        public delegate void HandlerEvent();
        public HandlerEvent refresh;
        public frmTakeWrittenTest(int createdBy, int DLappID, string className, string name, DateTime date, decimal fees, int testAppontmentID, int trial)
        {
            InitializeComponent();
            _TestAppointment = testAppontmentID;
            lblDLAppID.Text = DLappID.ToString();
            lblClass.Text = className;
            lblName.Text = name;
            lblDate.Text = date.ToString();
            lblFees.Text = fees.ToString();
            _CreatedBy = createdBy;
            lblTrial.Text = trial.ToString();
        }

        private void gabSave_Click(object sender, EventArgs e)
        {
            clsTest test = new clsTest();
            test.testAppointmentID = _TestAppointment;
            test.notes = txtNotes.Text;
            test.createdByUserID = _CreatedBy;
            if (rbPass.Checked)
            {
                test.testResult = true;
            }
            else
            {
                test.testResult = false;
            }
            if (test.save())
            {
                clsTestAppointment.updateTestAppointmentLocked(_TestAppointment, true);
                MessageBox.Show("Successfully!!!");
                gabSave.Enabled = false;
                lblTestID.Text = test.testID.ToString();
            }
            else
            {
                MessageBox.Show("Somethin wrong!!");

            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            refresh?.Invoke();
            this.Close();
        }

        private void frmTakeWrittenTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            refresh?.Invoke();
        }
    }
}
