using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayerDVLD;
using System.IO;
namespace DVLDtest.People
{
    public partial class frmPersonForm : Form
    {
        int personID;
        clsPerson person;
       
        private void stateofForm(clsPerson person)
        {
            if (person != null)
            {
                txtFirstName.Text = person.firstName;
                txtLastName.Text = person.lastName;
                txtSecondName.Text = person.secondName;
                txtNationalNo.Text = person.nationalNo;
                if (person.thirdName != null)
                {
                    txtThirdName.Text= person.thirdName;
                }
                txtPhone.Text = person.phone;   
                txtEmail.Text = person.email;
                cmbGender.SelectedIndex = person.gender ? 1 : 0;
                cmbCountry.SelectedIndex = person.NationalityCountryID - 1;
                dtpBirthday.Text = person.birthday.ToString();
                txtAddress.Text = person.address;
                if (File.Exists(person.imagePath))
                {
                    pbImage.Image = Image.FromFile(person.imagePath);
                }
                else
                {
                    // تعيين صورة افتراضية إذا لم يتم العثور على الصورة
                    pbImage.Image = person.gender ? Properties.Resources.person_woman : Properties.Resources.person_boy; // تحتاج إلى إضافة صورة افتراضية في الموارد
                }


            }
            else
            {
                this.person = new clsPerson();
            }


        }

        public frmPersonForm(int personID)
        {
            InitializeComponent();
            foreach (DataRow row in clsCountry.getAllCountries().Rows)
            {
                cmbCountry.Items.Add(row["CountryName"]);
            }
            this.personID = personID;
            person = clsPerson.getUserByPersonID(personID);
            stateofForm(person);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            person.firstName = txtFirstName.Text;
            person.secondName = txtSecondName.Text;
            person.thirdName = txtThirdName.Text;
            person.lastName = txtLastName.Text;
            person.phone = txtPhone.Text;
            person.email = txtEmail.Text;
            person.nationalNo = txtNationalNo.Text;
            person.gender = cmbGender.SelectedIndex == 0 ? false : true;
            person.birthday = DateTime.Parse(dtpBirthday.Text);
            person.NationalityCountryID = cmbCountry.SelectedIndex+1;
            person.address = txtAddress.Text;
            person.imagePath = pbImage.ToString();
            if (person.save())
            {
                MessageBox.Show("This Operation was succeeded");
            }
            else { MessageBox.Show("This Operation was failed"); }
        }
    }
}
