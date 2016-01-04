using System.Collections.Generic;

namespace Snake
{
    public class HorizontalLine
    {
        private readonly List<Point> _line;

        public HorizontalLine(int left, int right, int y, char symbol)
        {
            this._line = new List<Point>();

            for (var i = left; i < right; i++)
            {
                this._line.Add(new Point(i, y, symbol));
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
