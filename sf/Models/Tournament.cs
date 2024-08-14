using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace sf.Models
{
	public class Tournament
	{
        [Key]
        public int TournamentId { get; set; }

        [Required]
        [MaxLength(100)]
        public string TournamentName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [MaxLength(100)]
        public string Location { get; set; }
        [MaxLength(50)]
        public string Format { get; set; }
        public int? NumberOfTeams { get; set; }
        public decimal? PrizeMoney { get; set; }
        [MaxLength(100)]
        public string Organizer { get; set; }
        [MaxLength(100)]
        public string Sponsor { get; set; }
        [MaxLength(100)]
        public string Website { get; set; }

        // Navigation properties
        public ICollection<Match> Matches { get; set; }
    }
}

