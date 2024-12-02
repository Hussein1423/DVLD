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
    public partial class frmShowPerson : Form
    {
        int id;
        public frmShowPerson(int id)
        {
            InitializeComponent();
            this.id = id;
            ucPersonalCard1.personID = id;
            ucPersonalCard1.loadTheInfo();
        }

        private void lnkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonForm personForm = new frmPersonForm(id);
            personForm.ShowDialog();
        }
    }
}
