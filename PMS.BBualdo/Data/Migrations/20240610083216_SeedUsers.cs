using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0843560c-3ab4-44c0-87f4-3062ad369487", 0, "83dc1995-6996-46d6-a7a8-10e67674b295", "test1@test.com", false, "User 1", "Seeded", false, null, null, null, null, null, false, "dd5e4d78-4033-44c8-aaca-b64a4ce6e1a1", false, "test1@test.com" },
                    { "24d0a153-8c5d-42bb-9373-ae617d025f36", 0, "c0355bb5-b23f-4038-b049-ceab8bc11dd7", "test3@test.com", false, "User 3", "Seeded", false, null, null, null, null, null, false, "2394530a-cb2a-4129-8d0e-b838044fe048", false, "test3@test.com" },
                    { "3095ae0b-fdba-4461-aead-0bb1760e8944", 0, "568f0f4c-bb82-4539-accc-19b58641d232", "test5@test.com", false, "User 5", "Seeded", false, null, null, null, null, null, false, "0e09fc5d-470c-4ee4-b1db-0d25b11b3219", false, "test5@test.com" },
                    { "39f8b94c-abd0-44b6-a218-eba6a34cd4aa", 0, "48c9cb02-b4d3-4b40-a086-323f835c779d", "test8@test.com", false, "User 8", "Seeded", false, null, null, null, null, null, false, "cb825bb7-a2e1-4bba-9c85-355f4292fb33", false, "test8@test.com" },
                    { "66bf31f2-31c0-4e59-a96f-83c03619ac10", 0, "ec728f0d-e4f8-40cf-9c00-cedfb0511cf6", "test6@test.com", false, "User 6", "Seeded", false, null, null, null, null, null, false, "a148f717-ab9b-48f1-9b15-9ef6ce1b67da", false, "test6@test.com" },
                    { "76c86596-8a86-42af-8e51-54131a9d6b58", 0, "31d48e31-d0ca-4eb0-9065-f844d99bd56b", "test10@test.com", false, "User 10", "Seeded", false, null, null, null, null, null, false, "dc461b04-3587-4fa6-8668-bb306569b683", false, "test10@test.com" },
                    { "878817ba-7da4-4f19-bac5-d9df4fe4030d", 0, "ace06ffb-cd88-424a-9478-79a6a10eb199", "test7@test.com", false, "User 7", "Seeded", false, null, null, null, null, null, false, "7c326deb-fc30-4063-9de8-7b6a2323debe", false, "test7@test.com" },
                    { "94552052-34ed-447d-9a71-81e1bebb6b77", 0, "0464f2d4-2d9e-49fc-b27c-d3d536b27d4c", "test9@test.com", false, "User 9", "Seeded", false, null, null, null, null, null, false, "30fa9e68-353f-42fc-ae04-5cec8ef48510", false, "test9@test.com" },
                    { "c826136d-a2bd-4649-8b44-cb835364495a", 0, "6173bd84-1088-409d-b64e-c581a0a38342", "test2@test.com", false, "User 2", "Seeded", false, null, null, null, null, null, false, "6247bdf7-3d40-4197-93ae-2bdddbd87839", false, "test2@test.com" },
                    { "fb696696-2ece-4fda-805c-75ec01680159", 0, "3a5e7dc8-9942-4b98-a38f-7e15bb125f94", "test4@test.com", false, "User 4", "Seeded", false, null, null, null, null, null, false, "1597c7f6-d438-4da1-8d35-59a32373d455", false, "test4@test.com" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 20, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2939), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 1, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2947), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2949), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 3, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2951), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 6, 4, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 5, 27, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 6, 9, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 5, 25, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 18, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2961), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 28, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2964), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2024, 5, 30, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2024, 5, 17, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2024, 6, 4, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2969), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2971), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2972), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 19, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2974), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 12, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2976), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 30, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2977), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2024, 5, 18, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 22, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2980), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 20, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2982), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 25, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2983), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2984), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateAdded",
                value: new DateTime(2024, 5, 26, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 12, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2987), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2989), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateAdded",
                value: new DateTime(2024, 5, 16, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateAdded",
                value: new DateTime(2024, 5, 19, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 1, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2994), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateAdded",
                value: new DateTime(2024, 5, 13, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateAdded",
                value: new DateTime(2024, 6, 3, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 19, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(2998), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(3001), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 9, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(3003), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 31, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(3005), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateAdded",
                value: new DateTime(2024, 5, 26, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 12, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(3008), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateAdded",
                value: new DateTime(2024, 5, 31, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateAdded",
                value: new DateTime(2024, 6, 9, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateAdded",
                value: new DateTime(2024, 5, 23, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 1, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(3014), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateAdded",
                value: new DateTime(2024, 5, 26, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateAdded",
                value: new DateTime(2024, 6, 2, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(3018), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateAdded",
                value: new DateTime(2024, 5, 22, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateAdded",
                value: new DateTime(2024, 5, 30, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateAdded",
                value: new DateTime(2024, 5, 12, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateAdded",
                value: new DateTime(2024, 5, 25, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 32, 15, 597, DateTimeKind.Utc).AddTicks(3026), true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0843560c-3ab4-44c0-87f4-3062ad369487");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24d0a153-8c5d-42bb-9373-ae617d025f36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3095ae0b-fdba-4461-aead-0bb1760e8944");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39f8b94c-abd0-44b6-a218-eba6a34cd4aa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66bf31f2-31c0-4e59-a96f-83c03619ac10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76c86596-8a86-42af-8e51-54131a9d6b58");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "878817ba-7da4-4f19-bac5-d9df4fe4030d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94552052-34ed-447d-9a71-81e1bebb6b77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c826136d-a2bd-4649-8b44-cb835364495a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb696696-2ece-4fda-805c-75ec01680159");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 30, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7554), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7564), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 7, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7566), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 24, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7569), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 5, 31, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 6, 2, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 5, 25, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 6, 6, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 30, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7579), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 20, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7581), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2024, 5, 25, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2024, 5, 23, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2024, 5, 12, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 2, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7587), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 13, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7588), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 29, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7590), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 1, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7591), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7594), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 24, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7595), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2024, 5, 23, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 5, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7598), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 30, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7600), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 27, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7601), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 5, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7603), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateAdded",
                value: new DateTime(2024, 5, 11, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7605), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 28, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7607), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateAdded",
                value: new DateTime(2024, 5, 13, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateAdded",
                value: new DateTime(2024, 6, 6, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 28, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7612), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateAdded",
                value: new DateTime(2024, 6, 5, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateAdded",
                value: new DateTime(2024, 5, 13, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 7, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7616), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7618), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 24, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7620), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7621), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateAdded",
                value: new DateTime(2024, 5, 16, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 7, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7624), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateAdded",
                value: new DateTime(2024, 5, 20, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateAdded",
                value: new DateTime(2024, 5, 24, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateAdded",
                value: new DateTime(2024, 5, 26, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7629), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateAdded",
                value: new DateTime(2024, 6, 3, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateAdded",
                value: new DateTime(2024, 5, 20, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 6, 8, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7633), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateAdded",
                value: new DateTime(2024, 5, 17, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateAdded",
                value: new DateTime(2024, 6, 8, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateAdded",
                value: new DateTime(2024, 5, 29, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateAdded",
                value: new DateTime(2024, 5, 27, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateAdded", "IsActive" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 52, 42, 758, DateTimeKind.Utc).AddTicks(7640), false });
        }
    }
}
