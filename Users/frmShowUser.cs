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
    public partial class frmShowUser : Form
    {
        public frmShowUser(int personID,int userID)
        {
            InitializeComponent();
            ucPersonalCard1.personID = personID;
            ucPersonalCard1.loadTheInfo();
            ucUserCard1.idUser = userID;
            ucUserCard1.loadTheInfo();
        }
    }
}
