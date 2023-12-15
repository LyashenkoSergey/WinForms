using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ13._12._23._Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton_Male.Checked = true;
            comboBox_Status.SelectedIndex = 0;
            dateTimePicker_BirthDate.MaxDate = DateTime.Now;
        }

        private void textBox_LastName_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_LastName.Text))
            {
                textBox_LastName.BackColor = Color.Red;
            }
            else
            {
                textBox_LastName.BackColor = Color.White;
            }
        }
        private void textBox_Name_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Name.Text.ToString()))
            {
                textBox_Name.BackColor = Color.Red;
            }
            else
            {
                textBox_Name.BackColor = Color.White;
            }
        }




        private void button_Save_Click(object sender, EventArgs e)
        {
            string str = "";
            str += $"Ваша фамилия: {textBox_LastName.Text.ToString()}\n" +
                $"Ваше имя: {textBox_Name.Text.ToString()}\n";
            if(!String.IsNullOrEmpty(textBox_SecondName.Text))
            {
                str += $"Ваше отчество: {textBox_SecondName.Text.ToString()}\n";
            }
            if(radioButton_Male.Checked)
            {
                str += $"Ваш пол: {radioButton_Male.Text}\n";
            }
            else
            {
                str += $"Ваш пол: {radioButton_Female.Text} \n";
            }
            str += $"Дата вашего рождения: {dateTimePicker_BirthDate.Value.ToShortDateString()}\n" +
                $"Семейный статус: {comboBox_Status.Text}\n";
            if(!String.IsNullOrEmpty(textBox_Info.Text))
            {
                str += $"Дополнительная информаия: {textBox_Info.Text.ToString()}\n";
            }
            MessageBox.Show(str);
                
                   

        }

    }
}
