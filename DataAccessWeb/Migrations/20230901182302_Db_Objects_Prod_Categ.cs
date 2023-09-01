using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessWeb.Migrations
{
    public partial class Db_Objects_Prod_Categ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "27c4e9f8-7ad0-44a2-810b-9256ca697f42");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "2fffc1bd-60f1-4691-8235-628d1ce3f188");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "99ceb1ee-ce53-4329-988d-be4ced6f3062");

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "Product",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Product",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,2)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDatetime",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Product",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Category",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "IT", null },
                    { 2, "Goods", null },
                    { 3, "Kitchen stuff", null },
                    { 4, "Limited Edition", null },
                    { 5, "Unknown", null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedDatetime", "Description", "ImageName", "Price", "Quantity", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2002), "Dark Red", null, 21m, 5m, "T-Shirt", null },
                    { 2, new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2057), "The GoldOne", null, 300m, 2m, "Pen", null },
                    { 3, new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2067), "Red Wine with 20% alcohol", null, 115m, 45m, "Wine", null },
                    { 4, new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2077), "Full Subscription on Azure platform (License)", null, 2500m, 3m, "Azure License", null },
                    { 5, new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2087), "Super GREEN", null, 20m, 3m, "XXL Shirt", null },
                    { 6, new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2098), "Ancient fork from China", null, 33m, 2000m, "Fork", null },
                    { 7, new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2108), "license for RedHat distro in 15% OFF , def. nije piratizirano", null, 15m, 5498m, "RedHat License", null },
                    { 8, new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2118), "Super Big Hat for Winter", null, 15m, 51m, "XXL Hat", null },
                    { 9, new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2127), "GPU Nvidia", null, 475m, 6m, "Nvidia 200NN", null },
                    { 10, new DateTime(2023, 9, 1, 20, 23, 2, 681, DateTimeKind.Local).AddTicks(2138), "Big Green Carpet", null, 190m, 3m, "Carpet", null }
                });

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
                name: "IX_Product_UserId",
                table: "Product",
                column: "UserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Product_AspNetUsers_UserId",
                table: "Product",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_AspNetUsers_UserId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_AspNetUsers_UserId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_UserId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Category_UserId",
                table: "Category");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

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
                name: "CreatedDatetime",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Category");

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "Product",
                type: "decimal(9,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Product",
                type: "decimal(9,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "27c4e9f8-7ad0-44a2-810b-9256ca697f42", "772fd1f5-a68f-44f7-b2c0-9f7bafe6e3e8", "Moderator", "Moderator" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2fffc1bd-60f1-4691-8235-628d1ce3f188", "247c36e8-e036-4f8a-bac7-81c1e7fb35c9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "99ceb1ee-ce53-4329-988d-be4ced6f3062", "19551757-5ac1-49d6-a605-b3509a2b4e12", "User", "User" });
        }
    }
}
