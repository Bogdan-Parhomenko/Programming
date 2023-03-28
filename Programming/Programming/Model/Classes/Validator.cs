using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Programming.Model.Classes
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value, [CallerMemberName] string propertyName = "")
        {
            if (value <= 0)
            {
                throw new ArgumentException($"В свойство {propertyName} нельзя присвоить отрицательное значение");
            }
        }

        public static void AssertOnPositiveValue(double value, [CallerMemberName] string propertyName = "")
        {
            if (value <= 0.0)
            {
                throw new ArgumentException($"В свойство {propertyName} нельзя присвоить отрицательное значение");
            }
        }

        public static void AssertValueInRange(int value, int min, int max, [CallerMemberName] string propertyName = "")
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"В свойство {propertyName} нельзя присвоить значение которое меньше {min} или больше {max}");
            }
        }

        public static void AssertValueInRange(double value, double min, double max, [CallerMemberName] string propertyName = "")
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"В свойство {propertyName} нельзя присвоить значение которое меньше {min} или больше {max}");
            }
        }
    }
}
