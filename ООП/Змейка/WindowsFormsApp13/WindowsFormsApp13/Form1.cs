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
        Game g;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            g = new Game(pictureBox1);//Мы создаем экземпляр игры
            g.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Move(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Move(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Move(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            g.Move(4);
            
        }
    }
}
