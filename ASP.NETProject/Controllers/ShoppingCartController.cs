using ASP.NETProject.Models;
using ASP.NETProject.Views;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETProject.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IMonitorRepository _monitorRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IMonitorRepository monitorRepository, ShoppingCart shoppingCart)
        {
            _monitorRepository = monitorRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var sCVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(sCVM);
        }

        public RedirectToActionResult AddToShoppingCart(int monitorId)
        {
            //_monitorRepository.Monitors = _monitorRepository.GetAllMonitors();

            var selectedMonitor = _monitorRepository.GetMonitorById(monitorId);

            if (selectedMonitor != null)
            {
                _shoppingCart.AddToCart(selectedMonitor, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int monitorId)
        {
            var selectedMonitor = _monitorRepository.Monitors.FirstOrDefault(p => p.Id == monitorId);

            if (selectedMonitor != null)
            {
                _shoppingCart.RemoveFromCart(selectedMonitor);
            }

            return RedirectToAction("Index");
        }

    }
}
