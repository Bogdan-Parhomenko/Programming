using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model
{
    internal class Flight
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
                if( value > 0)
                {
                    _flightTimeInMinutes = value;
                }
                else
                {
                    throw new ArgumentException("Продолжительнось полета должна быть больше 0 минут");
                }
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