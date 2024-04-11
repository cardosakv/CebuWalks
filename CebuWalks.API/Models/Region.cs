using System.ComponentModel.DataAnnotations;

namespace CebuWalks.API.Models
{
    public class Region
    {
        [Key]
        public int Id { get; set; }

        public int Code { get; set; }

        public required string Name { get; set; }

        public string? ImageUrl { get; set; }
    }
}
