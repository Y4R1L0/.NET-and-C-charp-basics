using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo
            {
                NumberDecimalSeparator = ".",
            };
            /*
            string ,strr;
            strr=Console.ReadLine();
            Console.WriteLine("Hello, "+strr);
            */

            /*
            int a,b;
            string str;
            Console.WriteLine("Input number 1:");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.WriteLine("Input number 2:");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            int res = a + b;
            Console.WriteLine(a+"+"+ b +"="+res);
            */

            string strToNum = "5";

            int c = int.Parse(strToNum);
            Console.WriteLine("Number 3:");
            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}
