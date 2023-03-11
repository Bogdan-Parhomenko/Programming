using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (value >= 0 && value <= 23)
                {
                    _hours = value;
                }
                else
                {
                    throw new ArgumentException("Количество часов не может быть отрицательным и больше 23");
                }
            }
        }
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    _minutes = value;
                }
                else
                {
                    throw new ArgumentException("Количество минут не может быть отрицательным и больше 59");
                }
            }
        }
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    _seconds = value;
                }
                else
                {
                    throw new ArgumentException("Количество секунд не может быть отрицательным и больше 59");
                }
            }
        }
    }
}