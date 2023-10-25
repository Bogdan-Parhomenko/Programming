using ObjectOrientedPractics.Services;
using System.ComponentModel;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Возвращает и задает внутри класса уникальный идентификатор покупателя.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Возвращает или задает полное имя покупателя. Не должно быть длиннее 200 символов.
        /// </summary>
        public string FullName
        {
            get => _fullName;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200);
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает или задает адрес доставки для покупателя.
        /// </summary>
        public Address Address { get; set; } = new Address();

        /// <summary>
        /// Возвращает и задает корзину покупателя.
        /// </summary>
        public Cart Cart { get; set; } = new Cart();

        /// <summary>
        /// Возвращает и задает список заказов покупателя.
        /// </summary>
        public BindingList<Order> Order { get; set; } = new BindingList<Order>();

        /// <summary>
        /// Возвращает строку, отражающую информацию о покупателе.
        /// </summary>
        public string DisplayInfo
        {
            get
            {
                return $"{FullName}";
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/> без его инициализации.
        /// </summary>
        public Customer()
        {
            Id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное имя покупателя. Не должно быть длиннее 200 символов.</param>
        /// <param name="address">Адрес доставки для покупателя.</param>
        public Customer(string fullName, Address address)
        {
            Id = IdGenerator.GetNextId();
            FullName = fullName;
            Address = address;
        }
    }
}
