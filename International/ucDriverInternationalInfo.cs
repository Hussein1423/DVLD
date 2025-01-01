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

namespace DVLDtest.International
{
    public partial class ucDriverInternationalInfo : UserControl
    {
        clsMockInternationalLicense _MockInternationalLicense;
        public int InternationalID;
        public ucDriverInternationalInfo()
        {
            InitializeComponent();
        }
        public void loadTheInfo()
        {
            _MockInternationalLicense = clsMockInternationalLicense.GetMockInternationalLicenseByID(InternationalID);

            if (_MockInternationalLicense != null)
            {
                lblName.Text = _MockInternationalLicense.FullName;
                lblAppID.Text = _MockInternationalLicense.ApplicationID.ToString();
                lblDateBirth.Text = _MockInternationalLicense.DateOfBirth.ToString();
                lblDriverID.Text = _MockInternationalLicense.DriverID.ToString();
                lblGender.Text = _MockInternationalLicense.Gender ? "Female" : "Male";
                lblExpDate.Text = _MockInternationalLicense.ExpirationDate.ToString();
                lblIntID.Text = _MockInternationalLicense.InternationalLicenseID.ToString();
                lblIsActive.Text = _MockInternationalLicense.IsActive ? "Yes" : "No";
                lblIssue.Text = _MockInternationalLicense.IssueDate.ToString();
                lblLicense.Text = _MockInternationalLicense.IssuedUsingLocalLicenseID.ToString();
                lblNationalNo.Text = _MockInternationalLicense.NationalNo.ToString();

            }
            else
            {
                // تعيين قيم افتراضية لتجنب الأخطاء
                lblName.Text = "Unknown";
                lblAppID.Text = "N/A";
                lblDateBirth.Text = "N/A";
                lblDriverID.Text = "N/A";
                lblGender.Text = "Unknown";
                lblExpDate.Text = "N/A";
                lblIntID.Text = "N/A";
                lblIsActive.Text = "N/A";
                lblIssue.Text = "N/A";
                lblLicense.Text = "N/A";
                lblNationalNo.Text = "N/A";
            }

        }
    }
}
