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
                values: new object[] { "c0c6661b-0964-4e62-8083-3cac6a6741ec", "b18b8a35-38d8-4680-abe2-42f88102c7bc", "SystemAdmin", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2c0fca4e-9376-4a70-bcc6-35bebe497866", 0, null, "7ab00feb-3e01-40ed-99a0-0be0620edf46", "khoa.nguyen@codegym.vn", false, false, null, null, null, null, null, false, "b575481b-3e16-472f-adc1-0a2af1bd73cc", false, "khoa.nguyen@codegym.vn" });

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
