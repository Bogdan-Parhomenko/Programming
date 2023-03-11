using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    internal class Discipline
    {
        private string _name;
        private int _year;
        private int _hoursCount;
        private int _grade;

        public string Name { get; set; }
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
        public int HoursCount
        {
            get
            {
                return _hoursCount;
            }
            set
            {
                if(value > 0)
                {
                    _hoursCount = value;
                }
                else
                {
                    throw new ArgumentException("Количество освоенных часов должно быть больше 0");
                }
            }
        }
        public int Grade
        { 
            get
            {
                return _grade;
            }
            set
            {
                if (value >= 1 && value <= 5)
                {
                    _grade = value;
                }
                else
                {
                    throw new ArgumentException("Оценка должна быть в пределе значений от 1 до 5");
                }
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