using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sf.Models
{
	public class Match
	{
        [Key]
        public int MatchId { get; set; }
        public int? TournamentId { get; set; }
        public int? HomeTeamId { get; set; }
        public int? AwayTeamId { get; set; }
        public DateTime? MatchDate { get; set; }
        public TimeSpan? MatchTime { get; set; }
        [MaxLength(100)]
        public string Venue { get; set; }
        public int? HomeTeamScore { get; set; }
        public int? AwayTeamScore { get; set; }
        public int? Attendance { get; set; }
        [MaxLength(100)]
        public string Referee { get; set; }
        [MaxLength(50)]
        public string Weather { get; set; }

        // Navigation properties
        [ForeignKey("TournamentId")]
        public Tournament Tournament { get; set; }

        [ForeignKey("HomeTeamId")]
        public Team HomeTeam { get; set; }

        [ForeignKey("AwayTeamId")]
        public Team AwayTeam { get; set; }
    }
}

