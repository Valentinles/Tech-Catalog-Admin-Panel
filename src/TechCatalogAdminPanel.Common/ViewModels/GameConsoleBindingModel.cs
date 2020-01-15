using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TechCatalogAdminPanel.Models.Enums;

namespace TechCatalogAdminPanel.Common.ViewModels
{
    public class GameConsoleBindingModel : BaseDeviceBindingModel
    {
        [Required(ErrorMessage = "Enter HDD(gb), please!")]
        public int Hdd { get; set; }

        [Required(ErrorMessage = "Enter Processor, please!")]
        public string Processor { get; set; }

        [Required(ErrorMessage = "Enter Video Card, please!")]
        public string VideoCard { get; set; }

        [Required(ErrorMessage = "Select RAM, please!")]
        public Ram Ram { get; set; }

        [Required(ErrorMessage = "Choose if the game console has Bluetooth or not, please!")]
        public bool IsBluetooth { get; set; }

        [Required(ErrorMessage = "Choose if the game console has HDMI or not, please!")]
        public bool IsHdmi { get; set; }

        [Required(ErrorMessage = "Enter Dimension, please!")]
        public string Dimension { get; set; }
    }
}
