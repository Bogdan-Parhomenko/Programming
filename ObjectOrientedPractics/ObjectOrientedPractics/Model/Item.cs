using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        /// <summary>
        /// Событие изменения имени товара.
        /// </summary>
        public event EventHandler<EventArgs> NameChanged;

        /// <summary>
        /// Событие изменения цены товара.
        /// </summary>
        public event EventHandler<EventArgs> CostChanged;

        /// <summary>
        /// Событие изменения описания товара.
        /// </summary>
        public event EventHandler<EventArgs> InfoChanged;

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
                if (_name != value)
                {
                    var args = new EventArgs();
                    _name = value;
                    NameChanged?.Invoke(this, args);
                }
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
                if (_info != value)
                {
                    var args = new EventArgs();
                    _info = value;
                    InfoChanged?.Invoke(this, args);
                }
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
                if (_cost != value)
                {
                    var args = new EventArgs();
                    _cost = value;
                    CostChanged?.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category { get; set; }

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
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost, Category category)
        {
            Id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        /// <inheritdoc/>
        public object Clone()
        {
            return new Item(
                Name,
                Info,
                Cost,
                Category);
        }

        /// <inheritdoc/>
        public bool Equals(Item other)
        {
            if (other == null)
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return Name == other.Name && Info == other.Info && Cost == other.Cost && Category == other.Category;
        }

        /// <inheritdoc/>
        public int CompareTo(Item other)
        {
            if (Cost == other.Cost)
            {
                return 0;
            }
            else if (Cost < other.Cost)
            {
                return -1;
            }
            else if (Cost > other.Cost)
            {
                return 1;
            }
            return 1;
        }
    }
}
