using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessWeb.Migrations
{
    public partial class Rem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "08ccd3c0-2aca-41b6-a598-5ad3b72fd427");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3fa44e00-fcf9-408f-8b3c-37cfcf705a16");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "b20edc45-07b8-4a07-adc0-5f12b8d3dd21");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 3, 21, 34, 40, 37, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 3, 21, 34, 40, 37, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 3, 21, 34, 40, 37, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 3, 21, 34, 40, 37, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 3, 21, 34, 40, 37, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 3, 21, 34, 40, 37, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 3, 21, 34, 40, 37, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 3, 21, 34, 40, 37, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 3, 21, 34, 40, 37, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 3, 21, 34, 40, 37, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37078311-af2e-4adf-bf46-c2cb6c23cfdd", "427748db-a867-470b-936b-91cbf18e3c95", "Moderator", "Moderator" },
                    { "3a7190e6-fa8e-4e8c-a924-c907af0b96a2", "bdccdeb0-9894-4506-8381-a5e7b96d1c15", "User", "User" },
                    { "41f5bf7d-b497-449c-a522-da57f29c9b50", "bb775fea-e63c-4bf7-8630-2093e4f8a631", "Admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "37078311-af2e-4adf-bf46-c2cb6c23cfdd");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3a7190e6-fa8e-4e8c-a924-c907af0b96a2");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "41f5bf7d-b497-449c-a522-da57f29c9b50");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 12, 54, 50, 947, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 12, 54, 50, 947, DateTimeKind.Local).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 12, 54, 50, 947, DateTimeKind.Local).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 12, 54, 50, 947, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 12, 54, 50, 947, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 12, 54, 50, 947, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 12, 54, 50, 947, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 12, 54, 50, 947, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 12, 54, 50, 947, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDatetime",
                value: new DateTime(2023, 9, 2, 12, 54, 50, 947, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08ccd3c0-2aca-41b6-a598-5ad3b72fd427", "3ecb7cc6-9b05-4f00-8b82-586d97cd6df1", "User", "User" },
                    { "3fa44e00-fcf9-408f-8b3c-37cfcf705a16", "7143774f-d372-4c5a-adfc-d865b5e5a607", "Moderator", "Moderator" },
                    { "b20edc45-07b8-4a07-adc0-5f12b8d3dd21", "5aa3748b-9d05-44f5-93a9-477be6149ced", "Admin", "ADMIN" }
                });
        }
    }
}
