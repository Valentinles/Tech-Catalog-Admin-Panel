using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class TvBindingModel : BaseDeviceBindingModel
    {
        [Required(ErrorMessage = "Select Resolution, please!")]
        public Resolution Resolution { get; set; }

        [Required(ErrorMessage = "Select Screen Technology, please!")]
        public ScreenTechnology ScreenTechnology { get; set; }

        [Required(ErrorMessage = "Enter Display Size(inch), please!")]
        public decimal DisplaySizeInch { get; set; }

        [Required(ErrorMessage = "Choose if the TV has Voice Control or not, please!")]
        public bool IsVoiceControl { get; set; }

        [Required(ErrorMessage = "Choose if the TV is Smart or not, please!")]
        public bool IsSmartTv { get; set; }
    }
}
