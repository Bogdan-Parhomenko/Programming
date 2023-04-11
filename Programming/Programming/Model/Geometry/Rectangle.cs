using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    public class Rectangle
    {
        private double _height;
        private double _width;
        private double _x;
        private double _y;
        private Point2D _center;

        public double Height
        {
            get => _height;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _height = value;
            }
        }

        public double Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _width = value;
            }
        }

        public double X
        {
            get => _x;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _x = value;
            }
        }

        public double Y
        {
            get => _y;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _y = value;
            }
        }

        public string Color { get; set; }

        public Point2D Center
        {
            get => new Point2D(X + Width/2.0, Y + Height/2.0);
        }

        public static int AllRectanglesCount { get; private set; }

        public int Id { get; }

        public string Info
        {
            get
            {
                return $"{Id}: (X = {X}; Y = {Y}; W = {(int)Width}; H = {(int)Height})";
            }
        }

        public Rectangle()
        {
            AllRectanglesCount++;
            Id = AllRectanglesCount;
        }

        public Rectangle(double height, double width, double x, double y, string color)
        {
            Height = height;
            Width = width;
            X = x;
            Y = y;
            Color = color;
            AllRectanglesCount++;
            Id = AllRectanglesCount;
        }
    }
}