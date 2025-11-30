using Authserver.Models;
using Microsoft.EntityFrameworkCore;

namespace Authserver.DBContexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Explicitly map the User entity to the "Users" table
        modelBuilder.Entity<User>().ToTable("Users");
        
        base.OnModelCreating(modelBuilder);
    }
}