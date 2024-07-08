using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateAdded", "IsActive", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 30, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7554), true, "IPhone 15 Pro Max 512GB", 2999.9899999999998 },
                    { 2, new DateTime(2024, 6, 4, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7564), true, "Samsung Galaxy S23 Ultra 256GB", 1399.99 },
                    { 3, new DateTime(2024, 6, 7, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7566), false, "Google Pixel 7 Pro 128GB", 999.99000000000001 },
                    { 4, new DateTime(2024, 5, 24, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7569), true, "Sony Bravia 65\" 4K TV", 1499.99 },
                    { 5, new DateTime(2024, 5, 31, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7571), false, "Bose QuietComfort 35 II Headphones", 299.99000000000001 },
                    { 6, new DateTime(2024, 6, 2, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7574), false, "Apple MacBook Pro 16\" 1TB", 2499.9899999999998 },
                    { 7, new DateTime(2024, 5, 25, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7576), false, "Samsung Galaxy Tab S8 256GB", 799.99000000000001 },
                    { 8, new DateTime(2024, 6, 6, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7577), false, "Canon EOS R5 Mirrorless Camera", 3899.9899999999998 },
                    { 9, new DateTime(2024, 5, 30, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7579), true, "Sony WH-1000XM4 Wireless Headphones", 349.99000000000001 },
                    { 10, new DateTime(2024, 5, 20, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7581), true, "Microsoft Surface Laptop 4 512GB", 1599.99 },
                    { 11, new DateTime(2024, 5, 25, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7582), true, "Dell XPS 13 1TB", 1899.99 },
                    { 12, new DateTime(2024, 5, 23, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7584), false, "Amazon Echo Show 10", 249.99000000000001 },
                    { 13, new DateTime(2024, 5, 12, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7585), true, "GoPro HERO9 Black", 399.99000000000001 },
                    { 14, new DateTime(2024, 6, 2, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7587), true, "Apple Watch Series 7", 499.99000000000001 },
                    { 15, new DateTime(2024, 5, 13, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7588), true, "HP Envy 6055 All-in-One Printer", 129.99000000000001 },
                    { 16, new DateTime(2024, 5, 29, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7590), true, "LG 27\" 4K UltraFine Monitor", 699.99000000000001 },
                    { 17, new DateTime(2024, 6, 1, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7591), false, "Fitbit Charge 5", 179.99000000000001 },
                    { 18, new DateTime(2024, 6, 4, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7594), true, "Nintendo Switch OLED Model", 349.99000000000001 },
                    { 19, new DateTime(2024, 5, 24, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7595), true, "DJI Mavic Air 2 Drone", 799.99000000000001 },
                    { 20, new DateTime(2024, 5, 23, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7597), true, "JBL Flip 5 Bluetooth Speaker", 119.98999999999999 },
                    { 21, new DateTime(2024, 6, 5, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7598), false, "Apple AirPods Pro", 249.99000000000001 },
                    { 22, new DateTime(2024, 5, 30, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7600), true, "Razer Blade 15 Gaming Laptop", 2199.9899999999998 },
                    { 23, new DateTime(2024, 5, 27, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7601), true, "Logitech MX Master 3 Mouse", 99.989999999999995 },
                    { 24, new DateTime(2024, 6, 5, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7603), false, "Sony PlayStation 5", 499.99000000000001 },
                    { 25, new DateTime(2024, 5, 11, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7604), false, "Xbox Series X", 499.99000000000001 },
                    { 26, new DateTime(2024, 6, 3, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7605), true, "Samsung Galaxy Watch 4", 249.99000000000001 },
                    { 27, new DateTime(2024, 5, 28, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7607), true, "Garmin Forerunner 945", 599.99000000000001 },
                    { 28, new DateTime(2024, 5, 13, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7608), true, "Acer Predator Helios 300 Gaming Laptop", 1499.99 },
                    { 29, new DateTime(2024, 6, 6, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7610), true, "LG Gram 17\" Laptop 1TB", 1699.99 },
                    { 30, new DateTime(2024, 5, 28, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7612), false, "Apple iPad Pro 12.9\" 256GB", 1099.99 },
                    { 31, new DateTime(2024, 6, 5, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7613), false, "Sony Alpha a7 III Mirrorless Camera", 1999.99 },
                    { 32, new DateTime(2024, 5, 13, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7615), false, "Nikon Z6 II Mirrorless Camera", 1799.99 },
                    { 33, new DateTime(2024, 6, 7, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7616), false, "Canon PowerShot G7 X Mark III", 749.99000000000001 },
                    { 34, new DateTime(2024, 6, 4, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7618), false, "Fujifilm X-T4 Mirrorless Camera", 1699.99 },
                    { 35, new DateTime(2024, 5, 24, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7620), true, "Panasonic Lumix GH5", 1399.99 },
                    { 36, new DateTime(2024, 6, 3, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7621), true, "Olympus OM-D E-M1 Mark III", 1799.99 },
                    { 37, new DateTime(2024, 5, 16, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7622), true, "Sony RX100 VII", 1299.99 },
                    { 38, new DateTime(2024, 6, 7, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7624), false, "GoPro MAX", 499.99000000000001 },
                    { 39, new DateTime(2024, 5, 20, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7625), false, "DJI Osmo Action", 329.99000000000001 },
                    { 40, new DateTime(2024, 5, 24, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7627), true, "Insta360 ONE R Twin Edition", 479.99000000000001 },
                    { 41, new DateTime(2024, 5, 26, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7628), true, "Microsoft Surface Pro 7", 899.99000000000001 },
                    { 42, new DateTime(2024, 5, 21, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7629), true, "Apple Mac Mini M1", 699.99000000000001 },
                    { 43, new DateTime(2024, 6, 3, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7631), true, "HP Spectre x360 14", 1599.99 },
                    { 44, new DateTime(2024, 5, 20, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7632), true, "Asus ZenBook Duo 14", 1299.99 },
                    { 45, new DateTime(2024, 6, 8, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7633), true, "Lenovo ThinkPad X1 Carbon", 1799.99 },
                    { 46, new DateTime(2024, 5, 17, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7635), false, "Acer Swift 3", 699.99000000000001 },
                    { 47, new DateTime(2024, 6, 8, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7636), false, "Razer Book 13", 1499.99 },
                    { 48, new DateTime(2024, 5, 29, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7637), false, "Dell Inspiron 15 7000", 899.99000000000001 },
                    { 49, new DateTime(2024, 5, 27, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7639), false, "MSI Stealth 15M", 1399.99 },
                    { 50, new DateTime(2024, 5, 21, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7640), false, "Gigabyte Aero 15", 1799.99 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
