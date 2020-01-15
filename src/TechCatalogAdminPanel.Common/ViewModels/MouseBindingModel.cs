using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class MouseBindingModel : BaseDeviceBindingModel
    {
        [Required(ErrorMessage = "Enter ResolutionDpi, please!")]
        public string ResolutionDpi { get; set; }

        [Required(ErrorMessage = "Choose if the mouse has scroll button or not, please!")]
        public bool IsScrollButton { get; set; }

        [Required(ErrorMessage = "Choose if the mouse is ergonomic or not, please!")]
        public bool IsErgonomic { get; set; }

        [Required(ErrorMessage = "Enter Interface, please!")]
        public string Interface { get; set; }
    }
}
