using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp27
{
    class MyCircle
    {
        public int x, y, l, s, dx,dy;
        public Color myColor;
        PictureBox myPb;

        public MyCircle(int nX, int nY, int nL, int nS, 
            Color nMyColor, PictureBox nMyPb)
        {
            x = nX;
            y = nY;
            l = nL;
            s = nS;
            myColor = nMyColor;
            myPb = nMyPb;
            dx = s*3;
            dy = s*5;
            Risov();
        }

        public void Risov()
        {
            Graphics g = Graphics.FromImage(myPb.Image);
            SolidBrush b = new SolidBrush(myColor);
            g.FillEllipse(b, x, y, l, l);
            myPb.Refresh();
        }
        public void Stiranie()
        {
            Graphics g = Graphics.FromImage(myPb.Image);
            SolidBrush b = new SolidBrush(Color.White);
            g.FillEllipse(b, x, y, l, l);
            myPb.Refresh();
        }
        public void Dviz()
        {
            Stiranie();
            int xx = x + dx;
            if (xx<0 || xx> (myPb.Width - l)){
                dx = -dx;
            }
            x = x + dx;


            int yy = y + dy;
            if (yy < 0 || yy > (myPb.Height - l))
            {
                dy = -dy;
            }
            y = y + dy;

            Risov();
        }

        public override string ToString()
        {
            return ("масштаб:"+l+" цвет:"+myColor);
        }

    }
}
