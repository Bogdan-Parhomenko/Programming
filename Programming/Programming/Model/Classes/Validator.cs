using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value)
        {
            if (value <= 0)
            {
                //TODO: вместо value должно стоять свойство поля откуда вызывается этот метод
                throw new ArgumentException($"Нельзя присвоить отрицательное значение в свойство {value}");
            }
        }
    }
}
