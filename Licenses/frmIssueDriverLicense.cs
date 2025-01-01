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

namespace DVLDtest.Licenses
{
    public partial class frmIssueDriverLicense : Form
    {
        int _createdBy;
        public delegate void HandlerEvent();
        public HandlerEvent refresh;

        public frmIssueDriverLicense(int localDrivingID, int applicationID,int createdBy)
        {
            InitializeComponent();
            ucDrivingLicenseApplicationInfo1._localDrivingLicenseApplicationID = localDrivingID;
            ucDrivingLicenseApplicationInfo1.loadTheInfo();
            ucApplicationBasicInfo1.applicationID = applicationID;
            ucApplicationBasicInfo1.loadTheInfo();
            _createdBy = createdBy;
        }

        private void gabSave_Click(object sender, EventArgs e)
        {
            int personID = clsPerson.getPersonIDByFullName(ucApplicationBasicInfo1.lblApplicant.Text);
            int driverID = clsDriver.getDriverIDByPersonID(personID);
            if (driverID == -1)
            {
                clsDriver driver = new clsDriver();
                driver.personID = personID;
                driver.createdDate = DateTime.Now;
                driver.createdByUserID = _createdBy;
                driver.save();
                driverID = driver.driverID;
            }
            clsLicense license = new clsLicense();
            license.ApplicationID = ucApplicationBasicInfo1.applicationID;
            license.CreatedByUserID = _createdBy;
            license.IssueDate = DateTime.Now;
            license.DriverID = driverID;
            license.LicenseClassID = clsLicenseClass.getLicenseClassIDbyName(ucDrivingLicenseApplicationInfo1.lblClass.Text);
            license.Notes = textBox1.Text;
            int thevaldityofLicense = clsLicenseClass.getValidityLengthbyClassName(ucDrivingLicenseApplicationInfo1.lblClass.Text);
            license.ExpirationDate = DateTime.Now.AddYears(thevaldityofLicense);
            license.IsActive = true;
            license.PaidFees = 20;
            license.IssueReason = 1;
            if (license.save())
            {
                MessageBox.Show("Successfully!!!!!");
                clsApplication.updateApplicationStatus(license.ApplicationID, 3);
            
            }

        }

        private void gabClose_Click(object sender, EventArgs e)
        {
            refresh?.Invoke();
            this.Close();
        }

        private void frmIssueDriverLicense_FormClosed(object sender, FormClosedEventArgs e)
        {
            refresh?.Invoke();
            
        }
    }
}
