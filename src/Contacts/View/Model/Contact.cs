namespace View.Model
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Возвращает и задает телефон контакта.
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// Возвращает и задает почту контакта.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// Инициализирует поля объекта.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="phone">Телефон контакта.</param>
        /// <param name="email">Почта контакта.</param>
        public Contact(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
}
