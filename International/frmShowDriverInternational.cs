using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDtest.International
{
    public partial class frmShowDriverInternational : Form
    {
        public frmShowDriverInternational(int internationalID)
        {
            InitializeComponent();
            ucDriverInternationalInfo1.InternationalID = internationalID;
            ucDriverInternationalInfo1.loadTheInfo();
        }
    }
}
