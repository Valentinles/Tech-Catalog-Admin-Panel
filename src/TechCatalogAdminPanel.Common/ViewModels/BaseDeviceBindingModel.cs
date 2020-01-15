using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public abstract class BaseDeviceBindingModel
    {
        [Required(ErrorMessage = "Enter Brand, please!")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Enter Model, please!")]
        public string DeviceModel { get; set; }

        [Required(ErrorMessage = "Enter Color, please!")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Enter Image(url), please!")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Enter Weight, please!")]
        public decimal Weight { get; set; }

        [Required(ErrorMessage = "Enter Warranty, please!")]
        public int Warranty { get; set; }

        [Required(ErrorMessage = "Enter Price(usd), please!")]
        public decimal Price { get; set; }
    }
}
