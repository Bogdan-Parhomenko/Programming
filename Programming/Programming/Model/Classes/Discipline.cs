using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о дисциплине.
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// Год освоения дисциплины.
        /// </summary>
        private int _year;

        /// <summary>
        /// Количество освоенных часов.
        /// </summary>
        private int _hoursCount;

        /// <summary>
        /// Полученная оценка.
        /// </summary>
        private int _grade;

        /// <summary>
        /// ВОзвращает и задает наименование дисциплины.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает год освоения дисциплины. Должен быть в пределах с 1900 года по текущий год.
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
        /// Возвращает и задает количество освоенных часов. Должно быть больше нуля.
        /// </summary>
        public int HoursCount
        {
            get => _hoursCount;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _hoursCount = value;
            }
        }

        /// <summary>
        /// Возвращает и задает полученную оценку. Должна быть больше нуля.
        /// </summary>
        public int Grade
        { 
            get => _grade;
            set
            {
                Validator.AssertValueInRange(value, 1, 5);
                _grade = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Discipline"/> без его инициализации.
        /// </summary>
        public Discipline()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        /// <param name="name">Наименование дисциплины.</param>
        /// <param name="year">Год освоения дисциплины. Должен быть в пределах с 1900 года по текущий год.</param>
        /// <param name="hoursCount">Количество освоенных часов. Должно быть больше нуля.</param>
        /// <param name="grade">Полученная оценка. Должна быть больше нуля.</param>
        public Discipline(string name, int year, int hoursCount, int grade)
        {
            Name = name;
            Year = year;
            HoursCount = hoursCount;
            Grade = grade;
        }
    }
}