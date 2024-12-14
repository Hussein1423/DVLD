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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLDtest.People
{
    public partial class ucPersonCardwithFilter : UserControl
    {
        //public event Action<int, int> OnCalculationComplete;
        //protected virtual void CalculationComplete(int resualt)
        //{
        //    Action<int, int> handler = OnCalculationComplete;
        //    if (handler != null)
        //        handler(resualt, 99);
        //}
        public enum eFilter
        {
            PersonId = 0,
            NationalNo = 1,
        }
       public int personID=0;
        public ucPersonCardwithFilter()
        {
            InitializeComponent();
            cbFliter.SelectedIndex = 0;
        }

 

        private void btnShow_Click(object sender, EventArgs e)
        {
            switch (cbFliter.SelectedIndex)
            {
                case (int)eFilter.PersonId:
                    if (!string.IsNullOrEmpty(mtbFliter.Text))
                    {
                        clsPerson person1 = clsPerson.getUserByPersonID(int.Parse(mtbFliter.Text.Replace(" ", "").Trim()));
                        if (person1 != null)
                        {
                            ucPersonalCard1.personID = person1.PersonID;
                            ucPersonalCard1.loadTheInfo();
                            personID = person1.PersonID;
                        }
                        else
                        {
                            ucPersonalCard1.personID = -1;
                            personID = -1;
                            ucPersonalCard1.loadTheInfo();
                            MessageBox.Show("This Person is not existence", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case (int)eFilter.NationalNo:
                    clsPerson person = clsPerson.getUserByNationalNo(mtbFliter.Text);
                    if (person != null)
                    {
                        ucPersonalCard1.personID = person.PersonID;
                        ucPersonalCard1.loadTheInfo();
                        personID = person.PersonID;
                    }
                    else
                    {
                        ucPersonalCard1.personID = -1;
                        personID = -1;
                        ucPersonalCard1.loadTheInfo();
                        MessageBox.Show("This Person is not existence", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        public void loadTheInfo()
        {
            ucPersonalCard1.personID = personID;
            ucPersonalCard1.loadTheInfo();
        }

        private void cbFliter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFliter.SelectedIndex)
            {
                case (int)eFilter.PersonId:
                    mtbFliter.Mask = "00000000000";
                    break;
                case (int)eFilter.NationalNo:
                    mtbFliter.Mask = "";
                    break;
            }
        }

        public event Action<int> showPersonForm;
        protected virtual void ShowPersonForm()
        {
            Action<int> handler = showPersonForm;
            if (handler != null)
                handler(0);
        }
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (showPersonForm != null)
                showPersonForm(0);
        }
       
    }
}
