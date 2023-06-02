using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TheConfectionery.Models
{
  public class TheConfectioneryContext : IdentityDbContext<ApplicationUser>
  {

    public DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<TreatFlavor> TreatFlavors { get; set; }
    
    public TheConfectioneryContext(DbContextOptions options) : base(options) { }
  }
}
