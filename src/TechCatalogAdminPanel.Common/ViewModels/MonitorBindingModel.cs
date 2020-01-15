using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class MonitorBindingModel : BaseDeviceBindingModel
    {
        [Required(ErrorMessage = "Enter Contrast, please!")]
        public string Contrast { get; set; }

        [Required(ErrorMessage = "Enter Display Type, please!")]
        public string DisplayType { get; set; }

        [Required(ErrorMessage = "Enter Display Size(inch), please!")]
        public decimal DisplaySizeInch { get; set; }

        [Required(ErrorMessage = "Select Refresh Rate, please!")]
        public RefreshRate RefreshRate { get; set; }

        [Required(ErrorMessage = "Select Resolution, please!")]
        public Resolution Resolution { get; set; }

        [Required(ErrorMessage = "Enter Dimension, please!")]
        public string Dimension { get; set; }
    }
}
