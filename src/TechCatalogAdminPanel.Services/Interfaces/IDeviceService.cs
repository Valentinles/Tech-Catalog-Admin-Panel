using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechCatalogAdminPanel.Common.ViewModels;
using TechCatalogAdminPanel.Models;

namespace TechCatalogAdminPanel.Services.Interfaces
{
    public interface IDeviceService
    {
        Task AddAirConditioner(AirConditionerBindingModel model);
        Task DeleteAirConditioner(int id);
        Task EditAirConditioner(AirConditionerEditViewModel model);
        Task<IEnumerable<AirConditioner>> GetAllAirConditioners();
        Task<AirConditioner> GetAirConditionerById(int id);

        Task AddCooker(CookerBindingModel model);
        Task DeleteCooker(int id);
        Task EditCooker(CookerEditViewModel model);
        Task<IEnumerable<Cooker>> GetAllCookers();
        Task<Cooker> GetCookerById(int id);

        Task AddDesktopPc(DesktopPcBindingModel model);
        Task DeleteDesktopPc(int id);
        Task EditDesktopPc(DesktopPcEditViewModel model);
        Task<IEnumerable<DesktopPc>> GetAllDesktopPcs();
        Task<DesktopPc> GetDesktopPcById(int id);

        Task AddGameConsole(GameConsoleBindingModel model);
        Task DeleteGameConsole(int id);
        Task EditGameConsole(GameConsoleEditViewModel model);
        Task<IEnumerable<GameConsole>> GetAllGameConsoles();
        Task<GameConsole> GetGameConsoleById(int id);

        Task AddHeadphone(HeadphoneBindingModel model);
        Task DeleteHeadphone(int id);
        Task EditHeadphone(HeadphoneEditViewModel model);
        Task<IEnumerable<Headphone>> GetAllHeadphones();
        Task<Headphone> GetHeadphoneById(int id);

        Task AddKeyboard(KeyboardBindingModel model);
        Task DeleteKeyboard(int id);
        Task EditKeyboard(KeyboardEditViewModel model);
        Task<IEnumerable<Keyboard>> GetAllKeyboards();
        Task<Keyboard> GetKeyboardById(int id);

        Task AddLaptop(LaptopBindingModel model);
        Task DeleteLaptop(int id);
        Task EditLaptop(LaptopEditViewModel model);
        Task<IEnumerable<Laptop>> GetAllLaptops();
        Task<Laptop> GetLaptopById(int id);

        Task AddMobilePhone(MobilePhoneBindingModel model);
        Task DeleteMobilePhone(int id);
        Task EditMobilePhone(MobilePhoneEditViewModel model);
        Task<IEnumerable<MobilePhone>> GetAllMobilePhones();
        Task<MobilePhone> GetMobilePhoneById(int id);

        Task AddMonitor(MonitorBindingModel model);
        Task DeleteMonitor(int id);
        Task EditMonitor(MonitorEditViewModel model);
        Task<IEnumerable<Monitor>> GetAllMonitors();
        Task<Monitor> GetMonitorById(int id);

        Task AddMouse(MouseBindingModel model);
        Task DeleteMouse(int id);
        Task EditMouse(MouseEditViewModel model);
        Task<IEnumerable<Mouse>> GetAllMice();
        Task<Mouse> GetMouseById(int id);

        Task AddRefrigerator(RefrigeratorBindingModel model);
        Task DeleteRefrigerator(int id);
        Task EditRefrigerator(RefrigeratorEditViewModel model);
        Task<IEnumerable<Refrigerator>> GetAllRefrigerators();
        Task<Refrigerator> GetRefrigeratorById(int id);

        Task AddTablet(TabletBindingModel model);
        Task DeleteTablet(int id);
        Task EditTablet(TabletEditViewModel model);
        Task<IEnumerable<Tablet>> GetAllTablets();
        Task<Tablet> GetTabletById(int id);

        Task AddTv(TvBindingModel model);
        Task DeleteTv(int id);
        Task EditTv(TvEditViewModel model);
        Task<IEnumerable<Tv>> GetAllTvs();
        Task<Tv> GetTvById(int id);

        Task AddWashingMachine(WashingMachineBindingModel model);
        Task DeleteWashingMachine(int id);
        Task EditWashingMachine(WashingMachineEditViewModel model);
        Task<IEnumerable<WashingMachine>> GetAllWashingMachines();
        Task<WashingMachine> GetWashingMachineById(int id);
    }
}
