namespace UndergroundConnectionsApi.Models
{
  public class ArtistClassification
{
  public int ArtistClassificationId { get; set;}
  public int ArtistId { get; set; }
  public int ClassificationId { get; set;}
  public virtual Artist Artist { get; set;}
  public virtual Classification Classification { get; set; }
}
}