using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Служебный класс, который содержит методы генерации случайных уникальных id.
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Список уникальных созданных id.
        /// </summary>
        private static List<int> _ids = new List<int>();

        /// <summary>
        /// Генерирует случайный уникальный id.
        /// </summary>
        /// <returns>Возвращает случайный уникальный id.</returns>
        public static int GetNextId()
        {
            Random random = new Random();
            while (true)
            {
                var newId = random.Next();
                if (!_ids.Contains(newId))
                {
                    _ids.Add(newId);
                    return newId;
                }
            }
        }
    }
}
