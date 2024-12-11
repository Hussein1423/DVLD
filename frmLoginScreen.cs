using LogicLayerDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDtest
{
    public partial class frmLoginScreen : Form
    {
        private string file = @"D:\Programmin Advice\Project 19\RemeberMe.txt";
        public frmLoginScreen()
        {
            InitializeComponent();
            string[] user = File.ReadAllLines(file);
            if (user.Length != 0)
            {
                txtUsername.Text = user[0];
                txtPassword.Text = user[1];
            }
        }
        private void saveDataInFile(string text)
        {
            using (StreamWriter writer = new StreamWriter(file, true))
            {
                writer.WriteLine(text);
            }
        }
        
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.getUserByuserNameandPassword(txtUsername.Text, txtPassword.Text);
            if (user != null)
            {
                if (user.Active == true)
                {
                    if (chbRemeber.Checked)
                    {
                        File.WriteAllText(file, string.Empty);
                        saveDataInFile(txtUsername.Text);
                        saveDataInFile(txtPassword.Text);

                    }
                    else
                    {
                        txtUsername.Clear();
                        txtPassword.Clear();
                        File.WriteAllText(file, string.Empty);
                    }
                    frmHomePage homePage = new frmHomePage(user.UserID,user.PersonID);
                    homePage.ShowDialog();
                   
                   
                }
                else
                {
                    MessageBox.Show("Error This User is not Active!!", "Not Active", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Error This User is not in system!!", "is not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
    }
}

