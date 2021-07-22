using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class SeedingCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c0fca4e-9376-4a70-bcc6-35bebe497866",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f55c6c0-afba-41b7-9ecb-e66a25055528", "AQAAAAEAACcQAAAAEMUDfsddPFI3fgiR/8+pwAUSyBxPlb0MZIhafOZQgdGKyNXZMSRbhTShHuI5lGd5rw==", "620d7747-dd04-4f64-8d2a-c562dbc463b8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c0fca4e-9376-4a70-bcc6-35bebe497866",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d165605-45d0-403e-9808-a9e50b49d389", "AQAAAAEAACcQAAAAEI3GDsDpddsla8+6V1yb7aKGdvhfpzi1qWWq3VcvXPfG+Dpp0DywVXZqLeZMnyaZOw==", "64959944-f77f-492a-a28a-914e7a88e1be" });
        }
    }
}
