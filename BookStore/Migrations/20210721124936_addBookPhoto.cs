using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class addBookPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c0fca4e-9376-4a70-bcc6-35bebe497866",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1dd88341-60f3-4838-9548-dcc65ff1457f", "AQAAAAEAACcQAAAAELemOUOTZbGhfLz1/iwZ5uCVq3uAQ+dLwGoOGvGkAQpyZzrcfdv4PSV0o5bMQF0wgw==", "99fc4bd1-b542-4f18-94fc-59e4dc615bda" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "Photo",
                value: "~/images/Doraemon1.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "Photo",
                value: "~/images/TiengAnh12.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c0fca4e-9376-4a70-bcc6-35bebe497866",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75e25a63-095b-43a6-a93a-235f8ae04e5f", "AQAAAAEAACcQAAAAEFFPrekJwR4j7DV3RM64EhSxNTEG5qONy+scIaEqsg2cVfLHANpvcEda83T7iRI2ZQ==", "34b2f656-14cc-4b62-9640-a0a75479245c" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "Photo",
                value: "images/no-photo.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "Photo",
                value: "images/no-photo.jpg");
        }
    }
}
