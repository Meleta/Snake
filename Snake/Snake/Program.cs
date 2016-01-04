using System;

namespace Snake
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //рамка
            var lineTop = new HorizontalLine(0, 80, 0, '*');
            lineTop.DrawFigure();

            var lineLeft = new VerticalLine(0, 0, 24, '*');
            lineLeft.DrawFigure();

            var lineBottom = new HorizontalLine(0, 80, 24, '*');
            lineBottom.DrawFigure();

            var lineRight = new VerticalLine(79, 0, 24, '*');
            lineRight.DrawFigure();

            Console.ReadLine();
        }
    }
}
