using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;


namespace DZ24._12._23_ListBox
{
    public partial class Anketa : Form
    {
        int counter = 0;
        Dictionary <int,User> usersList=new Dictionary<int, User>();
        List<string> list = new List<string>();
        public Anketa()
        {
            InitializeComponent();
        }

        void WriteToTXT(Dictionary<int,User> userList)
        {
            using (StreamWriter file = new StreamWriter("base.txt"))
            {
                foreach (KeyValuePair<int, User> user in userList)
                {
                    file.WriteLine(user.Key + "," + user.Value.Name + "," + user.Value.LastName + "," + user.Value.Email + "," + user.Value.Phone);
                }
            }
        }

        void WriteToXml(Dictionary<int, User> userList)
        {
            var serializer = new XmlSerializer(typeof(Dictionary<int, User>));
            var settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "\t"
            };
            using (var writer = XmlWriter.Create("base.xml", settings))
            {
                serializer.Serialize(writer, userList);
            }
        }

        void ReadFromXml()
        {
            usersList.Clear();
            if (File.Exists("base.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Dictionary<int, User>));
                using (TextReader reader = new StreamReader("base.xml"))
                {
                    try
                    {
                        usersList = (Dictionary<int, User>)serializer.Deserialize(reader);
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show("Ошибка при попытке прочитать XML: " + ex.Message);
                    }
                }
                UpdateListBox(usersList);
            }
            else
            {
                MessageBox.Show("Файл base.xml не найден");
            }
        }

        void ReadFromTXT()
        {
            usersList.Clear();
            if (File.Exists("base.txt"))
            {
                try
                {
                    string[] str = File.ReadAllLines("base.txt");
                    foreach (string e in str)
                    {
                        string[] data = e.Split(',');
                        if (data.Length >= 5)
                        {
                            int userId = int.Parse(data[0]);
                            string userName = data[1];
                            string userLastName = data[2];
                            string userEmail = data[3];
                            string userPhone = data[4];
                            User user=new User(userName, userLastName, userEmail, userPhone);
                            usersList.Add(userId, user);
                        }
                        else
                        {
                            MessageBox.Show("Данные записаны неверно в base.txt");
                        }
                    }
                    UpdateListBox(usersList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка чтения base.txt: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Файл base.txt не найден");
            }
        }


        bool chechedEmpty(TextBox textBox)
        {
            if(String.IsNullOrEmpty(textBox.Text))
            {
                textBox.BackColor= Color.Red;
                return false;
            }
            else
            {
                textBox.BackColor= Color.White;
                return true;
            }
        }

        void UpdateListBox(Dictionary<int, User> userList)
        {
            listBox.Items.Clear();
            foreach (KeyValuePair<int, User> entry in userList)
            {
                listBox.Items.Add(entry.Key + ":" + entry.Value.Name + ":" + entry.Value.LastName + ":" + entry.Value.Email + ":" + entry.Value.Phone);
            }
        }
        private void button_Registration_Click(object sender, EventArgs e)
        {
            if (chechedEmpty(textBox_Name) && chechedEmpty(textBox_LastName)
                && chechedEmpty(textBox_email) && chechedEmpty(textBox_Phone))
            {
                User user = new User(
                    textBox_Name.Text,
                    textBox_LastName.Text,
                    textBox_email.Text,
                    textBox_Phone.Text);
                usersList.Add(++counter,user);
                UpdateListBox(usersList);
                textBox_Name.Clear();
                textBox_LastName.Clear();
                textBox_email.Clear();
                textBox_Phone.Clear();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str=listBox.SelectedItem.ToString();
            List<string> list1 = str.Split(':').ToList();
            textBox_Name.Text = list1[1].ToString();
            textBox_LastName.Text = list1[2].ToString();
            textBox_email.Text = list1[3].ToString();
            textBox_Phone.Text = list1[4].ToString();
            list=list1;
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {

            int index = int.Parse(list[0]);
            if (usersList.ContainsKey(index))
            {
                User user = new User(
                        textBox_Name.Text,
                        textBox_LastName.Text,
                        textBox_email.Text,
                        textBox_Phone.Text);
                usersList[index] = user;
                list.Clear();
                textBox_Name.Clear();
                textBox_LastName.Clear();
                textBox_email.Clear();
                textBox_Phone.Clear();
                UpdateListBox(usersList);
            }
            else
            {
                MessageBox.Show("Что-то пошло не так");
            }

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(list[0]);
            if (usersList.ContainsKey(index))
            {
                usersList.Remove(index);
                list.Clear();
                UpdateListBox(usersList);
            }
            else
            {
                MessageBox.Show("Что-то пошло не так");
            }
            textBox_Name.Clear();
            textBox_LastName.Clear();
            textBox_email.Clear();
            textBox_Phone.Clear();
        }

        private void button_SaveInfoTXT_Click(object sender, EventArgs e)
        {
            if (usersList.Keys.Count > 0)
            {
                WriteToTXT(usersList);
            }
            else
            {
                MessageBox.Show("Список пуст");
            }
        }

        private void button_SaveInfoXML_Click(object sender, EventArgs e)
        {
            if (usersList.Keys.Count > 0)
            {
                WriteToXml(usersList);
            }
            else
            {
                MessageBox.Show("Список пуст");
            }
        }

        private void button_LoadInfo_Click(object sender, EventArgs e)
        {
            string filePathTXT = "base.txt";
            string filePathXML = "base.xml";
            FileInfo fileInfoTXT= new FileInfo(filePathTXT);
            DateTime dateTimeTXT = fileInfoTXT.CreationTime;
            FileInfo fileInfoXML= new FileInfo(filePathXML);
            DateTime dateTimeXML = fileInfoXML.CreationTime;
            bool txtExist = false;
            bool xmlExist = false;
            int lastDate = -1;
            
            if(fileInfoTXT.Exists)
            {
                txtExist= true;
            }
            if (fileInfoXML.Exists)
            { 
                xmlExist = true;
            }
            if (txtExist && xmlExist)
            {
                if (dateTimeTXT > dateTimeXML)
                {
                    lastDate = 0;
                }
                else
                {
                    lastDate = 1;
                }
                if (lastDate == 0)
                {
                    ReadFromTXT();
                }
                else if (lastDate == 1)
                {
                    ReadFromXml();
                }
            }
            else if (txtExist && !xmlExist)
            {
                ReadFromTXT();
            }
            else if (!txtExist && xmlExist)
            {
                ReadFromXml();
            }
            else
            {
                MessageBox.Show("Файл базы данных не найден");
            }


        }
    }

    public class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public User(string name, string lastName, string email, string phone)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            Phone = phone;

        }
    }
}
