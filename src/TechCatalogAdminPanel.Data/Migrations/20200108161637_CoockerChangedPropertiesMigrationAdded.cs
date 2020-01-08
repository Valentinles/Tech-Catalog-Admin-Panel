using Microsoft.EntityFrameworkCore.Migrations;

namespace TechCatalogAdminPanel.Data.Migrations
{
    public partial class CoockerChangedPropertiesMigrationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnergyConsumption",
                table: "Coockers");

            migrationBuilder.DropColumn(
                name: "WashingCapacity",
                table: "Coockers");

            migrationBuilder.DropColumn(
                name: "WaterConsumption",
                table: "Coockers");

            migrationBuilder.AddColumn<int>(
                name: "Volume",
                table: "Coockers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Volume",
                table: "Coockers");

            migrationBuilder.AddColumn<int>(
                name: "EnergyConsumption",
                table: "Coockers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "WashingCapacity",
                table: "Coockers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "WaterConsumption",
                table: "Coockers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
