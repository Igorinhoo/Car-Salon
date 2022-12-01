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
                columns: new[] { "Id", "CreatedAt", "ImgUrl", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8419), "https://brandslogos.com/wp-content/uploads/images/large/audi-logo.png", "Audi", new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8421) },
                    { 2, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8441), "img/Brands/Bmw .png", "BMW", new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8441) },
                    { 3, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8448), "img/Brands/Fiat .png", "Fiat", new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8449) },
                    { 4, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8455), "img/Brands/Porsche .png", "Porsche", new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8456) },
                    { 5, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8462), "img/Brands/Jeep .png", "Jeep", new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8462) },
                    { 6, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8471), "img/Brands/Mercedes .png", "Mercedes", new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8471) }
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
                columns: new[] { "Id", "BrandForeignKey", "CarType", "CreatedAt", "Fuel", "ImgUrl", "IsNew", "MadeIn", "Name", "Price", "UpdatedAt", "ViewNumber" },
                values: new object[,]
                {
                    { 1, 2, 0, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8486), 2, "img/Models/M850i Coupé.png", true, new DateTime(2020, 11, 30, 15, 1, 12, 423, DateTimeKind.Local).AddTicks(8492), "M850i xDrive Coupé", 700000.0, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8487), 0L },
                    { 2, 6, 2, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8537), 1, "img/Models/citaro.png", true, new DateTime(2018, 11, 30, 15, 1, 12, 423, DateTimeKind.Local).AddTicks(8538), "Citaro", 400000.0, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8537), 0L },
                    { 3, 4, 0, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8548), 2, "img/Models/Cayenne SUV.png", false, new DateTime(2020, 11, 30, 15, 1, 12, 423, DateTimeKind.Local).AddTicks(8549), "Cayenne SUV", 440000.0, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8548), 0L },
                    { 4, 1, 0, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8561), 4, "img/Models/Q5 TFSI.png", true, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8561), "Q5 II TFSI e", 600000.0, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8561), 0L },
                    { 5, 6, 1, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8568), 1, "img/Models/actros.png", false, new DateTime(2017, 11, 30, 15, 1, 12, 423, DateTimeKind.Local).AddTicks(8569), "Actros", 400000.0, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8568), 0L },
                    { 6, 3, 0, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8578), 4, "img/Models/500.png", false, new DateTime(2017, 11, 30, 15, 1, 12, 423, DateTimeKind.Local).AddTicks(8579), "500", 120000.0, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8578), 0L },
                    { 7, 5, 0, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8587), 4, "https://www.jeep.pl/content/dam/jeep/crossmarket/model/wrangler-4xe-my22/overview/colorizer/sahara/jeep-wrangler-4xe-sahara-black-565x330.png", true, new DateTime(2018, 11, 30, 15, 1, 12, 423, DateTimeKind.Local).AddTicks(8587), "Wrangler", 361000.0, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8587), 0L },
                    { 8, 5, 0, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8595), 4, "https://www.jeep.pl/content/dam/jeep/crossmarket/compass-my-23/compass-ehybrid/overview/trim/trim-s/Jeep_Compass_eHybrid_S_SolidBlack.png", true, new DateTime(2016, 11, 30, 15, 1, 12, 423, DateTimeKind.Local).AddTicks(8596), "Compass", 410000.0, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8596), 0L },
                    { 9, 2, 3, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8604), 1, "https://www.robomarkets.pl/uploads/news/2019/may/bmw-m-motorsport-sponsorship-05-2019/images/car-dtm-final.png", true, new DateTime(2021, 11, 30, 15, 1, 12, 423, DateTimeKind.Local).AddTicks(8605), "M MOTORSPORT", 710000.0, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8605), 0L },
                    { 10, 3, 0, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8614), 4, "https://www.fiat.pl/content/dam/fiat/com/my23/panda/colorizer/white/Panda-figurini-colorizer-Gelato-White-desktop-680x430.png", false, new DateTime(2016, 11, 30, 15, 1, 12, 423, DateTimeKind.Local).AddTicks(8615), "Panda", 70000.0, new DateTime(2022, 11, 30, 14, 1, 12, 423, DateTimeKind.Utc).AddTicks(8614), 0L }
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
                    { 15, 4, 5 },
                    { 16, 3, 7 },
                    { 17, 1, 7 },
                    { 18, 1, 8 },
                    { 19, 4, 8 },
                    { 20, 6, 8 },
                    { 21, 8, 8 },
                    { 22, 2, 9 },
                    { 23, 6, 9 },
                    { 24, 9, 9 },
                    { 25, 3, 9 },
                    { 26, 3, 10 },
                    { 27, 8, 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Model_Equipment",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 2);

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
                table: "Models",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 10);

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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
