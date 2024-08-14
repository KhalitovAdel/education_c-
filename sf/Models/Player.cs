using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sf.Models
{
	public class Player
	{
        [Key]
        public int PlayerId { get; set; }
        public int? TeamId { get; set; }
        [Required]
        [MaxLength(100)]
        public string PlayerName { get; set; }
        public int? Age { get; set; }
        [MaxLength(50)]
        public string Position { get; set; }
        [MaxLength(50)]
        public string Nationality { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public int GoalsScored { get; set; } = 0;
        public int Assists { get; set; } = 0;
        public int Appearances { get; set; } = 0;
        public int YellowCards { get; set; } = 0;
        public int RedCards { get; set; } = 0;

        // Navigation properties
        [ForeignKey("TeamId")]
        public Team? Team { get; set; }
    }
}

