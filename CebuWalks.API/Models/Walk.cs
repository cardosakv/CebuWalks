using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CebuWalks.API.Models
{
    public class Walk
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Description { get; set; }

        public double DistanceInKm { get; set; }

        public string? ImageUrl { get; set; }

        [ForeignKey("Region")]
        public int RegionId { get; set; }
        public Region Region { get; set; }

        [ForeignKey("Difficulty")]
        public int DifficultyId { get; set; }
        public Difficulty Difficulty { get; set; }
    }
}
