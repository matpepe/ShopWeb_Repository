using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessWeb.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "UserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDatetime",
                table: "Product",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 10, 38, 34, 992, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 10, 38, 34, 992, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 10, 38, 34, 992, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 10, 38, 34, 992, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 10, 38, 34, 992, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 10, 38, 34, 992, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 10, 38, 34, 992, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 10, 38, 34, 992, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 10, 38, 34, 992, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 10, 38, 34, 992, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, 9 },
                    { 2, 1, 7 },
                    { 3, 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28560d1b-0673-4b12-acb0-c57ee921cbeb", "880851ef-b570-4083-9032-d5ca46c98b9d", "Admin", "ADMIN" },
                    { "42b2ddaa-ca36-4b4a-8094-270576e05951", "09609359-deb4-4bfe-98a3-47e443e676c0", "User", "User" },
                    { "d7889625-beb9-4ff9-8fa0-9e2559fa9215", "2d20b8eb-2222-4d56-aff8-a74789e9d44c", "Moderator", "Moderator" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "28560d1b-0673-4b12-acb0-c57ee921cbeb");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "42b2ddaa-ca36-4b4a-8094-270576e05951");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "d7889625-beb9-4ff9-8fa0-9e2559fa9215");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "UserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDatetime",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
    }
}
