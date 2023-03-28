namespace Programming.Model.Classes
{
    public class Point2D
    {
        private double _x;
        private double _y;

        public double X
        {
            get
            {
                return _x;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value);
                _x = value;
            }
        }

        public double Y
        {
            get
            {
                return _y;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value);
                _y = value;
            }
        }

        public Point2D()
        {

        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}