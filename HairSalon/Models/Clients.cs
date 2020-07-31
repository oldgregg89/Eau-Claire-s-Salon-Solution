using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSolon.Models
{
  public class Client
  {
    public int ClientId { get; }
    public string Name { get; set; }
    public string Details { get; set; }
    public virtual Stylist Stylist { get; set; }

  }
}