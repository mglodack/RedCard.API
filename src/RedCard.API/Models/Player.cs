using System.ComponentModel.DataAnnotations;

namespace RedCard.API.Models
{
    public class Player
    {
        public int Id { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string Name { get; set; }

        public int YellowCards { get; set; }

        public int RedCards { get; set; }

        [Required]
        public string Team { get; set; }

        [Required]
        public string League { get; set; }

        [Required]
        public string Country { get; set; }
    }
}
