using DVLDtest.People;
using DVLDtest.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDtest
{
    public partial class frmHomePage : Form
    {
        int _userID;
        int _personID;
        public frmHomePage(int userID,int personID)
        {
            InitializeComponent();
            _userID = userID;
            _personID = personID;
        }

        private void addUserControlToScreen(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucShowPeople showPeople = new ucShowPeople();
            addUserControlToScreen(showPeople);
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucShowUsers showUsers = new ucShowUsers();
            addUserControlToScreen(showUsers);
        }

     
        private void currentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUser currentUser = new frmShowUser(_personID,_userID);
            currentUser.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword changePassword = new frmChangePassword(_personID,_userID);
            changePassword.Show();
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
