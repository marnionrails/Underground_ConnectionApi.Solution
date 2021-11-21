using Microsoft.EntityFrameworkCore;

namespace UndergroundConnectionsApi.Models
{
    public class UndergroundConnectionsApiContext : DbContext
    {
        public UndergroundConnectionsApiContext(DbContextOptions<UndergroundConnectionsApiContext> options)
            : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Classification> Classifications { get; set; }
        public DbSet<ArtistClassification> ArtistClassifications { get; set; }
        
    }
}