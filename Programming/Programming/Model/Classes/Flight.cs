namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о полете.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Длительность полета в минутах.
        /// </summary>
        private int _flightTimeInMinutes;

        /// <summary>
        /// Возвращает и задает место отправления.
        /// </summary>
        public string DeparturePoint { get; set; }

        /// <summary>
        /// Возвращает и задает место назначения.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задает длительность полета в минутах. Должна быть больше нуля.
        /// </summary>
        public int FlightTimeInMinutes
        {
            get => _flightTimeInMinutes;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _flightTimeInMinutes = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/> без его инициализации.
        /// </summary>
        public Flight()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departurePoint">Место отправления</param>
        /// <param name="destination">место назначения</param>
        /// <param name="flightTimeInMinutes">Длительность полета в минутах. Должна быть больше нуля.</param>
        public Flight(string departurePoint, string destination, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTimeInMinutes = flightTimeInMinutes;
        }
    }
}