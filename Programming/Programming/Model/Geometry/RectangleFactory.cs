using System;
using Programming.Model.Enums;

namespace Programming.Model.Geometry
{
    public static class RectangleFactory
    {
        public static Rectangle Randomize()
        {
            Random random = new Random();
            var rectangle = new Rectangle(random.Next(1, 101),
            random.Next(1, 101),
            random.Next(1, 401),
            random.Next(1, 401),
            Enum.GetNames(typeof(Color))[random.Next(8)]);
            return rectangle;
        }
    }
}