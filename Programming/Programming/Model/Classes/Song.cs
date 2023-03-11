using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        private string _name;
        private string _singer;
        private string _genre;
        private int _durationInMinutes;

        public string Name { get; set; }
        public string Singer { get; set; }
        public string Genre { get; set; }
        public int DurationInMinutes
        {
            get
            {
                return _durationInMinutes;
            }
            set
            {
                if (value > 0)
                {
                    _durationInMinutes = value;
                }
                else
                {
                    throw new ArgumentException("Продолжительность песни должна быть больше 0 минут");
                }
            }
        }

        public Song()
        {

        }

        public Song(string name, string singer, string genre, int durationInMinutes)
        {
            Name = name;
            Singer = singer;
            Genre = genre;
            DurationInMinutes = durationInMinutes;
        }
    }
}