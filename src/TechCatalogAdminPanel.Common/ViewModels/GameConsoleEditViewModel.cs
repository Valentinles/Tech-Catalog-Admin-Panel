using System;
using System.Collections.Generic;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class GameConsoleEditViewModel : BaseDeviceEditViewModel
    {
        public int Hdd { get; set; }

        public string Processor { get; set; }

        public string VideoCard { get; set; }

        public Ram Ram { get; set; }

        public bool IsBluetooth { get; set; }

        public bool IsHdmi { get; set; }

        public string Dimension { get; set; }
    }
}
