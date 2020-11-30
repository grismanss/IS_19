using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp17
{
   public class Treugol:Figura
    {
        public double b, c;

        public Treugol(double na,double nb, double nc) : base(na)
        {
            b = nb;
            c = nc;
        }

        public override double Calc()
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
        public override string ToString()
        {
            return "Треугольник a="+a+"b="+b+"c="+c;
        }

    }
}
