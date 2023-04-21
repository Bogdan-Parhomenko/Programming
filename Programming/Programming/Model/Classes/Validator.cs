using System;
using System.Runtime.CompilerServices;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Служебный класс, который хранит методы проверки правильности вводимых данных.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что целочисленное значение больше нуля.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Имя свойства, вызвавшего данный метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если вводимое значение меньше или равно нулю.</exception>
        public static void AssertOnPositiveValue(int value, [CallerMemberName] string propertyName = "")
        {
            if (value <= 0)
            {
                throw new ArgumentException($"В свойство {propertyName}" +
                                            $" нельзя присвоить отрицательное значение");
            }
        }

        /// <summary>
        /// Проверяет, что вещественное значение больше нуля.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Имя свойства, вызвавшего данный метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если вводимое значение меньше или равно нулю.</exception>
        public static void AssertOnPositiveValue(double value, [CallerMemberName] string propertyName = "")
        {
            if (value <= 0.0)
            {
                throw new ArgumentException($"В свойство {propertyName}" +
                                            $" нельзя присвоить отрицательное значение");
            }
        }

        /// <summary>
        /// Проверяет, что целочисленное значение находится в заданном целочисленном пределе.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное допустимое значение.</param>
        /// <param name="max">Максимальное допустимое значение.</param>
        /// <param name="propertyName">Имя свойства, вызвавшего данный метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если вводимое значение не находится в заданном пределе.</exception>
        public static void AssertValueInRange(int value, int min, int max, [CallerMemberName] string propertyName = "")
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"В свойство {propertyName}" +
                                            $" нельзя присвоить значение которое меньше {min} или больше {max}");
            }
        }

        /// <summary>
        /// Проверяет, что вещественное значение находится в заданном вещественном пределе.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="propertyName">Имя свойства, вызвавшего данный метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если вводимое значение не находится в заданном пределе.</exception>
        public static void AssertValueInRange(double value, double min, double max, [CallerMemberName] string propertyName = "")
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"В свойство {propertyName}" +
                                            $" нельзя присвоить значение которое меньше {min} или больше {max}");
            }
        }
    }
}
