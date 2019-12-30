using System;
using System.Collections.Generic;
using System.Text;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class MouseEditViewModel : BaseDeviceEditViewModel
    {
        public string ResolutionDpi { get; set; }

        public bool IsScrollButton { get; set; }

        public bool IsErgonomic { get; set; }

        public string Interface { get; set; }
    }
}
