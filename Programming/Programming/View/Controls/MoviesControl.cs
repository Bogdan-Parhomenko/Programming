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
                    _random.Next(1, 301),
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
                TitleTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Title = TitleTextBox.Text;
            }
            catch
            {
                TitleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

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

        private void MovieButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRate();
        }
    }
}
