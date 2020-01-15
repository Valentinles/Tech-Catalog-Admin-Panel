using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class WashingMachineBindingModel : BaseDeviceBindingModel
    {
        [Required(ErrorMessage = "Select Energy Class, please!")]
        public EnergyClass EnergyClass { get; set; }

        [Required(ErrorMessage = "Enter Washing Capacity, please!")]
        public decimal WashingCapacity { get; set; }

        [Required(ErrorMessage = "Enter Energy Consumption, please!")]
        public int EnergyConsumption { get; set; }

        [Required(ErrorMessage = "Enter Water Consumption, please!")]
        public int WaterConsumption { get; set; }

        [Required(ErrorMessage = "Choose if the washing machine has display or not, please!")]
        public bool IsDisplay { get; set; }

        [Required(ErrorMessage = "Enter Programmes Number, please!")]
        public int ProgrammesNumber { get; set; }

        [Required(ErrorMessage = "Enter Height, please!")]
        public decimal Height { get; set; }

        [Required(ErrorMessage = "Enter Width, please!")]
        public decimal Width { get; set; }

        [Required(ErrorMessage = "Enter Depth, please!")]
        public decimal Depth { get; set; }

        [Required(ErrorMessage = "Choose if the water machine has wool program or not, please!")]
        public bool IsWoolProgram { get; set; }

        [Required(ErrorMessage = "Choose if the water machinge has quick wash or not, please!")]
        public bool IsQuickWash { get; set; }
    }
}
