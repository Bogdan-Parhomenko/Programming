using System;

namespace Programming.Model.Classes
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            var dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            var sumWidth = (rectangle1.Width + rectangle2.Width) / 2.0;
            var dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            var sumLength = (rectangle1.Length + rectangle2.Length) / 2.0;

            return dX < sumWidth && dY < sumLength;
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            var dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            var dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            var hypotenuse = Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));
            var sumRadius = ring1.OuterRadius + ring2.OuterRadius;

            return hypotenuse < sumRadius;
        }
    }
}