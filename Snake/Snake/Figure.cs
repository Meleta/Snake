using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
