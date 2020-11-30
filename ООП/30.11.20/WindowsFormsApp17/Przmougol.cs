using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp17
{
    public class Pramougol:Figura
    {
        public double b;

        public Pramougol(double na, double nb) : base(na)
        {
            b = nb;
        }

        public override double Calc()
        {
            return a*b;
        }
        public override string ToString()
        {
            return "Прямоугольник a=" + a + "b=" + b ;
        }
    }
}
