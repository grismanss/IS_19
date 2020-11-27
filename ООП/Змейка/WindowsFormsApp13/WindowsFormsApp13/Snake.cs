using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp13
{
    class Snake:GameOb
    {
        int speed = 1;

        public Snake(Color n_cl)
        {
            myColor = n_cl;
        }
        //добавление в хвост новой точки 
        public void AddHvost()
        {

        }
        //функция движения звмеи
        public void Move(int dx, int dy)
        {
            for (int i= body.Count-1; i>0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x = body[0].x+dx;
            body[0].y = body[0].y+dy;
        }
    }
}
