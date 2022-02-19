﻿using System;
using Operations.Extentions;


namespace Operations
{
    class Program
    {

        public static void Complex()
        {

            var c1 = new DataTypes.Complex
            {
                Im = -2,
                Re = 1
            };
            var c2 = new DataTypes.Complex
            {
                Im = -2,
                Re = 1
            };
            var c3 = new DataTypes.Complex
            {
                Im = 1,
                Re = 0
            };
            var c0 = new DataTypes.Complex
            {
                Im = 0,
                Re = 0
            };

            Console.WriteLine(c1.ToString());
            Console.WriteLine($"{c1} + {c2} = {c1 + c2}");
            Console.WriteLine($"{c1} - {c2} = {c1 - c2}");

            try
            {

                Console.WriteLine($"{c3} * {c3} = {c3 * c3}");
                Console.WriteLine($"{c3} / {c3} = {c3 / c3}");
                Console.WriteLine($"{c3} / {c0} = {c3 / c0}");
            }
            catch (Exceptions.ComplexExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public static void vec()
        {
            try
            {

                var v1 = new DataTypes.vec2
                {
                    x = 1,
                    y = 2
                };
                var v2 = new DataTypes.vec2
                {
                    x = 2,
                    y = 1
                };

                Console.WriteLine($"x:{v1[0]} y: {v1[1]}");
                Console.WriteLine($"x:{v2[0]} y: {v2[1]}");

                Console.WriteLine("Dot: " + DataTypes.vec2.Dot(v1, v2));
                Console.WriteLine("v1 Len: " + v1.Len());
                Console.WriteLine("v2 Len: " + v2.Len());

                Console.WriteLine("Angle: " + (v1 ^ v2));
            }
            catch (Exceptions.Vec2Exceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Clone()
        {

            var c = new DataTypes.Complex { Re=1,Im=2};
            var c2 = c.Clone();
            var c1 = c;
            c.Re = 3;
            Console.WriteLine($"{c},  {c1}, {c2}");
            Console.WriteLine(c.Reflect());
        }
        public static void vec2Extentions()
        {
            var v1 = new DataTypes.vec2 { x = -2, y = 1 };
            v1.Abs();
            v1.Inverse();
            Console.WriteLine(v1);
        }
        static void Main(string[] args)
        {
            Program.vec2Extentions();

        }
    }
}
