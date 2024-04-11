using System.ComponentModel.DataAnnotations;

namespace CebuWalks.API.Models
{
    public class Difficulty
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }
    }
}
