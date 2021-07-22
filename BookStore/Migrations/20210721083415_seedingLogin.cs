using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class seedingLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c0fca4e-9376-4a70-bcc6-35bebe497866",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d165605-45d0-403e-9808-a9e50b49d389", "AQAAAAEAACcQAAAAEI3GDsDpddsla8+6V1yb7aKGdvhfpzi1qWWq3VcvXPfG+Dpp0DywVXZqLeZMnyaZOw==", "64959944-f77f-492a-a28a-914e7a88e1be" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c0fca4e-9376-4a70-bcc6-35bebe497866",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f74911c3-3977-4faf-be24-8e005320c5db", "AQAAAAEAACcQAAAAEKyxC8PZoikTyE2Ee/73PlepBes3magOhG9l7dS9dIaKfIaL04jfsZK7L8q8U9GdOw==", "e2fe1740-d5f0-40af-b62a-83cceed19770" });
        }
    }
}
