using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSalon.Web.Migrations
{
    public partial class basicseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5564), "Audi", new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5568) },
                    { 2, new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5585), "BMW", new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5586) },
                    { 3, new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5594), "Fiat", new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5594) },
                    { 4, new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5602), "Porsche", new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5602) },
                    { 5, new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5610), "Jeep", new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5610) },
                    { 6, new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5620), "Mercedes", new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5621) }
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Four Drive Wheel" },
                    { 2, "Turbo" },
                    { 3, "Manual Transmission" },
                    { 4, "Automatic Transmission" },
                    { 5, "Cabriolet" },
                    { 6, "System ABS" },
                    { 7, "Two doors" },
                    { 8, "Five doors" },
                    { 9, "Three doors" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "BrandForeignKey", "CarType", "CreatedAt", "Fuel", "IsNew", "MadeIn", "Name", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 2, 2, new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5640), 2, true, new DateTime(2020, 11, 25, 20, 47, 32, 645, DateTimeKind.Local).AddTicks(5645), "M850i xDrive Coupé", 700000.0, new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5640) },
                    { 2, 6, 1, new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5695), 1, true, new DateTime(2018, 11, 25, 20, 47, 32, 645, DateTimeKind.Local).AddTicks(5696), "Citaro", 400000.0, new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5695) },
                    { 3, 4, 2, new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5708), 2, false, new DateTime(2020, 11, 25, 20, 47, 32, 645, DateTimeKind.Local).AddTicks(5709), "Cayenne SUV", 440000.0, new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5708) },
                    { 4, 1, 2, new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5719), 4, true, new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5720), "Q5 II TFSI e", 600000.0, new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5720) },
                    { 5, 6, 0, new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5727), 1, false, new DateTime(2017, 11, 25, 20, 47, 32, 645, DateTimeKind.Local).AddTicks(5728), "Actros", 400000.0, new DateTime(2022, 11, 25, 19, 47, 32, 645, DateTimeKind.Utc).AddTicks(5728) }
                });

            migrationBuilder.InsertData(
                table: "Model_Equipment",
                columns: new[] { "Id", "EquipmentId", "ModelId" },
                values: new object[,]
                {
                    { 1, 9, 1 },
                    { 2, 6, 1 },
                    { 3, 4, 1 },
                    { 4, 7, 2 },
                    { 5, 3, 2 },
                    { 6, 8, 3 },
                    { 7, 4, 3 },
                    { 8, 1, 3 },
                    { 9, 6, 3 },
                    { 10, 8, 4 },
                    { 11, 6, 4 },
                    { 12, 4, 4 },
                    { 13, 6, 5 },
                    { 14, 7, 5 },
                    { 15, 4, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
