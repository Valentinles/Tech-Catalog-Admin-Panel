using System;
using System.Collections.Generic;
using System.Text;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class DeviceListingViewModel
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string DeviceModel { get; set; }

        public string Color { get; set; }

        public string Image { get; set; }

        public decimal Weight { get; set; }

        public int Warranty { get; set; }

        public decimal Price { get; set; }
    }
}
