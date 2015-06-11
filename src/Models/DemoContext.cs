using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Framework.OptionsModel;

namespace aspnetefdemo {
  public class DemoContext : DbContext
  {
    public DbSet<Country> Countries {get; set;}
    
    private static bool _created;
    
    public DemoContext()
        {
            if (!_created)
            {
                Database.AsRelational().ApplyMigrations();
                _created = true;
            }
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            builder.UseSqlServer(@"Server={your_db_host_name};Database={your_db_name};User ID={your_db_user};Password={your_db_password};Trusted_Connection=False;Encrypt=False;Connection Timeout=30;");
        }
  }
}