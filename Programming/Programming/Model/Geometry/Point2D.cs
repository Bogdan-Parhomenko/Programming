using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данный о точке центра.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата оси OX.
        /// </summary>
        private double _x;

        /// <summary>
        /// Координата оси OY.
        /// </summary>
        private double _y;

        /// <summary>
        /// Возвращает и задает координату оси OX. Должна быть больше нуля.
        /// </summary>
        public double X
        {
            get => _x;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координату оси OY. Должна быть больше нуля.
        /// </summary>
        public double Y
        {
            get => _y;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _y = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/> без его инициализации.
        /// </summary>
        public Point2D()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата оси OX. Должна быть больше нуля.</param>
        /// <param name="y">Координата оси OY. Должна быть больше нуля.</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}