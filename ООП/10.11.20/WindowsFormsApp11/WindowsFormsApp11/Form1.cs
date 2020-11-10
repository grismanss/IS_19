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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Graphics класс для работы с графикой
            //Соединяем пикчебокс  обьектоном, на котором будем рисовать
            Graphics polotno = Graphics.FromImage(pictureBox1.Image);
            //Объект для рисования контура
            Pen kontur = new Pen(Color.Red);
            //Обьект для рисования заливки
            SolidBrush kist = new SolidBrush(Color.Yellow);

            //Закрашеный эллипс, передаем фон, х у ширину и высоту
            polotno.FillEllipse(kist, 200, 150, 50, 90);
            //Незакрашеный эллипс, передаем фон, х у ширину и высоту
            polotno.DrawEllipse(kontur, 200, 150, 50, 90);

            //Point класс для хранения точки с координатами х у
            Point t = new Point(10, 20);
            Point t2 = new Point(10, 200);
            polotno.DrawLine(kontur, t, t2);//Построение линии по двум обьектам point

            //Построение линии по 4м значениям х1 у1 х2 у2
            polotno.DrawLine(kontur, 50,90,80,200);

            //Рисованире прямоугодльного обькта
            polotno.FillRectangle(kist,150, 200, 60, 90);
            //Обновляем изображение в пикчебокс
            pictureBox1.Refresh();

            
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Создаем программно изображение в пикчебокс
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point t = new Point(Convert.ToInt32(numericUpDown1.Value),
               Convert.ToInt32(numericUpDown2.Value));
            int l = Convert.ToInt32(numericUpDown3.Value);

            SolidBrush br = new SolidBrush(Color.Yellow);
            SolidBrush br2 = new SolidBrush(Color.White);
            SolidBrush br3 = new SolidBrush(Color.Black);

            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.FillRectangle(br2, 0, 0, pictureBox1.Width, pictureBox1.Height);
            
            //Лицо
            g.FillEllipse(br, t.X, t.Y, l, l);

            int l2 = l / 4;
            Point t2 = new Point(t.X +l2, t.Y+ l2);

            //пЕРВЫЙ ГЛАЗ
            g.FillEllipse(br3, t2.X, t2.Y, l2-l2/2, l2- l2 / 2);
            //вТОРОЙ ГЛАЗ
            g.FillEllipse(br3, t.X+l-l2-(l2 - l2 / 2), t2.Y, l2 - l2 / 2, l2 - l2 / 2);

            SolidBrush br4 = new SolidBrush(Color.Red);
            g.FillRectangle(br4, t2.X, t.Y +l- l2, l - l2 - l2, l / 10);

            pictureBox1.Refresh();
        }
    }
}
