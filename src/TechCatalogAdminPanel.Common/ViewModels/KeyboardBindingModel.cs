using System;
using System.Collections.Generic;
using System.Text;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class KeyboardBindingModel : BaseDeviceBindingModel
    {
        public bool IsFastButtons { get; set; }

        public string Interface { get; set; }
    }
}
