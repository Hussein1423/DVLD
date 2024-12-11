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

namespace DVLDtest.Users
{
    public partial class ucShowUsers : UserControl
    {
        public enum eFilter
        {
            UserID = 0,
            PersonID = 1,
            Username = 2,
            Active = 3,
        }

        public enum eKindofActive
        {
            all=0,
            active = 1,
            notActive=2,
           
        }
        public ucShowUsers()
        {
            InitializeComponent();
            _refresh(clsUser.getAllUsers());
            lblRecords.Text = clsUser.countUsers().ToString();
        }
        private void _refresh(DataTable data)
        {
            dgvPeople.DataSource = data;
        }
       

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser addUser = new frmAddUser();
            addUser.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID =(int) dgvPeople.CurrentRow.Cells[0].Value;
            int personID = (int)dgvPeople.CurrentRow.Cells[1].Value;
            frmShowUser currentUser = new frmShowUser(personID,userID);
            currentUser.ShowDialog();
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            if(MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)== DialogResult.OK)
            {
                if(clsUser.deleteUser(userID))
                {
                    MessageBox.Show("This user has deleted successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _refresh(clsUser.getAllUsers());
                    lblRecords.Text = clsUser.countUsers().ToString();
                }
                else
                {
                    MessageBox.Show("Error,Something is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
           
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            int personID = (int)dgvPeople.CurrentRow.Cells[1].Value;
            frmChangePassword changePassword = new frmChangePassword(personID,userID);
            changePassword.ShowDialog();
        }

        private void callToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is going to be here soon", "Soon", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is going to be here soon", "Soon", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private void setupFilterInput(string mask)
        {
            mtbFliter.Mask = mask;
            mtbFliter.Clear();
            cbActive.Visible = false;
            mtbFliter.Visible = true;
        }
        private void setupFilterActive()
        {
            mtbFliter.Visible = false;
            cbActive.Visible = true;
        }


        private void cbFliter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFliter.SelectedIndex)
            {
                case (int)eFilter.UserID:
                    setupFilterInput("00000000000");
                    break;
                case (int)eFilter.PersonID:
                    setupFilterInput("00000000000");
                    break;
                case (int)eFilter.Username:
                    setupFilterInput("");
                    break;
                case (int)eFilter.Active:
                   setupFilterActive();
                    break;
            }
        }
        private bool isValidtoConvertToInt(string text)
        {
            if(string.IsNullOrEmpty(text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void mtbFliter_TextChanged(object sender, EventArgs e)
        {
            switch (cbFliter.SelectedIndex)
            {
                case (int)eFilter.UserID:
                    int userID;
                    if (isValidtoConvertToInt(mtbFliter.Text.Trim()))
                    {
                      userID = int.Parse(mtbFliter.Text.Trim());
                       _refresh(clsUser.filterUserID(userID));
                    }
                    else
                    {
                        _refresh(clsUser.getAllUsers());
                    }
                    break;
                case (int)eFilter.PersonID:
                    if (isValidtoConvertToInt(mtbFliter.Text.Trim()))
                    {
                        int personID = int.Parse(mtbFliter.Text.Trim());
                        _refresh(clsUser.filterPersonID(personID));
                    }
                    else
                    {
                        _refresh(clsUser.getAllUsers());
                    }

                    break;
                case (int)eFilter.Username:
                    string username = mtbFliter.Text;
                    if(!string.IsNullOrEmpty(username))
                    {
                        _refresh(clsUser.filterUsername(username));
                    }
                    else
                    {
                        _refresh(clsUser.getAllUsers());
                    }
                    break;
                case (int)eFilter.Active:
                    setupFilterActive();
                    break;
               
            }
        }

        private void cbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbActive.SelectedIndex)
            {
                case (short)eKindofActive.all:
                    _refresh(clsUser.filterActive((short)eKindofActive.all));
                    break;
                case (short)eKindofActive.active:
                    _refresh(clsUser.filterActive((short)eKindofActive.active));
                    break;
                case (short)eKindofActive.notActive:
                    _refresh(clsUser.filterActive((short)eKindofActive.notActive));
                    break;
            }
        }

        private void gabAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUser addUser= new frmAddUser();
            addUser.ShowDialog();
        }

        private void editPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = (int)dgvPeople.CurrentRow.Cells[0].Value;   
            frmAddUser addUser = new frmAddUser(userID);
            addUser.ShowDialog();
        }
    }
}
