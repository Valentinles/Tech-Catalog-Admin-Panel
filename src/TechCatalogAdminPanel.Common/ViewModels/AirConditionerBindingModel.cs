using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class AirConditionerBindingModel : BaseDeviceBindingModel
    {
        [Required(ErrorMessage = "Enter Capacity Cooling, please!")]
        public decimal CapacityCooling { get; set; }

        [Required(ErrorMessage = "Enter Capacity Heating, please!")]
        public decimal CapacityHeating { get; set; }

        [Required(ErrorMessage = "Enter Power Consumption Cooling, please!")]
        public decimal PowerConsumptionCooling { get; set; }

        [Required(ErrorMessage = "Enter Power Consumption Heating, please!")]
        public decimal PowerConsumptionHeating { get; set; }

        [Required(ErrorMessage = "Choose if the air conditioner has Inverter Motor or not, please!")]
        public bool IsInverterMotor { get; set; }

        [Required(ErrorMessage = "Select Energy Class Cooling, please!")]
        public EnergyClass EnergyClassCooling { get; set; }

        [Required(ErrorMessage = "Select Energy Class Heating, please!")]
        public EnergyClass EnergyClassHeating { get; set; }

        [Required(ErrorMessage = "Choose if the air conditioner has Remote Control or not, please!")]
        public bool IsRemoteControl { get; set; }

        [Required(ErrorMessage = "Enter Noise level inside Unit, please!")]
        public int NoiseLevelInsideUnit { get; set; }

        [Required(ErrorMessage = "Enter Noise level outside Unit, please!")]
        public int NoiseLevelOutsideUnit { get; set; }
    }
}
