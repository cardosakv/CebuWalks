using CebuWalks.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CebuWalks.API
{
    public class CebuWalksDbContext : DbContext
    {
        public CebuWalksDbContext(DbContextOptions<CebuWalksDbContext> options) : base(options)
        {
        }

        public DbSet<Walk> Walks { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Difficulty> Difficulties { get; set; }
    }
}
