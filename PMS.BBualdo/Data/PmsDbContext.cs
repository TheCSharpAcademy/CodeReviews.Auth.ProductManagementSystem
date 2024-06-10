using Data.DummyData;
using Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class PmsDbContext(DbContextOptions options) : IdentityDbContext<User>(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<ErrorLog> Errors { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<User>().Property(u => u.UserName)
            .IsRequired(false);
        builder.Entity<User>().Property(u => u.FirstName)
            .HasMaxLength(50);
        builder.Entity<User>().Property(u => u.LastName)
            .HasMaxLength(50);

        builder.Entity<Product>().HasData(DummyGenerator.GetDummyProducts());
        builder.Entity<User>().HasData(DummyGenerator.GetDummyUsers());
    }
}