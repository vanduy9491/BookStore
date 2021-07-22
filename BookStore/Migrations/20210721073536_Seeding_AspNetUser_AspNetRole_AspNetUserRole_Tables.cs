using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class Seeding_AspNetUser_AspNetRole_AspNetUserRole_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0c6661b-0964-4e62-8083-3cac6a6741ec", "1", "SystemAdmin", "SystemAdmin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2c0fca4e-9376-4a70-bcc6-35bebe497866", 0, null, "f74911c3-3977-4faf-be24-8e005320c5db", "khoa.nguyen@codegym.vn", false, false, null, "khoa.nguyen@codegym.vn", "khoa.nguyen@codegym.vn", "AQAAAAEAACcQAAAAEKyxC8PZoikTyE2Ee/73PlepBes3magOhG9l7dS9dIaKfIaL04jfsZK7L8q8U9GdOw==", null, false, "e2fe1740-d5f0-40af-b62a-83cceed19770", false, "khoa.nguyen@codegym.vn" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "2c0fca4e-9376-4a70-bcc6-35bebe497866", "c0c6661b-0964-4e62-8083-3cac6a6741ec" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2c0fca4e-9376-4a70-bcc6-35bebe497866", "c0c6661b-0964-4e62-8083-3cac6a6741ec" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0c6661b-0964-4e62-8083-3cac6a6741ec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c0fca4e-9376-4a70-bcc6-35bebe497866");
        }
    }
}
