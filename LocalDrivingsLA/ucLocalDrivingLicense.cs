using DVLDtest.People;
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
using static System.Net.Mime.MediaTypeNames;

namespace DVLDtest.Applications
{
    public partial class ucLocalDrivingLicense : UserControl
    {
        int _CreatedUserID;
        DataTable licenseClasses = clsLicenseClass.getAllLicenseClasses();
        public ucLocalDrivingLicense(int createdUserID)
        {
            InitializeComponent();
            _CreatedUserID = createdUserID;
            foreach (DataRow dr in licenseClasses.Rows) 
            { 
            cmbLicenseClass.Items.Add(dr["ClassName"].ToString());
            }
            tabControl1.TabPages[1].Enabled = false;
        }
     
        private void frmPersonForm_DataBack(int PersonID)
        {
            // Handle the data received from Form2
            ucPersonCardwithFilter1.personID = PersonID;
            ucPersonCardwithFilter1.loadTheInfo();

        }

        private void ucPersonCardwithFilter1_showPersonForm_1(int obj)
        {
            frmPersonForm personForm = new frmPersonForm(-1);
            personForm.DataBack += frmPersonForm_DataBack;
            personForm.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ucPersonCardwithFilter1.personID > 0)
            {
                tabControl1.TabPages[1].Enabled = true;
                cmbLicenseClass.SelectedIndex = 0;
                lblApplicationDate.Text = DateTime.Now.ToShortDateString();
                lblApplicationFees.Text = "15";
                lblCreatedBy.Text = clsUser.getUserNameByID(_CreatedUserID);
                tabControl1.SelectTab("tabApplication");

            }
            else
            {
                tabControl1.TabPages[1].Enabled = false;
            }
        }
        bool applicationisnitFound()
        {
            bool isNotFound = true;
            DataTable ApllicationsID = clsApplication.getAllApllicationsID(ucPersonCardwithFilter1.personID);
            int licenseClass = cmbLicenseClass.SelectedIndex + 1;
            foreach (DataRow dr in ApllicationsID.Rows)
            {
                if (clsLocalDrivingLA.isLocalDrivingExisting((int)dr["ApplicationID"], licenseClass))
                {
                    isNotFound = false;
                    break;
                }
                
            }
            return isNotFound;

        }

        clsApplication putValuesinApplication()
        {
            clsApplication application = new clsApplication();
            application.applicantPersonID = ucPersonCardwithFilter1.personID;
            application.applicationTypeID = 1;
            application.applicationStatus = 1;
            application.lastStatusDate = DateTime.Now;
            application.paidFees = int.Parse(lblApplicationFees.Text);
            application.createdByUserID = _CreatedUserID;
            return application;

        }

        clsLocalDrivingLA putValuesinLocalDrivingLA()
        {
            int licenseClass = cmbLicenseClass.SelectedIndex + 1;
            clsLocalDrivingLA localDrivingLA = new clsLocalDrivingLA();
            localDrivingLA.applicationID = int.Parse(lblApplicationID.Text);
            localDrivingLA.licenseClassID = licenseClass;
            return localDrivingLA;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isNotFound = applicationisnitFound();
           
            if(isNotFound)
            {
                clsApplication application = putValuesinApplication();
                if(application.save())
                {
                    MessageBox.Show("This Operation is successed!!!");
                    isNotFound = false;
                    lblApplicationID.Text = application.applicationID.ToString();
                    clsLocalDrivingLA localDrivingLA = putValuesinLocalDrivingLA();
                    localDrivingLA.save();
                }
                else
                {
                    MessageBox.Show("Something wrong for inserting application!!");

                }
            }
            else
            {
                MessageBox.Show("This person has taken like this they can't take it again!!!");

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPerson_Click(object sender, EventArgs e)
        {

        }

        private void ucPersonCardwithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void lblApplicationFees_Click(object sender, EventArgs e)
        {

        }

        private void lblApplicationID_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblCreatedBy_Click(object sender, EventArgs e)
        {

        }

        private void tabApplication_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblApplicationDate_Click(object sender, EventArgs e)
        {

        }

        private void cmbLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
