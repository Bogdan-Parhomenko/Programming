using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Длительность фильма в минутах.
        /// </summary>
        private int _durationInMinutes;

        /// <summary>
        /// Год выпуска фильма.
        /// </summary>
        private int _year;

        /// <summary>
        /// Пользовательский оценка.
        /// </summary>
        private double _rate;

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает длительность фильма в минутах. Должна быть больше нуля.
        /// </summary>
        public int DurationInMinutes
        {
            get => _durationInMinutes;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _durationInMinutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает год выпуска фильма. Должен быть в пределах с 1900 года по текущий год.
        /// </summary>
        public int Year
        {
            get => _year;
            set
            {
                var currentYear = DateTime.Now.Year;
                Validator.AssertValueInRange(value, 1900, currentYear);
                _year = value;
            }
        }

        /// <summary>
        /// Возвращает и задает пользовательскую оценку. Должна быть в предесах от 0 до 10.
        /// </summary>
        public double Rate
        {
            get => _rate;
            set
            {
                Validator.AssertValueInRange(value, 0.0, 10.0);
                _rate = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/> без его инициализации.
        /// </summary>
        public Movie()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="title">Название фильма.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="durationInMinutes">Длительность фильма в минутах. Должна быть больше нуля.</param>
        /// <param name="year">Год выпуска фильма. Должен быть в пределах с 1900 года по текущий год.</param>
        /// <param name="rate">Пользовательская оценка. Должна быть в предесах от 0 до 10.</param>
        public Movie(string title, string genre, int durationInMinutes, int year, double rate)
        {
            Title = title;
            Genre = genre;
            DurationInMinutes = durationInMinutes;
            Year = year;
            Rate = rate;
        }
    }
}