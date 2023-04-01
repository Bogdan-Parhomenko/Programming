using System;

namespace Programming.Model.Classes
{
    public class Discipline
    {
        private int _year;
        private int _hoursCount;
        private int _grade;

        public string Name { get; set; }

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

        public int HoursCount
        {
            get => _hoursCount;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _hoursCount = value;
            }
        }

        public int Grade
        { 
            get => _grade;
            set
            {
                Validator.AssertValueInRange(value, 1, 5);
                _grade = value;
            }
        }

        public Discipline()
        {

        }

        public Discipline(string name, int year, int hoursCount, int grade)
        {
            Name = name;
            Year = year;
            HoursCount = hoursCount;
            Grade = grade;
        }
    }
}