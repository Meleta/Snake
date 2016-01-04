using System.Collections.Generic;

namespace Snake
{
    public class HorizontalLine : Figure
    {
        public HorizontalLine(int left, int right, int y, char symbol)
        {
            _line = new List<Point>();

            for (var i = left; i < right; i++)
            {
                _line.Add(new Point(i, y, symbol));
            }
        }
    }
}
