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
using System.Text.RegularExpressions;
namespace DVLDtest.People
{
    public partial class frmPersonForm : Form
    {

        // Declare a delegate
        public delegate void DataBackEventHandler(int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

    
        int personID;
        clsPerson person;
       
        private void stateofForm(clsPerson person)
        {
            if (person != null)
            {
                lblPersonID.Text = person.PersonID.ToString();
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
                    lnkRemove.Visible = true;
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
            txtNationalNo.CausesValidation = true;
            dtpBirthday.MaxDate = DateTime.Now.AddYears(-18);


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
                lblPersonID.Text = person.PersonID.ToString();
                MessageBox.Show("This Operation was succeeded");
                personID = int.Parse(lblPersonID.Text);

                // Trigger the event to send data back to Form1
                DataBack?.Invoke(personID);


                this.Close();
            }
            else { MessageBox.Show("This Operation was failed"); }
        }

        // تعريف ErrorProvider على مستوى النموذج
        ErrorProvider errorProvider1 = new ErrorProvider();

        private void txtNationalNo_Validated(object sender, EventArgs e)
        {
            if (clsPerson.isNotionalNoExist(txtNationalNo.Text))
            {
                errorProvider1.SetError(txtNationalNo, "This NationalNo is already used");
                txtNationalNo.Focus();
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, ""); // إزالة الخطأ إذا كان الإدخال صحيحًا
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            // تعريف التعبير النمطي للتحقق من البريد الإلكتروني
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // التحقق من البريد الإلكتروني باستخدام التعبير النمطي
            if (!Regex.IsMatch(txtEmail.Text, emailPattern) && txtEmail.Text != "")
            {
                // إذا كانت الصيغة غير صحيحة، يتم عرض رسالة خطأ
                errorProvider1.SetError(txtEmail, "Invalid email format");
                txtEmail.Focus();
            }
            else
            {
                // إذا كانت الصيغة صحيحة، يتم إزالة الخطأ
                errorProvider1.SetError(txtEmail, "");
            }
        }
        private string targetDirectory = @"D:\Programmin Advice\Project 19\Images";
        private void lnkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // إعداد نافذة OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png"; // تصفية الصور فقط
            openFileDialog.Title = "Select an Image";

            // إذا اختار المستخدم صورة
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // عرض الصورة في PictureBox
                pbImage.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);

                // إنشاء اسم الملف الجديد
                string fileExtension = Path.GetExtension(openFileDialog.FileName); // استخراج الامتداد (مثل .jpg)
                string newFileName = txtNationalNo.Text.Trim() + fileExtension;
                string targetPath = Path.Combine(targetDirectory, newFileName);

                // ضمان وجود المجلد الهدف
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                // إذا كانت الصورة موجودة بالفعل، احذفها
                if (File.Exists(targetPath))
                {
                    File.Delete(targetPath);
                }

                // نسخ الصورة إلى المسار المحدد
                File.Copy(openFileDialog.FileName, targetPath);
                lnkRemove.Visible = true;

            }
        }

        private void lnkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.Image = person.gender ? Properties.Resources.person_woman : Properties.Resources.person_boy; // تحتاج إلى إضافة صورة افتراضية في الموارد
            lnkRemove.Visible = false;
        }
    }
  }
