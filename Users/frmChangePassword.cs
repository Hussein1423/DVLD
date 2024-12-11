using LogicLayerDVLD;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmChangePassword : Form
    {
        clsUser user;
        public frmChangePassword(int personID,int userID)
        {
            InitializeComponent();
            ucPersonalCard1.personID = personID;
            ucPersonalCard1.loadTheInfo();
            ucUserCard1.idUser = userID;
            ucUserCard1.loadTheInfo();
            user = clsUser.getUserByID(userID);
            btnConfirm.Enabled = false;
        }
        private void _validateFields()
        {
            bool isValid = true; // افتراض أن كل شيء صحيح

            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text) || string.IsNullOrWhiteSpace(txtNewPassword.Text) || string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                isValid = false; // إذا كان غير صحيح
            }
            if (txtCurrentPassword.Text != user.Password)
            {
                isValid = false;
            }
            if(txtNewPassword.Text != txtConfirmPassword.Text)
            {
                isValid = false;
            }
            // تمكين أو تعطيل الزر بناءً على التحقق
            btnConfirm.Enabled = isValid;
        }

        ErrorProvider require = new ErrorProvider();
        ErrorProvider currentPassword = new ErrorProvider();
        ErrorProvider confirmPassword = new ErrorProvider();
        private void txtCurrentPassword_Validated(object sender, EventArgs e)
        {
            if (txtCurrentPassword.Text != user.Password)
            {
                currentPassword.SetError(txtCurrentPassword, "this is not current password");
                txtCurrentPassword.Focus();
            }
            else
            {
                currentPassword.SetError(txtCurrentPassword, "");
                _validateFields();

            }
            if (string.IsNullOrEmpty(txtCurrentPassword.Text))
            {
                require.SetError(txtCurrentPassword,"This filed is required");
                txtCurrentPassword.Focus();
            }
            else
            {
                require.SetError(txtCurrentPassword, "");
                _validateFields();
            }


        }

        private void txtConfirmPassword_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                require.SetError(txtConfirmPassword, "This filed is required");
                txtConfirmPassword.Focus();
            }
            else
            {
                require.SetError(txtConfirmPassword, "");
                _validateFields();

            }
            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                confirmPassword.SetError(txtConfirmPassword, "Confirm Password is not equal with password");
                txtConfirmPassword.Focus();
            }
            else
            {
                confirmPassword.SetError(txtConfirmPassword, null);
                _validateFields();

            }
        }

        private void txtNewPassword_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                require.SetError(txtNewPassword, "This filed is required");
                txtNewPassword.Focus();
            }
            else
            {
                require.SetError(txtNewPassword, "");

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (clsUser.updatePassword(ucUserCard1.idUser, txtNewPassword.Text))
            {
                MessageBox.Show("This password updated!!!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something wrong!!!");

            }
        }
    }
}
