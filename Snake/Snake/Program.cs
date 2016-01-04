using System;
using System.Collections.Generic;

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

            var p3 = new Point(5, 6, '%');
            p3.Draw();

            var p4 = new Point(7, 8, '@');
            p4.Draw();

            var charList = new List<char>();
            charList.Add(p1.symbol);
            charList.Add(p2.symbol);
            charList.Add(p3.symbol);
            charList.Add(p4.symbol);

            foreach (var sym in charList)
            {
                Console.WriteLine(sym);
            }

            var pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);
            pointList.Add(p3);
            pointList.Add(p4);
            
            Console.ReadLine();
        }
    }
}
