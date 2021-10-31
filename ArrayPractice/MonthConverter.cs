using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayPractice
{
    public partial class MonthConverter : Form
    {
        public MonthConverter()
        {
            InitializeComponent();
        }

        private void btnDisplayMonth_Click(object sender, EventArgs e)
        {
            string[] monthNames = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            bool parseSuccessful = int.TryParse(txtMonthNumber.Text, out int monthNumber);

            monthNumber = monthNumber - 1;

            if (parseSuccessful)
            {
                if(monthNumber >= 0 && monthNumber < monthNames.Length)
                {
                    lblMonthName.Text = monthNames[monthNumber];
                }
                else //This is the case where it does parse (user enters an integer), but integer not 1 - 12
                {
                    MessageBox.Show("Please enter an integer between 1 -12.");
                }
            }
            else
            {
                MessageBox.Show("Please enter an integer between 1 -12.");
            }


        }
    }
}
