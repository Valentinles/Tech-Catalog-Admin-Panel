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
            this.CreateMap<AirConditioner, AirConditionerBindingModel>().ReverseMap();
            this.CreateMap<Cooker, CookerBindingModel>().ReverseMap();
            this.CreateMap<DesktopPc, DesktopPcBindingModel>().ReverseMap();
            this.CreateMap<GameConsole, GameConsoleBindingModel>().ReverseMap();
            this.CreateMap<Headphone, HeadphoneBindingModel>().ReverseMap();
            this.CreateMap<Keyboard, KeyboardBindingModel>().ReverseMap();
            this.CreateMap<Laptop, LaptopBindingModel>().ReverseMap();
            this.CreateMap<MobilePhone, MobilePhoneBindingModel>().ReverseMap();
            this.CreateMap<Monitor, MonitorBindingModel>().ReverseMap();
            this.CreateMap<Mouse, MouseBindingModel>().ReverseMap();
            this.CreateMap<Refrigerator, RefrigeratorBindingModel>().ReverseMap();
            this.CreateMap<Tablet, TabletBindingModel>().ReverseMap();
            this.CreateMap<Tv, TvBindingModel>().ReverseMap();
            this.CreateMap<WashingMachine, WashingMachineBindingModel>().ReverseMap();

            //edit mappings
            this.CreateMap<AirConditioner, AirConditionerEditViewModel>().ReverseMap();
            this.CreateMap<Cooker, CookerEditViewModel>().ReverseMap();
            this.CreateMap<DesktopPc, DesktopPcEditViewModel>().ReverseMap();
            this.CreateMap<GameConsole, GameConsoleEditViewModel>().ReverseMap();
            this.CreateMap<Headphone, HeadphoneEditViewModel>().ReverseMap();
            this.CreateMap<Keyboard, KeyboardEditViewModel>().ReverseMap();
            this.CreateMap<Laptop, LaptopEditViewModel>().ReverseMap();
            this.CreateMap<MobilePhone, MobilePhoneEditViewModel>().ReverseMap();
            this.CreateMap<Monitor, MonitorEditViewModel>().ReverseMap();
            this.CreateMap<Mouse, MouseEditViewModel>().ReverseMap();
            this.CreateMap<Refrigerator, RefrigeratorEditViewModel>().ReverseMap();
            this.CreateMap<Tablet, TabletEditViewModel>().ReverseMap();
            this.CreateMap<Tv, TvEditViewModel>().ReverseMap();
            this.CreateMap<WashingMachine, WashingMachineEditViewModel>().ReverseMap();

            //listing mappings
            this.CreateMap<AirConditioner, DeviceListingViewModel>();
            this.CreateMap<Cooker, DeviceListingViewModel>();
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

            //history
            this.CreateMap<History, HistoryListingViewModel>();
        }
    }
}
