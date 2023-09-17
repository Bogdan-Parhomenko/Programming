using System;
using System.Runtime.CompilerServices;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Служебный класс, который хранит методы проверки правильности вводимых данных.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет, что строка не превышает заданной длинны.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">максимально допустимая длинна.</param>
        /// <param name="propertyName">Имя свойства, вызвавшего данный метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если вводимая строка длиннее максимально допустимой длинны.</exception>
        public static void AssertStringOnLength(string value, int maxLength, [CallerMemberName] string propertyName = "")
        {
            if (value == null)
            {
                return;
            }
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} не может содержать больше {maxLength} символов.");
            }
        }

        /// <summary>
        /// Проверяет, что вещественное значение находится в заданном вещественном пределе.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное допустимое вещественное значение.</param>
        /// <param name="max">Максимальное допустимое вещественное значение.</param>
        /// <param name="propertyName">Имя свойства, вызвавшего данный метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если вводимое значение не находится в заданном пределе.</exception>
        public static void AssertValueInRange(double value,double min, double max, [CallerMemberName] string propertyName = "")
        {
            if (value < min || value >= max)
            {
                throw new ArgumentException($"В свойство {propertyName}" +
                                            $" нельзя присвоить значение которое меньше {min} или больше {max}");
            }
        }
    }
}
