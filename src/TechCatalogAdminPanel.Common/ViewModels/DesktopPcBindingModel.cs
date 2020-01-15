using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class DesktopPcBindingModel : BaseDeviceBindingModel
    {
        [Required(ErrorMessage = "Select RAM, please!")]
        public Ram Ram { get; set; }

        [Required(ErrorMessage = "Enter HDD(gb), please!")]
        public int Hdd { get; set; }

        [Required(ErrorMessage = "Enter SSD(gb), please!")]
        public int Ssd { get; set; }

        [Required(ErrorMessage = "Enter Processor, please!")]
        public string Processor { get; set; }

        [Required(ErrorMessage = "Enter Processor Speed, please!")]
        public decimal ProcessorSpeed { get; set; }

        [Required(ErrorMessage = "Enter Video Card, please!")]
        public string VideoCard { get; set; }

        [Required(ErrorMessage = "Enter Video Card Memory(gb), please!")]
        public int VideoCardMemory { get; set; }

        [Required(ErrorMessage = "Enter Case, please!")]
        public string Case { get; set; }
        [Required(ErrorMessage = "Choose if the desktop PC has Bluetooth or not, please!")]
        public bool IsBluetooth { get; set; }
    }
}
