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
        public frmHomePage()
        {
            InitializeComponent();
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

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginScreen loginScreen = new frmLoginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
}
