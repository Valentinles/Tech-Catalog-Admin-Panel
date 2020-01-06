using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TechCatalogAdminPanel.Common.ViewModels;
using TechCatalogAdminPanel.Models;

namespace TechCatalogAdminPanel.Common.Mapper
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            //binding mappings
            this.CreateMap<AirConditioner, AirConditionerBindingModel>();
            this.CreateMap<Coocker, CoockerBindingModel>();
            this.CreateMap<DesktopPc, DesktopPcBindingModel>();
            this.CreateMap<GameConsole, GameConsoleBindingModel>();
            this.CreateMap<Headphone, HeadphoneBindingModel>();
            this.CreateMap<Keyboard, KeyboardBindingModel>();
            this.CreateMap<Laptop, LaptopBindingModel>();
            this.CreateMap<MobilePhone, MobilePhoneBindingModel>();
            this.CreateMap<Monitor, MonitorBindingModel>();
            this.CreateMap<Mouse, MouseBindingModel>();
            this.CreateMap<Refrigerator, RefrigeratorBindingModel>();
            this.CreateMap<Tablet, TabletBindingModel>();
            this.CreateMap<Tv, TvBindingModel>();
            this.CreateMap<WashingMachine, WashingMachineBindingModel>();

            //edit mappings
            this.CreateMap<AirConditioner, AirConditionerEditViewModel>();
            this.CreateMap<Coocker, CoockerEditViewModel>();
            this.CreateMap<DesktopPc, DesktopPcEditViewModel>();
            this.CreateMap<GameConsole, GameConsoleEditViewModel>();
            this.CreateMap<Headphone, HeadphoneEditViewModel>();
            this.CreateMap<Keyboard, KeyboardEditViewModel>();
            this.CreateMap<Laptop, LaptopEditViewModel>();
            this.CreateMap<MobilePhone, MobilePhoneEditViewModel>();
            this.CreateMap<Monitor, MonitorEditViewModel>();
            this.CreateMap<Mouse, MouseEditViewModel>();
            this.CreateMap<Refrigerator, RefrigeratorEditViewModel>();
            this.CreateMap<Tablet, TabletEditViewModel>();
            this.CreateMap<Tv, TvEditViewModel>();
            this.CreateMap<WashingMachine, WashingMachineEditViewModel>();

            //listing mappings
            this.CreateMap<AirConditioner, DeviceListingViewModel>();
            this.CreateMap<Coocker, DeviceListingViewModel>();
            this.CreateMap<DesktopPc, DeviceListingViewModel>();
            this.CreateMap<GameConsole, DeviceListingViewModel>();
            this.CreateMap<Headphone, DeviceListingViewModel>();
            this.CreateMap<Keyboard, DeviceListingViewModel>();
            this.CreateMap<Laptop, DeviceListingViewModel>();
            this.CreateMap<MobilePhone, DeviceListingViewModel>();
            this.CreateMap<Monitor, DeviceListingViewModel>();
            this.CreateMap<Mouse, DeviceListingViewModel>();
            this.CreateMap<Refrigerator, DeviceListingViewModel>();
            this.CreateMap<Tablet, DeviceListingViewModel>();
            this.CreateMap<Tv, DeviceListingViewModel>();
            this.CreateMap<WashingMachine, DeviceListingViewModel>();

        }
    }
}
