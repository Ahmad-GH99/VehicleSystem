using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VehicleSystem.API.Models;
using VehicleSystem.Application.Services;
using VehicleSystem.Domain.Entities;
using VehicleSystem.Domain.Interfaces;
using VehicleSystem.Models;

namespace VehicleSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVehicleService _vehicleService;

        public HomeController(ILogger<HomeController> logger , IVehicleService vehicleService)
        {
            _logger = logger;
            _vehicleService = vehicleService;
        }

        public async Task<IActionResult> Index()
        {
            var makes = await _vehicleService.GetAllMakesAsync();
            var model = new VehicleSearchResultViewModel
            {
                Makes = makes.OrderBy(m => m.MakeName).ToList()
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Search(int makeId , int year)
        {
            var makes = await _vehicleService.GetAllMakesAsync();

            var vehicleTypes = await _vehicleService.GetVehicleTypesByMakeIdAsync(makeId);
            var vehicleType = vehicleTypes.FirstOrDefault()?.VehicleTypeName ?? "";

            var models = await _vehicleService.GetModelsAsync(makeId, year);

            var modelCards = models.Select(m => new VehicleModelCard
            {
                MakeName = m.MakeName,
                ModelName = m.ModelName,
                VehicleType = vehicleType
            }).ToList();

            var resultViewModel = new VehicleSearchResultViewModel
            {
                MakeId = makeId,
                Year = year,
                Makes = makes.OrderBy(m => m.MakeName).ToList(),
                Models = modelCards
            };

            return View("Index", resultViewModel);


        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
