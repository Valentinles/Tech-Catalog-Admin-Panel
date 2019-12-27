using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechCatalogAdminPanel.Models.Enums
{
    public enum Ram
    {
        [Display(Name = "2 GB")]
        GB_2,

        [Display(Name = "4 GB")]
        GB_4,

        [Display(Name ="6 GB")]
        GB_6,

        [Display(Name = "12 GB")]
        GB_12,

        [Display(Name = "16 GB")]
        GB_16,

        [Display(Name = "32 GB")]
        GB_32,

        [Display(Name = "64 GB")]
        GB_64
    }
}
