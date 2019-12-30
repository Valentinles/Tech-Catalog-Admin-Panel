using System;
using System.Collections.Generic;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class DesktopPcBindingModel : BaseDeviceBindingModel
    {
        public Ram Ram { get; set; }

        public int Hdd { get; set; }

        public int Ssd { get; set; }

        public string Processor { get; set; }

        public decimal ProcessorSpeed { get; set; }

        public string VideoCard { get; set; }

        public int VideoCardMemory { get; set; }

        public string Case { get; set; }

        public bool IsBluetooth { get; set; }
    }
}
