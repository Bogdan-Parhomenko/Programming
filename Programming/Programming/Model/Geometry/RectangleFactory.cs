using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Служебный класс, который хранит методы создания прямоугольников.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Создает прямоугольник со случайными характеристиками.
        /// </summary>
        /// <returns>Возвращает экземпляр созданного прямоугольника.</returns>
        public static Rectangle Randomize()
        {
            Random random = new Random();
            var rectangle = new Rectangle(
                random.Next(1, 101),
                random.Next(1, 101),
                random.Next(1, 401),
                random.Next(1, 401),
                Enum.GetNames(typeof(Color))[random.Next(8)]);
            return rectangle;
        }

        /// <summary>
        /// Создает прямоугольник со случайными характеристиками, не выходящий за границы панели.
        /// </summary>
        /// <param name="canvas">Панель, в пределах которой будут создаваться прямугольники.</param>
        /// <returns>Возвращает экземпляр созданного в пределах панели прямоугольника.</returns>
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