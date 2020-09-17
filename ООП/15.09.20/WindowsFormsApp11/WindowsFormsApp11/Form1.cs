using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Привет мир!!!";
            this.BackColor = Color.Aquamarine;
           // this.Width = 400;
            //this.Height = 200;
            this.Size = new Size(400, 200);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Событие при нажатии");
            this.Enabled = false;

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
           // MessageBox.Show("Событие при наведении");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
           // MessageBox.Show("Событие при MouseDown");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();//создаем экземпляр формы2
            F2.Show();//показываем форму 2
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //срабатывает после инициализации но до визуального появления
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //в момент визуального появления
        }
    }
}
