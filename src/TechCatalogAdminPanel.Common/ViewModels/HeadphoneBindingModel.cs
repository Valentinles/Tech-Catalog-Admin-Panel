using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class HeadphoneBindingModel : BaseDeviceBindingModel
    {
        [Required(ErrorMessage = "Enter Type, please!")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Enter Frequency Range, please!")]
        public string FrequencyRange { get; set; }

        [Required(ErrorMessage = "Enter Impedance, please!")]
        public int Impedance { get; set; }

        [Required(ErrorMessage = "Choose if the headphones has Microphone or not, please!")]
        public bool IsMicrophone { get; set; }

        [Required(ErrorMessage = "Choose if the headphones has Sound Control or not, please!")]
        public bool IsSoundControl { get; set; }

        [Required(ErrorMessage = "Enter Interface, please!")]
        public string Interface { get; set; }

        [Required(ErrorMessage = "Enter Cable Length, please!")]
        public decimal CableLength { get; set; }
    }
}
