using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSalon.Web.Migrations
{
    public partial class carequipmentmodelequipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Model_EquipmentEntity_EquipmentEntity_EquipmentId",
                table: "Model_EquipmentEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_EquipmentEntity_Models_ModelId",
                table: "Model_EquipmentEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Model_EquipmentEntity",
                table: "Model_EquipmentEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EquipmentEntity",
                table: "EquipmentEntity");

            migrationBuilder.RenameTable(
                name: "Model_EquipmentEntity",
                newName: "Model_Equipment");

            migrationBuilder.RenameTable(
                name: "EquipmentEntity",
                newName: "Equipment");

            migrationBuilder.RenameIndex(
                name: "IX_Model_EquipmentEntity_ModelId",
                table: "Model_Equipment",
                newName: "IX_Model_Equipment_ModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Model_EquipmentEntity_EquipmentId",
                table: "Model_Equipment",
                newName: "IX_Model_Equipment_EquipmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Model_Equipment",
                table: "Model_Equipment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Equipment_Equipment_EquipmentId",
                table: "Model_Equipment",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Equipment_Models_ModelId",
                table: "Model_Equipment",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Model_Equipment_Equipment_EquipmentId",
                table: "Model_Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_Equipment_Models_ModelId",
                table: "Model_Equipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Model_Equipment",
                table: "Model_Equipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment");

            migrationBuilder.RenameTable(
                name: "Model_Equipment",
                newName: "Model_EquipmentEntity");

            migrationBuilder.RenameTable(
                name: "Equipment",
                newName: "EquipmentEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Model_Equipment_ModelId",
                table: "Model_EquipmentEntity",
                newName: "IX_Model_EquipmentEntity_ModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Model_Equipment_EquipmentId",
                table: "Model_EquipmentEntity",
                newName: "IX_Model_EquipmentEntity_EquipmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Model_EquipmentEntity",
                table: "Model_EquipmentEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EquipmentEntity",
                table: "EquipmentEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Model_EquipmentEntity_EquipmentEntity_EquipmentId",
                table: "Model_EquipmentEntity",
                column: "EquipmentId",
                principalTable: "EquipmentEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Model_EquipmentEntity_Models_ModelId",
                table: "Model_EquipmentEntity",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
