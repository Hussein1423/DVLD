using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayerDVLD;
namespace DVLDtest.People
{
    public partial class ucShowPeople : UserControl
    {
        public ucShowPeople()
        {
            InitializeComponent();
         

        }
        public enum eFilter
        {
            PersonId = 0,
            NationalNo = 1,
            FirstName = 2,
            SecondName = 3,
            LastName = 4,
            Email = 5,
            Phone = 6
        }
        private void _refresh(DataTable dataTable)
        {
            dgvPeople.DataSource = dataTable;
        }
       
        private void ucShowPeople_Load(object sender, EventArgs e)
        {
           _refresh(clsPerson.getAllPeople());
            lblRecords.Text = dgvPeople.RowCount.ToString();
        }

        private void gabAddPerson_Click(object sender, EventArgs e)
        {
            frmPersonForm personForm = new frmPersonForm(-1);
            personForm.ShowDialog();
        }

        private void cbFliter_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtbFliter.Visible = true;
            mtbFliter.Clear();
            if(cbFliter.SelectedIndex == 0)
            {
                mtbFliter.Mask = "00000000000";

            }
            else
            {
                mtbFliter.Mask = "";
            }
        }

        private void gabClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void mtbFliter_TextChanged(object sender, EventArgs e)
        {
            switch(cbFliter.SelectedIndex)
            {
                case 0:
                    _refresh(clsPerson.PersonIDSearchStartWith(mtbFliter.Text.Trim(), (int) eFilter.PersonId));
                    lblRecords.Text = dgvPeople.RowCount.ToString();
                    break;
                case 1:
                    _refresh(clsPerson.PersonIDSearchStartWith(mtbFliter.Text.Trim(), (int)eFilter.NationalNo));
                    lblRecords.Text = dgvPeople.RowCount.ToString();
                    break;
                case 2:
                    _refresh(clsPerson.PersonIDSearchStartWith(mtbFliter.Text.Trim(), (int)eFilter.FirstName));
                    lblRecords.Text = dgvPeople.RowCount.ToString();
                    break;
                case 3:
                    _refresh(clsPerson.PersonIDSearchStartWith(mtbFliter.Text.Trim(), (int)eFilter.SecondName));
                    lblRecords.Text = dgvPeople.RowCount.ToString();
                    break;
                case 4:
                    _refresh(clsPerson.PersonIDSearchStartWith(mtbFliter.Text.Trim(), (int)eFilter.LastName));
                    lblRecords.Text = dgvPeople.RowCount.ToString();
                    break;
                case 5:
                    _refresh(clsPerson.PersonIDSearchStartWith(mtbFliter.Text.Trim(), (int)eFilter.Phone));
                    lblRecords.Text = dgvPeople.RowCount.ToString();
                    break;
                case 6:
                    _refresh(clsPerson.PersonIDSearchStartWith(mtbFliter.Text.Trim(), (int)eFilter.Email));
                    lblRecords.Text = dgvPeople.RowCount.ToString();
                    break;
            }
          
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this user", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int personID = (int)dgvPeople.CurrentRow.Cells[0].Value;
                if (clsPerson.deletePerson(personID))
                {
                    MessageBox.Show("Deleted Successfully!!");
                    _refresh(clsPerson.getAllPeople());
                }
                else
                {
                    MessageBox.Show("This Person Has Connected With Other Records");
                }
            }
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonForm personForm = new frmPersonForm(-1);
            personForm.ShowDialog();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is going to be here soon","Soon",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void callToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is going to be here soon", "Soon", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void editPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            frmPersonForm personForm = new frmPersonForm(personID);
            personForm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            frmShowPerson showPerson = new frmShowPerson(personID);
            showPerson.ShowDialog();
        }
    }
}
