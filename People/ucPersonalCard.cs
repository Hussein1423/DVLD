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

namespace DVLDtest
{
    public partial class ucPersonalCard : UserControl
    {
     
        clsPerson _person = new clsPerson();
        public int personID { get; set; }
        public ucPersonalCard()
        {
            InitializeComponent();
            
        }

        public void loadTheInfo()
        {
            _person = clsPerson.getUserByPersonID(personID);

            if (_person != null)
            {
                lblName.Text = _person.firstName + " " + _person.lastName;
                lblPersonalID.Text = _person.PersonID.ToString();
                lblNational.Text = _person.nationalNo;
                lblCountry.Text = clsCountry.getCountryName(_person.NationalityCountryID);
                lblGender.Text = _person.gender ? "Female" : "Male";
                lblEmail.Text = _person.email ?? string.Empty;
                lblPhone.Text = _person.phone;
                lblBirthday.Text = _person.birthday.ToString();
                lblAddress.Text = _person.address;
            }
            else
            {
                // تعيين قيم افتراضية لتجنب الأخطاء
                lblName.Text = "Unknown";
                lblPersonalID.Text = "0";
                lblNational.Text = "N/A";
                lblCountry.Text = "N/A";
                lblGender.Text = "Unknown";
                lblEmail.Text = "N/A";
                lblPhone.Text = "N/A";
                lblBirthday.Text = "N/A";
                lblAddress.Text = "N/A";
            }

        }
        private void ucPersonalCard_Load(object sender, EventArgs e)
        {
           
        }
    }
}
