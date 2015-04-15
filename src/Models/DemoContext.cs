using Microsoft.Data.Entity;

namespace aspnetefdemo {
  public class DemoContext : DbContext
  {
    public DbSet<Country> Countries {get; set;}

    protected override void OnConfiguring(DbContextOptions builder)
    {
      builder.UseSqlServer(@"Server={your_db_host_name};Database={your_db_name};User ID={your_db_user};Password={your_db_password};Trusted_Connection=False;Encrypt=False;Connection Timeout=30;");
    }
  }
}
