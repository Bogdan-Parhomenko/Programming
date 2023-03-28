using System;

namespace Programming.Model.Classes
{
    public class Ring
    {
        private Point2D _center;
        private double _outerRadius;
        private double _innerRadius;
        private double _area;

        public Point2D Center { get; set; }

        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                if (value < _innerRadius)
                {
                    throw new ArgumentException("Значение внешнего радиуса не может быть меньше значения внутреннего радиуса");
                }
                _outerRadius = value;
            }
        }

        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                if (value > _outerRadius)
                {
                    throw new ArgumentException("Значение внутреннего радиуса не может быть больше значения внешнего радиуса");
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