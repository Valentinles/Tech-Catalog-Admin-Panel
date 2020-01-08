using System;
using System.Collections.Generic;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class CoockerBindingModel : BaseDeviceBindingModel
    {
        public EnergyClass EnergyClass { get; set; }

        public int Volume { get; set; }

        public int NumberOfFunctions { get; set; }

        public bool IsTimer { get; set; }

        public bool IsProgrammer { get; set; }

        public bool IsCatalicPanel { get; set; }
    }
}
