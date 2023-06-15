using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace StorageMarketProjectAPI.Models.DbContexts
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Data Source = localhost\\SQLEXPRESS; Initial Catalog = StorageDB; User ID = sa; Password = 1234");
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
