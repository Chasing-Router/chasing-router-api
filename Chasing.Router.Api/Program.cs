using Chasing.Router.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<StoreContext>(options => 
{
options.UseSqlite("Data Source../Registrar.sqlite", 
b => b.MigrationsAssembly("Chasing.Router.Api"));
options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
