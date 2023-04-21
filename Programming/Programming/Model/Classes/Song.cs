namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Длительность песни в минутах.
        /// </summary>
        private int _durationInMinutes;

        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает исполнителя.
        /// </summary>
        public string Singer { get; set; }

        /// <summary>
        /// Возвращает и задает жанр песни.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает длительность песни в минутах. Должна быть больше нуля.
        /// </summary>
        public int DurationInMinutes
        {
            get => _durationInMinutes;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _durationInMinutes = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/> без его инициализации.
        /// </summary>
        public Song()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Название песни.</param>
        /// <param name="singer">Исполнитель.</param>
        /// <param name="genre">Жанр песни.</param>
        /// <param name="durationInMinutes">Длительность песни в минутах. Должна быть больше нуля.</param>
        public Song(string name, string singer, string genre, int durationInMinutes)
        {
            Name = name;
            Singer = singer;
            Genre = genre;
            DurationInMinutes = durationInMinutes;
        }
    }
}