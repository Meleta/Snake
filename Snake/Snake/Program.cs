using System;
using System.Threading;

namespace Snake
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //рамка 80 X 25
            var lineTop = new HorizontalLine(0, 80, 0, '*');
            lineTop.DrawFigure();

            var lineLeft = new VerticalLine(0, 0, 24, '*');
            lineLeft.DrawFigure();

            var lineBottom = new HorizontalLine(0, 80, 24, '*');
            lineBottom.DrawFigure();

            var lineRight = new VerticalLine(79, 0, 24, '*');
            lineRight.DrawFigure();

            //еда (на старте)
            Food createFood = new Food(80, 25, '$');
            Point food = createFood.CreateMeal();
            food.Draw();

            // змейка
            var startSnakePoint = new Point(1, 1, '@');
            Snake snake = new Snake(startSnakePoint, 10, Direction.Right); // длина змейки десять маг.число
            snake.DrawFigure();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = createFood.CreateMeal();
                    food.Draw();
                }
                else
                {
                    snake.SnakeMove();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.SnakeDirection(key.Key);
                }
            }

            // ReSharper disable once FunctionNeverReturns
        }
    }
}
