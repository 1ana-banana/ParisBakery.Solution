using System.Collections.Generic;

namespace ParisBakery.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.Treats = new HashSet<FlavorTreat>();
    }
    public int FlavorId { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }
    public ICollection<FlavorTreat> Treats { get; }
  }
}