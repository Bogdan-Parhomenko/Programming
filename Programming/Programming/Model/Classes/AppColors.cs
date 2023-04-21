using System.Drawing;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Служебный класс, который хранит цвета.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Цвет объектов, если они не пересекаются.
        /// </summary>
        public static Color CollisionFalseColor = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Цвет объектов, если они пересекаются.
        /// </summary>
        public static Color CollisionTrueColor = Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Цвет поля, если его значение прошло валидацию.
        /// </summary>
        public static Color ValidationTrueColor = Color.White;

        /// <summary>
        /// Цвет поля, если его значение не прошло валидацию.
        /// </summary>
        public static Color ValidationFalseColor = Color.LightPink;

        /// <summary>
        /// Цвет объекта, если выбрано осеннее время года.
        /// </summary>
        public static Color AutumnColor = ColorTranslator.FromHtml("#e29c45");

        /// <summary>
        /// Цвет объекта, если выбрано весеннее время года.
        /// </summary>
        public static Color SpringColor = ColorTranslator.FromHtml("#559c45");
    }
}
