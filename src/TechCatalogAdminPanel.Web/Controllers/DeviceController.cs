using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechCatalogAdminPanel.Common.ViewModels;
using TechCatalogAdminPanel.Services.Interfaces;

namespace TechCatalogAdminPanel.Web.Controllers
{
    public class DeviceController : Controller
    {
        private readonly IDeviceService deviceService;
        private readonly IMapper mapper;

        public DeviceController(IDeviceService deviceService, IMapper mapper)
        {
            this.deviceService = deviceService;
            this.mapper = mapper;
        }

        //air conditioner
        [HttpGet]
        public IActionResult AddAirConditioner()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAirConditioner(AirConditionerBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            await this.deviceService.AddAirConditioner(model);

            return RedirectToAction("AllAirConditioners", "Device");
        }

        public async Task<IActionResult> AllAirConditioners()
        {
            var airConditioners = (await this.deviceService.GetAllAirConditioners())
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(airConditioners);
        }

        public async Task<IActionResult> DeleteAirConditioner(int id)
        {
            await this.deviceService.DeleteAirConditioner(id);

            return RedirectToAction("AllAirConditioners", "Device");
        }

        [HttpGet]
        public async Task<IActionResult> EditAirConditioner(int id)
        {
            var getAirConditioner = await this.deviceService.GetAirConditionerById(id);

            var airConditioner = mapper.Map<AirConditionerEditViewModel>(getAirConditioner);            

            if (airConditioner == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(airConditioner);
        }

        [HttpPost]
        public async Task<IActionResult> EditAirConditioner(AirConditionerEditViewModel model)
        {
            await this.deviceService.EditAirConditioner(model);

            return RedirectToAction("AllAirConditioners", "Device");
        }

        //coocker
        [HttpGet]
        public IActionResult AddCoocker()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCoocker(CoockerBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            await this.deviceService.AddCoocker(model);

            return RedirectToAction("AllCoockers", "Device");
        }

        public async Task<IActionResult> AllCoockers()
        {
            var coockers = (await this.deviceService.GetAllCoockers())
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(coockers);
        }

        public async Task<IActionResult> DeleteCoocker(int id)
        {
            await this.deviceService.DeleteCoocker(id);

            return RedirectToAction("AllCoockers", "Device");
        }

        [HttpGet]
        public async Task<IActionResult> EditCoocker(int id)
        {
            var getCoocker = await this.deviceService.GetCoockerById(id);

            var coocker = mapper.Map<CoockerEditViewModel>(getCoocker);

            if (getCoocker == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(coocker);
        }

        [HttpPost]
        public async Task<IActionResult> EditCoocker(CoockerEditViewModel model)
        {
            await this.deviceService.EditCoocker(model);

            return RedirectToAction("AllCoockers", "Device");
        }

        //desktop pc
        [HttpGet]
        public IActionResult AddDesktopPc()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddDesktopPc(DesktopPcBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            await this.deviceService.AddDesktopPc(model);

            return RedirectToAction("AllDesktopPcs", "Device");
        }

        public async Task<IActionResult> AllDesktopPcs()
        {
            var desktopPc = (await this.deviceService.GetAllDesktopPcs())
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(desktopPc);
        }

        public async Task<IActionResult> DeleteDesktopPc(int id)
        {
            await this.deviceService.DeleteDesktopPc(id);

            return RedirectToAction("AllDesktopPcs", "Device");
        }

        [HttpGet]
        public async Task<IActionResult> EditDesktopPc(int id)
        {
            var getDesktopPc = await this.deviceService.GetDesktopPcById(id);

            var desktopPc = mapper.Map<DesktopPcEditViewModel>(getDesktopPc);

            if (getDesktopPc == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(desktopPc);
        }

        [HttpPost]
        public async Task<IActionResult> EditDesktopPc(DesktopPcEditViewModel model)
        {
            await this.deviceService.EditDesktopPc(model);

            return RedirectToAction("AllDesktopPcs", "Device");
        }

        //game console
        [HttpGet]
        public IActionResult AddGameConsole()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddGameConsole(GameConsoleBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            await this.deviceService.AddGameConsole(model);

            return RedirectToAction("AllGameConsoles", "Device");
        }

        public async Task<IActionResult> AllGameConsoles()
        {
            var gameConsoles = (await this.deviceService.GetAllGameConsoles())
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(gameConsoles);
        }

        public async Task<IActionResult> DeleteGameConsole(int id)
        {
            await this.deviceService.DeleteGameConsole(id);

            return RedirectToAction("AllGameConsoles", "Device");
        }

        [HttpGet]
        public async Task<IActionResult> EditGameConsole(int id)
        {
            var getGameConsole = await this.deviceService.GetGameConsoleById(id);

            var gameConsole = mapper.Map<GameConsoleEditViewModel>(getGameConsole);

            if (getGameConsole == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(gameConsole);
        }

        [HttpPost]
        public async Task<IActionResult> EditGameConsole(GameConsoleEditViewModel model)
        {
            await this.deviceService.EditGameConsole(model);

            return RedirectToAction("AllGameConsoles", "Device");
        }

        //headphone
        [HttpGet]
        public IActionResult AddHeadphone()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddHeadphone(HeadphoneBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            await this.deviceService.AddHeadphone(model);

            return RedirectToAction("AllHeadphones", "Device");
        }

        public async Task<IActionResult> AllHeadphones()
        {
            var headphones = (await this.deviceService.GetAllHeadphones())
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(headphones);
        }

        public async Task<IActionResult> DeleteHeadphone(int id)
        {
            await this.deviceService.DeleteHeadphone(id);

            return RedirectToAction("AllHeadphones", "Device");
        }

        [HttpGet]
        public async Task<IActionResult> EditHeadphone(int id)
        {
            var getHeadphone = await this.deviceService.GetHeadphoneById(id);

            var headphone = mapper.Map<HeadphoneEditViewModel>(getHeadphone);

            if (getHeadphone == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(headphone);
        }

        [HttpPost]
        public async Task<IActionResult> EditHeadphone(HeadphoneEditViewModel model)
        {
            await this.deviceService.EditHeadphone(model);

            return RedirectToAction("AllHeadphones", "Device");
        }

        //keyboard
        [HttpGet]
        public IActionResult AddKeyboard()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddKeyboard(KeyboardBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            await this.deviceService.AddKeyboard(model);

            return RedirectToAction("AllKeyboards", "Device");
        }

        public async Task<IActionResult> AllKeyboards()
        {
            var keyboards = (await this.deviceService.GetAllKeyboards())
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(keyboards);
        }

        public async Task<IActionResult> DeleteKeyboard(int id)
        {
            await this.deviceService.DeleteKeyboard(id);

            return RedirectToAction("AllKeyboards", "Device");
        }

        [HttpGet]
        public async Task<IActionResult> EditKeyboard(int id)
        {
            var getKeyboard = await this.deviceService.GetKeyboardById(id);

            var keyboard = mapper.Map<KeyboardEditViewModel>(getKeyboard);

            if (getKeyboard == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(keyboard);
        }

        [HttpPost]
        public async Task<IActionResult> EditKeyboard(KeyboardEditViewModel model)
        {
            await this.deviceService.EditKeyboard(model);

            return RedirectToAction("AllKeyboards", "Device");
        }

        //laptop
        [HttpGet]
        public IActionResult AddLaptop()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddLaptop(LaptopBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            await this.deviceService.AddLaptop(model);

            return RedirectToAction("AllLaptops", "Device");
        }

        public async Task<IActionResult> AllLaptops()
        {
            var laptops = (await this.deviceService.GetAllLaptops())
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(laptops);
        }

        public async Task<IActionResult> DeleteLaptop(int id)
        {
            await this.deviceService.DeleteLaptop(id);

            return RedirectToAction("AllLaptops", "Device");
        }

        [HttpGet]
        public async Task<IActionResult> EditLaptop(int id)
        {
            var getLaptop = await this.deviceService.GetLaptopById(id);

            var laptop = mapper.Map<LaptopEditViewModel>(getLaptop);

            if (getLaptop == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(laptop);
        }

        [HttpPost]
        public async Task<IActionResult> EditLaptop(LaptopEditViewModel model)
        {
            await this.deviceService.EditLaptop(model);

            return RedirectToAction("AllLaptops", "Device");
        }

        //mobile phone
        [HttpGet]
        public IActionResult AddMobilePhone()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddMobilePhone(MobilePhoneBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            await this.deviceService.AddMobilePhone(model);

            return RedirectToAction("AllMobilePhones", "Device");
        }

        public async Task<IActionResult> AllMobilePhones()
        {
            var mobilePhones = (await this.deviceService.GetAllMobilePhones())
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(mobilePhones);
        }

        public async Task<IActionResult> DeleteMobilePhone(int id)
        {
            await this.deviceService.DeleteMobilePhone(id);

            return RedirectToAction("AllMobilePhones", "Device");
        }

        [HttpGet]
        public async Task<IActionResult> EditMobilePhone(int id)
        {
            var getMobilePhone = await this.deviceService.GetMobilePhoneById(id);

            var mobilePhone = mapper.Map<MobilePhoneEditViewModel>(getMobilePhone);

            if (getMobilePhone == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(mobilePhone);
        }

        [HttpPost]
        public async Task<IActionResult> EditMobilePhone(MobilePhoneEditViewModel model)
        {
            await this.deviceService.EditMobilePhone(model);

            return RedirectToAction("AllMobilePhones", "Device");
        }

        //monitor
        [HttpGet]
        public IActionResult AddMonitor()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddMonitor(MonitorBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            await this.deviceService.AddMonitor(model);

            return RedirectToAction("AllMonitors", "Device");
        }

        public async Task<IActionResult> AllMonitors()
        {
            var monitors = (await this.deviceService.GetAllMonitors())
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(monitors);
        }

        public async Task<IActionResult> DeleteMonitor(int id)
        {
            await this.deviceService.DeleteMonitor(id);

            return RedirectToAction("AllMonitors", "Device");
        }

        [HttpGet]
        public async Task<IActionResult> EditMonitor(int id)
        {
            var getMonitor = await this.deviceService.GetMonitorById(id);

            var monitor = mapper.Map<MonitorEditViewModel>(getMonitor);

            if (getMonitor == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(monitor);
        }

        [HttpPost]
        public async Task<IActionResult> EditMonitor(MonitorEditViewModel model)
        {
            await this.deviceService.EditMonitor(model);

            return RedirectToAction("AllMonitors", "Device");
        }

        //mouse
        [HttpGet]
        public IActionResult AddMouse()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddMouse(MouseBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            await this.deviceService.AddMouse(model);

            return RedirectToAction("AllMice", "Device");
        }

        public async Task<IActionResult> AllMice()
        {
            var mice = (await this.deviceService.GetAllMice())
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(mice);
        }

        public async Task<IActionResult> DeleteMouse(int id)
        {
            await this.deviceService.DeleteMouse(id);

            return RedirectToAction("AllMice", "Device");
        }

        [HttpGet]
        public async Task<IActionResult> EditMouse(int id)
        {
            var getMouse = await this.deviceService.GetMouseById(id);

            var mouse = mapper.Map<MouseEditViewModel>(getMouse);

            if (getMouse == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(mouse);
        }

        [HttpPost]
        public async Task<IActionResult> EditMouse(MouseEditViewModel model)
        {
            await this.deviceService.EditMouse(model);

            return RedirectToAction("AllMice", "Device");
        }

        //refrigerator
        [HttpGet]
        public IActionResult AddRefrigerator()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRefrigerator(RefrigeratorBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            await this.deviceService.AddRefrigerator(model);

            return RedirectToAction("AllRefrigerators", "Device");
        }

        public async Task<IActionResult> AllRefrigerators()
        {
            var refrigerators = (await this.deviceService.GetAllRefrigerators())
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(refrigerators);
        }

        public async Task<IActionResult> DeleteRefrigerator(int id)
        {
            await this.deviceService.DeleteRefrigerator(id);

            return RedirectToAction("AllRefrigerators", "Device");
        }

        [HttpGet]
        public async Task<IActionResult> EditRefrigerator(int id)
        {
            var getRefrigerator = await this.deviceService.GetRefrigeratorById(id);

            var refrigerator = mapper.Map<RefrigeratorEditViewModel>(getRefrigerator);

            if (getRefrigerator == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(refrigerator);
        }

        [HttpPost]
        public async Task<IActionResult> EditRefrigerator(RefrigeratorEditViewModel model)
        {
            await this.deviceService.EditRefrigerator(model);

            return RedirectToAction("AllRefrigerators", "Device");
        }

        //tablet
        [HttpGet]
        public IActionResult AddTablet()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTablet(TabletBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            await this.deviceService.AddTablet(model);

            return RedirectToAction("AllTablets", "Device");
        }

        public async Task<IActionResult> AllTablets()
        {
            var tablets = (await this.deviceService.GetAllTablets())
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(tablets);
        }

        public async Task<IActionResult> DeleteTablet(int id)
        {
            await this.deviceService.DeleteTablet(id);

            return RedirectToAction("AllTablets", "Device");
        }

        [HttpGet]
        public async Task<IActionResult> EditTablet(int id)
        {
            var getTablet = await this.deviceService.GetTabletById(id);

            var tablet = mapper.Map<TabletEditViewModel>(getTablet);

            if (getTablet == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(tablet);
        }

        [HttpPost]
        public async Task<IActionResult> EditTablet(TabletEditViewModel model)
        {
            await this.deviceService.EditTablet(model);

            return RedirectToAction("AllTablets", "Device");
        }

        //tv
        [HttpGet]
        public IActionResult AddTv()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTv(TvBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            await this.deviceService.AddTv(model);

            return RedirectToAction("AllTvs", "Device");
        }

        public async Task<IActionResult> AllTvs()
        {
            var tvs = (await this.deviceService.GetAllTvs())
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(tvs);
        }

        public async Task<IActionResult> DeleteTv(int id)
        {
            await this.deviceService.DeleteTv(id);

            return RedirectToAction("AllTvs", "Device");
        }

        [HttpGet]
        public async Task<IActionResult> EditTv(int id)
        {
            var getTv = await this.deviceService.GetTvById(id);

            var tv = mapper.Map<TvEditViewModel>(getTv);

            if (getTv == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(tv);
        }

        [HttpPost]
        public async Task<IActionResult> EditTv(TvEditViewModel model)
        {
            await this.deviceService.EditTv(model);

            return RedirectToAction("AllTvs", "Device");
        }

        //washing machine
        [HttpGet]
        public IActionResult AddWashingMachine()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddWashingMachine(WashingMachineBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            await this.deviceService.AddWashingMachine(model);

            return RedirectToAction("AllWashingMachines", "Device");
        }

        public async Task<IActionResult> AllWashingMachines()
        {
            var washingMachines = (await this.deviceService.GetAllWashingMachines())
                .Select(mapper.Map<DeviceListingViewModel>);

            return this.View(washingMachines);
        }

        public async Task<IActionResult> DeleteWashingMachine(int id)
        {
            await this.deviceService.DeleteWashingMachine(id);

            return RedirectToAction("AllWashingMachines", "Device");
        }

        [HttpGet]
        public async Task<IActionResult> EditWashingMachine(int id)
        {
            var getWashingMachine = await this.deviceService.GetWashingMachineById(id);

            var washingMachine = mapper.Map<WashingMachineEditViewModel>(getWashingMachine);

            if (getWashingMachine == null)
            {
                return RedirectToAction("ApplicationError", "Home");
            }

            return this.View(washingMachine);
        }

        [HttpPost]
        public async Task<IActionResult> EditWashingMachine(WashingMachineEditViewModel model)
        {
            await this.deviceService.EditWashingMachine(model);

            return RedirectToAction("AllWashingMachines", "Device");
        }
    }
}