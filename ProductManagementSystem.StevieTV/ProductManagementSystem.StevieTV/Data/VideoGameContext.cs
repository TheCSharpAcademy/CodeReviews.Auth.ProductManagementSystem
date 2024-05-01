using Microsoft.EntityFrameworkCore;
using ProductManagementSystem.StevieTV.Models;

namespace ProductManagementSystem.StevieTV.Data;

public class VideoGameContext(DbContextOptions<VideoGameContext> options) : DbContext(options)
{
    public DbSet<VideoGame> VideoGames { get; set; }
    public DbSet<ErrorLog> ErrorLog { get; set; }
}