using Microsoft.EntityFrameworkCore;
using EfCorePostgresDemo.Models;

namespace EfCorePostgresDemo.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
{
}

    public DbSet<User> Users => Set<User>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseNpgsql(Environment.GetEnvironmentVariable("POSTGRES_CONN_STRING"));
}
