using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Polygon
{
    class Program
    {
        static void Main(string[] args)
        {
                //Среднее арефметическое 5 рандомнчх чисел
                NumberFormatInfo numberFormatInfo = new NumberFormatInfo
                {
                    NumberDecimalSeparator = ".",
                };
            //Создание объекта для генерации чисел
            Random rnd = new Random();

            double num1 = rnd.Next(0, 1000);
            Console.WriteLine(num1);

            double num2 = rnd.Next(0, 1000);
            Console.WriteLine(num2);

            double num3 = rnd.Next(0, 1000);
            Console.WriteLine(num3);

            double num4 = rnd.Next(0, 1000);
            Console.WriteLine(num4);

            double num5 = rnd.Next(0, 1000);
            Console.WriteLine(num5);

            double rndnum = ( num1 + num2 + num3 + num4 + num5) / 5;

            Console.WriteLine(rndnum);

            Console.ReadLine();
            
        }
    }
}
/*
 Компоненты которыми управляет ОС
 
 */