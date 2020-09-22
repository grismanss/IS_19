using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1, v2, s, dt;
            v1 = Convert.ToDouble(textBox1.Text);
            v2 = Convert.ToDouble(textBox2.Text);
            s = Convert.ToDouble(textBox3.Text);
            dt= Convert.ToDouble(textBox4.Text);
            double t = 0;
            while (v1*t+v2*t<s)
            {
                t += dt;
              //  textBox5.Text = t.ToString();
               // System.Threading.Thread.Sleep(100);
            }
            textBox6.Text = (t * v1).ToString();
            textBox7.Text = (t * v2).ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
