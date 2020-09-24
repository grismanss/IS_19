using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public static int progress = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;//Назначаем выбранной 1ю строку комбобокса
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = comboBox1.SelectedIndex;//Номер выбранной строки
            string s = comboBox1.Items[k].ToString();//взять текстовые данные выбранной строки
            listBox1.Items.Add(s);//Добавление полученных данных в ListBox

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            //обходим коллекцию выбранных обьектов
            for (int i=0; i<checkedListBox1.CheckedItems.Count; i++)
            {
                //накапливаем полученные данные в строку
                s += checkedListBox1.CheckedItems[i].ToString();
            }
            MessageBox.Show(s);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Width = 100 * trackBar1.Value;
            pictureBox1.Height = 80 * trackBar1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress += 1;
            if (progress > 100)
            {
                progress = 0;
            }
            progressBar1.Value = progress;
        }
    }
}
