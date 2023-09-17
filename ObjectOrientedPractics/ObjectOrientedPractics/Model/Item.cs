using ObjectOrientedPractics.Services;
using System;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Уникальный идентификатор товара.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает уникальный идентификатор товара.
        /// </summary>
        public int Id
        {
            get => _id;
        }

        /// <summary>
        /// Возвращает и задает название товара. Не должно быть длиннее 200 символов.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает описание товара. Не должно быть длиннее 1000 символов.
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000);
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость товара. Должна быть больше 0 и меньше 100000.
        /// </summary>
        public double Cost
        {
            get => _cost;
            set
            {
                ValueValidator.AssertValueInRange(value, 0, 100000);
                _cost = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/> без его инициализации.
        /// </summary>
        public Item()
        {
            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара. Не должно быть длиннее 200 символов.</param>
        /// <param name="info">Описание товара. Не должно быть длиннее 1000 символов.</param>
        /// <param name="cost">Стоимость товара. Должна быть больше 0 и меньше 100000.</param>
        public Item(string name, string info, double cost)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
        }

        public static Item CopyItem(Item item)
        {
            Item copiedItem = new Item();
            copiedItem.Name = item.Name;
            copiedItem.Info = item.Info;
            copiedItem.Cost = item.Cost;
            return copiedItem;
        }
    }
}
