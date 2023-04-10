using System;
using Programming.Model.Enums;

namespace Programming.Model.Classes
{
    public static class RectangleFactory
    {
        private static Random random = new Random();
        public static Rectangle Randomize()
        {
            var rectangle = new Rectangle(random.Next(1, 101),
            random.Next(1, 101),
            random.Next(1, 401),
            random.Next(1, 401),
            Enum.GetNames(typeof(Color))[random.Next(8)],
            new Point2D(random.Next(1, 401), random.Next(1, 401)));
            return rectangle;
        }
    }
}