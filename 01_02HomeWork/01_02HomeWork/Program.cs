using System;

namespace _01_02HomeWork
{
    class Program
    {
        //Task5
        public static int Reverse(int num)
        {
            for (var result = 0; ; result = result * 10 + num % 10, num /= 10) if (num == 0) return result;
        }
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Enter some symbols: ");
            char input;
            Int32 spaceCount = 0;
            do
            {
                input = Console.ReadKey().KeyChar; //Эта штука получает следующий символ или функциональную клавишу, нажатую пользователем. Нажатая клавиша отображается в окне консоли.
                if (input == ' ')
                    spaceCount++;
            }
            while (input != '.');

            Console.WriteLine("Quantity of spaces: " + spaceCount);
            //_____________________________________________________________________________
            //Task 2
            Console.Write("Enter tram ticket number:  ");

            Int32 ticketNumber = Convert.ToInt32(Console.ReadLine());
            if (ticketNumber > 100000 && ticketNumber < 999999)
            {
                int[] tmpNumbers = new int[6];
                tmpNumbers[0] = ticketNumber / 100000;
                tmpNumbers[1] = ticketNumber % 100000 / 10000;
                tmpNumbers[2] = ticketNumber % 10000 / 1000;
                tmpNumbers[3] = ticketNumber % 1000 / 100;
                tmpNumbers[4] = ticketNumber % 100 / 10;
                tmpNumbers[5] = ticketNumber % 10;
                int sum1 = tmpNumbers[0] + tmpNumbers[1] + tmpNumbers[2];
                int sum2 = tmpNumbers[3] + tmpNumbers[4] + tmpNumbers[5];
                if (sum1 == sum2)
                    Console.WriteLine("Is lucky!");
                else
                    Console.WriteLine("Better luck next time. =(");
            }
            else { Console.WriteLine("Entered wrong number!"); }
            //Task 3
            //________________________________________________________________________________
            /*
            int e, count = 0;
            char str;
            do
            {
                Console.WriteLine("Input Symbol");
                do
                {
                    e = Console.Read();
                    str = (char)e;
                } while (str == '\n' | str == '\r');

                if (e >= 65 && e <= 90)
                {
                    e += 32;
                    str = (char)e;
                    Console.WriteLine(str);
                    count++;

                }
                else if (e >= 97 && e <= 122)
                {
                    e -= 32;
                    str = (char)e;
                    Console.WriteLine(str);
                    count++;
                }
                else if (e == 46)
                {
                    break;
                }
                else
                {
                    str = (char)e;
                    Console.WriteLine(str);
                }

            } while (e != 46);
            Console.WriteLine("Total entered "+count+" symbols");*/
            //Task4
            //__________________________________________________________________________________
            Console.WriteLine("Input 2 numbers");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (a <= b)
            {
                for (int i = 0; i < a; i++)
                    Console.Write("{0}", a);
                Console.WriteLine();
                a++;
            }
            //task5
            Console.WriteLine("Input number to reverse");
            int numrev = int.Parse(Console.ReadLine());
            Console.WriteLine(Reverse(numrev));
        }
    }
}
