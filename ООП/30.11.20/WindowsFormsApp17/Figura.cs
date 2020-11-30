using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp17
{
    abstract public class Figura
    {
        public double a;

        public Figura(double na)
        {
            a = na;
        }

        abstract public double Calc();//абстрактная функция, 
        //котроя будет описана в классе наследнке
    }
}
