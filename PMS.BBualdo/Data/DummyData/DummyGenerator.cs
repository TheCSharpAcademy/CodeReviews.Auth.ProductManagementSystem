using Data.Models;

namespace Data.DummyData;

public static class DummyGenerator
{
    public static List<Product> GetDummyProducts()
    {
        var random = new Random();
        return new List<Product>
        {
            new()
            {
                Id = 1, Name = "IPhone 15 Pro Max 512GB", Price = 2999.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 2, Name = "Samsung Galaxy S23 Ultra 256GB", Price = 1399.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 3, Name = "Google Pixel 7 Pro 128GB", Price = 999.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 4, Name = "Sony Bravia 65\" 4K TV", Price = 1499.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 5, Name = "Bose QuietComfort 35 II Headphones", Price = 299.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 6, Name = "Apple MacBook Pro 16\" 1TB", Price = 2499.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 7, Name = "Samsung Galaxy Tab S8 256GB", Price = 799.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 8, Name = "Canon EOS R5 Mirrorless Camera", Price = 3899.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 9, Name = "Sony WH-1000XM4 Wireless Headphones", Price = 349.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 10, Name = "Microsoft Surface Laptop 4 512GB", Price = 1599.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 11, Name = "Dell XPS 13 1TB", Price = 1899.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 12, Name = "Amazon Echo Show 10", Price = 249.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 13, Name = "GoPro HERO9 Black", Price = 399.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 14, Name = "Apple Watch Series 7", Price = 499.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 15, Name = "HP Envy 6055 All-in-One Printer", Price = 129.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 16, Name = "LG 27\" 4K UltraFine Monitor", Price = 699.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 17, Name = "Fitbit Charge 5", Price = 179.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 18, Name = "Nintendo Switch OLED Model", Price = 349.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 19, Name = "DJI Mavic Air 2 Drone", Price = 799.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 20, Name = "JBL Flip 5 Bluetooth Speaker", Price = 119.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 21, Name = "Apple AirPods Pro", Price = 249.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 22, Name = "Razer Blade 15 Gaming Laptop", Price = 2199.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 23, Name = "Logitech MX Master 3 Mouse", Price = 99.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 24, Name = "Sony PlayStation 5", Price = 499.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 25, Name = "Xbox Series X", Price = 499.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 26, Name = "Samsung Galaxy Watch 4", Price = 249.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 27, Name = "Garmin Forerunner 945", Price = 599.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 28, Name = "Acer Predator Helios 300 Gaming Laptop", Price = 1499.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 29, Name = "LG Gram 17\" Laptop 1TB", Price = 1699.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 30, Name = "Apple iPad Pro 12.9\" 256GB", Price = 1099.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 31, Name = "Sony Alpha a7 III Mirrorless Camera", Price = 1999.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 32, Name = "Nikon Z6 II Mirrorless Camera", Price = 1799.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 33, Name = "Canon PowerShot G7 X Mark III", Price = 749.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 34, Name = "Fujifilm X-T4 Mirrorless Camera", Price = 1699.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 35, Name = "Panasonic Lumix GH5", Price = 1399.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 36, Name = "Olympus OM-D E-M1 Mark III", Price = 1799.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 37, Name = "Sony RX100 VII", Price = 1299.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 38, Name = "GoPro MAX", Price = 499.99, DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)),
                IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 39, Name = "DJI Osmo Action", Price = 329.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 40, Name = "Insta360 ONE R Twin Edition", Price = 479.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 41, Name = "Microsoft Surface Pro 7", Price = 899.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 42, Name = "Apple Mac Mini M1", Price = 699.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 43, Name = "HP Spectre x360 14", Price = 1599.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 44, Name = "Asus ZenBook Duo 14", Price = 1299.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 45, Name = "Lenovo ThinkPad X1 Carbon", Price = 1799.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 46, Name = "Acer Swift 3", Price = 699.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 47, Name = "Razer Book 13", Price = 1499.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 48, Name = "Dell Inspiron 15 7000", Price = 899.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 49, Name = "MSI Stealth 15M", Price = 1399.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            },
            new()
            {
                Id = 50, Name = "Gigabyte Aero 15", Price = 1799.99,
                DateAdded = DateTime.UtcNow.AddDays(-random.Next(1, 30)), IsActive = random.Next(0, 2) == 1
            }
        };
    }

    public static List<User> GetDummyUsers()
    {
        var users = new List<User>();

        for (int i = 1; i <= 10; i++)
        {
            var user = new User()
            {
                FirstName = $"User {i}",
                LastName = "Seeded",
                Email = $"test{i}@test.com",
                UserName = $"test{i}@test.com",
            };

            users.Add(user);
        }

        return users;
    }
}