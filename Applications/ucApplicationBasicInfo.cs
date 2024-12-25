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

namespace DVLDtest.Applications
{
    public partial class ucApplicationBasicInfo : UserControl
    {
        clsApplication application;
      public  int  applicationID;
        public ucApplicationBasicInfo()
        {
            InitializeComponent();
        }
        public void loadTheInfo()
        {


            application = clsApplication.GetApplicationByID(applicationID);
            if (application != null)
            {
                lblApplicationID.Text = application.ApplicationID.ToString();
                lblStatus.Text = application.ApplicationStatus;
                lblType.Text = application.ApplicationTypeTitle;
                lblFees.Text = application.ApplicationFees.ToString("C"); // Formats as currency
                lblApplicant.Text = application.FullName;
                lblDate.Text = application.ApplicationDate.ToString("yyyy-MM-dd");
                lblStatusDate.Text = application.LastStatusDate.ToString("yyyy-MM-dd");
                lblCreatedBy.Text = application.UserName;
            }
            else
            {
                lblApplicationID.Text = "0";
                lblStatus.Text = "nun";
                lblType.Text = "nun";
                lblFees.Text = "0";
                lblApplicant.Text = "nun";
                lblDate.Text = "0/0/0";
                lblStatusDate.Text = "0/0/0";
                lblCreatedBy.Text = "";
            }


        }
    }
}
