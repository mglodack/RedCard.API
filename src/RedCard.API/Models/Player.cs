namespace RedCard.API.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string Position { get; set; }

        public string Name { get; set; }

        public int YellowCards { get; set; }

        public int RedCards { get; set; }

        public string Team { get; set; }

        public string League { get; set; }

        public string Country { get; set; }
    }
}
