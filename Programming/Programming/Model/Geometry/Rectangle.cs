using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Высота прямоугольника.
        /// </summary>
        private double _height;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private double _width;

        /// <summary>
        /// Координата X левого верхнего угла.
        /// </summary>
        private double _x;

        /// <summary>
        /// Координата Y левого верхнего угла.
        /// </summary>
        private double _y;

        /// <summary>
        /// Возвращает и задает высоту прямоугольника. Должна быть больше нуля.
        /// </summary>
        public double Height
        {
            get => _height;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _height = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ширину прямоугольника. Должна быть больше нуля.
        /// </summary>
        public double Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _width = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координату X левого верхнего угла. Должна быть больше нуля.
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
        /// Возвращает и задает координату Y левого верхнего угла. Должна быть больше нуля.
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
        /// Возвращает и задает цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает координаты X и Y центра прямоугольника типа <see cref="Point2D"/>.
        /// </summary>
        public Point2D Center
        {
            get => new Point2D(X + Width/2.0, Y + Height/2.0);
        }

        /// <summary>
        /// Возвращает количество созданных прямоугольников данного класса.
        /// </summary>
        public static int AllRectanglesCount { get; private set; }

        /// <summary>
        /// Возвращает уникальный идентификатор для всех прямоугольников данного класса.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает строку, отражающую характеристики прямоугольника.
        /// </summary>
        public string Info
        {
            get
            {
                return $"{Id}: (X = {X}; Y = {Y}; W = {(int)Width}; H = {(int)Height})";
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/> без его инициализации.
        /// </summary>
        public Rectangle()
        {
            AllRectanglesCount++;
            Id = AllRectanglesCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="height">Высота прямоугольника. Должна быть больше нуля.</param>
        /// <param name="width">Ширина прямоугольника. Должна быть больше нуля.</param>
        /// <param name="x">Координату X левого верхнего угла. Должна быть больше нуля.</param>
        /// <param name="y">Координату Y левого верхнего угла. Должна быть больше нуля.</param>
        /// <param name="color">Цвет прямоугольника.</param>
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