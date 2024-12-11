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
    public partial class ucUserCard : UserControl
    {
      public int idUser {get;set;}
      clsUser _user=new clsUser();

        public ucUserCard()
        {
            InitializeComponent();
        }
        public void loadTheInfo()
        {
            _user = clsUser.getUserByID(idUser);

            if (_user != null)
            {
                lblUserID.Text = _user.UserID.ToString();
                lblPersonID.Text = _user.PersonID.ToString();
                lblUserName.Text = _user.UserName;
                if(_user.Active)
                {
                    lblActive.Text = "Yes";
                }
                else
                {
                    lblActive.Text = "No";
                }
                

            }
            else
            {
                // تعيين قيم افتراضية لتجنب الأخطاء
                lblUserName.Text = "Unknown";
                lblPersonID.Text = "0";
                lblUserID.Text = "0";
                lblActive.Text = "No";
            }

        }
    }
}
