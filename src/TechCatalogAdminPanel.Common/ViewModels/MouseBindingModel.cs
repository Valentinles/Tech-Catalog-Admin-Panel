using System;
using System.Collections.Generic;
using System.Text;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class MouseBindingModel : BaseDeviceBindingModel
    {
        public string ResolutionDpi { get; set; }

        public bool IsScrollButton { get; set; }

        public bool IsErgonomic { get; set; }

        public string Interface { get; set; }
    }
}
