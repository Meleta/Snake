using System.Collections.Generic;

namespace Snake
{
    public class Figure
    {
        protected List<Point> _line;

        public void DrawFigure()
        {
            foreach (var point in _line)
            {
                point.Draw();
            }
        }

        public bool IsHitFigure(Figure figure)
        {
            foreach (var point in _line)
            {
                if (figure.IsHitFigure(point))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsHitFigure(Point point)
        {
            foreach (var p in _line)
            {
                if (p.IsEqual(point))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
