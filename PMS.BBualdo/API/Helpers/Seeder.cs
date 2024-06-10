using Data.Models;
using Microsoft.AspNetCore.Identity;

namespace Data.Helpers;

public class Seeder(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
{
    private readonly RoleManager<IdentityRole> _roleManager = roleManager;
    private readonly UserManager<User> _userManager = userManager;
    private readonly IConfiguration _configuration = configuration;

    public async Task SeedRolesAsync()
    {
        string[] roles = ["Admin", "Staff Member"];
        foreach (var role in roles)
            if (!await _roleManager.RoleExistsAsync(role))
                await _roleManager.CreateAsync(new IdentityRole(role));
    }

    public async Task CreateAdminAsync()
    {
        var adminSection = _configuration.GetSection("Admin");
        var email = adminSection.GetValue<string>("AdminEmail");
        var password = adminSection.GetValue<string>("AdminPassword");

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