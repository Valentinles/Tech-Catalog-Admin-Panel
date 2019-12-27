using System;
using System.Collections.Generic;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Models
{
    public class Tv : Device
    {
        public Resolution Resolution { get; set; }

        public ScreenTechnology ScreenTechnology { get; set; }

        public decimal DisplaySizeInch { get; set; }

        public bool IsVoiceControl { get; set; }

        public bool IsSmartTv { get; set; }
    }
}
