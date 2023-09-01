using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessWeb.Migrations
{
    public partial class Db2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_AspNetUsers_UserId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_UserId",
                table: "Category");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "03d4768c-c486-46b6-a911-58aa8b8b4665");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "a90c6daa-1cba-4d02-b168-9ccfa6f3cf97");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ca95cfde-d98c-4705-8c94-a57c871b0cca");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Category");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUser",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 37, 47, 586, DateTimeKind.Local).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 37, 47, 586, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 37, 47, 586, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 37, 47, 586, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 37, 47, 586, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 37, 47, 586, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 37, 47, 586, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 37, 47, 586, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 37, 47, 586, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 37, 47, 586, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6ee88484-744d-4d94-b677-032abadf79da", "3e692dc0-bcc0-4351-be93-19b7f466ea0d", "Moderator", "Moderator" },
                    { "9826599c-c7de-4a99-a05e-1c801612afdc", "8f706cc6-d83f-449c-9782-95249bcde97a", "User", "User" },
                    { "ba2c7d93-d07a-46cc-b0be-fd7487dd9f85", "2313732b-4df0-4c50-ba96-46eda6482cad", "Admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "6ee88484-744d-4d94-b677-032abadf79da");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "9826599c-c7de-4a99-a05e-1c801612afdc");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ba2c7d93-d07a-46cc-b0be-fd7487dd9f85");

            migrationBuilder.DropColumn(
                name: "ApplicationUser",
                table: "Category");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Category",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03d4768c-c486-46b6-a911-58aa8b8b4665", "32523d23-fb04-4ebe-b0cd-9f84f636594e", "Admin", "ADMIN" },
                    { "a90c6daa-1cba-4d02-b168-9ccfa6f3cf97", "6b3570b4-c169-43cf-8a64-551df01df107", "Moderator", "Moderator" },
                    { "ca95cfde-d98c-4705-8c94-a57c871b0cca", "63b562c9-1349-4c21-9d26-99d08400e0f6", "User", "User" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_UserId",
                table: "Category",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_AspNetUsers_UserId",
                table: "Category",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
