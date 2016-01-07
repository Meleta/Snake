using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Wall
    {
        private List<Figure> walls;
 
        public Wall(int mapWidth, int mapHeight)
        {
            walls = new List<Figure>();

            //рамка
            var lineTop = new HorizontalLine(0, mapWidth - 2, 0, '*');
            var lineLeft = new VerticalLine(0, 0, mapHeight - 1, '*');
            var lineBottom = new HorizontalLine(0, mapWidth - 1, mapHeight - 1, '*');
            var lineRight = new VerticalLine(mapWidth - 2, 0, mapHeight - 1, '*');
            
            walls.Add(lineTop);
            walls.Add(lineLeft);
            walls.Add(lineBottom);
            walls.Add(lineRight);
        }

        public void DrawWalls()
        {
            foreach (var wall in walls)
            {
                wall.DrawFigure();
            }
        }

        public bool IsHit(Figure figure)
        {
            foreach (var wall in walls)
            {
                if (wall.IsHitFigure(figure))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
