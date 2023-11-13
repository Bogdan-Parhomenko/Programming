using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class Flat : House
    {
        private int _floor;

        public int Floor { get; set; }

        public Flat(string address, string owner, int countOfRooms, int floor) : base(address, owner, countOfRooms)
        {
            _floor = floor;
        }
    }
}
