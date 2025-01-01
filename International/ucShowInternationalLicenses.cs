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

namespace DVLDtest.International
{
    public partial class ucShowInternationalLicenses : UserControl
    {
        public enum eFilter
        {
            internationalLicenseID = 0,
            driverID = 1,
            applicationID = 2,
            issuedUsingLocalLicenseID = 3,
        }

        private void _refresh(DataTable dataTable)
        {
            dgvInternationalDrivingsLA.DataSource = dataTable;
        }
        public ucShowInternationalLicenses()
        {
            InitializeComponent();
            dgvInternationalDrivingsLA.DataSource = clsInternational.getAllInternationalLicenses();
            lblRecords.Text = dgvInternationalDrivingsLA.RowCount.ToString();
        }

     

        private void mtbFliter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mtbFliter.Text))
            {
                switch (cbFliter.SelectedIndex)
                {
                    case (int)eFilter.internationalLicenseID:
                        _refresh(clsInternational.getInternationalLicenseByID(int.Parse(mtbFliter.Text.Trim())));
                        lblRecords.Text = dgvInternationalDrivingsLA.RowCount.ToString();
                        break;
                    case (int)eFilter.driverID:
                        _refresh(clsInternational.getInternationalLicensesByDriverID(int.Parse(mtbFliter.Text.Trim())));
                        lblRecords.Text = dgvInternationalDrivingsLA.RowCount.ToString();
                        break;
                    case (int)eFilter.applicationID:
                        _refresh(clsInternational.getInternationalLicensesByApplicationID(int.Parse(mtbFliter.Text.Trim())));
                        lblRecords.Text = dgvInternationalDrivingsLA.RowCount.ToString();
                        break;
                    case (int)eFilter.issuedUsingLocalLicenseID:
                        _refresh(clsInternational.getInternationalLicensesByLocalLicenseID(int.Parse(mtbFliter.Text.Trim())));
                        lblRecords.Text = dgvInternationalDrivingsLA.RowCount.ToString();
                        break;
                    default:
                        MessageBox.Show("Invalid filter selected.");
                        break;
                }

            }
            else
            {
                dgvInternationalDrivingsLA.DataSource = clsInternational.getAllInternationalLicenses();
                lblRecords.Text = dgvInternationalDrivingsLA.RowCount.ToString();
            }
        }
    }
}
