using DVLDtest.Appoiniments.Vision;
using DVLDtest.Tests;
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
    public partial class frmWrittenTestAppointments : Form
    {
        int _createdBy;
        public delegate void HandlerEvent();
        public HandlerEvent refresh;
        public frmWrittenTestAppointments(int localDrivingID, int applicationID, int createdBy)
        {
            InitializeComponent();
            ucDrivingLicenseApplicationInfo1._localDrivingLicenseApplicationID = localDrivingID;
            ucDrivingLicenseApplicationInfo1.loadTheInfo();
            ucApplicationBasicInfo1.applicationID = applicationID;
            ucApplicationBasicInfo1.loadTheInfo();
            dgvTests.DataSource = clsTest.getAllTestsforSpecificLocalDrivingLicense(localDrivingID,2);
            lblRecords.Text = dgvTests.RowCount.ToString();
            _createdBy = createdBy;
        }

        private void gabAddVision_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            foreach (DataGridViewRow row in dgvTests.Rows)
            {
                if ((bool)row.Cells["IsLocked"].Value == false || ucDrivingLicenseApplicationInfo1.passedTests == 2)
                {
                    MessageBox.Show("You can't book this test again, you have one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                short rows = (short)dgvTests.Rows.Count;
                frmScheduleWrittenTest scheduleTest = new frmScheduleWrittenTest(ucDrivingLicenseApplicationInfo1._localDrivingLicenseApplicationID, ucDrivingLicenseApplicationInfo1.lblClass.Text, ucApplicationBasicInfo1.lblApplicant.Text, _createdBy, rows, ucApplicationBasicInfo1.lblApplicant.Text);
                scheduleTest.refresh += refreshData;
                scheduleTest.ShowDialog();
            }
        }
        private void refreshData()
        {
            dgvTests.DataSource = clsTest.getAllTestsforSpecificLocalDrivingLicense(ucDrivingLicenseApplicationInfo1._localDrivingLicenseApplicationID,2);
            lblRecords.Text = dgvTests.RowCount.ToString();
        }

        private void gabClose_Click(object sender, EventArgs e)
        {
            refresh?.Invoke();
            this.Close();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isLocked = false;

            if ((bool)dgvTests.CurrentRow.Cells["IsLocked"].Value == true)
            {
                MessageBox.Show("You can't take this test again, you take it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isLocked = true;
            }
            if (!isLocked)
            {
                DateTime dateTime = (DateTime)dgvTests.CurrentRow.Cells["AppointmentDate"].Value;
                decimal fees = (decimal)dgvTests.CurrentRow.Cells["PaidFees"].Value;
                int testAppointmentID = (int)dgvTests.CurrentRow.Cells["TestAppointmentID"].Value;
                int trial = dgvTests.Rows.Count;
                frmTakeTest takeTest = new frmTakeTest(_createdBy, ucDrivingLicenseApplicationInfo1._localDrivingLicenseApplicationID, ucDrivingLicenseApplicationInfo1.lblClass.Text, ucApplicationBasicInfo1.lblApplicant.Text, dateTime, fees, testAppointmentID, trial);
                takeTest.refresh += refreshData;
                takeTest.ShowDialog();
            }
        }

        private void editDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isLocked = false;

            if ((bool)dgvTests.CurrentRow.Cells["IsLocked"].Value == true)
            {

                MessageBox.Show("You can't edit this test, you take it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isLocked = true;
            }

            if (!isLocked)
            {
                int testAppointmentID = (int)dgvTests.CurrentRow.Cells["TestAppointmentID"].Value;
                short rows = (short)dgvTests.Rows.Count;
                frmScheduleWrittenTest scheduleTest = new frmScheduleWrittenTest(ucDrivingLicenseApplicationInfo1._localDrivingLicenseApplicationID, ucDrivingLicenseApplicationInfo1.lblClass.Text, ucApplicationBasicInfo1.lblApplicant.Text, _createdBy, rows, ucApplicationBasicInfo1.lblApplicant.Text, false, testAppointmentID);
                scheduleTest.refresh += refreshData;
                scheduleTest.ShowDialog();
            }
        }

        private void frmWrittenTestAppointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            refresh?.Invoke();
        }
    }
}
