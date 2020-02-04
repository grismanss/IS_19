using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ДАНО трехзначное число найти сумму его цифр*/
            int n;
            Console.WriteLine("Введите трехзначное число");
            n = Convert.ToInt32(Console.ReadLine());
            int a, b, c;
            c = n % 10;// % остаток от деления 
            a = n / 100;//целочисленное деление
            b = n % 100 / 10;
            Console.WriteLine(a + b + c);

            Console.ReadKey();
            
            /*Написать программу, которая спрашивает ваше имя, возраст, 
             * рост и вес, а затем печатает на экрат краткую анкету
             
             Привет:Михаил!
             Твой возраст 22. 
             Рост 178см и вес 78кг*/

        }
    }
}
