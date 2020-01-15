using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class RefrigeratorBindingModel : BaseDeviceBindingModel
    {
        [Required(ErrorMessage = "Select Energy Class, please!")]
        public EnergyClass EnergyClass { get; set; }

        [Required(ErrorMessage = "Enter Height, please!")]
        public decimal Height { get; set; }

        [Required(ErrorMessage = "Enter Width, please!")]
        public decimal Width { get; set; }

        [Required(ErrorMessage = "Enter Depth, please!")]
        public decimal Depth { get; set; }

        [Required(ErrorMessage = "Enter Total Capacity, please!")]
        public int TotalCapacity { get; set; }

        [Required(ErrorMessage = "Enter Capacity of the refrigerator, please!")]
        public int CapacityRefrigerator { get; set; }

        [Required(ErrorMessage = "Enter Capacity of the refrigerator's freezer, please!")]
        public int CapacityFreezer { get; set; }

        [Required(ErrorMessage = "Enter Number of Shelves please!")]
        public int NumberOfShelves { get; set; }

        [Required(ErrorMessage = "Enter Noise Level, please!")]
        public int NoiseLevel { get; set; }
    }
}
