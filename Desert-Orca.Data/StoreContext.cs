using Desert.Orca.Data.Db;
using Desert.Orca.Domain.Catalog;
using Desert.Orca.Domain.Orders;
using Desert.Orca.Domain.Orders.Item;
using Microsoft.EntityFrameworkCore;

namespace Desert.Orca.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext (DbContextOptions<StoreContext> options)
            : base(options)
        { }
        public DbSet<Item> Items { get; set; }

        public DbSet<Orders> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);
        }
    }
}