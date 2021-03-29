using Microsoft.EntityFrameworkCore.Migrations;

namespace Umi.API.Migrations
{
    public partial class OrderDropRequire : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "R-000",
                column: "ConcurrencyStamp",
                value: "a32ba618-3834-47d3-91d7-c92eee721a80");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "U-OOO",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18abf5e0-6790-44ba-be30-be63d11ee89b", "AQAAAAEAACcQAAAAEBvjXHSBNE/WHz11qrlw0qMJLIyBokSVaphfNoSnJfS/Fg4Yjxi7FBIOtSlFlSRwtQ==", "5ecf70d6-05a8-4c36-b1b9-f7d3515ab431" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "R-000",
                column: "ConcurrencyStamp",
                value: "70cf844f-2e19-4bb3-8372-e7b7c4d0295a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "U-OOO",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a7ff531-ba8e-4228-9649-f82fa2c8ae38", "AQAAAAEAACcQAAAAEG84NDjvHyFFs1hamcAeyT9yciRjG2zTqIYtkzoHMLvINM8AaYyPw1qN/TaQ65ZPFQ==", "9d3cf29d-efb0-461d-b856-a39f83378a76" });
        }
    }
}
