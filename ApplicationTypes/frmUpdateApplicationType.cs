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
    public partial class frmUpdateApplicationType : Form
    {
     
        public frmUpdateApplicationType(int applicationTypeID, string applicationTypeTitle, double applicationFees)
        {
            InitializeComponent();
            lblApplicationTypeID.Text= applicationTypeID.ToString();
            txtApplicationTypeTitle.Text = applicationTypeTitle;
            mtbApplicationFees.Text = applicationFees.ToString();
        }

        ErrorProvider require = new ErrorProvider();
        private void txtApplicationTypeTitle_Validated(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtApplicationTypeTitle.Text))
            {
                require.SetError(txtApplicationTypeTitle,"this filed is required");
                txtApplicationTypeTitle.Focus();
            }
            else
            {
                require.SetError(txtApplicationTypeTitle, "");

            }
        }

        private void mtbApplicationFees_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtbApplicationFees.Text))
            {
                require.SetError(mtbApplicationFees, "this filed is required");
                mtbApplicationFees.Focus(); 
            }
            else
            {
                require.SetError(mtbApplicationFees, "");

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (clsApplicationType.updateApplicationTypes(int.Parse(lblApplicationTypeID.Text), txtApplicationTypeTitle.Text, double.Parse(mtbApplicationFees.Text)))
            {
                MessageBox.Show("Updated successfully!!");
            }
            else
            {
                MessageBox.Show("Something Wrong!!");

            }
        }

        private void mtbApplicationFees_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtbApplicationFees.Text))
            {
                btnUpdate.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = true;
            }
        }
    }
}
