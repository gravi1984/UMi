using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Umi.API.Migrations
{
    public partial class Order3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LineItems_Orders_OrderId",
                table: "LineItems");

            migrationBuilder.DropForeignKey(
                name: "FK_LineItems_ShoppingCarts_ShoppingCardId",
                table: "LineItems");

            migrationBuilder.AlterColumn<Guid>(
                name: "ShoppingCardId",
                table: "LineItems",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "LineItems",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_LineItems_Orders_OrderId",
                table: "LineItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LineItems_ShoppingCarts_ShoppingCardId",
                table: "LineItems",
                column: "ShoppingCardId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LineItems_Orders_OrderId",
                table: "LineItems");

            migrationBuilder.DropForeignKey(
                name: "FK_LineItems_ShoppingCarts_ShoppingCardId",
                table: "LineItems");

            migrationBuilder.AlterColumn<Guid>(
                name: "ShoppingCardId",
                table: "LineItems",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "LineItems",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "R-000",
                column: "ConcurrencyStamp",
                value: "02a6be99-8f4d-4734-98f5-7a77a445d226");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "U-OOO",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fd0dedc-04a2-40bc-814e-196f06cc0620", "AQAAAAEAACcQAAAAEKwXSu36CKxHpXC6mXdO3Xy9+FQcoGPeKjtTfg5lmcX5x2aIsSGAGa9MJ7vAATobDQ==", "dffa6be0-03f5-480d-b4b6-64c5b2a0a166" });

            migrationBuilder.AddForeignKey(
                name: "FK_LineItems_Orders_OrderId",
                table: "LineItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LineItems_ShoppingCarts_ShoppingCardId",
                table: "LineItems",
                column: "ShoppingCardId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
