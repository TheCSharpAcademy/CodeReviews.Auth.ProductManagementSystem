using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductManagementSystems.tonyissa.Models;

namespace ProductManagementSystems.tonyissa.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<ErrorLog> Errors { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
