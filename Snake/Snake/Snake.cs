using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    public class Snake : Figure
    {
        private Direction _direction;

        public Snake(Point tail, int length, Direction direction)
        {
            _direction = direction;
            _line = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, _direction);
                _line.Add(p);
            }
        }

        public void SnakeDirection(ConsoleKey key)
        {
            if (key == ConsoleKey.RightArrow)
            {
                this._direction = Direction.Right;
            }

            if (key == ConsoleKey.LeftArrow)
            {
                this._direction = Direction.Left;
            }
            
            if (key == ConsoleKey.UpArrow)
            {
                this._direction = Direction.Up;
            }

            if (key == ConsoleKey.DownArrow)
            {
                this._direction = Direction.Down;
            }
        }

        public void SnakeMove()
        {
            Point tail = _line.First();
            _line.Remove(tail);
            Point head = GetNextPoint();
            _line.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = _line.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, _direction);
            return nextPoint;
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsEqual(food))
            {
                food.symbol = head.symbol;
                _line.Add(food);
                return true;
            }

            return false;
        }
    }
}
