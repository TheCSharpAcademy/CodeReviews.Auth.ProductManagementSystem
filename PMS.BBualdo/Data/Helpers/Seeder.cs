using Data.Models;
using Microsoft.AspNetCore.Identity;

namespace Data.Helpers;

public class Seeder(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
{
    private readonly RoleManager<IdentityRole> _roleManager = roleManager;
    private readonly UserManager<User> _userManager = userManager;

    public async Task SeedRolesAsync()
    {
        string[] roles = ["Admin", "Staff Member"];
        foreach (var role in roles)
            if (!await _roleManager.RoleExistsAsync(role))
                await _roleManager.CreateAsync(new IdentityRole(role));
    }

    public async Task CreateAdminAsync()
    {
        const string email = "admin@admin.com";
        const string password = "Admin123!";

        if (await _userManager.FindByEmailAsync(email) == null)
        {
            var admin = new User
            {
                FirstName = "Admin",
                LastName = "Admin",
                Email = email,
                UserName = email,
                EmailConfirmed = true
            };

            await _userManager.CreateAsync(admin, password);

            await _userManager.AddToRoleAsync(admin, "Admin");
        }
    }
}