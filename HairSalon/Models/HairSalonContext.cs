using Microsoft.EntityFrameworkCore;

namespace HairSolon.Models
{
  public class HairSolonContext : DbContext
  {
    public virtual DbSet<Stylist> Stylists { get; set;}
    public DbSet<Client> Clients { get; set; }

    public HairSolonContext(DbContextOptions options) : base(options) { }
  }
}