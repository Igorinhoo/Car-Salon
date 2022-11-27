using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSalon.Web.Migrations
{
    public partial class carmodelsequipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentEntity_ModelEntity_ModelId",
                table: "EquipmentEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ModelEntity_Brands_BrandId",
                table: "ModelEntity");

            migrationBuilder.DropIndex(
                name: "IX_EquipmentEntity_ModelId",
                table: "EquipmentEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModelEntity",
                table: "ModelEntity");

            migrationBuilder.DropColumn(
                name: "DoorsNumber",
                table: "EquipmentEntity");

            migrationBuilder.DropColumn(
                name: "ModelForeignKey",
                table: "EquipmentEntity");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "EquipmentEntity");

            migrationBuilder.RenameTable(
                name: "ModelEntity",
                newName: "Models");

            migrationBuilder.RenameIndex(
                name: "IX_ModelEntity_BrandId",
                table: "Models",
                newName: "IX_Models_BrandId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "EquipmentEntity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateTable(
                name: "Model_Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model_Equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Model_Equipment_EquipmentEntity_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "EquipmentEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Model_Equipment_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Model_Equipment_EquipmentId",
                table: "Model_Equipment",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Model_Equipment_ModelId",
                table: "Model_Equipment",
                column: "ModelId");

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
                name: "FK_Models_Brands_BrandId",
                table: "Models");

            migrationBuilder.DropTable(
                name: "Model_Equipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "Name",
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

            migrationBuilder.AddColumn<int>(
                name: "DoorsNumber",
                table: "EquipmentEntity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModelForeignKey",
                table: "EquipmentEntity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "EquipmentEntity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModelEntity",
                table: "ModelEntity",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentEntity_ModelId",
                table: "EquipmentEntity",
                column: "ModelId");

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
