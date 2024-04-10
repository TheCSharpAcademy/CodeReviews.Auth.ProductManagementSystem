using Microsoft.EntityFrameworkCore;

namespace ProductManagementSystem.StevieTV.Data;

public class SeedDatabase
{
    public static void CreateDatabase(DbContext context)
    {
        context.Database.EnsureCreated();
    }
}