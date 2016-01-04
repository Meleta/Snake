using System;

namespace Snake
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var p1 = new Point();
            p1.x = 1;
            p1.y = 2;
            p1.symbol = '*';
            p1.Draw();

            var p2 = new Point();
            p2.x = 3;
            p2.y = 4;
            p2.symbol = '#';
            p2.Draw();
            
            Console.ReadLine();
        }
    }
}
