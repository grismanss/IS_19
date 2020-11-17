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

namespace WindowsFormsApp27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap
                (pictureBox1.Width, pictureBox1.Height);
            pictureBox1.BackColor = Color.White;
            timer1.Start();

            button2.Enabled = false;
            button3.Enabled = false;
            редактироватьToolStripMenuItem.Enabled = false;
            удалитьToolStripMenuItem.Enabled = false;
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Text = "Добавление";
            if (f.ShowDialog() == DialogResult.OK)
            {
                timer1.Stop();
                int x = Convert.ToInt32(f.numericUpDown1.Value);
                int y = Convert.ToInt32(f.numericUpDown2.Value);
                int l = Convert.ToInt32(f.numericUpDown3.Value);
                int s = Convert.ToInt32(f.numericUpDown4.Value);
                Color cl = f.pictureBox1.BackColor;
                MyCircle cr = new MyCircle(x, y, l, s, cl, pictureBox1);
                listBox1.Items.Add(cr);
                timer1.Start();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (int i=0; i < listBox1.Items.Count; i++)
            {
                MyCircle m = listBox1.Items[i] as MyCircle;
                m.Dviz();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                MyCircle m = listBox1.Items[listBox1.SelectedIndex]
                    as MyCircle;
                m.Stiranie();
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                toolStripStatusLabel1.Text = "";
                toolStripStatusLabel2.Text = "";
                toolStripStatusLabel3.Text = "";

                if (listBox1.Items.Count == 0)
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                    редактироватьToolStripMenuItem.Enabled = false;
                    удалитьToolStripMenuItem.Enabled = false;
                    toolStripButton2.Enabled = false;
                    toolStripButton3.Enabled = false;
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) {
                Form2 f = new Form2();
                f.Text = "Редактировать";
                MyCircle m = listBox1.Items[listBox1.SelectedIndex] 
                    as MyCircle;
                f.numericUpDown1.Value = m.x;
                f.numericUpDown2.Value = m.y;
                f.numericUpDown3.Value = m.l;
                f.numericUpDown4.Value = m.s;
                f.pictureBox1.BackColor = m.myColor;

                if (f.ShowDialog() == DialogResult.OK)
                {
                    timer1.Stop();
                    m.Stiranie();
                    int x = Convert.ToInt32(f.numericUpDown1.Value);
                    int y = Convert.ToInt32(f.numericUpDown2.Value);
                    int l = Convert.ToInt32(f.numericUpDown3.Value);
                    int s = Convert.ToInt32(f.numericUpDown4.Value);
                    Color cl = f.pictureBox1.BackColor;
                    m.x = x;
                    m.y = y;
                    m.l = l;
                    m.s = s;
                    m.myColor = cl;
                    listBox1.Items[listBox1.SelectedIndex] = m;
                    timer1.Start();
                }

            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                редактироватьToolStripMenuItem.Enabled = true;
                удалитьToolStripMenuItem.Enabled = true;
                toolStripButton2.Enabled = true;
                toolStripButton3.Enabled = true;

                MyCircle m = listBox1.Items[listBox1.SelectedIndex] as MyCircle;
                toolStripStatusLabel1.Text = "Масштаб:"+m.l;
                toolStripStatusLabel2.Text = "Скорость:" + m.s;
                toolStripStatusLabel3.Text = "Цвет:" + m.myColor;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine(listBox1.Items.Count);
                    for (int i=0; i<listBox1.Items.Count; i++)
                    {
                        MyCircle m = listBox1.Items[i] as MyCircle;
                        sw.WriteLine(m.x);
                        sw.WriteLine(m.y);
                        sw.WriteLine(m.l);
                        sw.WriteLine(m.s);                        
                        sw.WriteLine(m.myColor.ToArgb());
                    }
                }
                
            }
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            listBox1.Items.Clear();
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    int k = Convert.ToInt32(sr.ReadLine());
                    for (int i=0; i<k; i++)
                    {
                        int x= Convert.ToInt32(sr.ReadLine());
                        int y= Convert.ToInt32(sr.ReadLine());
                        int l= Convert.ToInt32(sr.ReadLine());
                        int s = Convert.ToInt32(sr.ReadLine());
                        string cl = sr.ReadLine();

                        /*int k1 = cl.IndexOf("[");
                        int k2 = cl.IndexOf("]");
                       // cl = cl.Substring(k2);
                        cl = cl.Substring(k1+1, k2-k1-1);
                        Char[] sp = { ',' };
                        string[] str = cl.Split(sp);
                        int ma = str[0].IndexOf("=");
                        int a = Convert.ToInt32(str[0].Substring(ma + 1));
                        int mr = str[1].IndexOf("=");
                        int r = Convert.ToInt32(str[1].Substring(mr + 1));
                        int mg = str[2].IndexOf("=");
                        int g = Convert.ToInt32(str[2].Substring(mg + 1));
                        int mb = str[3].IndexOf("=");
                        int b = Convert.ToInt32(str[3].Substring(mb + 1));
                        //Color mycl = Color.FromName(cl);
                        Color mycl = Color.FromArgb(a, r, g, b);*/

                        Color mycl = Color.FromArgb(Convert.ToInt32(cl));
                        MyCircle my = new MyCircle(x, y, l, s, mycl, pictureBox1);
                        listBox1.Items.Add(my);

                    }

                }
                timer1.Enabled = true;

            }
        }
    }
}
