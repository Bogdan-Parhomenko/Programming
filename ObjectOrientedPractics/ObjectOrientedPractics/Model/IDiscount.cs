using System.ComponentModel;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Предоставляет функциональность для классов скидок.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Возвращает строку информации о скидке.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Расчитывает размер скидки для товаров.
        /// </summary>
        /// <param name="items">Список товаров, которые подлежат скидке.</param>
        /// <returns>Возвращает размер скидки.</returns>
        double Calculate(BindingList<Item> items);

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        /// <param name="items">Список товаров, которые подлежат скидке.</param>
        /// <returns>Возвращает размер скидки.</returns>
        double Apply(BindingList<Item> items);

        /// <summary>
        /// Добавляет скидочные баллы.
        /// </summary>
        /// <param name="items">Список товаров за которые начисляется скидка.</param>
        void Update(BindingList<Item> items);
    }
}
