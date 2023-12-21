using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace DZ27._12_ProgressBar
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Download_Click(object sender, EventArgs e)
        {
            string filePath=textBox_FilePath.Text.ToString();
            if (File.Exists(filePath)) 
            { 
                try
                {
                    string str = File.ReadAllText(filePath);
                    int length = str.Length;
                    progressBar_Download.Maximum= length;
                    progressBar_Download.Step = 1;
                    for (int i=0;i< length; i++)
                    {
                        progressBar_Download.PerformStep();
                        Thread.Sleep(500);
                    }
                    listBox1.Items.Add(str);
                    textBox_FilePath.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка чтения файла: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Файл не найден");
            }
        }
    }
}
