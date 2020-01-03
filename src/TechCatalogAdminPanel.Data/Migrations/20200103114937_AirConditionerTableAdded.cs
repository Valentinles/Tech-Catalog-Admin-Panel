using Microsoft.EntityFrameworkCore.Migrations;

namespace TechCatalogAdminPanel.Data.Migrations
{
    public partial class AirConditionerTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GameConsole",
                table: "GameConsole");

            migrationBuilder.RenameTable(
                name: "GameConsole",
                newName: "AirConditioners");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AirConditioners",
                table: "AirConditioners",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AirConditioners",
                table: "AirConditioners");

            migrationBuilder.RenameTable(
                name: "AirConditioners",
                newName: "GameConsole");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameConsole",
                table: "GameConsole",
                column: "Id");
        }
    }
}
