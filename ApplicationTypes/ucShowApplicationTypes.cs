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

namespace DVLDtest.ApplicationTypes
{
    public partial class ucShowApplicationTypes : UserControl
    {
        public ucShowApplicationTypes()
        {
            InitializeComponent();
            dgvApplicationTypes.DataSource = clsApplicationType.getAllApplicationTypes();
            lblRecords.Text = clsApplicationType.countApplicationTypes().ToString();
        }

        private void editPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
           int applicationTypeID =(int)dgvApplicationTypes.CurrentRow.Cells[0].Value;
           string applicationTypeTitle =dgvApplicationTypes.CurrentRow.Cells[1].Value.ToString();
            double applicationFees =double.Parse(dgvApplicationTypes.CurrentRow.Cells[2].Value.ToString());
            frmUpdateApplicationType updateApplicationType = new frmUpdateApplicationType(applicationTypeID,applicationTypeTitle,applicationFees);
            updateApplicationType.ShowDialog();
        }
    }
}
