using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class Cottage : House
    {
        private int _garageArea;

        private int _backYardArea;

        private bool _dogHouse;

        public Cottage(string address, string owner, int countOfRooms, int garageArea, int backYardArea, bool dogHouse)
            : base(address, owner, countOfRooms)
        {
            GarageArea = garageArea;
            BackYardArea = backYardArea;
            DogHouse = dogHouse;
        }

        public int GarageArea
        {
            get => _garageArea;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Должна быть больше или равна нулю.");
                }
                _garageArea = value;
            }
        }

        public int BackYardArea
        {
            get => _backYardArea;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Должна быть больше или равна нулю.");
                }
                _backYardArea = value;
            }
        }

        public bool DogHouse { get; set; }


    }
}
