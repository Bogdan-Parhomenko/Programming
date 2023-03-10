using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Movie
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
                if (value > 0)
                {
                    _durationInMinutes = value;
                }
                else
                {
                    throw new ArgumentException("Продолжительность фильма должна быть больше 0 минут");
                }
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
                int currentYear = DateTime.Now.Year;

                if (value >= 1900 && value <= currentYear)
                {
                    _year = value;
                }
                else
                {
                    throw new ArgumentException($"Укажите значение от 1900 до {currentYear}");
                }
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
                if( value > 0 && value <= 10)
                {
                    _rate = value;
                }
                else
                {
                    throw new ArgumentException("Рейтинг должен быть от 0 до 10");
                }
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