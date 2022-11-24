using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSalon.Web.Migrations
{
    public partial class brandmodelequipmentrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Models_ModelId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Brands_BrandId",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_ModelId",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "ModelForeignKey",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Equipment");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "Models",
                newName: "EquipmentForeignKey");

            migrationBuilder.RenameIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                newName: "IX_Models_EquipmentForeignKey");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Equipment_EquipmentForeignKey",
                table: "Models",
                column: "EquipmentForeignKey",
                principalTable: "Equipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Brands_BrandForeignKey",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Equipment_EquipmentForeignKey",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Models_BrandForeignKey",
                table: "Models");

            migrationBuilder.RenameColumn(
                name: "EquipmentForeignKey",
                table: "Models",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_Models_EquipmentForeignKey",
                table: "Models",
                newName: "IX_Models_BrandId");

            migrationBuilder.AddColumn<int>(
                name: "ModelForeignKey",
                table: "Equipment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "Equipment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_ModelId",
                table: "Equipment",
                column: "ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Models_ModelId",
                table: "Equipment",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
