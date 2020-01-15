using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class TabletBindingModel : BaseDeviceBindingModel
    {
        [Required(ErrorMessage = "Enter Processor, please!")]
        public string Processor { get; set; }

        [Required(ErrorMessage = "Enter Display Size(inch), please!")]
        public decimal DisplaySizeInch { get; set; }

        [Required(ErrorMessage = "Enter Display Type, please!")]
        public string DisplayType { get; set; }

        [Required(ErrorMessage = "Select Resolution, please!")]
        public Resolution Resolution { get; set; }

        [Required(ErrorMessage = "Enter Memory, please!")]
        public int Memory { get; set; }

        [Required(ErrorMessage = "Enter RAM, please!")]
        public Ram Ram { get; set; }

        [Required(ErrorMessage = "Enter Rear Cam Resolution(megapixels), please!")]
        public int RearCameraResolution { get; set; }

        [Required(ErrorMessage = "Enter Front Cam Resolution(megapixels), please!")]
        public int FrontCameraResolution { get; set; }

        [Required(ErrorMessage = "Choose if the tablet has Bluetooth or not, please!")]
        public bool IsBluetooth { get; set; }

        [Required(ErrorMessage = "Enter Battery, please!")]
        public string Battery { get; set; }

        [Required(ErrorMessage = "Select the Operating System, please!")]
        public MobileOs MobileOs { get; set; }
    }
}
