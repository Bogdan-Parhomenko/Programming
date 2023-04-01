using System;

namespace Programming.Model.Classes
{
    public class Ring
    {
        private double _outerRadius;
        private double _innerRadius;
        private double _area;

        public Point2D Center { get; set; }

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

        public double Area
        {
            get
            {
                _area = Math.PI * (Math.Pow(_outerRadius, 2) - Math.Pow(_innerRadius, 2));
                return _area;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value);
                _area = value;
            }
        }

        public Ring()
        {

        }

        public Ring(Point2D center, double outerRadius, double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
        }
    }
}