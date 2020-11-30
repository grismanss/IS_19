using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                Treugol t = new Treugol(a, b, c);
                listBox1.Items.Add(t);
            }
            else if (radioButton2.Checked)
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
              
                Pramougol t = new Pramougol(a, b);
                listBox1.Items.Add(t);
            }
            else if (radioButton3.Checked)
            {
                double a = Convert.ToDouble(textBox1.Text);
                Circle t = new Circle(a);
                listBox1.Items.Add(t);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Figura f = listBox1.Items[listBox1.SelectedIndex] as Figura;
                double s = f.Calc();
                textBox4.Text = s.ToString();

             /*  if (listBox1.SelectedItem is Treugol)
                {
                    Treugol f = listBox1.Items[listBox1.SelectedIndex] as Treugol;
                    double s = f.Calc();

                    textBox4.Text = s.ToString();
                }
                else if (listBox1.SelectedItem is Pramougol)
                {
                    Pramougol f = listBox1.Items[listBox1.SelectedIndex] as Pramougol;
                    double s = f.Calc();
                    textBox4.Text = s.ToString();
                }
               else if (listBox1.SelectedItem is Circle)
                {
                    Circle f = listBox1.Items[listBox1.SelectedIndex] as Circle;
                    double s = f.Calc();
                    textBox4.Text = s.ToString();
                }
             */
            }
        }
    }
}
