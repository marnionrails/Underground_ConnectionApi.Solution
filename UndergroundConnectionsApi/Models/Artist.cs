using System.Collections.Generic;

namespace UndergroundConnectionsApi.Models
{
  public class Artist
  {
    public Artist()
        {
            this.JoinEntities = new HashSet<ArtistClassification>();
        }
    public int ArtistId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set;}
    public string Bio { get; set; }
    public string Seeking { get; set; }
    public string PastWork { get; set; }
    public virtual ICollection<ArtistClassification> JoinEntities { get; set;}
  }
}