using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Classes;
using Color = Programming.Model.Enums.Color;
using EducationForm = Programming.Model.Enums.EducationForm;
using Genre = Programming.Model.Enums.Genre;
using Manufactures = Programming.Model.Enums.Manufactures;
using Season = Programming.Model.Enums.Season;
using Weekday = Programming.Model.Enums.Weekday;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private Random _random = new Random();

        // Создаем массива и переменной класса Rectangle
        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle;

        // Создаем массива и переменной класса Movie
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Добавление значений в Listbox и ComboBox
            var enums = new object[]
            {
                typeof(Color),
                typeof(EducationForm),
                typeof(Genre),
                typeof(Manufactures),
                typeof(Season),
                typeof(Weekday)
            };
            //EnumsListBox.DisplayMember = "enums";
            EnumsListBox.DataSource = enums;
            SeasonHandleComboBox.DataSource = Enum.GetValues(typeof(Season));

            // Инициализация массива _rectangles
            for (var i = 0; i < 5; i++)
            {
                _rectangles[i] = new Rectangle(_random.NextDouble() * 101,
                    _random.NextDouble() * 101,
                    Enum.GetNames(typeof(Color))[_random.Next(8)]);
                RectanglesListBox.Items.Add($"Rectangle {i+1}");
            }

            // Инициализация массива _movies
            for (var i = 0; i < 5; i++)
            {
                _movies[i] = new Movie($"Movie { i + 1 }",
                    Enum.GetNames(typeof(Genre))[_random.Next(6)],
                    _random.Next(301),
                    _random.Next(1900, DateTime.Now.Year),
                    _random.Next(11));
                MoviesListBox.Items.Add($"Movie {i + 1}");
            }
        }

        // При обновлении значения в EnumListBox обновляем значение в ValueListBox
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.DataSource = Enum.GetValues(Type.GetType(EnumsListBox.Text));
        }

        // При обновлении значения в ValueListBox выводим номер этого значения в ValueTextBox
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueTextBox.Text = ((int)Enum.Parse(Type.GetType(EnumsListBox.Text), ValuesListBox.Text)).ToString();
        }

        // Вводим текст и выводим день недели с его номером при совпадении
        private void WeekdayParsingButton_Click(object sender, EventArgs e)
        {
            if(Enum.IsDefined(typeof(Weekday), WeekdayParsingTextBox.Text))
            {
                var weekDayNumber = (int)Enum.Parse(typeof(Weekday),WeekdayParsingTextBox.Text);
                WeekdayAnswerLable.Text = $"Это день недели ( {WeekdayParsingTextBox.Text} = {weekDayNumber} )";
            }
            else
            {
                WeekdayAnswerLable.Text = "Нет такого дня недели";
            }
        }

        // В зависимости от выбранного времени года выполняем определенное действие
        private void SeasonHandleButton_Click(object sender, EventArgs e)
        {
            switch (SeasonHandleComboBox.Text)
            {
                case "Summer":
                {
                    MessageBox.Show("Ура! Солнце!", "Лето");
                    break;
                }
                case "Autumn":
                {
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    TabControl.BackColor = BackColor;
                    break;
                }
                case "Winter":
                {
                    MessageBox.Show("Бррр! Холодно!", "Зима");
                    break;
                }
                case "Spring":
                {
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    TabControl.BackColor = BackColor;
                    break;
                }
                default:
                {
                    MessageBox.Show("Нет такого времени года");
                    break;
                }
            }
        }

        // При обновлении значения RectanglesListBox запоминаем выбранный Rectangle в _currentRectangle
        // и заполняем Принадлежащие ему TextBox
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
        }

        // При обновлении значения MoviesListBox запоминаем выбранный Movie в _currentMovie
        // и заполняем Принадлежащие ему TextBox
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[MoviesListBox.SelectedIndex];
            TitleTextBox.Text = _currentMovie.Title;
            DurationInMinutesTextBox.Text = _currentMovie.DurationInMinutes.ToString();
            YearTextBox.Text = _currentMovie.Year.ToString();
            GenreTextBox.Text = _currentMovie.Genre;
            RateTextBox.Text = _currentMovie.Rate.ToString();
        }

        // При изменении значения в LengthTextBox проверяем верность введенных данных
        // и обновляем данные массива Rectangles[]
        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LengthTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Length = Double.Parse(LengthTextBox.Text);
            }
            catch
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        // При изменении значения в WidthTextBox проверяем верность введенных данных
        // и обновляем данные массива Rectangles[]
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WidthTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Width = Double.Parse(WidthTextBox.Text);
            }
            catch
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        // При изменении значения в ColorTextBox проверяем верность введенных данных
        // и обновляем данные массива Rectangles[]
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ColorTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Color = (Enum.Parse(typeof(Color), ColorTextBox.Text)).ToString();
            }
            catch
            {
                ColorTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        // При изменении значения в TitleTextBox проверяем верность введенных данных
        // и обновляем данные массива Movies[]
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TitleTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Title = TitleTextBox.Text;
            }
            catch
            {
                TitleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        // При изменении значения в DurationInMinutesTextBox проверяем верность введенных данных
        // и обновляем данные массива Movies[]
        private void DurationInMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DurationInMinutesTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.DurationInMinutes = Int32.Parse(DurationInMinutesTextBox.Text);
            }
            catch
            {
                DurationInMinutesTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        // При изменении значения в YearTextBox проверяем верность введенных данных
        // и обновляем данные массива Movies[]
        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                YearTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Year = Int32.Parse(YearTextBox.Text);
            }
            catch
            {
                YearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        // При изменении значения в GenreTextBox проверяем верность введенных данных
        // и обновляем данные массива Movies[]
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GenreTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Genre = (Enum.Parse(typeof(Genre), GenreTextBox.Text)).ToString();
            }
            catch
            {
                GenreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        // При изменении значения в RateTextBox проверяем верность введенных данных
        // и обновляем данные массива Movies[]
        private void RateTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RateTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Rate = Double.Parse(RateTextBox.Text);
            }
            catch
            {
                RateTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        // Метод, который находит Rectangle с максимальной шириной и возвращает его индекс
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

        // Метод, который находит Movie с максимальным рейтингом и возвращает его индекс
        private int FindMovieWithMaxRate()
        {
            var maxRate = _movies[0].Rate;
            var i = 0;
            var maxRateMovie = 0;
            foreach (var movie in _movies)
            {
                if (movie.Rate > maxRate)
                {
                    maxRate = movie.Rate;
                    maxRateMovie = i;
                }
                i++;
            }
            return maxRateMovie;
        }

        // Находим Rectangle с максимальной шириной и выделяем его в ListBox
        private void RectangleButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
        }

        // Находим Movie с максимальным рейтингом и выделяем его в ListBox
        private void MovieButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRate();
        }
    }
}