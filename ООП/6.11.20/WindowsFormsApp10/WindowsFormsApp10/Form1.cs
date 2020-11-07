using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            //  f.Show();//вызов обычной формы
            if (f.ShowDialog() == DialogResult.OK)
            {
                int a = Convert.ToInt32(f.textBox1.Text);
                int b = Convert.ToInt32(f.textBox2.Text);
                Drobi d = new Drobi();
                d.a = a;
                d.b = b;
                listBox1.Items.Add(d);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int k = listBox1.SelectedIndex;
            if (k != -1)
            {
                Drobi d = listBox1.Items[k] as Drobi;
                Form2 f = new Form2();
                f.textBox1.Text = d.a.ToString();
                f.textBox2.Text = d.b.ToString();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    d.a = Convert.ToInt32(f.textBox1.Text);
                    d.b = Convert.ToInt32(f.textBox2.Text);
                    listBox1.Items[k] = d;
                }
               
            }
            else
            {
                MessageBox.Show("Не выбрано обьект для редактирования");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = listBox1.SelectedIndex;
            if (k != -1)
            {
                listBox1.Items.RemoveAt(k);
            }
            else
            {
                MessageBox.Show("Не выбрано обьект для удаления");
            }
        }
    }
}
