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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текст на экране", "Заголовок");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текст на экране", "Заголовок", MessageBoxButtons.YesNoCancel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текст на экране", "Заголовок",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
           DialogResult r= MessageBox.Show("Текст на экране", "Заголовок",
               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
            if (r == DialogResult.Yes)
            {
                button1.BackColor = Color.Blue;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = openFileDialog1.FileName;//получаем путь до файла
                string s2 = File.ReadAllText(s);//получаем данные из файла
                textBox1.Text = s2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = saveFileDialog1.FileName;
                string s2 = textBox1.Text;
                File.WriteAllText(s, s2);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.BackColor = colorDialog1.Color;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("1.jpeg");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("2.jpg");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("3.jpg");
        }
    }
}
