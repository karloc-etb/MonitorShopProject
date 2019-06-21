using System.Diagnostics;
using System.Linq;
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

        public IActionResult ViewDetails(int id)
        {
            var monitor = _monitorRepository.GetMonitorById(id);

            if (monitor == null)
            {
                return NotFound();
            }
            return View(monitor);
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
