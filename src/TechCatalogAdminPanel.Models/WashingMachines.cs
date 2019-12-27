using System;
using System.Collections.Generic;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Models
{
    public class WashingMachines : Device
    {
        public EnergyClass EnergyClass { get; set; }

        public decimal WashingCapacity { get; set; }

        public int EnergyConsumption { get; set; }

        public int WaterConsumption { get; set; }

        public bool IsDisplay { get; set; }

        public int ProgrammesNumber { get; set; }

        public decimal Height { get; set; }

        public decimal Width { get; set; }

        public decimal Depth { get; set; }

        public bool IsWoolProgram { get; set; }

        public bool IsQuickWash { get; set; }


    }
}
