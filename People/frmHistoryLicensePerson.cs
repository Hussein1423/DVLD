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

namespace DVLDtest.People
{
    public partial class frmHistoryLicensePerson : Form
    {
        public frmHistoryLicensePerson(int personID)
        {
            InitializeComponent();
            ucPersonalCard1.personID = personID;
            ucPersonalCard1.loadTheInfo();  
            dgvLocal.DataSource = clsLocalDrivingLA.getAllLocalDrivingsLAforSpecficPerson(personID);
            lblRecordsLocal.Text = dgvLocal.RowCount.ToString();    
        }
    }
}
