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
    public partial class frmUpdateTest : Form
    {
        public frmUpdateTest(int testTypeID,string testTypeTitle,string testTypeDescription,double testTypeFees)
        {
            InitializeComponent();
            lblTestTypeID.Text = testTypeID.ToString();
            txtTestTypeTitle.Text = testTypeTitle;
            txtTestTypeDescription.Text = testTypeDescription;
            mtbTestTypeFees.Text = testTypeFees.ToString();
        }

        ErrorProvider require = new ErrorProvider();
        private void mtbTestTypeFees_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtbTestTypeFees.Text))
            {
                require.SetError(mtbTestTypeFees, "This Filed is required");
                mtbTestTypeFees.Focus();
            }
            else
            {
                require.SetError(mtbTestTypeFees, "");

            }
        }

        private void mtbTestTypeFees_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtbTestTypeFees.Text))
            {
                btnUpdate.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (clsTestTypes.updateTestType(int.Parse(lblTestTypeID.Text), txtTestTypeTitle.Text, txtTestTypeDescription.Text,double.Parse(mtbTestTypeFees.Text)))
            {
                MessageBox.Show("Updated successfully!!");
            }
            else
            {
                MessageBox.Show("Something Wrong!!");

            }
        }
    }
}
