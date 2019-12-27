using System;
using System.Collections.Generic;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Models
{
    public class Laptop : Device
    {
        public Ram Ram { get; set; }

        public int Hdd { get; set; }

        public int Ssd { get; set; }

        public string Processor { get; set; }

        public decimal ProcessorSpeed { get; set; }

        public string VideoCard { get; set; }

        public int VideoCardMemory { get; set; }

        public string DisplayType { get; set; }

        public RefreshRate RefreshRate { get; set; }

        public decimal DisplaySizeInch { get; set; }

        public Resolution Resolution { get; set; }

        public string WirelessAdapter { get; set; }

        public int NumberOfUsbPorts { get; set; }

        public bool IsHdmi { get; set; }

        public bool IsBluetooth { get; set; }

        public string Battery { get; set; }

        public Os OperatingSystemOs { get; set; }


    }
}
