using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp13
{
    class GameOb
    {
        public List<MyPoint> body = new List<MyPoint>();// список точек, анатогичен массиву,
        //но с более простым управлением
        public Color myColor;
       
        public void Add(MyPoint p)
        {
            body.Add(p);
           /*List<int> k = new List<int>();
            k.Add(5);
            k.Add(-10);*/
        }
    }
}
