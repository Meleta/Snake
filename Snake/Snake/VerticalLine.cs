using System.Collections.Generic;

namespace Snake
{
    public class VerticalLine : Figure
    {
        public VerticalLine(int x, int top, int bottom, char symbol)
        {
            _line = new List<Point>();

            for (var i = top; i < bottom; i++)
            {
                _line.Add(new Point(x, i, symbol));
            }
        }
    }
}
