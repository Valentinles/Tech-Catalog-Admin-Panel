﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechCatalogAdminPanel.Data;

namespace TechCatalogAdminPanel.Data.Migrations
{
    [DbContext(typeof(TechCatalogDbContext))]
    [Migration("20200212133548_FixTypeInModelName")]
    partial class FixTypeInModelName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TechCatalogAdminPanel.Models.AirConditioner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CapacityCooling")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CapacityHeating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnergyClassCooling")
                        .HasColumnType("int");

                    b.Property<int>("EnergyClassHeating")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInverterMotor")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRemoteControl")
                        .HasColumnType("bit");

                    b.Property<int>("NoiseLevelInsideUnit")
                        .HasColumnType("int");

                    b.Property<int>("NoiseLevelOutsideUnit")
                        .HasColumnType("int");

                    b.Property<decimal>("PowerConsumptionCooling")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PowerConsumptionHeating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Warranty")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("AirConditioners");
                });

            modelBuilder.Entity("TechCatalogAdminPanel.Models.Cooker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnergyClass")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCatalicPanel")
                        .HasColumnType("bit");

                    b.Property<bool>("IsProgrammer")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTimer")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfFunctions")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Volume")
                        .HasColumnType("int");

                    b.Property<int>("Warranty")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Cookers");
                });

            modelBuilder.Entity("TechCatalogAdminPanel.Models.DesktopPc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Case")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Hdd")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBluetooth")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Processor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProcessorSpeed")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Ram")
                        .HasColumnType("int");

                    b.Property<int>("Ssd")
                        .HasColumnType("int");

                    b.Property<string>("VideoCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VideoCardMemory")
                        .HasColumnType("int");

                    b.Property<int>("Warranty")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("DesktopPcs");
                });

            modelBuilder.Entity("TechCatalogAdminPanel.Models.GameConsole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dimension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Hdd")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBluetooth")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHdmi")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Processor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ram")
                        .HasColumnType("int");

                    b.Property<string>("VideoCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Warranty")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("GameConsoles");
                });

            modelBuilder.Entity("TechCatalogAdminPanel.Models.Headphone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CableLength")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrequencyRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Impedance")
                        .HasColumnType("int");

                    b.Property<string>("Interface")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMicrophone")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSoundControl")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Warranty")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Headphones");
                });

            modelBuilder.Entity("TechCatalogAdminPanel.Models.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("TechCatalogAdminPanel.Models.Keyboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Interface")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFastButtons")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Warranty")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Keyboards");
                });

            modelBuilder.Entity("TechCatalogAdminPanel.Models.Laptop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Battery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DisplaySizeInch")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DisplayType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Hdd")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBluetooth")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHdmi")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfUsbPorts")
                        .HasColumnType("int");

                    b.Property<int>("OperatingSystemOs")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Processor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProcessorSpeed")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Ram")
                        .HasColumnType("int");

                    b.Property<int>("RefreshRate")
                        .HasColumnType("int");

                    b.Property<int>("Resolution")
                        .HasColumnType("int");

                    b.Property<int>("Ssd")
                        .HasColumnType("int");

                    b.Property<string>("VideoCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VideoCardMemory")
                        .HasColumnType("int");

                    b.Property<int>("Warranty")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("WirelessAdapter")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Laptops");
                });

            modelBuilder.Entity("TechCatalogAdminPanel.Models.MobilePhone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Battery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DisplaySizeInch")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DisplayType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FrontCameraResolution")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBluetooth")
                        .HasColumnType("bit");

                    b.Property<int>("Memory")
                        .HasColumnType("int");

                    b.Property<int>("MobileOs")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Processor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ram")
                        .HasColumnType("int");

                    b.Property<int>("RearCameraResolution")
                        .HasColumnType("int");

                    b.Property<int>("Resolution")
                        .HasColumnType("int");

                    b.Property<int>("Warranty")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("MobilePhones");
                });

            modelBuilder.Entity("TechCatalogAdminPanel.Models.Monitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrast")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dimension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DisplaySizeInch")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DisplayType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RefreshRate")
                        .HasColumnType("int");

                    b.Property<int>("Resolution")
                        .HasColumnType("int");

                    b.Property<int>("Warranty")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Monitors");
                });

            modelBuilder.Entity("TechCatalogAdminPanel.Models.Mouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Interface")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsErgonomic")
                        .HasColumnType("bit");

                    b.Property<bool>("IsScrollButton")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ResolutionDpi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Warranty")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Mice");
                });

            modelBuilder.Entity("TechCatalogAdminPanel.Models.Refrigerator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CapacityFreezer")
                        .HasColumnType("int");

                    b.Property<int>("CapacityRefrigerator")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Depth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DeviceModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnergyClass")
                        .HasColumnType("int");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoiseLevel")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfShelves")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TotalCapacity")
                        .HasColumnType("int");

                    b.Property<int>("Warranty")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Width")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Refrigerators");
                });

            modelBuilder.Entity("TechCatalogAdminPanel.Models.Tablet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Battery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DisplaySizeInch")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DisplayType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FrontCameraResolution")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBluetooth")
                        .HasColumnType("bit");

                    b.Property<int>("Memory")
                        .HasColumnType("int");

                    b.Property<int>("MobileOs")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Processor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ram")
                        .HasColumnType("int");

                    b.Property<int>("RearCameraResolution")
                        .HasColumnType("int");

                    b.Property<int>("Resolution")
                        .HasColumnType("int");

                    b.Property<int>("Warranty")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Tablets");
                });

            modelBuilder.Entity("TechCatalogAdminPanel.Models.Tv", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DisplaySizeInch")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSmartTv")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVoiceControl")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Resolution")
                        .HasColumnType("int");

                    b.Property<int>("ScreenTechnology")
                        .HasColumnType("int");

                    b.Property<int>("Warranty")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Tvs");
                });

            modelBuilder.Entity("TechCatalogAdminPanel.Models.WashingMachine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Depth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DeviceModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnergyClass")
                        .HasColumnType("int");

                    b.Property<int>("EnergyConsumption")
                        .HasColumnType("int");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDisplay")
                        .HasColumnType("bit");

                    b.Property<bool>("IsQuickWash")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWoolProgram")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProgrammesNumber")
                        .HasColumnType("int");

                    b.Property<int>("Warranty")
                        .HasColumnType("int");

                    b.Property<decimal>("WashingCapacity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("WaterConsumption")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Width")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("WashingMachines");
                });
#pragma warning restore 612, 618
        }
    }
}
