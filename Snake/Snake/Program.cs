using System;

namespace Snake
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var p1 = new Point(1, 2, '*');
            p1.Draw();

            var p2 = new Point(3, 4, '#');
            p2.Draw();
            
            Console.ReadLine();
        }
    }
}
