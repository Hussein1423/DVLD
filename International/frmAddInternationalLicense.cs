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

namespace DVLDtest.International
{
    public partial class frmAddInternationalLicense : Form
    {
        int _createdBy;
        public frmAddInternationalLicense(int createdBy)
        {
            InitializeComponent();
            _createdBy = createdBy;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mtbLicenseID.Text))
            {
                if (clsLicense.getClassNameByLicenseID(int.Parse(mtbLicenseID.Text.Trim())) == "Class 3 - Ordinary driving license")
                {
                    ucDriverLicense1.LicenseID = int.Parse(mtbLicenseID.Text);
                    ucDriverLicense1.loadTheInfo();
                    lnkHistory.Enabled = true;
                    gabIssue.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You can't convert this license to international");
                }
            }
        }

        private void lnkHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int personID = clsPerson.getPersonIDByFullName(ucDriverLicense1.lblName.Text);
            frmHistoryLicensePerson historyLicensePerson = new frmHistoryLicensePerson(personID);
            historyLicensePerson.ShowDialog();
        }

        private void gabIssue_Click(object sender, EventArgs e)
        {
            if (!clsInternational.isLocalDrivingLicenseIssued(ucDriverLicense1.LicenseID))
            {
                clsApplication application = new clsApplication();
                application.applicationStatus = 3;
                application.applicantPersonID = clsPerson.getPersonIDByFullName(ucDriverLicense1.lblName.Text);
                application.applicationDate = DateTime.Now;
                application.lastStatusDate = DateTime.Now;
                application.paidFees = 50;
                application.applicationTypeID = 6;
                application.createdByUserID = _createdBy;
                application.save(); 

                clsInternational international = new clsInternational();
                international.applicationID = application.applicationID;
                international.issuedUsingLocalLicenseID = ucDriverLicense1.LicenseID;
                international.isActive = true;
                international.issueDate = DateTime.Now; 
                international.expirationDate = DateTime.Now.AddYears(1);
                international.createdByUserID = _createdBy;
                international.driverID =int.Parse(ucDriverLicense1.lblDriverID.Text);
                if(international.save())
                {
                    MessageBox.Show("Issued Successfully!!!");
                    ucApplicationInfo1.internationalID = international.internationalLicenseID;

                    gabIssue.Enabled = false;
                    lnkLicenseInfo.Enabled = true;
                    //ucApplicationInfo1.
                }
            }
        }
    }
}
