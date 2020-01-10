using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechCatalogAdminPanel.Common.ViewModels;
using TechCatalogAdminPanel.Data;
using TechCatalogAdminPanel.Models;
using TechCatalogAdminPanel.Services.Interfaces;

namespace TechCatalogAdminPanel.Services.Implementations
{
    public class DeviceService : DataService, IDeviceService
    {
        public readonly IMapper mapper;
        public DeviceService(TechCatalogDbContext context, IMapper mapper) : base(context)
        {
            this.mapper = mapper;
        }

        //air conditioner
        public async Task AddAirConditioner(AirConditionerBindingModel model)
        {
            var airConditioner = mapper.Map<AirConditioner>(model);

            var history = new History();
            history.Text = "Air Conditioner has been added.";
            history.CreatedOn = DateTime.Now;

            await this.context.AddAsync(airConditioner);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteAirConditioner(int id)
        {
            var airConditioner = await this.context.AirConditioners.FirstOrDefaultAsync(ac => ac.Id == id);

            if (airConditioner == null)
            {
                return;
            }

            var history = new History();
            history.Text = "Air Conditioner has been deleted.";
            history.CreatedOn = DateTime.Now;

            this.context.AirConditioners.Remove(airConditioner);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task EditAirConditioner(AirConditionerEditViewModel model)
        {
            var airConditioner = await this.context.AirConditioners.FirstOrDefaultAsync(c => c.Id == model.Id);

            if (airConditioner == null)
            {
                return;
            }

            airConditioner.Id = model.Id;
            airConditioner.Brand = model.Brand;
            airConditioner.DeviceModel = model.DeviceModel;
            airConditioner.Color = model.Color;
            airConditioner.Image = model.Image;
            airConditioner.Weight = model.Weight;
            airConditioner.Warranty = model.Warranty;
            airConditioner.Price = model.Price;
            airConditioner.CapacityCooling = model.CapacityCooling;
            airConditioner.CapacityHeating = model.CapacityHeating;
            airConditioner.PowerConsumptionCooling = model.PowerConsumptionCooling;
            airConditioner.PowerConsumptionHeating = model.PowerConsumptionHeating;
            airConditioner.IsInverterMotor = model.IsInverterMotor;
            airConditioner.EnergyClassCooling = model.EnergyClassCooling;
            airConditioner.EnergyClassHeating = model.EnergyClassHeating;
            airConditioner.IsRemoteControl = model.IsRemoteControl;
            airConditioner.NoiseLevelInsideUnit = model.NoiseLevelInsideUnit;
            airConditioner.NoiseLevelOutsideUnit = model.NoiseLevelOutsideUnit;

            var history = new History();
            history.Text = "Air Conditioner has been edited.";
            history.CreatedOn = DateTime.Now;

            this.context.AirConditioners.Update(airConditioner);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<AirConditioner>> GetAllAirConditioners()
        {
            var airConditioners = await this.context.AirConditioners.ToListAsync();

            return airConditioners;
        }

        public async Task<AirConditioner> GetAirConditionerById(int id)
        {
            var airConditioner = await this.context.AirConditioners
                .FirstOrDefaultAsync(a => a.Id == id);

            return airConditioner;
        }

        //coocker
        public async Task AddCoocker(CoockerBindingModel model)
        {
            var coocker = mapper.Map<Coocker>(model);

            var history = new History();
            history.Text = "Coocker has been added.";
            history.CreatedOn = DateTime.Now;

            await this.context.AddAsync(coocker);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteCoocker(int id)
        {
            var cooker = await this.context.Coockers.FirstOrDefaultAsync(c => c.Id == id);

            if (cooker == null)
            {
                return;
            }

            var history = new History();
            history.Text = "Coocker has been deleted.";
            history.CreatedOn = DateTime.Now;

            this.context.Coockers.Remove(cooker);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task EditCoocker(CoockerEditViewModel model)
        {
            var coocker = await this.context.Coockers.FirstOrDefaultAsync(c => c.Id == model.Id);

            if (coocker == null)
            {
                return;
            }

            coocker.Id = model.Id;
            coocker.Brand = model.Brand;
            coocker.DeviceModel = model.DeviceModel;
            coocker.Color = model.Color;
            coocker.Image = model.Image;
            coocker.Weight = model.Weight;
            coocker.Warranty = model.Warranty;
            coocker.Price = model.Price;
            coocker.EnergyClass = model.EnergyClass;
            coocker.Volume = model.Volume;
            coocker.NumberOfFunctions = model.NumberOfFunctions;
            coocker.IsTimer = model.IsTimer;
            coocker.IsProgrammer = model.IsProgrammer;
            coocker.IsCatalicPanel = model.IsCatalicPanel;

            var history = new History();
            history.Text = "Coocker has been edited.";
            history.CreatedOn = DateTime.Now;

            this.context.Coockers.Update(coocker);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Coocker>> GetAllCoockers()
        {
            var coockers = await this.context.Coockers.ToListAsync();

            return coockers;
        }

        public async Task<Coocker> GetCoockerById(int id)
        {
            var coocker = await this.context.Coockers
                .FirstOrDefaultAsync(a => a.Id == id);

            return coocker;
        }

        //desktop pc
        public async Task AddDesktopPc(DesktopPcBindingModel model)
        {
            var desktopPc = mapper.Map<DesktopPc>(model);

            var history = new History();
            history.Text = "Desktop PC has been added.";
            history.CreatedOn = DateTime.Now;

            await this.context.AddAsync(desktopPc);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteDesktopPc(int id)
        {
            var desktopPc = await this.context.DesktopPcs.FirstOrDefaultAsync(d => d.Id == id);

            if (desktopPc == null) 
            {
                return;
            }

            var history = new History();
            history.Text = "Desktop PC has been deleted.";
            history.CreatedOn = DateTime.Now;

            this.context.DesktopPcs.Remove(desktopPc);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task EditDesktopPc(DesktopPcEditViewModel model)
        {
            var desktopPc = await this.context.DesktopPcs.FirstOrDefaultAsync(c => c.Id == model.Id);

            if (desktopPc == null)
            {
                return;
            }

            desktopPc.Id = model.Id;
            desktopPc.Brand = model.Brand;
            desktopPc.DeviceModel = model.DeviceModel;
            desktopPc.Color = model.Color;
            desktopPc.Image = model.Image;
            desktopPc.Weight = model.Weight;
            desktopPc.Warranty = model.Warranty;
            desktopPc.Price = model.Price;
            desktopPc.Ram = model.Ram;
            desktopPc.Hdd = model.Hdd;
            desktopPc.Ssd = model.Ssd;
            desktopPc.Processor = model.Processor;
            desktopPc.ProcessorSpeed = model.ProcessorSpeed;
            desktopPc.VideoCard = model.VideoCard;
            desktopPc.VideoCardMemory = model.VideoCardMemory;
            desktopPc.Case = model.Case;
            desktopPc.IsBluetooth = model.IsBluetooth;

            var history = new History();
            history.Text = "Desktop PC has been edited.";
            history.CreatedOn = DateTime.Now;

            this.context.DesktopPcs.Update(desktopPc);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<DesktopPc>> GetAllDesktopPcs()
        {
            var desktopPcs = await this.context.DesktopPcs.ToListAsync();

            return desktopPcs;
        }

        public async Task<DesktopPc> GetDesktopPcById(int id)
        {
            var desktopPc = await this.context.DesktopPcs
                .FirstOrDefaultAsync(d => d.Id == id);

            return desktopPc;
        }

        //game console
        public async Task AddGameConsole(GameConsoleBindingModel model)
        {
            var gameConsole = mapper.Map<GameConsole>(model);

            var history = new History();
            history.Text = "Game Console has been added.";
            history.CreatedOn = DateTime.Now;

            await this.context.AddAsync(gameConsole);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteGameConsole(int id)
        {
            var gameConsole = await this.context.GameConsoles.FirstOrDefaultAsync(g => g.Id == id);

            if (gameConsole == null) 
            {
                return;
            }

            var history = new History();
            history.Text = "Game Console has been deleted.";
            history.CreatedOn = DateTime.Now;

            this.context.GameConsoles.Remove(gameConsole);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task EditGameConsole(GameConsoleEditViewModel model)
        {
            var gameConsole = await this.context.GameConsoles.FirstOrDefaultAsync(c => c.Id == model.Id);

            if (gameConsole == null)
            {
                return;
            }

            gameConsole.Id = model.Id;
            gameConsole.Brand = model.Brand;
            gameConsole.DeviceModel = model.DeviceModel;
            gameConsole.Color = model.Color;
            gameConsole.Image = model.Image;
            gameConsole.Weight = model.Weight;
            gameConsole.Warranty = model.Warranty;
            gameConsole.Price = model.Price;
            gameConsole.Hdd = model.Hdd;
            gameConsole.Processor = model.Processor;
            gameConsole.VideoCard = model.VideoCard;
            gameConsole.Ram = model.Ram;
            gameConsole.IsBluetooth = model.IsBluetooth;
            gameConsole.IsHdmi = model.IsHdmi;
            gameConsole.Dimension = model.Dimension;

            var history = new History();
            history.Text = "Game Console has been edited.";
            history.CreatedOn = DateTime.Now;

            this.context.GameConsoles.Update(gameConsole);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<GameConsole>> GetAllGameConsoles()
        {
            var gameConsoles = await this.context.GameConsoles.ToListAsync();

            return gameConsoles;
        }

        public async Task<GameConsole> GetGameConsoleById(int id)
        {
            var gameConsole = await this.context.GameConsoles
                .FirstOrDefaultAsync(g => g.Id == id);

            return gameConsole;
        }

        //headphone
        public async Task AddHeadphone(HeadphoneBindingModel model)
        {
            var headphone = mapper.Map<Headphone>(model);

            var history = new History();
            history.Text = "Headphone has been added.";
            history.CreatedOn = DateTime.Now;

            await this.context.AddAsync(headphone);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteHeadphone(int id)
        {
            var headphone = await this.context.Headphones.FirstOrDefaultAsync(h => h.Id == id);

            if (headphone == null) 
            {
                return;
            }

            var history = new History();
            history.Text = "Headphone has been deleted.";
            history.CreatedOn = DateTime.Now;

            this.context.Headphones.Remove(headphone);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task EditHeadphone(HeadphoneEditViewModel model)
        {
            var headphone = await this.context.Headphones.FirstOrDefaultAsync(c => c.Id == model.Id);

            if (headphone == null)
            {
                return;
            }

            headphone.Id = model.Id;
            headphone.Brand = model.Brand;
            headphone.DeviceModel = model.DeviceModel;
            headphone.Color = model.Color;
            headphone.Image = model.Image;
            headphone.Weight = model.Weight;
            headphone.Warranty = model.Warranty;
            headphone.Price = model.Price;
            headphone.Type = model.Type;
            headphone.FrequencyRange = model.FrequencyRange;
            headphone.Impedance = model.Impedance;
            headphone.IsMicrophone = model.IsMicrophone;
            headphone.IsSoundControl = model.IsSoundControl;
            headphone.Interface = model.Interface;
            headphone.CableLength = model.CableLength;

            var history = new History();
            history.Text = "Headphone has been edited.";
            history.CreatedOn = DateTime.Now;

            this.context.Headphones.Update(headphone);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Headphone>> GetAllHeadphones()
        {
            var headphones = await this.context.Headphones.ToListAsync();

            return headphones;
        }

        public async Task<Headphone> GetHeadphoneById(int id)
        {
            var headphone = await this.context.Headphones
                .FirstOrDefaultAsync(h => h.Id == id);

            return headphone;
        }

        //keyboard
        public async Task AddKeyboard(KeyboardBindingModel model)
        {
            var keyboard = mapper.Map<Keyboard>(model);

            var history = new History();
            history.Text = "Keyboard has been added.";
            history.CreatedOn = DateTime.Now;

            await this.context.AddAsync(keyboard);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteKeyboard(int id)
        {
            var keyboard = await this.context.Keyboards.FirstOrDefaultAsync(k => k.Id == id);

            if (keyboard == null)
            {
                return;
            }

            var history = new History();
            history.Text = "Keyboard has been deleted.";
            history.CreatedOn = DateTime.Now;

            this.context.Keyboards.Remove(keyboard);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task EditKeyboard(KeyboardEditViewModel model)
        {
            var keyboard = await this.context.Keyboards.FirstOrDefaultAsync(c => c.Id == model.Id);

            if (keyboard == null)
            {
                return;
            }

            keyboard.Id = model.Id;
            keyboard.Brand = model.Brand;
            keyboard.DeviceModel = model.DeviceModel;
            keyboard.Color = model.Color;
            keyboard.Image = model.Image;
            keyboard.Weight = model.Weight;
            keyboard.Warranty = model.Warranty;
            keyboard.Price = model.Price;
            keyboard.IsFastButtons = model.IsFastButtons;
            keyboard.Interface = model.Interface;

            var history = new History();
            history.Text = "Keyboard has been edited.";
            history.CreatedOn = DateTime.Now;

            this.context.Keyboards.Update(keyboard);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Keyboard>> GetAllKeyboards()
        {
            var keyboards = await this.context.Keyboards.ToListAsync();

            return keyboards;
        }

        public async Task<Keyboard> GetKeyboardById(int id)
        {
            var keyboard = await this.context.Keyboards
                .FirstOrDefaultAsync(k => k.Id == id);

            return keyboard;
        }

        //laptop
        public async Task AddLaptop(LaptopBindingModel model)
        {
            var laptop = mapper.Map<Laptop>(model);

            var history = new History();
            history.Text = "Laptop has been added.";
            history.CreatedOn = DateTime.Now;

            await this.context.AddAsync(laptop);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteLaptop(int id)
        {
            var laptop = await this.context.Laptops.FirstOrDefaultAsync(l => l.Id == id);

            if (laptop == null)
            {
                return;
            }

            var history = new History();
            history.Text = "Laptop has been deleted.";
            history.CreatedOn = DateTime.Now;

            this.context.Laptops.Remove(laptop);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task EditLaptop(LaptopEditViewModel model)
        {
            var laptop = await this.context.Laptops.FirstOrDefaultAsync(c => c.Id == model.Id);

            if (laptop == null)
            {
                return;
            }

            laptop.Id = model.Id;
            laptop.Brand = model.Brand;
            laptop.DeviceModel = model.DeviceModel;
            laptop.Color = model.Color;
            laptop.Image = model.Image;
            laptop.Weight = model.Weight;
            laptop.Warranty = model.Warranty;
            laptop.Price = model.Price;
            laptop.Ram = model.Ram;
            laptop.Hdd = model.Hdd;
            laptop.Ssd = model.Ssd;
            laptop.Processor = model.Processor;
            laptop.ProcessorSpeed = model.ProcessorSpeed;
            laptop.VideoCard = model.VideoCard;
            laptop.VideoCardMemory = model.VideoCardMemory;
            laptop.DisplayType = model.DisplayType;
            laptop.RefreshRate = model.RefreshRate;
            laptop.DisplaySizeInch = model.DisplaySizeInch;
            laptop.Resolution = model.Resolution;
            laptop.WirelessAdapter = model.WirelessAdapter;
            laptop.NumberOfUsbPorts = model.NumberOfUsbPorts;
            laptop.IsHdmi = model.IsHdmi;
            laptop.IsBluetooth = model.IsBluetooth;
            laptop.Battery = model.Battery;
            laptop.OperatingSystemOs = model.OperatingSystemOs;

            var history = new History();
            history.Text = "Laptop has been edited.";
            history.CreatedOn = DateTime.Now;

            this.context.Laptops.Update(laptop);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Laptop>> GetAllLaptops()
        {
            var laptops = await this.context.Laptops.ToListAsync();

            return laptops;
        }

        public async Task<Laptop> GetLaptopById(int id)
        {
            var laptop = await this.context.Laptops
                .FirstOrDefaultAsync(l => l.Id == id);

            return laptop;
        }

        //mobile phone
        public async Task AddMobilePhone(MobilePhoneBindingModel model)
        {
            var mobilePhone = mapper.Map<MobilePhone>(model);

            var history = new History();
            history.Text = "Mobile phone has been added.";
            history.CreatedOn = DateTime.Now;

            await this.context.AddAsync(mobilePhone);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteMobilePhone(int id)
        {
            var mobilePhone = await this.context.MobilePhones.FirstOrDefaultAsync(m => m.Id == id);

            if (mobilePhone == null)
            {
                return;
            }

            var history = new History();
            history.Text = "Mobile phone has been deleted.";
            history.CreatedOn = DateTime.Now;

            this.context.MobilePhones.Remove(mobilePhone);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task EditMobilePhone(MobilePhoneEditViewModel model)
        {
            var mobilePhone = await this.context.MobilePhones.FirstOrDefaultAsync(c => c.Id == model.Id);

            if (mobilePhone == null)
            {
                return;
            }

            mobilePhone.Id = model.Id;
            mobilePhone.Brand = model.Brand;
            mobilePhone.DeviceModel = model.DeviceModel;
            mobilePhone.Color = model.Color;
            mobilePhone.Image = model.Image;
            mobilePhone.Weight = model.Weight;
            mobilePhone.Warranty = model.Warranty;
            mobilePhone.Price = model.Price;
            mobilePhone.Processor = model.Processor;
            mobilePhone.DisplaySizeInch = model.DisplaySizeInch;
            mobilePhone.DisplayType = model.DisplayType;
            mobilePhone.Resolution = model.Resolution;
            mobilePhone.Memory = model.Memory;
            mobilePhone.Ram = model.Ram;
            mobilePhone.RearCameraResolution = model.RearCameraResolution;
            mobilePhone.FrontCameraResolution = model.FrontCameraResolution;
            mobilePhone.IsBluetooth = model.IsBluetooth;
            mobilePhone.Battery = model.Battery;
            mobilePhone.MobileOs = model.MobileOs;

            var history = new History();
            history.Text = "Mobile phone has been edited.";
            history.CreatedOn = DateTime.Now;

            this.context.MobilePhones.Update(mobilePhone);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<MobilePhone>> GetAllMobilePhones()
        {
            var mobilePhones = await this.context.MobilePhones.ToListAsync();

            return mobilePhones;
        }

        public async Task<MobilePhone> GetMobilePhoneById(int id)
        {
            var mobilePhone = await this.context.MobilePhones
                .FirstOrDefaultAsync(m => m.Id == id);

            return mobilePhone;
        }

        //monitor
        public async Task AddMonitor(MonitorBindingModel model)
        {
            var monitor = mapper.Map<Monitor>(model);

            var history = new History();
            history.Text = "Monitor has been added.";
            history.CreatedOn = DateTime.Now;

            await this.context.AddAsync(monitor);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteMonitor(int id)
        {
            var monitor = await this.context.Monitors.FirstOrDefaultAsync(m => m.Id == id);

            if (monitor == null)
            {
                return;
            }

            var history = new History();
            history.Text = "Monitor has been deleted.";
            history.CreatedOn = DateTime.Now;

            this.context.Monitors.Remove(monitor);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task EditMonitor(MonitorEditViewModel model)
        {
            var monitor = await this.context.Monitors.FirstOrDefaultAsync(c => c.Id == model.Id);

            if (monitor == null)
            {
                return;
            }

            monitor.Id = model.Id;
            monitor.Brand = model.Brand;
            monitor.DeviceModel = model.DeviceModel;
            monitor.Color = model.Color;
            monitor.Image = model.Image;
            monitor.Weight = model.Weight;
            monitor.Warranty = model.Warranty;
            monitor.Price = model.Price;
            monitor.Contrast = model.Contrast;
            monitor.DisplayType = model.DisplayType;
            monitor.DisplaySizeInch = model.DisplaySizeInch;
            monitor.RefreshRate = model.RefreshRate;
            monitor.Resolution = model.Resolution;
            monitor.Dimension = model.Dimension;

            var history = new History();
            history.Text = "Monitor has been edited.";
            history.CreatedOn = DateTime.Now;

            this.context.Monitors.Update(monitor);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Monitor>> GetAllMonitors()
        {
            var monitors = await this.context.Monitors.ToListAsync();

            return monitors;
        }

        public async Task<Monitor> GetMonitorById(int id)
        {
            var monitor = await this.context.Monitors
                .FirstOrDefaultAsync(m => m.Id == id);

            return monitor;
        }

        //mouse
        public async Task AddMouse(MouseBindingModel model)
        {
            var mouse = mapper.Map<Mouse>(model);

            var history = new History();
            history.Text = "Mouse has been added.";
            history.CreatedOn = DateTime.Now;

            await this.context.AddAsync(mouse);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteMouse(int id)
        {
            var mouse = await this.context.Mice.FirstOrDefaultAsync(m => m.Id == id);

            if (mouse == null)
            {
                return;
            }

            var history = new History();
            history.Text = "Mouse has been deleted.";
            history.CreatedOn = DateTime.Now;

            this.context.Mice.Remove(mouse);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task EditMouse(MouseEditViewModel model)
        {
            var mouse = await this.context.Mice.FirstOrDefaultAsync(c => c.Id == model.Id);

            if (mouse == null)
            {
                return;
            }

            mouse.Id = model.Id;
            mouse.Brand = model.Brand;
            mouse.DeviceModel = model.DeviceModel;
            mouse.Color = model.Color;
            mouse.Image = model.Image;
            mouse.Weight = model.Weight;
            mouse.Warranty = model.Warranty;
            mouse.Price = model.Price;
            mouse.ResolutionDpi = model.ResolutionDpi;
            mouse.IsScrollButton = model.IsScrollButton;
            mouse.IsErgonomic = model.IsErgonomic;
            mouse.Interface = model.Interface;

            var history = new History();
            history.Text = "Mouse has been edited.";
            history.CreatedOn = DateTime.Now;

            this.context.Mice.Update(mouse);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Mouse>> GetAllMice()
        {
            var mice = await this.context.Mice.ToListAsync();

            return mice;
        }

        public async Task<Mouse> GetMouseById(int id)
        {
            var mouse = await this.context.Mice
                .FirstOrDefaultAsync(m => m.Id == id);

            return mouse;
        }

        //refrigerator
        public async Task AddRefrigerator(RefrigeratorBindingModel model)
        {
            var refrigerator = mapper.Map<Refrigerator>(model);

            var history = new History();
            history.Text = "Refrigerator has been added.";
            history.CreatedOn = DateTime.Now;

            await this.context.AddAsync(refrigerator);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteRefrigerator(int id)
        {
            var refrigerator = await this.context.Refrigerators.FirstOrDefaultAsync(r => r.Id == id);

            if (refrigerator == null) 
            {
                return;
            }

            var history = new History();
            history.Text = "Refrigerator has been deleted.";
            history.CreatedOn = DateTime.Now;

            this.context.Refrigerators.Remove(refrigerator);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task EditRefrigerator(RefrigeratorEditViewModel model)
        {
            var refrigerator = await this.context.Refrigerators.FirstOrDefaultAsync(c => c.Id == model.Id);

            if (refrigerator == null)
            {
                return;
            }

            refrigerator.Id = model.Id;
            refrigerator.Brand = model.Brand;
            refrigerator.DeviceModel = model.DeviceModel;
            refrigerator.Color = model.Color;
            refrigerator.Image = model.Image;
            refrigerator.Weight = model.Weight;
            refrigerator.Warranty = model.Warranty;
            refrigerator.Price = model.Price;
            refrigerator.EnergyClass = model.EnergyClass;
            refrigerator.Height = model.Height;
            refrigerator.Width = model.Width;
            refrigerator.Depth = model.Depth;
            refrigerator.TotalCapacity = model.TotalCapacity;
            refrigerator.CapacityRefrigerator = model.CapacityRefrigerator;
            refrigerator.CapacityFreezer = model.CapacityFreezer;
            refrigerator.NumberOfShelves = model.NumberOfShelves;
            refrigerator.NoiseLevel = model.NoiseLevel;

            var history = new History();
            history.Text = "Refrigerator has been edited.";
            history.CreatedOn = DateTime.Now;

            this.context.Refrigerators.Update(refrigerator);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Refrigerator>> GetAllRefrigerators()
        {
            var refrigerators = await this.context.Refrigerators.ToListAsync();

            return refrigerators;
        }

        public async Task<Refrigerator> GetRefrigeratorById(int id)
        {
            var refrigerator = await this.context.Refrigerators
                .FirstOrDefaultAsync(a => a.Id == id);

            return refrigerator;
        }

        //tablet
        public async Task AddTablet(TabletBindingModel model)
        {
            var tablet = mapper.Map<Tablet>(model);

            var history = new History();
            history.Text = "Tablet has been added.";
            history.CreatedOn = DateTime.Now;

            await this.context.AddAsync(tablet);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteTablet(int id)
        {
            var tablet = await this.context.Tablets.FirstOrDefaultAsync(t => t.Id == id);

            if (tablet == null)
            {
                return;
            }

            var history = new History();
            history.Text = "Tablet has been deleted.";
            history.CreatedOn = DateTime.Now;

            this.context.Tablets.Remove(tablet);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task EditTablet(TabletEditViewModel model)
        {
            var tablet = await this.context.Tablets.FirstOrDefaultAsync(c => c.Id == model.Id);

            if (tablet == null)
            {
                return;
            }

            tablet.Id = model.Id;
            tablet.Brand = model.Brand;
            tablet.DeviceModel = model.DeviceModel;
            tablet.Color = model.Color;
            tablet.Image = model.Image;
            tablet.Weight = model.Weight;
            tablet.Warranty = model.Warranty;
            tablet.Price = model.Price;
            tablet.Processor = model.Processor;
            tablet.DisplaySizeInch = model.DisplaySizeInch;
            tablet.DisplayType = model.DisplayType;
            tablet.Resolution = model.Resolution;
            tablet.Memory = model.Memory;
            tablet.Ram = model.Ram;
            tablet.RearCameraResolution = model.RearCameraResolution;
            tablet.FrontCameraResolution = model.FrontCameraResolution;
            tablet.IsBluetooth = model.IsBluetooth;
            tablet.Battery = model.Battery;
            tablet.MobileOs = model.MobileOs;

            var history = new History();
            history.Text = "Tablet has been edited.";
            history.CreatedOn = DateTime.Now;

            this.context.Tablets.Update(tablet);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Tablet>> GetAllTablets()
        {
            var tablets = await this.context.Tablets.ToListAsync();

            return tablets;
        }

        public async Task<Tablet> GetTabletById(int id)
        {
            var tablet = await this.context.Tablets
                .FirstOrDefaultAsync(t => t.Id == id);

            return tablet;
        }

        //tv
        public async Task AddTv(TvBindingModel model)
        {
            var tv = mapper.Map<Tv>(model);

            var history = new History();
            history.Text = "TV has been added.";
            history.CreatedOn = DateTime.Now;

            await this.context.AddAsync(tv);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteTv(int id)
        {
            var tv = await this.context.Tvs.FirstOrDefaultAsync(t => t.Id == id);

            if (tv == null) 
            {
                return;
            }

            var history = new History();
            history.Text = "TV has been deleted.";
            history.CreatedOn = DateTime.Now;

            this.context.Tvs.Remove(tv);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task EditTv(TvEditViewModel model)
        {
            var tv = await this.context.Tvs.FirstOrDefaultAsync(c => c.Id == model.Id);

            if (tv == null)
            {
                return;
            }

            tv.Id = model.Id;
            tv.Brand = model.Brand;
            tv.DeviceModel = model.DeviceModel;
            tv.Color = model.Color;
            tv.Image = model.Image;
            tv.Weight = model.Weight;
            tv.Warranty = model.Warranty;
            tv.Price = model.Price;
            tv.Resolution = model.Resolution;
            tv.ScreenTechnology = model.ScreenTechnology;
            tv.DisplaySizeInch = model.DisplaySizeInch;
            tv.IsVoiceControl = model.IsVoiceControl;
            tv.IsSmartTv = model.IsSmartTv;

            var history = new History();
            history.Text = "TV has been edited.";
            history.CreatedOn = DateTime.Now;

            this.context.Tvs.Update(tv);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Tv>> GetAllTvs()
        {
            var Tvs = await this.context.Tvs.ToListAsync();

            return Tvs;
        }

        public async Task<Tv> GetTvById(int id)
        {
            var tv = await this.context.Tvs
                .FirstOrDefaultAsync(t => t.Id == id);

            return tv;
        }

        //washing machine
        public async Task AddWashingMachine(WashingMachineBindingModel model)
        {
            var washingMachine = mapper.Map<WashingMachine>(model);

            var history = new History();
            history.Text = "Washing Machine has been added.";
            history.CreatedOn = DateTime.Now;

            await this.context.AddAsync(washingMachine);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteWashingMachine(int id)
        {
            var washingMachine = await this.context.WashingMachines.FirstOrDefaultAsync(w => w.Id == id);

            if (washingMachine == null)
            {
                return;
            }

            var history = new History();
            history.Text = "Washing Machine has been deleted.";
            history.CreatedOn = DateTime.Now;

            this.context.WashingMachines.Remove(washingMachine);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task EditWashingMachine(WashingMachineEditViewModel model)
        {
            var washingMachine = await this.context.WashingMachines.FirstOrDefaultAsync(c => c.Id == model.Id);

            if (washingMachine == null)
            {
                return;
            }

            washingMachine.Id = model.Id;
            washingMachine.Brand = model.Brand;
            washingMachine.DeviceModel = model.DeviceModel;
            washingMachine.Color = model.Color;
            washingMachine.Image = model.Image;
            washingMachine.Weight = model.Weight;
            washingMachine.Warranty = model.Warranty;
            washingMachine.Price = model.Price;
            washingMachine.EnergyClass = model.EnergyClass;
            washingMachine.WashingCapacity = model.WashingCapacity;
            washingMachine.EnergyConsumption = model.EnergyConsumption;
            washingMachine.WaterConsumption = model.WaterConsumption;
            washingMachine.IsDisplay = model.IsDisplay;
            washingMachine.ProgrammesNumber = model.ProgrammesNumber;
            washingMachine.Height = model.Height;
            washingMachine.Width = model.Width;
            washingMachine.Depth = model.Depth;
            washingMachine.IsWoolProgram = model.IsWoolProgram;
            washingMachine.IsQuickWash = model.IsQuickWash;

            var history = new History();
            history.Text = "Washing Machine has been edited.";
            history.CreatedOn = DateTime.Now;

            this.context.WashingMachines.Update(washingMachine);
            await this.context.Histories.AddAsync(history);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<WashingMachine>> GetAllWashingMachines()
        {
            var washingMachines = await this.context.WashingMachines.ToListAsync();

            return washingMachines;
        }

        public async Task<WashingMachine> GetWashingMachineById(int id)
        {
            var washingMachine = await this.context.WashingMachines
                .FirstOrDefaultAsync(w => w.Id == id);

            return washingMachine;
        }
    }
}
