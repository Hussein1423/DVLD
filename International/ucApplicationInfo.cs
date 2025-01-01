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
    public partial class ucApplicationInfo : UserControl
    {
        clsInternational _InternationalLicense = new clsInternational();
        public int internationalID { get; set; }
        public ucApplicationInfo()
        {
            InitializeComponent();
        }

        //public void loadTheInfo()
        //{
        //    _InternationalLicense = clsInternational.getInternationalLicenseByID(internationalID);

        //    if (_InternationalLicense != null)
        //    {
        //        lblILAppID.Text = _InternationalLicense.applicationID.ToString();
        //        lblIssueDate.Text = _InternationalLicense.issueDate.ToString();
        //        lblFees.Text = _InternationalLicense.fe;
        //        lblCountry.Text = clsCountry.getCountryName(_InternationalLicense.NationalityCountryID);
        //        lblGender.Text = _InternationalLicense.gender ? "Female" : "Male";
        //        lblEmail.Text = _InternationalLicense.email ?? string.Empty;
        //        lblPhone.Text = _InternationalLicense.phone;
        //        lblBirthday.Text = _InternationalLicense.birthday.ToString();
        //        lblAddress.Text = _InternationalLicense.address;
        //        pbImage.Image = _InternationalLicense.gender ? Properties.Resources.person_woman : Properties.Resources.person_boy; // تحتاج إلى إضافة صورة افتراضية في الموارد

        //    }
        //    else
        //    {
        //        // تعيين قيم افتراضية لتجنب الأخطاء
        //        lblName.Text = "Unknown";
        //        lblPersonalID.Text = "0";
        //        lblNational.Text = "N/A";
        //        lblCountry.Text = "N/A";
        //        lblGender.Text = "Unknown";
        //        lblEmail.Text = "N/A";
        //        lblPhone.Text = "N/A";
        //        lblBirthday.Text = "N/A";
        //        lblAddress.Text = "N/A";
        //    }

        //}
    }
}
