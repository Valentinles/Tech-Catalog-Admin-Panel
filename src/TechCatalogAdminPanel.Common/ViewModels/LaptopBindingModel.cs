using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class LaptopBindingModel : BaseDeviceBindingModel
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

        [Required(ErrorMessage = "Enter Display Type, please!")]
        public string DisplayType { get; set; }

        [Required(ErrorMessage = "Select Refresh Rate, please!")]
        public RefreshRate RefreshRate { get; set; }

        [Required(ErrorMessage = "Enter Display Size(inch), please!")]
        public decimal DisplaySizeInch { get; set; }

        [Required(ErrorMessage = "Select Resolution, please!")]
        public Resolution Resolution { get; set; }

        [Required(ErrorMessage = "Enter Wireless Adapter, please!")]
        public string WirelessAdapter { get; set; }

        [Required(ErrorMessage = "Enter Number of USB Ports, please!")]
        public int NumberOfUsbPorts { get; set; }

        [Required(ErrorMessage = "Choose if the laptop has HDMI or not, please!")]
        public bool IsHdmi { get; set; }

        [Required(ErrorMessage = "Choose if the laptop has Bluetooth or not, please!")]
        public bool IsBluetooth { get; set; }

        [Required(ErrorMessage = "Enter Battery, please!")]
        public string Battery { get; set; }

        [Required(ErrorMessage = "Select Operating System, please!")]
        public Os OperatingSystemOs { get; set; }
    }
}
