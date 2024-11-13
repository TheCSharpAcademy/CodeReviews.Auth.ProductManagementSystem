using Microsoft.AspNetCore.Identity;
using ProductManagementSystems.tonyissa.Data;

namespace ProductManagementSystems.tonyissa.Models;

public static class SeedData
{
    public static void InitializeData(ApplicationDbContext context)
    {
        if (context.Games.Any())
            return;

        context.Games.AddRange(
            new Game
            {
                Name = "Devil May Cry 3",
                Description = "The game takes place in the enchanted tower of Temen-ni-gru, a decade before the events of the first Devil May Cry. It focuses on the strained relationship between Dante and his older brother Vergil. The game begins with Dante opening his own mercenary agency and receiving a challenge from Vergil. The game features fast-paced combat with an emphasis on combos. The story is told primarily through cutscenes and pre-rendered full motion videos.",
                Price = 20,
                Developer = "Capcom",
                Platform = "PS2",
                USAReleaseDate = DateTime.Parse("02/17/2005"),
                Genre = "Action"
            },
            new Game
            {
                Name = "Metal Gear Solid 3: Snake Eater",
                Description = "Metal Gear Solid 3: Snake Eater is a 2004 stealth action video game that takes place in 1964 during the Cold War: Players take on the role of Naked Snake, a tactical soldier, and must use stealth and infiltration to complete objectives. The game features a variety of camouflage options, open environments, and new weapons and moves. Players can also capture jungle animals for food and stamina, and use Close Quarters Combat (CQC) to fight enemies at close range.",
                Price = 30,
                Developer = "Konami",
                Platform = "PS2",
                USAReleaseDate = DateTime.Parse("11/17/2004"),
                Genre = "Stealth"
            },
            new Game
            {
                Name = "The Legend Of Zelda: Ocarina of Time",
                Description = "The Legend of Zelda: Ocarina of Time reveals the genesis of the fantasy land of Hyrule, the origin of the Triforce, and the tale of the first exploits of Princess Zelda and the heroic adventurer Link. Vibrant, real-time 3-D graphics transport you into the fantasy world of Hyrule.",
                Price = 15,
                Developer = "Nintendo",
                Platform = "N64",
                USAReleaseDate = DateTime.Parse("11/21/1998"),
                Genre = "Action-Adventure"
            }
        );

        context.SaveChanges();
    }

    public async static Task InitializeRolesAsync(RoleManager<IdentityRole> roleManager)
    {
        string[] roleNames = ["Admin", "User"];

        foreach (string roleName in roleNames)
        {
            if (await roleManager.RoleExistsAsync(roleName))
                continue;

            await roleManager.CreateAsync(new IdentityRole(roleName));
        }
    }
}