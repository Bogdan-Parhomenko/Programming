using ObjectOrientedPractics.Services;
using System;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные об адресе.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/регион.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город(населенный пункт).
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задает почтовый индекс. Должен состоять из 6 цифр.
        /// </summary>
        public int Index
        {
            get => _index;
            set
            {
                if (value.ToString().Length != 6)
                {
                    throw new ArgumentException("Индекс должен состоять из 6 цифр.");
                }
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задает страну/регион. Не должна быть длиннее 50 символов.
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                ValueValidator.AssertStringOnLength(value, 50);
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает или задает город(населенный пункт). Не должен быть длиннее 50 символов.
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                ValueValidator.AssertStringOnLength(value, 50);
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает или задает улицу. Не должна быть длиннее 100 символов.
        /// </summary>
        public string Street
        {
            get => _street;
            set
            {
                ValueValidator.AssertStringOnLength(value, 100);
                _street = value;
            }
        }
        
        /// <summary>
        /// Врзвращает или задает номер дома. Не должен быть длиннее 10 символов.
        /// </summary>
        public string Building
        {
            get => _building;
            set
            {
                ValueValidator.AssertStringOnLength(value, 10);
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает или задает номер квартиры/помещения. Не должен быть длиннее 10 символов.
        /// </summary>
        public string Apartment
        {
            get => _apartment;
            set
            {
                ValueValidator.AssertStringOnLength(value, 10);
                _apartment = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/> без его инициализации.
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс. Должен состоять из 6 цифр.</param>
        /// <param name="country">Страна/регион. Не должна быть длиннее 50 символов.</param>
        /// <param name="city">Город(населенный пункт). Не должен быть длиннее 50 символов.</param>
        /// <param name="street">Улица. Не должна быть длиннее 100 символов.</param>
        /// <param name="building">Номер дома. Не должен быть длиннее 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещения. Не должен быть длиннее 10 символов.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
