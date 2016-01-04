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
    }
}
