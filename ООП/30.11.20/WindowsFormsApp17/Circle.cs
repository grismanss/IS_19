using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp17
{
    public class Circle:Figura
    {
        public Circle(double na) : base(na)
        {

        }

        public override double Calc()
        {
            return 2 * Math.PI * a * a;
        }

        public override string ToString()
        {
            return "Окружность r=" + a ;
        }
    }
}
