using Programming.Model.Classes;
using System;
using System.Windows.Forms;
using Genre = Programming.Model.Enums.Genre;

namespace Programming.View.Controls
{
    /// <summary>
    /// Содержит логику выбора фильмов вкладки Classes.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Экземпляр класса Random, необходимый для доступа к методам этого класса.
        /// </summary>
        private Random _random = new Random();

        /// <summary>
        /// Массив из 5 экземпляров класса Movie.
        /// </summary>
        private Movie[] _movies = new Movie[5];

        /// <summary>
        /// Экземпляр класса Movie.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Создает объект типа <see cref="MoviesControl"/>.
        /// Инициализирует массив фильмов дефолтными значениями и заполняет ими MoviesListBox.
        /// </summary>
        public MoviesControl()
        {
            InitializeComponent();

            for (var i = 0; i < 5; i++)
            {
                _movies[i] = new Movie($"Movie {i + 1}",
                    Enum.GetNames(typeof(Genre))[_random.Next(6)],
                    _random.Next(1, 201),
                    _random.Next(1900, DateTime.Now.Year),
                    _random.Next(1, 11));
                MoviesListBox.Items.Add($"Movie {i + 1}");
            }
        }

        /// <summary>
        /// Находит экземпляр класса Movie с самой высокой пользовательской оценкой.
        /// </summary>
        /// <returns>Возвращает индекс экземпляра.</returns>
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

        /// <summary>
        /// При изменении индекса выбранного элемента MoviesListBox
        /// присваивает _currentMovie выбранный элемент
        /// и заполняет все текстовые поля значениями _currentMovie.
        /// </summary>
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[MoviesListBox.SelectedIndex];
            TitleTextBox.Text = _currentMovie.Title;
            DurationInMinutesTextBox.Text = _currentMovie.DurationInMinutes.ToString();
            YearTextBox.Text = _currentMovie.Year.ToString();
            GenreTextBox.Text = _currentMovie.Genre;
            RateTextBox.Text = _currentMovie.Rate.ToString();
        }

        /// <summary>
        /// При изменении текста TitleTextBox пытается присвоить этот текст в свойство Title элемента
        /// _currentMovie и красит TitleTextBox в соответствии с валидацией.
        /// </summary>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TitleTextBox.BackColor = AppColors.ValidationTrueColor;
                _currentMovie.Title = TitleTextBox.Text;
            }
            catch
            {
                TitleTextBox.BackColor = AppColors.ValidationFalseColor;
            }
        }

        /// <summary>
        /// При изменении текста DurationInMinutesTextBox пытается присвоить этот текст в свойство DurationInMinutes элемента
        /// _currentMovie и красит DurationInMinutesTextBox в соответствии с валидацией.
        /// </summary>
        private void DurationInMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DurationInMinutesTextBox.BackColor = AppColors.ValidationTrueColor;
                _currentMovie.DurationInMinutes = Int32.Parse(DurationInMinutesTextBox.Text);
            }
            catch
            {
                DurationInMinutesTextBox.BackColor = AppColors.ValidationFalseColor;
            }
        }

        /// <summary>
        /// При изменении текста YearTextBox пытается присвоить этот текст в свойство Year элемента
        /// _currentMovie и красит YearTextBox в соответствии с валидацией.
        /// </summary>
        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                YearTextBox.BackColor = AppColors.ValidationTrueColor;
                _currentMovie.Year = Int32.Parse(YearTextBox.Text);
            }
            catch
            {
                YearTextBox.BackColor = AppColors.ValidationFalseColor;
            }
        }

        /// <summary>
        /// При изменении текста GenreTextBox пытается присвоить этот текст в свойство Genre элемента
        /// _currentMovie и красит GenreTextBox в соответствии с валидацией.
        /// </summary>
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GenreTextBox.BackColor = AppColors.ValidationTrueColor;
                _currentMovie.Genre = Enum.Parse(typeof(Genre), GenreTextBox.Text).ToString();
            }
            catch
            {
                GenreTextBox.BackColor = AppColors.ValidationFalseColor;
            }
        }

        /// <summary>
        /// При изменении текста RateTextBox пытается присвоить этот текст в свойство Rate элемента
        /// _currentMovie и красит RateTextBox в соответствии с валидацией.
        /// </summary>
        private void RateTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RateTextBox.BackColor = AppColors.ValidationTrueColor;
                _currentMovie.Rate = Double.Parse(RateTextBox.Text);
            }
            catch
            {
                RateTextBox.BackColor = AppColors.ValidationFalseColor;
            }
        }

        /// <summary>
        /// При нажатии на MovieButton выбирает элемент в MoviesListBox
        /// у которого наибольшая пользовательская оценка.
        /// </summary>
        private void MovieButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRate();
        }
    }
}
