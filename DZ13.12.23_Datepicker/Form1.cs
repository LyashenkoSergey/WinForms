using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ13._12._23_Datepicker
{
    public partial class Form1 : Form
    {
        public Point mouse_offset;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker_Start.Value = DateTime.Now;
            dateTimePicker_Finish.Value = DateTime.Now;
            textBox_Result.Text=(dateTimePicker_Finish.Value - dateTimePicker_Start.Value).Days.ToString();
    

        }

        private void button_Minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos; 
            }
        }

        private void dateTimePicker_Start_ValueChanged(object sender, EventArgs e)
        {
            textBox_Result.Text = (dateTimePicker_Finish.Value - dateTimePicker_Start.Value).Days.ToString();
        }

        private void dateTimePicker_Finish_ValueChanged(object sender, EventArgs e)
        {
            textBox_Result.Text = (dateTimePicker_Finish.Value - dateTimePicker_Start.Value).Days.ToString();
        }
    }
}
