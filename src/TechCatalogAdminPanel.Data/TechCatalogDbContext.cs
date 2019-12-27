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

        public DbSet<Coockers> Coockers { get; set; }

        public DbSet<DesktopPc> DesktopPcs { get; set; }

        public DbSet<GameConsole> GameConsoles { get; set; }

        public DbSet<Headphone> Headphones { get; set; }

        public DbSet<Keyboard> Keyboards { get; set; }

        public DbSet<Laptop> Laptops { get; set; }

        public DbSet<MobilePhones> MobilePhones { get; set; }

        public DbSet<Monitors> Monitors { get; set; }

        public DbSet<Mouse> Mice { get; set; }

        public DbSet<Refrigerator> Refrigerators { get; set; }

        public DbSet<Tablet> Tablets { get; set; }

        public DbSet<Tv> Tvs { get; set; }

        public DbSet<WashingMachine> WashingMachines { get; set; }
    }
}
