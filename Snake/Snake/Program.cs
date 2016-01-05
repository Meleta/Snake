using System;
using System.Threading;

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

            // змейка
            var startPoint = new Point(1, 1, '@');
            Snake snake = new Snake(startPoint, 10, Direction.Right);
            snake.DrawFigure();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.SnakeDirection(key.Key);
                }

                Thread.Sleep(100);
                snake.SnakeMove();
            }

            // ReSharper disable once FunctionNeverReturns
        }
    }
}
