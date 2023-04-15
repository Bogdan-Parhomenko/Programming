using Programming.Model.Classes;
using System;
using System.Windows.Forms;
using Genre = Programming.Model.Enums.Genre;

namespace Programming.View.Controls
{
    public partial class MoviesControl : UserControl
    {
        private Random _random = new Random();

        private Movie[] _movies = new Movie[5];

        private Movie _currentMovie;

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

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[MoviesListBox.SelectedIndex];
            TitleTextBox.Text = _currentMovie.Title;
            DurationInMinutesTextBox.Text = _currentMovie.DurationInMinutes.ToString();
            YearTextBox.Text = _currentMovie.Year.ToString();
            GenreTextBox.Text = _currentMovie.Genre;
            RateTextBox.Text = _currentMovie.Rate.ToString();
        }

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

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GenreTextBox.BackColor = AppColors.ValidationTrueColor;
                _currentMovie.Genre = (Enum.Parse(typeof(Genre), GenreTextBox.Text)).ToString();
            }
            catch
            {
                GenreTextBox.BackColor = AppColors.ValidationFalseColor;
            }
        }

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

        private void MovieButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRate();
        }
    }
}
