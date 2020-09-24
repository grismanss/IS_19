using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            int x = r.Next(this.Width - button2.Width);
            int y = r.Next(this.Height - button2.Height);
            button2.Location = new Point(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спасибо за ответ!");
        }
    }
}
