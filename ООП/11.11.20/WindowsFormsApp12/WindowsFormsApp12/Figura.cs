using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    class Figura
    {
        int x, y, l, dx;
        PictureBox myP;//область рисования

        public Figura(int n_x, int n_y, int n_l, PictureBox n_myP)
        {
            dx = 10;
            x = n_x;
            y = n_y;
            l = n_l;
            myP = n_myP;
            Risovanie();
        }

        public void Risovanie()
        {
            SolidBrush br = new SolidBrush(Color.Yellow);
           // SolidBrush br2 = new SolidBrush(Color.White);
            SolidBrush br3 = new SolidBrush(Color.Black);
            Graphics g = Graphics.FromImage(myP.Image);
           // g.FillRectangle(br2, 0, 0, myP.Width, myP.Height);
            //Лицо
            g.FillEllipse(br, x, y, l, l);
            int l2 = l / 4;
            Point t2 = new Point(x + l2, y + l2);
            //пЕРВЫЙ ГЛАЗ
            g.FillEllipse(br3, t2.X, t2.Y, l2 - l2 / 2, l2 - l2 / 2);
            //вТОРОЙ ГЛАЗ
            g.FillEllipse(br3, x + l - l2 - (l2 - l2 / 2), t2.Y, l2 - l2 / 2, l2 - l2 / 2);
            SolidBrush br4 = new SolidBrush(Color.Red);
            g.FillRectangle(br4, t2.X,y + l - l2, l - l2 - l2, l / 10);
            myP.Refresh();
        }

        public void Stiranie()
        {
            Graphics g = Graphics.FromImage(myP.Image);
            SolidBrush br2 = new SolidBrush(Color.White);
            g.FillRectangle(br2, x, y, l, l);
            myP.Refresh();
        }

        public void Dvizenie()
        {
            Stiranie();

            int nevX = x + dx;
            if (nevX>(myP.Width-l) || nevX < 0)
            {
                dx = -dx;
            }
            x = x + dx;

            Risovanie();
        }
    }
}
