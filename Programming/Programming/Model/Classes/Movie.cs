using System;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private string _title;
        private string _genre;
        private int _durationInMinutes;
        private int _year;
        private double _rate;

        public string Title { get; set; }
        public string Genre { get; set; }
        public int DurationInMinutes
        {
            get
            {
                return _durationInMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _durationInMinutes = value;
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                var currentYear = DateTime.Now.Year;
                Validator.AssertValueInRange(value, 1900, currentYear);
                _year = value;
            }
        }
        public double Rate
        {
            get
            {
                return _rate;
            }
            set
            {
                Validator.AssertValueInRange(value, 0.0, 10.0);
                _rate = value;
            }
        }

        public Movie()
        {

        }

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