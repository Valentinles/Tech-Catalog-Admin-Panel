using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechCatalogAdminPanel.Models.Enums
{
    public enum RefreshRate
    {
        [Display(Name ="60 Hz")]
        _60Hz,

        [Display(Name = "75 Hz")]
        _75Hz,

        [Display(Name = "120 Hz")]
        _120hz,

        [Display(Name = "144 Hz")]
        _144hz,

        [Display(Name = "240 Hz")]
        _240hz
    }
}
