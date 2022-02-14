using System;

namespace Enums 
{ 
    class Program
    {
        private static    Random rnd = new();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Enum!");
            Directions direction;
            //direction = Directions.Left;
            for (int i = 0; i < 10; i++)
            {
                direction = RandomDirection();
                Console.Write(direction + " ");
                PrintDirection(direction);
            }
        }
        private static Directions RandomDirection()
        {
            //int[] val = { 0, 10, 11, 20, 21 };
            var val = Enum.GetValues(typeof(Directions));
            return (Directions) rnd.Next(Enum.GetValues(typeof(Directions)).Length);
        }
        private static void PrintDirection(Directions direction)
        {
            //Enum.IsDefined(typeof(Directions),direction)
            //Enum.IsDefined(direction.GetType(),direction) 
          if (!Enum.IsDefined(direction.GetType(), direction))
            {
                throw new ArgumentOutOfRangeException($"Value { direction} out of Enum");
            }

            string img = String.Empty;
            switch (direction)
            {
                case Directions.Left:    img = "<";  break;
                case Directions.Right:   img = ">";  break;
                case Directions.Up:      img = "^";  break;
                case Directions.Down:    img = "v";  break;
            }
            Console.WriteLine(img);
        }
    }
}
