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
    public partial class frmShowDriverLicense : Form
    {
        
        public frmShowDriverLicense(int licenseID)
        {
            InitializeComponent();
            ucDriverLicense1.LicenseID = licenseID;
            ucDriverLicense1.loadTheInfo();
        }
    }
}
