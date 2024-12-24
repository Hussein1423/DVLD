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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLDtest.LocalDrivingsLA
{
    public partial class ucShowLocalDrivingsLA : UserControl
    {
        int _createdUser;
        int _PersonID;

        enum eFilter
        {
            localDrivingLA = 0,
            Class = 1,
            Name = 2,
            State = 3,
        }
       void _refresh(DataTable data)
        {
            dgvLocalDrivingsLA.DataSource = data;
            lblRecords.Text = dgvLocalDrivingsLA.RowCount.ToString();  
        }
        public ucShowLocalDrivingsLA(int createdUser,int personID)
        {
            InitializeComponent();
            _refresh(clsLocalDrivingLA.getAllLocalDrivingsLA());
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

        private void cbFliter_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtbFliter.Visible = true;
            mtbFliter.Clear();
            if (cbFliter.SelectedIndex == 0)
            {
                mtbFliter.Mask = "00000000000";

            }
            else
            {
                mtbFliter.Mask = "";
            }
        }



        private void mtbFliter_TextChanged(object sender, EventArgs e)
        {
            switch (cbFliter.SelectedIndex)
            {
                case (int)eFilter.localDrivingLA:
                    if (!string.IsNullOrEmpty(mtbFliter.Text))
                    {
                        _refresh(clsLocalDrivingLA.getAllLocalDrivingsLAforLocalDrivingLAID(int.Parse(mtbFliter.Text)));

                    }
                    else
                    {
                        _refresh(clsLocalDrivingLA.getAllLocalDrivingsLA());

                    }
                    break;
                case (int)eFilter.Class:
                    _refresh(clsLocalDrivingLA.getAllLocalDrivingsLAforClassName(mtbFliter.Text));
                    break;
                case (int)eFilter.Name:
                    _refresh(clsLocalDrivingLA.getAllLocalDrivingsLAforFullName(mtbFliter.Text));
                    break;
                case (int)eFilter.State:
                    if (!string.IsNullOrEmpty(mtbFliter.Text))
                    {
                        _refresh(clsLocalDrivingLA.getAllLocalDrivingsLAforState(mtbFliter.Text));

                    }
                    else
                    {
                        _refresh(clsLocalDrivingLA.getAllLocalDrivingsLA());

                    }
                    break;

            }
        }

        private void dgvLocalDrivingsLA_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                int localDrivingLAID = (int)dgvLocalDrivingsLA.CurrentRow.Cells[0].Value;
                clsLocalDrivingLA localDrivingLA = clsLocalDrivingLA.getLocalDrivingLicenseByID(localDrivingLAID);
                switch(localDrivingLA.passedTest)
                {
                    case 0:
                       visionTestToolStripMenuItem.Enabled = true;
                       writtenTestToolStripMenuItem.Enabled = false;
                       streetTestToolStripMenuItem.Enabled = false;
                       break;
                    case 1:
                        visionTestToolStripMenuItem.Enabled= false;
                        writtenTestToolStripMenuItem.Enabled= true;
                        streetTestToolStripMenuItem.Enabled= false;
                        break;
                    case 2:
                        visionTestToolStripMenuItem.Enabled = false;
                        writtenTestToolStripMenuItem.Enabled = false;
                        streetTestToolStripMenuItem.Enabled = true;
                        break;
                    case 3:
                        visionTestToolStripMenuItem.Enabled = false;
                        writtenTestToolStripMenuItem.Enabled = false;
                        streetTestToolStripMenuItem.Enabled = false;
                        break;

                }
            }
        }
    }
}
