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

namespace DVLDtest.Appoiniments.Vision
{
    public partial class frmScheduleVisionTest : Form
    {
        public delegate void HandlerEvent();
        public HandlerEvent refresh;
        int _createdBy;
        bool insert;
        int testAppointmentID;
        short _rows=0;
        string fullName = "";
        public frmScheduleVisionTest(int localDrivingLAID,string className,string name,int createdBy,short rows, string fullName = "", bool insert = true,int testAppointmentID=0)
        {
            InitializeComponent();
            gdtpDate.MinDate = DateTime.Now;
            lblClass.Text = className;
          this.fullName = fullName;
            lblDIAppID.Text = localDrivingLAID.ToString();
            lblName.Text = name;    
            _createdBy = createdBy;
            if(rows > 0)
            {
                gbRetake.Enabled = true;
                lblTotalFees.Text = "15";
                lblAppFees.Text = "5";
                _rows = rows;
            }
            this.insert = insert;
            this.testAppointmentID = testAppointmentID;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            refresh?.Invoke();
            this.Close();
        }

        private void gabSave_Click(object sender, EventArgs e)
        {
            if (insert && _rows == 0)
            {
                clsTestAppointment testAppointment = new clsTestAppointment();
                testAppointment.paidFees = 10;
                testAppointment.createdByUserID = _createdBy;
                testAppointment.localDrivingLicenseApplicationID = int.Parse(lblDIAppID.Text);
                testAppointment.appointmentDate = DateTime.Parse(gdtpDate.Text);
                testAppointment.isLooked = false;
                testAppointment.testTypeID = 1;
                if (testAppointment.save())
                {
                    MessageBox.Show("This Appointment Saved!!");
                    lblAppointmentID.Text = testAppointment.testAppointmentID.ToString();
                }
                else
                {
                    MessageBox.Show("Something wrong !!!");

                }
            }
            else if(insert)
            {
                clsApplication application = new clsApplication();
                application.applicationDate = DateTime.Parse(gdtpDate.Text);
                application.lastStatusDate = DateTime.Parse(gdtpDate.Text);
                application.createdByUserID= _createdBy;
                application.applicationTypeID = 2;
                application.applicationStatus = 1;
                application.paidFees = 5;
                application.applicantPersonID = clsPerson.getPersonIDByFullName(fullName);
                application.save();


                clsTestAppointment testAppointment = new clsTestAppointment();
                testAppointment.paidFees = 10;
                testAppointment.createdByUserID = _createdBy;
                testAppointment.localDrivingLicenseApplicationID = int.Parse(lblDIAppID.Text);
                testAppointment.appointmentDate = DateTime.Parse(gdtpDate.Text);
                testAppointment.isLooked = false;
                testAppointment.testTypeID = 1;
                if (testAppointment.save())
                {
                    MessageBox.Show("This Appointment Saved!!");
                    lblAppointmentID.Text = testAppointment.testAppointmentID.ToString();
                    lblDIAppID.Text = testAppointment.testAppointmentID.ToString();
                }
                else
                {
                    MessageBox.Show("Something wrong !!!");

                }
            }
            else
            {
                clsTestAppointment.updateTestAppointmentDate(testAppointmentID, DateTime.Parse(gdtpDate.Text));
                MessageBox.Show("This Appointment Updated!!");
            }
        }

        private void frmScheduleTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            refresh?.Invoke();
        }
    }
}
