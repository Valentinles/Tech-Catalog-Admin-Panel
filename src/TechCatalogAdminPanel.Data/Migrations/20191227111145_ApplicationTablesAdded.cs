using Microsoft.EntityFrameworkCore.Migrations;

namespace TechCatalogAdminPanel.Data.Migrations
{
    public partial class ApplicationTablesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirConditioners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    DeviceModel = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    CapacityCooling = table.Column<decimal>(nullable: false),
                    CapacityHeating = table.Column<decimal>(nullable: false),
                    PowerConsumptionCooling = table.Column<decimal>(nullable: false),
                    PowerConsumptionHeating = table.Column<decimal>(nullable: false),
                    IsInverterMotor = table.Column<bool>(nullable: false),
                    EnergyClassCooling = table.Column<int>(nullable: false),
                    EnergyClassHeating = table.Column<int>(nullable: false),
                    IsRemoteControl = table.Column<bool>(nullable: false),
                    NoiseLevelInsideUnit = table.Column<int>(nullable: false),
                    NoiseLevelOutsideUnit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirConditioners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coockers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    DeviceModel = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    EnergyClass = table.Column<int>(nullable: false),
                    WashingCapacity = table.Column<decimal>(nullable: false),
                    EnergyConsumption = table.Column<int>(nullable: false),
                    WaterConsumption = table.Column<int>(nullable: false),
                    NumberOfFunctions = table.Column<int>(nullable: false),
                    IsTimer = table.Column<bool>(nullable: false),
                    IsProgrammer = table.Column<bool>(nullable: false),
                    IsCatalicPanel = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coockers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DesktopPcs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    DeviceModel = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Ram = table.Column<int>(nullable: false),
                    Hdd = table.Column<int>(nullable: false),
                    Ssd = table.Column<int>(nullable: false),
                    Processor = table.Column<string>(nullable: true),
                    ProcessorSpeed = table.Column<decimal>(nullable: false),
                    VideoCard = table.Column<string>(nullable: true),
                    VideoCardMemory = table.Column<int>(nullable: false),
                    Case = table.Column<string>(nullable: true),
                    IsBluetooth = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesktopPcs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameConsoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    DeviceModel = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Hdd = table.Column<int>(nullable: false),
                    Processor = table.Column<string>(nullable: true),
                    VideoCard = table.Column<string>(nullable: true),
                    Ram = table.Column<int>(nullable: false),
                    IsBluetooth = table.Column<bool>(nullable: false),
                    IsHdmi = table.Column<bool>(nullable: false),
                    Dimension = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameConsoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Headphones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    DeviceModel = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    FrequencyRange = table.Column<string>(nullable: true),
                    Impedance = table.Column<int>(nullable: false),
                    IsMicrophone = table.Column<bool>(nullable: false),
                    IsSoundControl = table.Column<bool>(nullable: false),
                    Interface = table.Column<string>(nullable: true),
                    CableLength = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headphones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Keyboards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    DeviceModel = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    IsFastButtons = table.Column<bool>(nullable: false),
                    Interface = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keyboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Laptops",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    DeviceModel = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Ram = table.Column<int>(nullable: false),
                    Hdd = table.Column<int>(nullable: false),
                    Ssd = table.Column<int>(nullable: false),
                    Processor = table.Column<string>(nullable: true),
                    ProcessorSpeed = table.Column<decimal>(nullable: false),
                    VideoCard = table.Column<string>(nullable: true),
                    VideoCardMemory = table.Column<int>(nullable: false),
                    DisplayType = table.Column<string>(nullable: true),
                    RefreshRate = table.Column<int>(nullable: false),
                    DisplaySizeInch = table.Column<decimal>(nullable: false),
                    Resolution = table.Column<int>(nullable: false),
                    WirelessAdapter = table.Column<string>(nullable: true),
                    NumberOfUsbPorts = table.Column<int>(nullable: false),
                    IsHdmi = table.Column<bool>(nullable: false),
                    IsBluetooth = table.Column<bool>(nullable: false),
                    Battery = table.Column<string>(nullable: true),
                    OperatingSystemOs = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    DeviceModel = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    ResolutionDpi = table.Column<string>(nullable: true),
                    IsScrollButton = table.Column<bool>(nullable: false),
                    IsErgonomic = table.Column<bool>(nullable: false),
                    Interface = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobilePhones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    DeviceModel = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Processor = table.Column<string>(nullable: true),
                    DisplaySizeInch = table.Column<decimal>(nullable: false),
                    DisplayType = table.Column<string>(nullable: true),
                    Resolution = table.Column<int>(nullable: false),
                    Memory = table.Column<int>(nullable: false),
                    Ram = table.Column<int>(nullable: false),
                    RearCameraResolution = table.Column<int>(nullable: false),
                    FrontCameraResolution = table.Column<int>(nullable: false),
                    IsBluetooth = table.Column<bool>(nullable: false),
                    Battery = table.Column<string>(nullable: true),
                    MobileOs = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobilePhones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monitors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    DeviceModel = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Contrast = table.Column<string>(nullable: true),
                    MyProperty = table.Column<int>(nullable: false),
                    DisplayType = table.Column<string>(nullable: true),
                    DisplaySizeInch = table.Column<decimal>(nullable: false),
                    RefreshRate = table.Column<int>(nullable: false),
                    Resolution = table.Column<int>(nullable: false),
                    Dimension = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Refrigerators",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    DeviceModel = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    EnergyClass = table.Column<int>(nullable: false),
                    Height = table.Column<decimal>(nullable: false),
                    Width = table.Column<decimal>(nullable: false),
                    Depth = table.Column<decimal>(nullable: false),
                    TotalCapacity = table.Column<int>(nullable: false),
                    CapacityRefrigerator = table.Column<int>(nullable: false),
                    CapacityFreezer = table.Column<int>(nullable: false),
                    NumberOfShelves = table.Column<int>(nullable: false),
                    NoiseLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refrigerators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tablets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    DeviceModel = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Processor = table.Column<string>(nullable: true),
                    DisplaySizeInch = table.Column<decimal>(nullable: false),
                    DisplayType = table.Column<string>(nullable: true),
                    Resolution = table.Column<int>(nullable: false),
                    Memory = table.Column<int>(nullable: false),
                    Ram = table.Column<int>(nullable: false),
                    RearCameraResolution = table.Column<int>(nullable: false),
                    FrontCameraResolution = table.Column<int>(nullable: false),
                    IsBluetooth = table.Column<bool>(nullable: false),
                    Battery = table.Column<string>(nullable: true),
                    MobileOs = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tablets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tvs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    DeviceModel = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Resolution = table.Column<int>(nullable: false),
                    ScreenTechnology = table.Column<int>(nullable: false),
                    DisplaySizeInch = table.Column<decimal>(nullable: false),
                    IsVoiceControl = table.Column<bool>(nullable: false),
                    IsSmartTv = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tvs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WashingMachines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    DeviceModel = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    EnergyClass = table.Column<int>(nullable: false),
                    WashingCapacity = table.Column<decimal>(nullable: false),
                    EnergyConsumption = table.Column<int>(nullable: false),
                    WaterConsumption = table.Column<int>(nullable: false),
                    IsDisplay = table.Column<bool>(nullable: false),
                    ProgrammesNumber = table.Column<int>(nullable: false),
                    Height = table.Column<decimal>(nullable: false),
                    Width = table.Column<decimal>(nullable: false),
                    Depth = table.Column<decimal>(nullable: false),
                    IsWoolProgram = table.Column<bool>(nullable: false),
                    IsQuickWash = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WashingMachines", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirConditioners");

            migrationBuilder.DropTable(
                name: "Coockers");

            migrationBuilder.DropTable(
                name: "DesktopPcs");

            migrationBuilder.DropTable(
                name: "GameConsoles");

            migrationBuilder.DropTable(
                name: "Headphones");

            migrationBuilder.DropTable(
                name: "Keyboards");

            migrationBuilder.DropTable(
                name: "Laptops");

            migrationBuilder.DropTable(
                name: "Mice");

            migrationBuilder.DropTable(
                name: "MobilePhones");

            migrationBuilder.DropTable(
                name: "Monitors");

            migrationBuilder.DropTable(
                name: "Refrigerators");

            migrationBuilder.DropTable(
                name: "Tablets");

            migrationBuilder.DropTable(
                name: "Tvs");

            migrationBuilder.DropTable(
                name: "WashingMachines");
        }
    }
}
