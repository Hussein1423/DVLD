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
    public partial class ucDrivingLicenseApplicationInfo : UserControl
    {
        public int _localDrivingLicenseApplicationID;
        clsLocalDrivingLA _localDrivingLA;
        public int passedTests = 0;
        public ucDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }
        public void loadTheInfo()
        {

            _localDrivingLA = clsLocalDrivingLA.getLocalDrivingLicenseByID(_localDrivingLicenseApplicationID);
            if (_localDrivingLA != null)
            {
                lblDLAID.Text = _localDrivingLicenseApplicationID.ToString();
                lblClass.Text = _localDrivingLA.licenseClass;
                lblPaseedTest.Text = _localDrivingLA.passedTest.ToString() + "/3";
                passedTests = _localDrivingLA.passedTest;


            }
            else
            {
                lblClass.Text = "Nun";
                lblDLAID.Text = "0";
                lblPaseedTest.Text = "0";

            }  

                
        }
    }
}
