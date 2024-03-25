using Desert.Orca.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Desert.Orca.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext (DbContextOptions<StoreContext> options)
            : base(options)
        { }
        public DbSet<Item> Items { get; set; }
    }
}