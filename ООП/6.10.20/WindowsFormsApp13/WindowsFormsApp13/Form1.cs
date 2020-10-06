using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Person p1 = new Person();
            Person p2 = new Person("Иван", 35);
            Person p3 = new Person( 35);
            //  Person p4 = new Person("Иван");

            string s1 = p1.GetUserData();
            string s2 = p2.GetUserData();
            string s3 = p3.GetUserData();

            textBox1.Text += s1 + "\r\n";
            textBox1.Text += s2 + "\r\n";
            textBox1.Text += s3 + "\r\n";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Treugolnik[] masT = new Treugolnik[5];
            Random r = new Random();
            for (int i=0; i<5; i++)
            {
                int a = r.Next(5, 15);
                int b = r.Next(5, 15);
                int c = r.Next(5, 15);
                masT[i] = new Treugolnik(a, b, c);
                string s = "a=" + masT[i].a.ToString() + " b=" + masT[i].b.ToString() + " c=" + masT[i].c.ToString();
                s += " " + masT[i].Exists().ToString() + " p=" + masT[i].Perimetr().ToString() + " s=" 
                    + masT[i].Plo().ToString();
                textBox1.Text += s + "\r\n";
            }
            //Написать класс для работы с окружностью
            //класс принимает радиус, вычисляет диаметр и площадь окружности
        }
    }
}
