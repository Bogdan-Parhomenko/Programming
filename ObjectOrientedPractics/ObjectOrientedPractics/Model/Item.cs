using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    public class Item
    {
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
        /// Возвращает и задает внутри класса уникальный идентификатор товара.
        /// </summary>
        public int Id { get; private set; }

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
        /// Возвращает строку, отражающую информацию о товаре.
        /// </summary>
        public string DisplayInfo
        {
            get
            {
                return $"{Name}";
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/> без его инициализации.
        /// </summary>
        public Item()
        {
            Id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара. Не должно быть длиннее 200 символов.</param>
        /// <param name="info">Описание товара. Не должно быть длиннее 1000 символов.</param>
        /// <param name="cost">Стоимость товара. Должна быть больше 0 и меньше 100000.</param>
        public Item(string name, string info, double cost)
        {
            Id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
        }

        /// <summary>
        /// Копирует информацию о товаре.
        /// </summary>
        /// <param name="item">Искомый товар, чью информацию необходимо скопировать.</param>
        /// <returns>Возвращает товар со скопированной информацией.</returns>
        public static Item CopyItem(Item item)
        {
            Item copiedItem = new Item();
            copiedItem.Id = item.Id;
            copiedItem.Name = item.Name;
            copiedItem.Info = item.Info;
            copiedItem.Cost = item.Cost;
            return copiedItem;
        }
    }
}
