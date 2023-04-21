using System;
using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о кольце.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внешний радиус кольца.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Внутренний радиус кольца.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Возвращает и задает координаты X и Y центра кольца типа <see cref="Point2D"/>.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задает внешний радиус кольца. Должен быть больше нуля и больше внутреннего радиуса.
        /// </summary>
        public double OuterRadius
        {
            get => _outerRadius;
            set
            {
                Validator.AssertOnPositiveValue(value);
                if (value < _innerRadius)
                {
                    var message = "Значение внешнего радиуса не может быть" +
                                  " меньше значения внутреннего радиуса";
                    throw new ArgumentException(message);
                }
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает внутренний радиус кольца. Должен быть больше нуля и меньше внешнего радиуса.
        /// </summary>
        public double InnerRadius
        {
            get => _innerRadius;
            set
            {
                Validator.AssertOnPositiveValue(value);
                if (value > _outerRadius)
                {
                    var message = "Значение внутреннего радиуса не может быть" +
                                  " больше значения внешнего радиуса";
                    throw new ArgumentException(message);
                }
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get => Math.PI * (Math.Pow(_outerRadius, 2) - Math.Pow(_innerRadius, 2));
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"/> без его инициализации.
        /// </summary>
        public Ring()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="center">Координаты X и Y центра кольца типа <see cref="Point2D"/>.</param>
        /// <param name="outerRadius">Внешний радиус кольца. Должен быть больше нуля и больше внутреннего радиуса.</param>
        /// <param name="innerRadius">Внутренний радиус кольца. Должен быть больше нуля и меньше внешнего радиуса.</param>
        public Ring(Point2D center, double outerRadius, double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
        }
    }
}