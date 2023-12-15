using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ13._12._23_BirthDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_Year_TextChanged(object sender, EventArgs e)
        {
            int year, month, day;
            if (int.TryParse(textBox_Year.Text, out year) &&
                int.TryParse(textBox_Mouth.Text, out month) &&
                int.TryParse(textBox_Date.Text, out day))
            {
                monthCalendar1.SetDate(new DateTime(year, month, day));
            }
            else
            {
                MessageBox.Show("Не верно введены данные");
            }
        }
    }
}
