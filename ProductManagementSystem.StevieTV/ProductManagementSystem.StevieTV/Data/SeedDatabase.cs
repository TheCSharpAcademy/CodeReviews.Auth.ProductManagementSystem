using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProductManagementSystem.StevieTV.Models;

namespace ProductManagementSystem.StevieTV.Data;

public class SeedDatabase
{
    public static async Task AddDefaultRoles(IServiceScope scope)
    {
        var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var roles = new[] { "Admin", "Staff" };

        foreach (var role in roles)
        {
            if (!await roleManager.RoleExistsAsync(role))
                await roleManager.CreateAsync(new IdentityRole(role));
        }
    }

    public static async Task AddDefaultUsers(IServiceScope scope)
    {
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

        var defaultAdminUser = new IdentityUser
        {
            UserName = "admin@admin.com",
            Email = "admin@admin.com",
            EmailConfirmed = true,
        };
        
        var defaultStaffUser = new IdentityUser
        {
            UserName = "staff@staff.com",
            Email = "staff@staff.com",
            EmailConfirmed = true,
        };

        await AddDefaultUsers(userManager, defaultAdminUser, "Admin");
        await AddDefaultUsers(userManager, defaultStaffUser, "Staff");
    }

    private static async Task AddDefaultUsers(UserManager<IdentityUser> userManager, IdentityUser userToAdd, string role)
    {
        var user = await userManager.FindByEmailAsync(userToAdd.Email);

        if (user == null)
        {
            await userManager.CreateAsync(userToAdd, "Password123!");
            user = await userManager.FindByEmailAsync(userToAdd.Email);
            await userManager.AddToRoleAsync(user, role);

        }
    }

    public static async Task AddDefaultProducts(IServiceScope scope)
    {
        await using var context = new VideoGameContext(scope.ServiceProvider.GetRequiredService<DbContextOptions<VideoGameContext>>());

        if (context.VideoGames.Any())
        {
            return;
        }
        
        context.VideoGames.AddRange(
            new VideoGame()
            {
                Name = "Baldur's Gate 3",
                IsActive = true,
                DateAdded = DateOnly.Parse("03/08/2023"),
                Price = 49.98M
            },
            new VideoGame()
            {
                Name = "Eiyuden Chronicle: Hundred Heroes",
                IsActive = false,
                DateAdded = DateOnly.Parse("23/04/2024"),
                Price = 64.99M
            },
            new VideoGame()
            {
                Name = "Elden Ring",
                IsActive = true,
                DateAdded = DateOnly.Parse("25/02/2022"),
                Price = 38.79M
            },
            new VideoGame()
            {
                Name = "Final Fantasy VII Rebirth",
                IsActive = true,
                DateAdded = DateOnly.Parse("29/02/2024"),
                Price = 55.99M
            },
            new VideoGame()
            {
                Name = "Resident Evil 4",
                IsActive = true,
                DateAdded = DateOnly.Parse("24/03/2023"),
                Price = 47.99M
            },
            new VideoGame()
            {
                Name = "The Legend of Zelda: Tears of the Kingdom",
                IsActive = true,
                DateAdded = DateOnly.Parse("12/05/2023"),
                Price = 79.99M
            }
            );

        await context.SaveChangesAsync();

    }
}