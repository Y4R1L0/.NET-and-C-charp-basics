using System;


namespace Basics
{
    class TypeC
    {
        public int x;
    }
    struct TypeS
    {
        public int x;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeC c1, c2;
            TypeS s1, s2;

            c1 = new TypeC();
            c1.x = 10;
            c2 = c1;
            c2.x = 20;
            Console.WriteLine("c1.x = {0}, c2.x = {1}",c1.x,c2.x);
            
            s1 = new TypeS();
            s1.x = 10;
            s2 = s1;
            s2.x = 20;
            Console.WriteLine("s1.x = {0}, s2.x = {1}", s1.x, s2.x);

            Console.WriteLine("Привет Мир!");
            Console.WriteLine("Hello World!");

        }
    }
}
