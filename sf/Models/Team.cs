using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace sf.Models
{
	public class Team
	{
        [Key]
        public int TeamId { get; set; }

        [Required]
        [MaxLength(100)]
        public string TeamName { get; set; }
        [MaxLength(100)]
        public string Coach { get; set; }
        [MaxLength(100)]
        public string Location { get; set; }
        public int? FoundedYear { get; set; }
        [MaxLength(100)]
        public string StadiumName { get; set; }
        [MaxLength(100)]
        public string ContactEmail { get; set; }
        [MaxLength(20)]
        public string ContactPhone { get; set; }
        [MaxLength(100)]
        public string Website { get; set; }
        public int ChampionshipsWon { get; set; } = 0;
        public decimal? AverageAge { get; set; }

        // Navigation properties
        public ICollection<Player> Players { get; set; }

        [InverseProperty("HomeTeam")]
        public ICollection<Match> HomeMatches { get; set; }

        [InverseProperty("AwayTeam")]
        public ICollection<Match> AwayMatches { get; set; }
    }
}

