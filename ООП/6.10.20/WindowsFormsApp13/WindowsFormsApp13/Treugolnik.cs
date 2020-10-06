using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    //Необходимо создать класс треугольник, 
    //принимающий 
    //величины трех сторон
    //реализовать меетоды вывода площади
    //периметра
    //ответа на вопрос о существовании треугольник

    class Treugolnik
    {
        public double a, b, c;

        public Treugolnik(double n_a, double n_b, double n_c)
        {
            a = n_a;
            b = n_b;
            c = n_c;
        }

        //Метод проверяющий существование треугольника
        public bool Exists()
        {
            bool t = true;
            if ((a+b)<c ||(b+c)<a || (c + a) < b)
            {
                t = false;
            }
            return t;
        }

        public double Perimetr()
        {
            if (Exists() == false)
            {
                return 0;
            }
            else
                return a + b + c;
        }

        public double Plo()
        {
            double p = Perimetr() / 2;
            double s;
            if (Exists() == false)
            {
                s = 0;
            }
            else
            {
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            return s;
        }
    }
}
