using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Food
    {
        int mapWidth;
        int mapHeight;
        char foodImage;

        Random random = new Random();

        public Food(int mapWidth, int mapHeight, char foodImage)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.foodImage = foodImage;
        }

        public Point CreateMeal()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            Point meal = new Point(x, y, foodImage);
            return meal;
        }
    }
}
