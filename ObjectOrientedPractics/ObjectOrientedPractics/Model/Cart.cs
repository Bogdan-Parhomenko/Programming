using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о корзине товаров.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Общая стоимость всех товаров в корзине.
        /// </summary>
        private double _amount;

        /// <summary>
        /// Возвращает и задает список товаров в корзине.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возвращает общую стоимость товаров в корзине.
        /// </summary>
        public double Amount
        {
            get
            {
                _amount = 0.0;

                if (Items == null)
                {
                    return _amount;
                }

                for (int i = 0; i < Items.Count; i++)
                {
                    _amount += Items[i].Cost;
                }
                return _amount;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {

        }
    }
}
