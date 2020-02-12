using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class CookerBindingModel : BaseDeviceBindingModel
    {
        [Required(ErrorMessage = "Select Energy Class, please!")]
        public EnergyClass EnergyClass { get; set; }

        [Required(ErrorMessage = "Enter Volume, please!")]
        public int Volume { get; set; }

        [Required(ErrorMessage = "Enter Number of Functions, please!")]
        public int NumberOfFunctions { get; set; }

        [Required(ErrorMessage = "Choose if the coocker has Timer or not, please!")]
        public bool IsTimer { get; set; }

        [Required(ErrorMessage = "Choose if the coocker has Programmer or not, please!")]
        public bool IsProgrammer { get; set; }

        [Required(ErrorMessage = "Choose if the coocker has Catalic Panel or not, please!")]
        public bool IsCatalicPanel { get; set; }
    }
}
