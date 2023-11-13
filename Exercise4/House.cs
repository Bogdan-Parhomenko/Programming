using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise4
{
    public class House
    {
        private string _address;

        private string _owner;

        private int _countOfRooms;

        public string Address { get; set; }

        public string Owner
        {
            get => _owner;
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    throw new ArgumentException("Допускаются только буквы.");
                }
                _owner = value;
            }
        }

        public int CountOfRooms
        {
            get => _countOfRooms;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Должно быть больше нуля.");
                }
                _countOfRooms = value;
            }
        }

        public House(string address, string owner, int countOfRooms)
        {
            _address = address;
            _owner = owner;
            _countOfRooms = countOfRooms;
        }
    }
}
