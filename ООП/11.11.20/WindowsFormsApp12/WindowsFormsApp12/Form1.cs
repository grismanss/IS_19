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
        Figura figura;
        Figura[] f = new Figura[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(numericUpDown1.Value);
            int y = Convert.ToInt32(numericUpDown2.Value);
            int l= Convert.ToInt32(numericUpDown3.Value);
            figura = new Figura(x, y, l, pictureBox1);

            Random r = new Random();
            for (int i=0; i<10; i++)
            {
                int x1 = r.Next(0,300);
                int y1 = r.Next(0, 300);
                int l1 = r.Next(0, 300);
                f[i] = new Figura(x1, y1, l1, pictureBox1);
            }


            timer1.Interval = 100;
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            figura.Dvizenie();

            for (int i = 0; i < 10; i++)
            {
                f[i].Dvizenie();
            }
            }
    }
}
