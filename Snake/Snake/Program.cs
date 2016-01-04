using System;

namespace Snake
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var x1 = 1;
            var y1 = 2;
            var z1 = '*';

            var x2 = 3;
            var y2 = 4;
            var z2 = '#';

            Draw(x1, y1, z1);
            Draw(x2, y2, z2);

            Console.ReadLine();
        }

        public static void Draw(int x, int y, char z)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(z);
        }
    }
}
