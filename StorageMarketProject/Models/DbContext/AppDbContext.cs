using Microsoft.EntityFrameworkCore;

namespace StorageMarketProjectAPI.Models.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products2 { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<StateOfStorage> StatesOfStorages { get; set; }
    }
}
