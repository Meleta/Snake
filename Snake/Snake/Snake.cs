using System.Collections.Generic;

namespace Snake
{
    public class Snake : Figure
    {
        public Snake(Point tail, int lenght, Direction direction)
        {
            _line = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                _line.Add(p);
            }
        }
    }
}
