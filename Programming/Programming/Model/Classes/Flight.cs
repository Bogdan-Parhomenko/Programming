﻿namespace Programming.Model.Classes
{
    public class Flight
    {
        private string _departurePoint;
        private string _destination;
        private int _flightTimeInMinutes;

        public string DeparturePoint { get; set; }
        public string Destination { get; set; }
        public int FlightTimeInMinutes
        {
            get
            {
                return _flightTimeInMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _flightTimeInMinutes = value;
            }
        }

        public Flight()
        {

        }

        public Flight(string departurePoint, string destination, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTimeInMinutes = flightTimeInMinutes;
        }
    }
}