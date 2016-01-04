using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class VerticalLine
    {
        private readonly List<Point> _line;

        public VerticalLine(int x, int top, int bottom, char symbol)
        {
            this._line = new List<Point>();

            for (var i = top; i < bottom; i++)
            {
                this._line.Add(new Point(x, i, symbol));
            }
        }

        public void DrawLine()
        {
            foreach (var point in this._line)
            {
                point.Draw();
            }
        }
    }
}
