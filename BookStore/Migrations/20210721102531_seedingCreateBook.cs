using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class seedingCreateBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c0fca4e-9376-4a70-bcc6-35bebe497866",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75e25a63-095b-43a6-a93a-235f8ae04e5f", "AQAAAAEAACcQAAAAEFFPrekJwR4j7DV3RM64EhSxNTEG5qONy+scIaEqsg2cVfLHANpvcEda83T7iRI2ZQ==", "34b2f656-14cc-4b62-9640-a0a75479245c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c0fca4e-9376-4a70-bcc6-35bebe497866",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f55c6c0-afba-41b7-9ecb-e66a25055528", "AQAAAAEAACcQAAAAEMUDfsddPFI3fgiR/8+pwAUSyBxPlb0MZIhafOZQgdGKyNXZMSRbhTShHuI5lGd5rw==", "620d7747-dd04-4f64-8d2a-c562dbc463b8" });
        }
    }
}
