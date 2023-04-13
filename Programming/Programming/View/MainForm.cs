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
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        // Создание переменной _random
        private Random _random = new Random();

        // Создаем массива и переменной класса Rectangle
        private Rectangle[] _classesRectangles = new Rectangle[5];
        private Rectangle _currentClassesRectangle;

        // Создаем массива и переменной класса Movie
        private Movie[] _classesMovies = new Movie[5];
        private Movie _currentClassesMovie;

        // Метод, который находит Rectangle с максимальной шириной и возвращает его индекс
        private int FindRectangleWithMaxWidth()
        {
            var maxWidth = _classesRectangles[0].Width;
            var i = 0;
            var maxWidthRectangle = 0;
            foreach (var rectangle in _classesRectangles)
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
            var maxRate = _classesMovies[0].Rate;
            var i = 0;
            var maxRateMovie = 0;
            foreach (var movie in _classesMovies)
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

            // Заполнение EnumListBox и SeasonHandleComboBox элементами
            EnumsEnumsListBox.DataSource = enums;
            EnumsEnumsListBox.SelectedIndex = 0;
            EnumsSeasonHandleComboBox.DataSource = Enum.GetValues(typeof(Season));

            // Инициализация массива _rectangles
            for (var i = 0; i < 5; i++)
            {
                _classesRectangles[i] = new Rectangle(_random.Next(1, 301),
                    _random.Next(1, 301),
                    _random.Next(1, 401),
                    _random.Next(1, 401),
                    Enum.GetNames(typeof(Color))[_random.Next(8)]);
                ClassesRectanglesListBox.Items.Add($"Rectangle {_classesRectangles[i].Id}");
            }

            // Инициализация массива _classesMovies
            for (var i = 0; i < 5; i++)
            {
                _classesMovies[i] = new Movie($"Movie { i + 1 }",
                    Enum.GetNames(typeof(Genre))[_random.Next(6)],
                    _random.Next(1, 301),
                    _random.Next(1900, DateTime.Now.Year),
                    _random.Next(1, 11));
                ClassesMoviesListBox.Items.Add($"Movie {i + 1}");
            }
        }

        // При обновлении значения в EnumListBox обновляем значение в ValueListBox
        private void EnumsEnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnumsValuesListBox.DataSource = Enum.GetValues(Type.GetType(EnumsEnumsListBox.Text));
            EnumsValuesListBox.SelectedIndex = 0;
        }

        // При обновлении значения в ValueListBox выводим номер этого значения в ValueTextBox
        private void EnumsValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnumsIntValueTextBox.Text = ((int)Enum.Parse(Type.GetType(EnumsEnumsListBox.Text), EnumsValuesListBox.Text)).ToString();
        }

        // Вводим текст и выводим день недели с его номером при совпадении
        private void EnumsWeekdayParsingButton_Click(object sender, EventArgs e)
        {
            if(Enum.IsDefined(typeof(Weekday), EnumsWeekdayParsingTextBox.Text))
            {
                var weekDayNumber = (int)Enum.Parse(typeof(Weekday),EnumsWeekdayParsingTextBox.Text);
                EnumsWeekdayAnswerLable.Text = $"Это день недели ( {EnumsWeekdayParsingTextBox.Text} = {weekDayNumber} )";
            }
            else
            {
                EnumsWeekdayAnswerLable.Text = "Нет такого дня недели";
            }
        }

        // В зависимости от выбранного времени года выполняем определенное действие
        private void EnumsSeasonHandleButton_Click(object sender, EventArgs e)
        {
            switch (EnumsSeasonHandleComboBox.Text)
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
        private void CLassesRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentClassesRectangle = _classesRectangles[ClassesRectanglesListBox.SelectedIndex];
            ClassesHeightTextBox.Text = _currentClassesRectangle.Height.ToString();
            ClassesWidthTextBox.Text = _currentClassesRectangle.Width.ToString();
            ClassesColorTextBox.Text = _currentClassesRectangle.Color;
            ClassesXCenterTextBox.Text = _currentClassesRectangle.Center.X.ToString();
            ClassesYCenterTextBox.Text = _currentClassesRectangle.Center.Y.ToString();
            ClassesIdTextBox.Text = _currentClassesRectangle.Id.ToString();
        }

        // При обновлении значения MoviesListBox запоминаем выбранный Movie в _currentClassesMovie
        // и заполняем Принадлежащие ему TextBox
        private void ClassesMoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentClassesMovie = _classesMovies[ClassesMoviesListBox.SelectedIndex];
            ClassesTitleTextBox.Text = _currentClassesMovie.Title;
            ClassesDurationInMinutesTextBox.Text = _currentClassesMovie.DurationInMinutes.ToString();
            ClassesYearTextBox.Text = _currentClassesMovie.Year.ToString();
            ClassesGenreTextBox.Text = _currentClassesMovie.Genre;
            ClassesRateTextBox.Text = _currentClassesMovie.Rate.ToString();
        }

        // При изменении значения в LengthTextBox проверяем верность введенных данных
        // и обновляем данные массива Rectangles[]
        private void ClassesHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClassesHeightTextBox.BackColor = System.Drawing.Color.White;
                _currentClassesRectangle.Height = Double.Parse(ClassesHeightTextBox.Text);
            }
            catch
            {
                ClassesHeightTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        // При изменении значения в WidthTextBox проверяем верность введенных данных
        // и обновляем данные массива Rectangles[]
        private void ClassesWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClassesWidthTextBox.BackColor = System.Drawing.Color.White;
                _currentClassesRectangle.Width = Double.Parse(ClassesWidthTextBox.Text);
            }
            catch
            {
                ClassesWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        // При изменении значения в ColorTextBox проверяем верность введенных данных
        // и обновляем данные массива Rectangles[]
        private void ClassesColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClassesColorTextBox.BackColor = System.Drawing.Color.White;
                _currentClassesRectangle.Color = (Enum.Parse(typeof(Color), ClassesColorTextBox.Text)).ToString();
            }
            catch
            {
                ClassesColorTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        // При изменении значения в TitleTextBox проверяем верность введенных данных
        // и обновляем данные массива Movies[]
        private void ClassesTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClassesTitleTextBox.BackColor = System.Drawing.Color.White;
                _currentClassesMovie.Title = ClassesTitleTextBox.Text;
            }
            catch
            {
                ClassesTitleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        // При изменении значения в DurationInMinutesTextBox проверяем верность введенных данных
        // и обновляем данные массива Movies[]
        private void ClassesDurationInMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClassesDurationInMinutesTextBox.BackColor = System.Drawing.Color.White;
                _currentClassesMovie.DurationInMinutes = Int32.Parse(ClassesDurationInMinutesTextBox.Text);
            }
            catch
            {
                ClassesDurationInMinutesTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        // При изменении значения в YearTextBox проверяем верность введенных данных
        // и обновляем данные массива Movies[]
        private void ClassesYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClassesYearTextBox.BackColor = System.Drawing.Color.White;
                _currentClassesMovie.Year = Int32.Parse(ClassesYearTextBox.Text);
            }
            catch
            {
                ClassesYearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        // При изменении значения в GenreTextBox проверяем верность введенных данных
        // и обновляем данные массива Movies[]
        private void ClassesGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClassesGenreTextBox.BackColor = System.Drawing.Color.White;
                _currentClassesMovie.Genre = (Enum.Parse(typeof(Genre), ClassesGenreTextBox.Text)).ToString();
            }
            catch
            {
                ClassesGenreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        // При изменении значения в RateTextBox проверяем верность введенных данных
        // и обновляем данные массива Movies[]
        private void ClassesRateTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClassesRateTextBox.BackColor = System.Drawing.Color.White;
                _currentClassesMovie.Rate = Double.Parse(ClassesRateTextBox.Text);
            }
            catch
            {
                ClassesRateTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        // Находим Rectangle с максимальной шириной и выделяем его в ListBox
        private void ClassesRectangleButton_Click(object sender, EventArgs e)
        {
            ClassesRectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
        }

        // Находим Movie с максимальным рейтингом и выделяем его в ListBox
        private void ClassesMovieButton_Click(object sender, EventArgs e)
        {
            ClassesMoviesListBox.SelectedIndex = FindMovieWithMaxRate();
        }
    }
}