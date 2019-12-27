using System;
using System.Collections.Generic;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Models
{
    public class MobilePhones : Device
    {
        public string Processor { get; set; }

        public decimal DisplaySizeInch { get; set; }

        public string DisplayType { get; set; }

        public Resolution Resolution { get; set; }

        public int Memory { get; set; }

        public Ram Ram { get; set; }

        public int RearCameraResolution { get; set; }

        public int FrontCameraResolution { get; set; }

        public bool IsBluetooth { get; set; }

        public string Battery { get; set; }

        public MobileOs MobileOs { get; set; }

    }
}
