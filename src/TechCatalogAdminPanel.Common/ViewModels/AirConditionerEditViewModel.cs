using System;
using System.Collections.Generic;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class AirConditionerEditViewModel : BaseDeviceEditViewModel
    {
        public decimal CapacityCooling { get; set; }

        public decimal CapacityHeating { get; set; }

        public decimal PowerConsumptionCooling { get; set; }

        public decimal PowerConsumptionHeating { get; set; }

        public bool IsInverterMotor { get; set; }

        public EnergyClass EnergyClassCooling { get; set; }

        public EnergyClass EnergyClassHeating { get; set; }

        public bool IsRemoteControl { get; set; }

        public int NoiseLevelInsideUnit { get; set; }

        public int NoiseLevelOutsideUnit { get; set; }
    }
}
