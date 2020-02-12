using Microsoft.EntityFrameworkCore.Migrations;

namespace TechCatalogAdminPanel.Data.Migrations
{
    public partial class FixTypeInModelName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coockers");

            migrationBuilder.CreateTable(
                name: "Cookers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    DeviceModel = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    EnergyClass = table.Column<int>(nullable: false),
                    Volume = table.Column<int>(nullable: false),
                    NumberOfFunctions = table.Column<int>(nullable: false),
                    IsTimer = table.Column<bool>(nullable: false),
                    IsProgrammer = table.Column<bool>(nullable: false),
                    IsCatalicPanel = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cookers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cookers");

            migrationBuilder.CreateTable(
                name: "Coockers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnergyClass = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCatalicPanel = table.Column<bool>(type: "bit", nullable: false),
                    IsProgrammer = table.Column<bool>(type: "bit", nullable: false),
                    IsTimer = table.Column<bool>(type: "bit", nullable: false),
                    NumberOfFunctions = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false),
                    Warranty = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coockers", x => x.Id);
                });
        }
    }
}
