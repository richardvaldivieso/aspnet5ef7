using Microsoft.Data.Entity;

namespace aspnetefdemo {
  public class DemoContext : DbContext
  {
    public DbSet<Country> Countries {get; set;}
  }
}
