using System;

namespace Snake
{
    public class Point
    {
        public int x;

        public int y;

        public char symbol;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(symbol);
        }
    }
}
