using System;

namespace Snake
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var line1 = new HorizontalLine(1, 5, 3, '*');
            line1.DrawLine();

            var line2 = new HorizontalLine(4, 7, 5, '+');
            line2.DrawLine();

            var line3 = new VerticalLine(8, 7, 10, '-');
            line3.DrawLine();

            Console.ReadLine();
        }
    }
}
