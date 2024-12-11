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
using static System.Net.Mime.MediaTypeNames;

namespace DVLDtest.Users
{
    public partial class frmAddUser : Form
    {
        clsUser user;
        public frmAddUser(int userID=-1)
        {
            InitializeComponent();
            user = clsUser.getUserByID(userID);
            stateofForm(user);
            if (user != null)
            {
                tabControl1.TabPages[1].Enabled = true;
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                tabControl1.TabPages[1].Enabled = false;
                _validateFields();
            }
           
        }
        private void stateofForm(clsUser user)
        {
            if (user != null)
            {
                txtUsername.Text = user.UserName;
                txtPassword.Text = user.Password;
                txtConfirmPassword.Text = user.Password;
                if(user.Active)
                {
                    rbActive.Checked = true;
                }
                else
                {
                    rbnotActive.Checked = true;
                }
          

            }
            else
            {
                user = new clsUser();
            }


        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
          clsUser user =  clsUser.getUserByPersonID(ucPersonCardwithFilter1.personID);
            if (user == null)
            {
                if (ucPersonCardwithFilter1.personID > 0)
                {
                    tabControl1.TabPages[1].Enabled = true;
                    tabControl1.SelectTab("tabUser");
                }
                else
                {
                    tabControl1.TabPages[1].Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("This person connected with other user!!", "Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }
        private void _validateFields()
        {
            bool isValid = true; // افتراض أن كل شيء صحيح

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                isValid = false; // إذا كان غير صحيح
            }
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                isValid = false;
            }
            if(txtPassword.Text.Length < 8 || txtConfirmPassword.Text.Length < 8)
            {
                isValid = false;
            }
                // تمكين أو تعطيل الزر بناءً على التحقق
                btnConfirm.Enabled = isValid;
        }


 

        ErrorProvider required = new ErrorProvider();
        ErrorProvider confirmPassword = new ErrorProvider();
        ErrorProvider minLength = new ErrorProvider();
        private void txtUsername_Validated(object sender, EventArgs e)
        {
           
            if (txtUsername.Text == "")
            {
                required.SetError(txtUsername, "This Field is required");
                txtUsername.Focus();
            }
            else
            {
                required.SetError(txtUsername, ""); // إزالة الخطأ باستخدام سلسلة فارغة
                _validateFields();
            }

        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                required.SetError(txtPassword, "This Field is required");
                txtPassword.Focus();
            }
            else
            {
                required.SetError(txtPassword, null);
                _validateFields();

            }
            if(txtPassword.Text.Length <8)
            {
                required.SetError(txtPassword, "Min number is 8");
                txtPassword.Focus();
            }
            else
            {
                required.SetError(txtPassword, null);
                _validateFields();

            }

        }


        private void txtConfirmPassword_Validated(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "")
            {
                required.SetError(txtConfirmPassword, "This Field is required");
                txtConfirmPassword.Focus();
            }
            else
            {
                required.SetError(txtConfirmPassword, null);
                _validateFields();
            }
            if(txtConfirmPassword.Text != txtPassword.Text)
            {
                confirmPassword.SetError(txtConfirmPassword, "Confirm Password is not equal with password");
                txtConfirmPassword.Focus();
            }
            else
            {
                confirmPassword.SetError(txtConfirmPassword, null);
                _validateFields();

            }
            if (txtConfirmPassword.Text.Length < 8)
            {
                minLength.SetError(txtConfirmPassword, "Min number is 8");
                txtPassword.Focus();
            }
            else
            {
                minLength.SetError(txtConfirmPassword, null);
                _validateFields();

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            user.UserName = txtUsername.Text;
            user.PersonID = ucPersonCardwithFilter1.personID;
            user.Password = txtPassword.Text;
            if(rbActive.Checked)
            {

            user.Active = true; 
            }
           else
            {
                user.Active = false;
            }
            if(user.save())
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";

                MessageBox.Show("User is added successfully!!");
                tabControl1.TabPages[1].Enabled = false;
                tabControl1.SelectTab("tabPerson");

            }
            else
            {
                MessageBox.Show("something wrong");

            }
        }
    }
}
