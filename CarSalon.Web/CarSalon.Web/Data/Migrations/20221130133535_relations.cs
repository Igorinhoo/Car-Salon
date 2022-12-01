using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSalon.Web.Migrations
{
    public partial class relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Brands_BrandId",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Models_BrandId",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Models");

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandForeignKey",
                table: "Models",
                column: "BrandForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Brands_BrandForeignKey",
                table: "Models",
                column: "BrandForeignKey",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Brands_BrandForeignKey",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Models_BrandForeignKey",
                table: "Models");

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Models",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Brands_BrandId",
                table: "Models",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
