using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Служебный класс, который хранит методы проверки коллиций объектов.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Проверяет, пересекаются ли прямоугольники. 
        /// </summary>
        /// <param name="rectangle1">Первый проверяемый прямокгольник.</param>
        /// <param name="rectangle2">Второй проверяемый прямоугольник.</param>
        /// <returns>Возвращает true, если прямоугольники пересекаются.
        /// И false, если прямоугольники не пересекаются.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            var dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            var sumWidth = (rectangle1.Width + rectangle2.Width) / 2.0;
            var dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            var sumHeight = (rectangle1.Height + rectangle2.Height) / 2.0;

            return dX < sumWidth && dY < sumHeight;
        }

        /// <summary>
        /// Проверяет, пересекаются ли кольца. 
        /// </summary>
        /// <param name="ring1">Первое проверяемое кольцо.</param>
        /// <param name="ring2">Второе проверяемое кольцо.</param>
        /// <returns>Возвращает true, если кольца пересекаются.
        /// И false, если кольца не пересекаются.</returns>
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