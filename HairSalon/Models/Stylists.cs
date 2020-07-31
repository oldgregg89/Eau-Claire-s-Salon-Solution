using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Clients>();
    }
    public int StylistId { get; }
    public string Name { get; set; }
    public virtual ICollection<Client> Clients { get; set;}
  }
}