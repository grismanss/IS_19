using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ввести два числа и найти их сумму*/
            int a, b, c;//обьявляем переменные
            Console.WriteLine("Введите первое число");//Пишем сообщение пользователю
            //обязательно при получении переменной типа int
            //делаем конвертирование 
            //т.к. все данные на консоли являются string
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Результат a+b=" + c);
            Console.ReadKey();
            /*
             Convert.ToInt32() (преобразует к типу int)
            Convert.ToDouble() (преобразует к типу double)
            Convert.ToDecimal() (преобразует к типу decimal)*/


        }
    }
}
