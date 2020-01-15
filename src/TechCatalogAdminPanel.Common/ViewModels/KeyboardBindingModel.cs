using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class KeyboardBindingModel : BaseDeviceBindingModel
    {
        [Required(ErrorMessage = "Choose if the keyboard has Fast Buttons or not, please!")]
        public bool IsFastButtons { get; set; }

        [Required(ErrorMessage = "Enter Interface, please!")]
        public string Interface { get; set; }
    }
}
