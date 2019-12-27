using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechCatalogAdminPanel.Models.Enums
{
    public enum Resolution
    {
        [Display(Name ="1280x720 (720p HD)")]
        _1280x720,

        [Display(Name = "1366x768")]
        _1366x768,

        [Display(Name = "1600x900")]
        _1600x900,

        [Display(Name = "1920x1080 (1080p Full-HD)")]
        _1920x1080,

        [Display(Name ="2560x1440 (2K)")]
        _2560x1440,

        [Display(Name = "3840x2160 (Ultra-HD 4K)")]
        _3840x2160,

        [Display(Name ="7680x4320 (Ultra-HD 8K)")]
        _7680x4320
    }
}
