using System;

namespace Oper
{
    class Complex
    {
        public double r, i;
        public Complex Sum(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r + b.r;
            res.i = a.i + b.i;
            return res;
        }

        public Complex Multiplication(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r * b.r;
            res.i = a.i * b.i;
            return res;
        }

        public Complex Subtract(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r - b.r;
            res.i = a.i - b.i;
            return res;
        }

        public void Print(Complex a)
        {
            Console.Write("{0} + i{1}", a.r, a.i);
        }

        public void PrintLine(Complex a)
        {
            Console.WriteLine("{0} + i{1}", a.r, a.i);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целую часть первого комплексного числа: ");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            double i1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите целую часть второго комплексного числа: ");
            double r2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            double i2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Complex c1 = new Complex();
            Complex c2 = new Complex();
            c1.r = r1;
            c1.i = i1;
            c2.r = r2;
            c2.i = i2;
            Console.WriteLine("Введенные комплексные числа: ");
            c1.PrintLine(c1);
            c2.PrintLine(c2);
            Console.WriteLine("\nДля продолжения нажмите [Enter]");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Сложение комплексных чисел:       {0} + {1}i", c1.Sum(c1, c2).r, c1.Sum(c1, c2).i);
            Console.WriteLine("Умножение комплексных чисел:      {0} + {1}i", c1.Multiplication(c1, c2).r, c1.Multiplication(c1, c2).i);
            Console.WriteLine("Вычитание комплексных чисел:      {0} + {1}i", c1.Subtract(c1, c2).r, c1.Subtract(c1, c2).i);
            Console.WriteLine("\nДля выхода из программы нажмите [Enter]");
            Console.ReadLine();
        }
    }
}
