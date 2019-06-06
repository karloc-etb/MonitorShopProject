using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP.NETProject.Models;

namespace ASP.NETProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMonitorRepository _monitorRepository;

        public HomeController(IMonitorRepository monitorRepository)
        {
            _monitorRepository = monitorRepository;
        }

        public IActionResult Index()
        {
            var monitors = _monitorRepository.GetAllMonitors().OrderBy(m => m.Name);
            return View(monitors);
        }

        public IActionResult Privacy()
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
