using DVLDtest.Applications;
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

namespace DVLDtest.LocalDrivingsLA
{
    public partial class ucShowLocalDrivingsLA : UserControl
    {
        int _createdUser;
        int _PersonID;
        public ucShowLocalDrivingsLA(int createdUser,int personID)
        {
            InitializeComponent();
            dgvLocalDrivingsLA.DataSource = clsLocalDrivingLA.getAllLocalDrivingsLA();
            lblRecords.Text = clsLocalDrivingLA.countAllLocalLicenses().ToString();
            _createdUser = createdUser;
            _PersonID = personID;
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Canceled this app??", "Canceled", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int localDrivingLAID = (int)dgvLocalDrivingsLA.CurrentRow.Cells[0].Value;
                int applicationID = clsLocalDrivingLA.getApplicationByLocalDrivingLicenseApplicationID(localDrivingLAID);
                if(clsApplication.updateApplicationStatus(applicationID,2))
                {
                    MessageBox.Show("it is canceled!!");
                }
                else
                {
                    MessageBox.Show("something Wrong!!");

                }
            }
        }

        private void gabAddPerson_Click(object sender, EventArgs e)
        {
            ucLocalDrivingLicense localDrivingLicense = new ucLocalDrivingLicense(_createdUser);
            frmHomePage homePage =new frmHomePage(_createdUser,_PersonID);
            homePage.Show();
            homePage.addUserControlToScreen(localDrivingLicense);
            
        }
    }
}
