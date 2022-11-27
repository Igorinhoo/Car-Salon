using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSalon.Web.Migrations
{
    public partial class ordercar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarType = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    IsNew = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6385), new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6421), new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6434), new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6445), new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6458), new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6473), new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "MadeIn", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6495), new DateTime(2020, 11, 27, 16, 9, 37, 355, DateTimeKind.Local).AddTicks(6503), new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "MadeIn", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6567), new DateTime(2018, 11, 27, 16, 9, 37, 355, DateTimeKind.Local).AddTicks(6569), new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "MadeIn", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6585), new DateTime(2020, 11, 27, 16, 9, 37, 355, DateTimeKind.Local).AddTicks(6586), new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6586) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "MadeIn", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6600), new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6602), new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "MadeIn", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6613), new DateTime(2017, 11, 27, 16, 9, 37, 355, DateTimeKind.Local).AddTicks(6615), new DateTime(2022, 11, 27, 15, 9, 37, 355, DateTimeKind.Utc).AddTicks(6614) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5564), new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5585), new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5594), new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5602), new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5610), new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5620), new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "MadeIn", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5640), new DateTime(2020, 11, 25, 20, 47, 32, 645, DateTimeKind.Local).AddTicks(5645), new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "MadeIn", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5695), new DateTime(2018, 11, 25, 20, 47, 32, 645, DateTimeKind.Local).AddTicks(5696), new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "MadeIn", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5708), new DateTime(2020, 11, 25, 20, 47, 32, 645, DateTimeKind.Local).AddTicks(5709), new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "MadeIn", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5719), new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5720), new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "MadeIn", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5727), new DateTime(2017, 11, 25, 20, 47, 32, 645, DateTimeKind.Local).AddTicks(5728), new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5728) });
        }
    }
}
