using Microsoft.EntityFrameworkCore;
using CareerBridge.Api.Entities;

namespace CareerBridge.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<User> Users => Set<User>();
}
