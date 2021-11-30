using Microsoft.EntityFrameworkCore;

namespace UndergroundConnectionsApi.Models
{
  public class UndergroundConnectionsApiContext : DbContext
  {
    public UndergroundConnectionsApiContext(DbContextOptions<UndergroundConnectionsApiContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Artist>()
          .HasData(
              new Artist { ArtistId = 1, Name = "Marni On Rails", Age = 19, Email = "marni@yomama.com", Bio = "Hey yall I make macaroni art and music", Seeking = "Photographers", PastWork = "Eiffle tower made out of penne" },
              new Artist { ArtistId = 2, Name = "Gozi", Age = 65, Email = "sisi@yomama.com", Bio = "Wonder if you'll ever have a woman like me, wonderwoman is who I be", Seeking = "Rappers", PastWork = "I killed a lot of bad guys" },
              new Artist { ArtistId = 3, Name = "Mike Cheese", Age = 4, Email = "daddy@yomama.com", Bio = "I'm Mike cheese aka the big cheese", Seeking = "Painters", PastWork = "Past work? Look no further, this biceps are years in the making" },
              new Artist { ArtistId = 4, Name = "Kanye Rest", Age = 50, Email = "ye@yomama.com", Bio = "I love myself like kanye likes kanye", Seeking = "Producer", PastWork = "Your childhood music is me" },
              new Artist { ArtistId = 5, Name = "Van Gno", Age = 27, Email = "starynite@yomama.com", Bio = "Wonder if you'll ever have a woman like me, wonderwoman is who I be", Seeking = "Graphic Designer", PastWork = "I killed a lot of bad guys" },
              new Artist { ArtistId = 6, Name = "Mouse and String", Age = 23, Email = "hipster_garbo@yomama.com", Bio = "I'm looking only for the peak of human life", Seeking = "Xylophonist's", PastWork = "Cats, the Musical 2.0" }, 
              new Artist { ArtistId = 7, Name = "Salt Shank", Age = 18, Email = "Salty_blanket@yomama.com", Bio = "Bringing you the best of salt extravaganza, each and every day!", Seeking = "Screamers", PastWork = "Bucket of salty salmon" },
              new Artist { ArtistId = 8, Name = "Crunchist", Age = 66, Email = "crunchdaddy@yomama.com", Bio = "Always striving to extract the most profound CRUCH out of my clients.", Seeking = "DJ's", PastWork = "Cap'n Crunch commercial theme" },
              new Artist { ArtistId = 9, Name = "Magic Mike", Age = 29, Email = "papi@yomama.com", Bio = "If you want it lets do it", Seeking = "Singer", PastWork = "Just put on pony and I'll show you my past work" },
              new Artist { ArtistId = 10, Name = "Don't Hang Up", Age = 46, Email = "phoneme@yomama.com", Bio = "I will talk to you all night long.", Seeking = "Videographers", PastWork = "Many conversations recorded and replayed" },
              new Artist { ArtistId = 11, Name = "Dusty Hogg", Age = 36, Email = "biker@yomama.com", Bio = "Don't mess with me or I will punch your lights out", Seeking = "Rappers", PastWork = "I beat the shit out of people" },
              new Artist { ArtistId = 12, Name = "Meera Lax", Age = 32, Email = "psychicmeera@yomama.com", Bio = "I will predict your future by connecting with the spirits", Seeking = "Painters", PastWork = "I helped many find their spiritual purposes." }
          );
          builder.Entity<Classification>()
          .HasData(
              new Classification { ClassificationId = 1, ClassificationName = "Singer", ClassificationSpecification = "Country"}
          );
    }
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Classification> Classifications { get; set; }
    public DbSet<ArtistClassification> ArtistClassifications { get; set; }

  }

}
