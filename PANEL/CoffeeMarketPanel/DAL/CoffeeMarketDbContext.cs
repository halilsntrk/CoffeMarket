using CoffeeMarketPanel.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;

namespace CoffeeMarketPanel.DAL
{
    public class CoffeeMarketDbContext : DbContext
    {
        public CoffeeMarketDbContext(DbContextOptions options) : base(options)
        { 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = DESKTOP-VK3H5EU;Database=CoffeeMarket;Trusted_Connection=True;Encrypt=False");
        }

        public DbSet<Product> Product{ get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<_Stock> Stock { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
