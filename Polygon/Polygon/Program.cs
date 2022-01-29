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
            while (true)
            {
                //Калькулятор
                NumberFormatInfo numberFormatInfo = new NumberFormatInfo
                {
                    NumberDecimalSeparator = ".",
                };
                double firstValue, secondValue;
                string action;

                Console.WriteLine("Input first number");
                firstValue = double.Parse(Console.ReadLine(), numberFormatInfo);

                Console.WriteLine("Input operator (+ - * /)");
                action = Console.ReadLine();

                Console.WriteLine("Input second number");
                secondValue = double.Parse(Console.ReadLine(), numberFormatInfo);

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;
                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;
                    case "/":
                        if (secondValue == 0) Console.WriteLine("Do you want to divide by zero ? A sick schizophrenic...");
                        else Console.WriteLine(firstValue / secondValue);
                        break;
                    default:
                        Console.WriteLine("Wrong operator");
                        break;
                }
            }
        }
    }
}
