using System.Collections.Generic;

namespace Snake
{
    public class Figure
    {
        protected static List<Point> _line;

        public void DrawFigure()
        {
            foreach (var point in _line)
            {
                point.Draw();
            }
        }
    }
}
