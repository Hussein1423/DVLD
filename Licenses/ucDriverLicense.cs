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

namespace DVLDtest.LocalDrivingsLA
{
    public partial class ucDriverLicense : UserControl
    {
        public int LicenseID { get; set; }
        clsMockLicense _mockLicense;
        public ucDriverLicense()
        {
            InitializeComponent();
        }

        public void loadTheInfo()
        {
            _mockLicense = clsMockLicense.GetLicenseByID(LicenseID);

            if (_mockLicense != null)
            {
                lblName.Text = _mockLicense.FullName;
                lblClass.Text = _mockLicense.ClassName;
                lblNationalNo.Text = _mockLicense.NationalNo;
                lblDateofBirth.Text = _mockLicense.DateOfBirth.ToString();
                lblGender.Text = _mockLicense.Gender ? "Female" : "Male";
                lblDriverID.Text =_mockLicense.DriverID.ToString();
                lblIsActive.Text = _mockLicense.IsActive ? "Yes" : "No";
                lblExpDate.Text = _mockLicense.ExpirationDate.ToString();
                lblIssueDate.Text = _mockLicense.IssueDate.ToString();
                lblIssueReason.Text = _mockLicense.IssueReason;
                lblLicenseID.Text = _mockLicense.LicenseID.ToString();
                lblNotes.Text = _mockLicense.Notes;
                lblIsDetained.Text = _mockLicense.IsActive ? "No" : "Yes";
                pbImage.Image = _mockLicense.Gender ? Properties.Resources.person_woman : Properties.Resources.person_boy; // تحتاج إلى إضافة صورة افتراضية في الموارد

            }
            else
            {
                lblName.Text = "";
                lblClass.Text = "";
                lblNationalNo.Text = "";
                lblDateofBirth.Text = "";
                lblGender.Text = "";
                lblDriverID.Text = "";
                lblIsActive.Text = "";
                lblExpDate.Text = "";
                lblIssueDate.Text = "";
                lblIssueReason.Text = "";
                lblLicenseID.Text = "";
                lblNotes.Text = "";
                lblIsDetained.Text = "";
            }

        }
    }
}
