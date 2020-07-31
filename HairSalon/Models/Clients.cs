using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; }
    public string Name { get; set; }

    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }

  }
}