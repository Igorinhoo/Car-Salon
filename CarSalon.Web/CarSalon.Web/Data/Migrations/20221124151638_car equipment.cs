using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSalon.Web.Migrations
{
    public partial class carequipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentEntity_Models_ModelId",
                table: "EquipmentEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EquipmentEntity",
                table: "EquipmentEntity");

            migrationBuilder.RenameTable(
                name: "EquipmentEntity",
                newName: "Equipment");

            migrationBuilder.RenameIndex(
                name: "IX_EquipmentEntity_ModelId",
                table: "Equipment",
                newName: "IX_Equipment_ModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Models_ModelId",
                table: "Equipment",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Models_ModelId",
                table: "Equipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment");

            migrationBuilder.RenameTable(
                name: "Equipment",
                newName: "EquipmentEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Equipment_ModelId",
                table: "EquipmentEntity",
                newName: "IX_EquipmentEntity_ModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EquipmentEntity",
                table: "EquipmentEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentEntity_Models_ModelId",
                table: "EquipmentEntity",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
