using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Umi.API.Migrations
{
    public partial class Order2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LineItems_Orders_OrderId",
                table: "LineItems");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "LineItems",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LineItems_Orders_OrderId",
                table: "LineItems");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "LineItems",
                type: "char(36)",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "R-000",
                column: "ConcurrencyStamp",
                value: "7c0f5b3a-8821-46f0-83bc-67547b13e2a4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "U-OOO",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abcb1a74-5080-46b3-9802-f74c38c488dc", "AQAAAAEAACcQAAAAEBY9YOGUdeBOCU4XolDPFQBafLiCl3LK/KXNCAqMrrx4W2tNze3FX8X1wByt5DzT8A==", "9608c4ec-a3b0-42e7-b686-f2ac7ce7f1e0" });

            migrationBuilder.AddForeignKey(
                name: "FK_LineItems_Orders_OrderId",
                table: "LineItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
