using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
  public class Client
  {
    [Key]
    public int ClientId { get; set; }
    public string Name { get; set; }

    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }

  }
}