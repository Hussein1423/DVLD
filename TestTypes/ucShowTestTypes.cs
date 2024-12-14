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

namespace DVLDtest.TestTypes
{
    public partial class ucShowTestTypes : UserControl
    {
        public ucShowTestTypes()
        {
            InitializeComponent();
            dgvTestTypes.DataSource = clsTestTypes.getAllTestTypes();
            lblRecords.Text = clsTestTypes.countTestTypes().ToString();
        }

        private void editPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int testTypeID =(int) dgvTestTypes.CurrentRow.Cells[0].Value;
            string testTypeTitle = dgvTestTypes.CurrentRow.Cells[1].Value.ToString();
            string testTypeDescription = dgvTestTypes.CurrentRow.Cells[2].Value.ToString();
            double testTypeFees = double.Parse(dgvTestTypes.CurrentRow.Cells[3].Value.ToString());
            frmUpdateTest updateTest = new frmUpdateTest(testTypeID,testTypeTitle,testTypeDescription,testTypeFees);
            updateTest.ShowDialog();
        }
    }
}
