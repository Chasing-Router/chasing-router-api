using Chasing.Router.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
 using Chasing.Router.Domain.Orders;
namespace Chasing.Router.Data{

public class StoreContext:DbContext {
    public StoreContext(DbContextOptions<StoreContext> options) : base(options) {}
    public DbSet<Item> Items { get; set; }

    //public DbSet<Order> Orders {get; set;}
    public DbSet<Order> Orders { get; set; }
    protected override void OnModelCreating(ModelBuilder builder) {
        base.OnModelCreating(builder);
        DbInitializer.Initialize(builder);

        /*  builder.Entity<Items>()
        .HasMany(i => i.Ratings)
        .WithOne()
        .OnDelete(Deletebehavior.Cascade); */
    }
}

}