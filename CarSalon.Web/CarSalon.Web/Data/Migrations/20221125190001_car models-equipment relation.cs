using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSalon.Web.Migrations
{
    public partial class carmodelsequipmentrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Model_Equipment_EquipmentEntity_EquipmentId",
                table: "Model_Equipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EquipmentEntity",
                table: "EquipmentEntity");

            migrationBuilder.RenameTable(
                name: "EquipmentEntity",
                newName: "Equipment");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Model_Equipment_Equipment_EquipmentId",
                table: "Model_Equipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment");

            migrationBuilder.RenameTable(
                name: "Equipment",
                newName: "EquipmentEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EquipmentEntity",
                table: "EquipmentEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Equipment_EquipmentEntity_EquipmentId",
                table: "Model_Equipment",
                column: "EquipmentId",
                principalTable: "EquipmentEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
