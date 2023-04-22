using Programming.Model.Classes;
using System;
using System.Windows.Forms;
using Color = Programming.Model.Enums.Color;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View.Controls
{
    /// <summary>
    /// Содержит логику выбора прямоугольников вкладки Classes.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Экземпляр класса Random, необходимый для доступа к методам этого класса.
        /// </summary>
        private Random _random = new Random();

        /// <summary>
        /// Массив из 5 экземпляров класса Rectangle.
        /// </summary>
        private Rectangle[] _rectangles = new Rectangle[5];

        /// <summary>
        /// Экземпляр класса Rectangle.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Создает объект типа <see cref="RectanglesControl"/>.
        /// Инициализирует список фильмов дефолтными значениями.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();

            for (var i = 0; i < 5; i++)
            {
                _rectangles[i] = new Rectangle(
                    _random.Next(1, 301),
                    _random.Next(1, 301),
                    _random.Next(1, 401),
                    _random.Next(1, 401),
                    Enum.GetNames(typeof(Color))[_random.Next(8)]);
                RectanglesListBox.Items.Add($"Rectangle {_rectangles[i].Id}");
            }
        }

        /// <summary>
        /// Находит экземпляр класса Rectangle с самым высоким значением ширины.
        /// </summary>
        /// <returns>Возвращает индекс экземпляра.</returns>
        private int FindRectangleWithMaxWidth()
        {
            var maxWidth = _rectangles[0].Width;
            var i = 0;
            var maxWidthRectangle = 0;
            foreach (var rectangle in _rectangles)
            {
                if (rectangle.Width > maxWidth)
                {
                    maxWidth = rectangle.Width;
                    maxWidthRectangle = i;
                }
                i++;
            }
            return maxWidthRectangle;
        }

        /// <summary>
        /// При изменении индекса выбранного элемента RectanglesListBox
        /// присваивает _currentRectangle выбранный элемент
        /// и заполняет все текстовые поля значениями _currentRectangles.
        /// </summary>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            HeightTextBox.Text = _currentRectangle.Height.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            XCenterTextBox.Text = _currentRectangle.Center.X.ToString();
            YCenterTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        /// <summary>
        /// При изменении текста HeightTextBox пытается присвоить этот текст в свойство Height элемента
        /// _currentRectangle и красит HeightTextBox в соответствии с валидацией.
        /// </summary>
        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HeightTextBox.BackColor = AppColors.ValidationTrueColor;
                _currentRectangle.Height = Double.Parse(HeightTextBox.Text);
            }
            catch
            {
                HeightTextBox.BackColor = AppColors.ValidationFalseColor;
            }
        }

        /// <summary>
        /// При изменении текста WidthTextBox пытается присвоить этот текст в свойство Width элемента
        /// _currentRectangle и красит WidthTextBox в соответствии с валидацией.
        /// </summary>
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WidthTextBox.BackColor = AppColors.ValidationTrueColor;
                _currentRectangle.Width = Double.Parse(WidthTextBox.Text);
            }
            catch
            {
                WidthTextBox.BackColor = AppColors.ValidationFalseColor;
            }
        }

        /// <summary>
        /// При изменении текста ColorTextBox пытается присвоить этот текст в свойство Color элемента
        /// _currentRectangle и красит ColorTextBox в соответствии с валидацией.
        /// </summary>
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ColorTextBox.BackColor = AppColors.ValidationTrueColor;
                _currentRectangle.Color = (Enum.Parse(typeof(Color), ColorTextBox.Text)).ToString();
            }
            catch
            {
                ColorTextBox.BackColor = AppColors.ValidationFalseColor;
            }
        }

        /// <summary>
        /// При нажатии на RectangleButton выбирает элемент в RectanglesListBox
        /// у которого наибольшее значение ширины.
        /// </summary>
        private void RectangleButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
        }
    }
}
