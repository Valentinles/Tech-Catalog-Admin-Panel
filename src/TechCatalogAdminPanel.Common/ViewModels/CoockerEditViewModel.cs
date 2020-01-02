using System;
using System.Collections.Generic;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class CoockerEditViewModel : BaseDeviceEditViewModel
    {
        public EnergyClass EnergyClass { get; set; }

        public decimal WashingCapacity { get; set; }

        public int EnergyConsumption { get; set; }

        public int WaterConsumption { get; set; }

        public int NumberOfFunctions { get; set; }

        public bool IsTimer { get; set; }

        public bool IsProgrammer { get; set; }

        public bool IsCatalicPanel { get; set; }
    }
}
