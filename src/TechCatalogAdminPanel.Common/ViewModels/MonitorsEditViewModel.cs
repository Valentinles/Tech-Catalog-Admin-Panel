using System;
using System.Collections.Generic;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class MonitorsEditViewModel : BaseDeviceEditViewModel
    {
        public string Contrast { get; set; }

        public int MyProperty { get; set; }

        public string DisplayType { get; set; }

        public decimal DisplaySizeInch { get; set; }

        public RefreshRate RefreshRate { get; set; }

        public Resolution Resolution { get; set; }

        public string Dimension { get; set; }
    }
}
