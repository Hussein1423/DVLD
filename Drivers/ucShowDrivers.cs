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

namespace DVLDtest.Drivers
{
    public partial class ucShowDrivers : UserControl
    {
        public ucShowDrivers()
        {
            InitializeComponent();
            dgvDrivers.DataSource = clsDriver.getAllDrivers();
            lblRecords.Text = dgvDrivers.RowCount.ToString();   
        }
    }
}
