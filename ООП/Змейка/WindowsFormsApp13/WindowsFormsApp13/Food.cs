using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp13
{
    class Food:GameOb
    {
        public Food(Color n_cl)
        {
            myColor = n_cl;          
        }

        //функция рандомит новую точку
        public MyPoint RandomFoodPoint(int sizeX, int sizeY)
        {
            Random r = new Random();
            MyPoint a = new MyPoint(r.Next(0, sizeX), r.Next(0, sizeY));
            return a;
        }

        public void Delete(int k)
        {
            body.RemoveAt(k);//удвляем обьект по номеру в списке
        }
    }
}
