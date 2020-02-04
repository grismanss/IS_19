using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Свое сообщение");
            //hvukolgujloghulo


            /*kl;jkl'
             * nhkjlhjl
             * highui
             * ghyi
             */

            //Переменная-именованная область памяти 
            //Используется языком программирования для хранения данных.
            //Делятся на два вида:
            //1. Типизированные переменные
            //2. Не типизированные

            //Целые
            
            byte d;//от 0..255
            sbyte d2;//-128..128
            short d3;//-32768 до 32767
            ushort d4;//0 до 65535 
            int k;//-2147483648 до 2147483647
            uint k2; //от 0 до 4294967295
            long k3;//в 2 раза больше int
            //от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт.
            ulong k4;//в 2 раза больше uint
            //хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт. 
            //Имена переменных могут начинаться с буквы или _ , и содержать в себе
            //числа.
            //
            //Дробные
            float dr1;
            double dr2;
            decimal dr3;

            //Логический тип данных. Xранит значение true или false
            bool log=true;
            bool log2 = false;

            //Символьный тип данных
            //хранит одиночный символ в кодировке Unicode и занимает 2 байта.
            char simvol = 'h';

            //Строковой тип данных
            //хранит набор символов Unicode
            string str = "h";
            string str2 = "какая-то строка";

            //Не строгая типизация
            var hello = "Hell to World";

            string my_name = "Светлана";
            Console.WriteLine("Привет " + my_name);


            Console.ReadKey();
        }
    }
}
