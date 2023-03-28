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
                Validator.AssertOnPositiveValue(value);
                _durationInMinutes = value;
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