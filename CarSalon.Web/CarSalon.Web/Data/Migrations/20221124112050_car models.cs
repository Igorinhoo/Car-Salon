using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSalon.Web.Migrations
{
    public partial class carmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentEntity_ModelEntity_ModelId",
                table: "EquipmentEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ModelEntity_Brands_BrandId",
                table: "ModelEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModelEntity",
                table: "ModelEntity");

            migrationBuilder.RenameTable(
                name: "ModelEntity",
                newName: "Models");

            migrationBuilder.RenameIndex(
                name: "IX_ModelEntity_BrandId",
                table: "Models",
                newName: "IX_Models_BrandId");

            migrationBuilder.AddColumn<bool>(
                name: "FourWheelDrive",
                table: "EquipmentEntity",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Fuel",
                table: "Models",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Models",
                table: "Models",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentEntity_Models_ModelId",
                table: "EquipmentEntity",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentEntity_Models_ModelId",
                table: "EquipmentEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Brands_BrandId",
                table: "Models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "FourWheelDrive",
                table: "EquipmentEntity");

            migrationBuilder.DropColumn(
                name: "Fuel",
                table: "Models");

            migrationBuilder.RenameTable(
                name: "Models",
                newName: "ModelEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Models_BrandId",
                table: "ModelEntity",
                newName: "IX_ModelEntity_BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModelEntity",
                table: "ModelEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentEntity_ModelEntity_ModelId",
                table: "EquipmentEntity",
                column: "ModelId",
                principalTable: "ModelEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModelEntity_Brands_BrandId",
                table: "ModelEntity",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
