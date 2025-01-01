using DVLDtest.Applications;
using DVLDtest.ApplicationTypes;
using DVLDtest.Drivers;
using DVLDtest.International;
using DVLDtest.LocalDrivingsLA;
using DVLDtest.People;
using DVLDtest.TestTypes;
using DVLDtest.Users;
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

namespace DVLDtest
{
    public partial class frmHomePage : Form
    {
        int _userID;
        int _personID;
        public frmHomePage(int userID,int personID)
        {
            InitializeComponent();
            _userID = userID;
            _personID = personID;
            clsLicense license = new clsLicense();
        }

        public void addUserControlToScreen(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucShowPeople showPeople = new ucShowPeople();
            addUserControlToScreen(showPeople);
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucShowUsers showUsers = new ucShowUsers();
            addUserControlToScreen(showUsers);
        }

     
        private void currentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUser currentUser = new frmShowUser(_personID,_userID);
            currentUser.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword changePassword = new frmChangePassword(_personID,_userID);
            changePassword.Show();
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           this.Close();
        }

        private void applicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucShowApplicationTypes applicationTypes = new ucShowApplicationTypes();
            addUserControlToScreen(applicationTypes);
        }

        private void testTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucShowTestTypes showTestTypes = new ucShowTestTypes();
            addUserControlToScreen(showTestTypes);
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {

        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucLocalDrivingLicense localDrivingLicense = new ucLocalDrivingLicense(_userID);
            addUserControlToScreen(localDrivingLicense);
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucShowLocalDrivingsLA  ucShowLocal = new ucShowLocalDrivingsLA(_userID,_personID);
            addUserControlToScreen(ucShowLocal);
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucShowDrivers showDrivers = new ucShowDrivers();
            addUserControlToScreen(showDrivers);
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucShowInternationalLicenses showInternationalLicenses = new ucShowInternationalLicenses();
            addUserControlToScreen(showInternationalLicenses);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
