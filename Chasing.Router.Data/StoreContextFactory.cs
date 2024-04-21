using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Migrations.Internal;

namespace Chasing.Router.Data;

public class StoreContextFactory : IDesignTimeDbContextFactory<StoreContext>
{
    public StoreContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<StoreContext>();
        optionsBuilder.UseSqlite("Data Source=../Registrar.sqlite", 
        b => b.MigrationsAssembly("Chasing.Router.Api") );
        return new StoreContext(optionsBuilder.Options);
    }
}