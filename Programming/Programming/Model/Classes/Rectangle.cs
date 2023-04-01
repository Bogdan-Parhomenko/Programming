namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _length;
        private double _width;

        public double Length
        {
            get => _length;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _length = value;
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

        public string Color { get; set; }

        public Point2D Center { get; set; }

        public static int AllRectanglesCount { get; private set; }

        public int Id { get; private set; }

        public Rectangle()
        {
            AllRectanglesCount++;
        }

        public Rectangle(double length, double width, string color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            AllRectanglesCount++;
            Id = AllRectanglesCount;
        }
    }
}