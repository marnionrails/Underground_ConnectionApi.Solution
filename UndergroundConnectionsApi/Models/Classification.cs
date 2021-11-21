using System.Collections.Generic;

namespace UndergroundConnectionsApi.Models
{
  public class Classification
  {
    public Classification()
    {
      this.JoinEntities = new HashSet<ArtistClassification>();
    }
    public int ClassificationId {get; set; }
    public string ClassificationName { get; set; }
    public string ClassificationSpecification { get; set; }
    public virtual ICollection<ArtistClassification> JoinEntities { get; set;}
  

  }
}