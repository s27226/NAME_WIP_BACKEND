using Microsoft.EntityFrameworkCore;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
{
}

    public DbSet<User> Users => Set<User>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseNpgsql(Environment.GetEnvironmentVariable("POSTGRES_CONN_STRING")?? throw new InvalidOperationException("JWT_SECRET not found in environment variables."));
}
