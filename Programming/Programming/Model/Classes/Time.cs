namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит количество времени.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Количество часов.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Количество минут.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Количество секунд.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задает количество часов. Должно быть в пределах от 0 до 23.
        /// </summary>
        public int Hours
        {
            get => _hours;
            set
            {
                Validator.AssertValueInRange(value, 0, 23);
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задает количество минут. Должно быть в пределах от 0 до 59.
        /// </summary>
        public int Minutes
        {
            get => _minutes;
            set
            {
                Validator.AssertValueInRange(value, 0, 59);
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает количество секунд. Должно быть в пределах от 0 до 59.
        /// </summary>
        public int Seconds
        {
            get => _seconds;
            set
            {
                Validator.AssertValueInRange(value, 0, 59);
                _seconds = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/> без его инициализации.
        /// </summary>
        public Time()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">Количество часов. Должно быть в пределах от 0 до 23.</param>
        /// <param name="minutes">Количество минут. Должно быть в пределах от 0 до 59.</param>
        /// <param name="seconds">Количество секунд. Должно быть в пределах от 0 до 59.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}