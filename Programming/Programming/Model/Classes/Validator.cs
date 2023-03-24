using System;
using System.Diagnostics;

namespace Programming.Model.Classes
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value)
        {
            var stackTrace = new StackTrace();
            var stackFrame = stackTrace.GetFrame(1);
            if (value <= 0)
            {
                throw new ArgumentException($"В свойство {stackFrame.GetMethod().Name}" +
                                            $" класса {stackFrame.GetMethod().DeclaringType.Name}" +
                                            " нельзя присвоить отрицательное значение");
            }
        }

        public static void AssertOnPositiveValue(double value)
        {
            var stackTrace = new StackTrace();
            var stackFrame = stackTrace.GetFrame(1);
            if (value <= 0.0)
            {
                throw new ArgumentException($"В свойство {stackFrame.GetMethod().Name}" +
                                            $" класса {stackFrame.GetMethod().DeclaringType.Name}" +
                                            " нельзя присвоить отрицательное значение");
            }
        }

        public static void AssertValueInRange(int value, int min, int max)
        {
            var stackTrace = new StackTrace();
            var stackFrame = stackTrace.GetFrame(1);
            if (value < min || value > max)
            {
                throw new ArgumentException($"В свойство {stackFrame.GetMethod().Name}" +
                                            $" класса {stackFrame.GetMethod().DeclaringType.Name}" +
                                            $" нельзя присвоить значение которое меньше {min} или больше {max}");
            }
        }

        public static void AssertValueInRange(double value, double min, double max)
        {
            var stackTrace = new StackTrace();
            var stackFrame = stackTrace.GetFrame(1);
            if (value < min || value > max)
            {
                throw new ArgumentException($"В свойство {stackFrame.GetMethod().Name}" +
                                            $" класса {stackFrame.GetMethod().DeclaringType.Name}" +
                                            $" нельзя присвоить значение которое меньше {min} или больше {max}");
            }
        }
    }
}
