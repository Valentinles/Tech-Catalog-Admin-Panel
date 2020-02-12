using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TechCatalogAdminPanel.Models;

namespace TechCatalogAdminPanel.Data
{
    public class TechCatalogDbContext : DbContext
    {
        public TechCatalogDbContext(DbContextOptions<TechCatalogDbContext> options)
            : base(options)
        {
        }

        public DbSet<AirConditioner> AirConditioners { get; set; }

        public DbSet<Cooker> Cookers { get; set; }

        public DbSet<DesktopPc> DesktopPcs { get; set; }

        public DbSet<GameConsole> GameConsoles { get; set; }

        public DbSet<Headphone> Headphones { get; set; }

        public DbSet<Keyboard> Keyboards { get; set; }

        public DbSet<Laptop> Laptops { get; set; }

        public DbSet<MobilePhone> MobilePhones { get; set; }

        public DbSet<Monitor> Monitors { get; set; }

        public DbSet<Mouse> Mice { get; set; }

        public DbSet<Refrigerator> Refrigerators { get; set; }

        public DbSet<Tablet> Tablets { get; set; }

        public DbSet<Tv> Tvs { get; set; }

        public DbSet<WashingMachine> WashingMachines { get; set; }

        public DbSet<History> Histories { get; set; }
    }
}
