using System;
using System.Windows.Forms;
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

        public static Rectangle Randomize(Panel canvas)
        {
            Random random = new Random();
            var intend = 15;
            var x = random.Next(intend, canvas.Width - intend);
            var y = random.Next(intend, canvas.Height - intend);
            var height = random.Next(1, canvas.Height - y - intend);
            var width = random.Next(1, canvas.Width - x - intend);
            var color = Enum.GetNames(typeof(Color))[random.Next(8)];
            return new Rectangle(height, width, x, y, color);
        }
    }
}