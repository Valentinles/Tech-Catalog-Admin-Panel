using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechCatalogAdminPanel.Common.ViewModels;
using TechCatalogAdminPanel.Services.Interfaces;
using TechCatalogAdminPanel.Web.Models;

namespace TechCatalogAdminPanel.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHistoryService historyService;
        readonly IMapper mapper;


        public HomeController(IHistoryService historyService, IMapper mapper, ILogger<HomeController> logger)
        {
            this.historyService = historyService;
            this.mapper = mapper;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var histories = (await this.historyService.GetAllHistories())
                .Select(mapper.Map<HistoryListingViewModel>); 

            return View(histories);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ApplicationError()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
