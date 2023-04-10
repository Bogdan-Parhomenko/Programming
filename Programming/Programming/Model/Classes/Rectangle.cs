using System.ComponentModel;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _height;
        private double _width;
        private double _x;
        private double _y;

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

        public Point2D Center { get; set; }

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
        }

        public Rectangle(double height, double width, double x, double y, string color, Point2D center)
        {
            Height = height;
            Width = width;
            X = x;
            Y = y;
            Color = color;
            Center = center;
            AllRectanglesCount++;
            Id = AllRectanglesCount;
        }
    }
}