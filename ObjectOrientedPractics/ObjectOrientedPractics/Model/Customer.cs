using ObjectOrientedPractics.Services;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный идентификатор товара.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Адрес доставки для покупателя.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает уникальный идентификатор товара.
        /// </summary>
        public int Id
        {
            get => _id;
        }

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
        /// Возвращает или задает адрес доставки для покупателя. Не должно быть длиннее 500 символов.
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                ValueValidator.AssertStringOnLength(value, 500);
                _address = value;
            }
        }

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
            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное имя покупателя. Не должно быть длиннее 200 символов.</param>
        /// <param name="address">Адрес доставки для покупателя. Не должно быть длиннее 500 символов.</param>
        public Customer(string fullName, string address)
        {
            _id = IdGenerator.GetNextId();
            FullName = fullName;
            Address = address;
        }

        /// <summary>
        /// Копирует информацию о покупателе.
        /// </summary>
        /// <param name="customer">Искомый покупатель, чью информацию необходимо скопировать.</param>
        /// <returns>Возвращает покупателя со скопированной информацией.</returns>
        public static Customer CopyCustomer(Customer customer)
        {
            Customer copiedCustomer = new Customer();
            copiedCustomer.FullName = customer.FullName;
            copiedCustomer.Address = customer.Address;
            return copiedCustomer;
        }
    }
}
