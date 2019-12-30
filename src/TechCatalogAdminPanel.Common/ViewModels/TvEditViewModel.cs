using System;
using System.Collections.Generic;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class TvEditViewModel : BaseDeviceEditViewModel
    {
        public Resolution Resolution { get; set; }

        public ScreenTechnology ScreenTechnology { get; set; }

        public decimal DisplaySizeInch { get; set; }

        public bool IsVoiceControl { get; set; }

        public bool IsSmartTv { get; set; }
    }
}
