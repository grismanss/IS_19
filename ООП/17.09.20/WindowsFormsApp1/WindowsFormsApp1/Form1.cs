using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //У системы запускаем переход по ссылке
            System.Diagnostics.Process.Start("https://metanit.com/");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true && checkBox3.Checked == true && checkBox2.Checked==false)
            {
                MessageBox.Show("Верно!");
            }
            else
            {
                MessageBox.Show("Не верно!");
            }

            //Равнозначная запись условия

          /*  if (checkBox1.Checked  && checkBox3.Checked  && !checkBox2.Checked)
            {
                MessageBox.Show("Верно!");
            }
            else
            {
                MessageBox.Show("Не верно!");
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("М");
            }
            else if(radioButton2.Checked == true)
            {
                MessageBox.Show("Ж");
            }
        }
    }
}
