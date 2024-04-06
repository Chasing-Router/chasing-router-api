using Chasing.Router.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Chasing.Router.Data
{
    public static class DbIntitializer {
        public static void Initialize(ModelBuilder builder) {
            builder.Entity<Item>().HasData(
                new Item("Shirt", "Ohio State shirt", "Nike", 29.99M)
                {
                    Id = 1
                },
                new Item("Shorts", "Ohio State shorts", "Nike", 44.99m)
                {
                    Id = 2
                }
            );
        }
    }
}