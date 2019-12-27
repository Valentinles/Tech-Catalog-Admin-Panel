using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechCatalogAdminPanel.Models.Enums
{
    public enum Os
    {
        [Display(Name ="Windows 10 Pro")]
        Windows_10_Pro,

        [Display(Name = "Windows 10 Home")]
        Windows_10_Home,

        Linux,

        [Display(Name = "Mac OS X")]
        Mac_Os_X,

        [Display(Name = "Mac OS")]
        Mac_Os,

        None
    }
}
