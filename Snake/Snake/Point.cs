using System;

namespace Snake
{
    public class Point
    {
        private int x;

        private int y;

        private char symbol;

        public Point(int _x, int _y, char _symbol)
        {
            x = _x;
            y = _y;
            symbol = _symbol;
        }

        public Point(Point point)
        {
            x = point.x;
            y = point.y;
            symbol = point.symbol;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.Right)
            {
                x = x + offset;
            }
            if (direction == Direction.Left)
            {
                x = x - offset;
            }
            if (direction == Direction.Top)
            {
                y = y - offset;
            }
            if (direction == Direction.Bottom)
            {
                y = y + offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(symbol);
        }
    }
}
