using EfCorePostgresDemo.Data;
using EfCorePostgresDemo.Models;
using Microsoft.EntityFrameworkCore;

DotNetEnv.Env.Load();

var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("POSTGRES_CONN_STRING"));

using var db = new AppDbContext(optionsBuilder.Options);

db.Users.Add(new User { Name = "Alice" });
db.SaveChanges();

foreach (var user in db.Users)
{
    Console.WriteLine($"{user.Id}: {user.Name}");
}
