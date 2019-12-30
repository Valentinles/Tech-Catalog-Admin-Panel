using System;
using System.Collections.Generic;
using System.Text;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class HeadphoneEditViewModel : BaseDeviceEditViewModel
    {
        public string Type { get; set; }

        public string FrequencyRange { get; set; }

        public int Impedance { get; set; }

        public bool IsMicrophone { get; set; }

        public bool IsSoundControl { get; set; }

        public string Interface { get; set; }

        public decimal CableLength { get; set; }
    }
}
